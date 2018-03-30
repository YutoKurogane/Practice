using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cs1Contructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer(1,"KY");
            Customer customer = new Customer
                                    {
                                        Id = 2,
                                        Name = "YT"
                                    };
            //object initializers ^

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            Order order = new Order();
            customer.Orders.Add(order);
        }
    }
}

