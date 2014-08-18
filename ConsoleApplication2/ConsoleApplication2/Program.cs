using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Database1Entities1();

            // products will get all products containing o
            var products = context.Products;
            var query1 = from c in products
                         where c.Name.Contains("Lion")
                         select c;

            foreach (var item in query1)
                Console.WriteLine("{0}, {1}", item.Name, item.Id);

            var context2 = new Database1Entities1();
            var produce = context2.Products;

            var q = from c in produce
                    where c.Name.Contains("Lion")
                    orderby c.Id
                    select c;

            foreach (Product c in q) 
                Console.WriteLine("{0}, {1}", c.Id, c.Name);
            Console.Read();

            
        }
    }
}
