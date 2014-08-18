using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;


namespace DatabaseApplication
{
    public partial class Customers
    {
        public double CustomerLength()
        {
            DateTime DateOfAcq = CustAcqDate;
            TimeSpan difference = DateTime.Now.Subtract(DateOfAcq);
            int timeInMonths = (int)(difference.Days / 12);
            return timeInMonths;
        }
       // Retrieve customers where appointment time order by soonest appointment

    }
}
