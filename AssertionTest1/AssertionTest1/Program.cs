using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertionTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(1991, 1, 1);
            dob.AddDays(7);
            dob.AddYears(-24);
            
            Console.WriteLine(dob);
            Console.ReadLine();
            Customer testCust = new Customer();
            testCust.DateOfBirth = dob;
            int expectedage = 23;
            int actualAge = testCust.GetAge();
        }
    }
}
