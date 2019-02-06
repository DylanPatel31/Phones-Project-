using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {

            //create an instance of our class clsStaff
            clsStaff AStaff = new clsStaff();
            //check to see that the class in not null
            Assert.IsNotNull(AStaff);
        }
    }
}
