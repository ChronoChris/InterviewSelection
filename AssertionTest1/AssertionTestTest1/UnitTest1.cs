using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssertionTest1;

namespace AssertionTestTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAge()
        {
            DateTime dob = new DateTime(1991, 1, 1);
            ///dob.AddDays(7);
            ///dob.AddYears(-24);
            
            Customer testCust = new Customer();
            testCust.DateOfBirth = dob;
            int expectedage = 23;
            int actualAge = testCust.GetAge();
            ///run the assertion based on 23 should be returned
            Assert.IsTrue((actualAge == expectedage), "Error in code somewhere");
            /// DateTime dob = new DateTime();
            /// dob.AddDays and Years is not evaluated because different reference?
        }
    }
}
