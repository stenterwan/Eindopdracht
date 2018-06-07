using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StoreForm.Properties;
using StoreForm.ServiceReference1;
using StoreWebservice;

namespace StoreForm
{
    public partial class storeForm : Form
    {
        public Customer me = null;

        public List<Product> productList = new List<Product>();

        public storeForm()
        {
            InitializeComponent();
            setDefaultValues();
        }

        private void setDefaultValues()
        {
            products.Items.Clear();
            inventory.Items.Clear();
            error.Text = "";

            using (var sc = new Service1Client())
            {
                productList = sc.GetAllProducts().ToList();
            }

            using (var sc = new Service1Client())
            {
                me = sc.GetCustomerById(LoginInfo.userId);
                label3.Text = Resources.storeForm_storeForm_Money_left__ + me.Saldo;
         
            }
            using (var sc = new Service1Client())
            {
                me.Orders = sc.GetAllOrdersByCustomer(me.Id);
            }
            foreach (var p in productList.Where(p => p.Stock > 0)) { 
                products.Items.Add(p);
            }

            var groups = me.Orders.Where(o=>o.CustomerId==me.Id && productList.Where(x => x.Id == o.ProductId).FirstOrDefault() != null).GroupBy(o => o.ProductId).Select(group => new
            {
                ProductName = productList.Where(x => x.Id == group.Key).FirstOrDefault().Name,
                Count = group.Count()
            });

            foreach (var group in groups)
            { 
                inventory.Items.Add(group.ProductName + ", " + group.Count);
            }
        }

        private void buy_Click(object sender, EventArgs e)
        {
            string b;
            using (var sc = new Service1Client())
            {
                b = sc.Buy(((Product) products.SelectedItem).Id, me.Id);
            }
            if (b == "")
            {
                setDefaultValues();
            }
            else
            {
                error.ForeColor = Color.Red;
                error.Text = b;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            setDefaultValues();
        }

        private void storeForm_Load(object sender, EventArgs e)
        {

        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}