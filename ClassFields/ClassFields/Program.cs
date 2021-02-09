using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
