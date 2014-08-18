using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertionTest1
{
    public class Customer
    {
        public DateTime DateOfBirth {get; set;}
        public int GetAge()
        {
            TimeSpan difference = DateTime.Now.Subtract(DateOfBirth);
            int ageInYears = (int)(difference.Days / 365.25);
            return ageInYears;
        }
       /* public DateTime BirthDate
       /// {
            get {return DateOfBirth;}
            set { DateOfBirth = value; }
       /// }*/
    }
}
