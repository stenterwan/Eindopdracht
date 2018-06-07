using System;
using System.Drawing;
using System.Windows.Forms;
using StoreForm.Properties;
using StoreForm.ServiceReference1;

namespace StoreForm
{
    public partial class Form1 : Form
    {
        private Label _label1;
        private TextBox _password;
        private TextBox _username;

        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            var username = _username.Text;
            var password = _password.Text;
            using (var sc = new Service1Client())
            {
                LoginInfo.userId = sc.Inloggen(username, password);
                if (LoginInfo.userId > 0)
                {
                    Hide();
                    var frame = new storeForm();
                    frame.Closed += (s, args) => Close();
                    frame.Show();
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = Resources.Form1_login_Click_Customer_not_registrered;
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            using (var sc = new Service1Client())
            {
                label4.ForeColor = Color.Red;
                label4.Text = sc.Registreren(regusername.Text);
            }
        }
    }
}