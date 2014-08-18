using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace DatabaseApplication
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var context = new ConstructionDB4Entities();
            var getCustomer = context.Customers;
           
        }
    }
}
