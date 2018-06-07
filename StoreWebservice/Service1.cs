using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StoreWebservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int Inloggen(string u, string p)
        {
            using (var ctx = new StoreContainer())
            {
                if (ctx.CustomerSet.Any(c => c.Username.Equals(u) && c.Password.Equals(p)))
                {
                    return ctx.CustomerSet.First(c => c.Username.Equals(u) && c.Password.Equals(p)).Id;
                }
                    
            }
            return 0;
        }

        public string Registreren(string u)
        {
            var charArray = u.ToCharArray();
            Array.Reverse(charArray);
            var password = new string(charArray);           
            

            using (var ctx = new StoreContainer())
            {
                if (!ctx.CustomerSet.Any(cus => cus.Username == u))
                {
                    var c = new Customer {Username = u, Password = password, Saldo = 10};
                    ctx.CustomerSet.Add(c);
                    ctx.SaveChanges();
                }
                else
                {
                    return "This username is taken";
                }
                
            }
            return "Your password is: " + password;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException(nameof(composite));
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Product[] GetAllProducts()
        {
            Product[] products;
            using (var ctx = new StoreContainer())
            {
                products = ctx.ProductSet.ToArray();
            }
            return products;
        }

        public Customer GetCustomerById(int id)
        {
            Customer c;
            using (var ctx = new StoreContainer())
            {
                var test = ctx.CustomerSet.Where(x => x.Id == id);
                c = test.First();
            }
            return c;
        }

        public string Buy(int pid, int id)
        {
            using (var ctx = new StoreContainer())
            {
                var customer = ctx.CustomerSet.Find(id);

                var product = ctx.ProductSet.Find(pid);

                if (customer.Saldo >= product.Price)
                {
                    if (product.Stock > 0)
                    {
                        var o = new Order
                        {
                            Date = DateTime.Now,
                            CustomerId = customer.Id,
                            ProductId = product.Id
                        };
                        customer.Orders.Add(o);
                        product.Orders.Add(o);

                        ctx.OrderSet.Add(o);
                        ctx.Entry(customer).CurrentValues.SetValues(customer.Saldo = customer.Saldo - product.Price);
                        ctx.Entry(customer).State = EntityState.Modified;
                        ctx.Entry(product).CurrentValues.SetValues(product.Stock = product.Stock - 1);
                        ctx.Entry(product).State = EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    else
                    {
                        return "This product is out of stock please refesh";
                    }

                }
                else
                {
                    return "You don't have enough money";
                }
            }
            return "";
        }

        public Order[] GetAllOrdersByCustomer(int customer)
        {
            List<Order> orders;
            using (var ctx = new StoreContainer())
            {
                orders = ctx.OrderSet.ToList();
            }
            return orders.ToArray();
        }
    }
}
