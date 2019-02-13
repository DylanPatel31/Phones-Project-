using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {   //create an instance of the class
            clsStock AnStock = new clsStock();
            //test to see if it exists 
            Assert.IsNotNull(AnStock);
        }


        [TestMethod]
        public void PhoneMakeExists()
        {
            //create some test data
            clsStock AnStock = new clsStock();
            //create some test data 
            string Test = "Iphone";
            //assign data to property
            AnStock.PhoneMake = Test;
            //test to see if values are the same 
            Assert.AreEqual(AnStock.PhoneMake, Test);

        }

        [TestMethod]
        public void PhoneModelExists()
        {
            //create some test data
            clsStock AnStock = new clsStock();
            //create some test data 
            string Test = "XSMAX";
            //assign data to property
            AnStock.PhoneModel = Test;
            //test to see if values are the same 
            Assert.AreEqual(AnStock.PhoneModel, Test);

        }


        [TestMethod]
        public void PhoneIDExists()
        {
            //create some test data
            clsStock AnStock = new clsStock();
            //create some test data 
            Int32 Test = 1;
            //assign data to property
            AnStock.PhoneID = Test;
            //test to see if values are the same 
            Assert.AreEqual(AnStock.PhoneID, Test);

        }


        [TestMethod]
        public void PhoneDescriptionExists()
        {
            //create some test data
            clsStock AnStock = new clsStock();
            //create some test data 
            string Test = "256gb";
            //assign data to property
            AnStock.PhoneDescription = Test;
            //test to see if values are the same 
            Assert.AreEqual(AnStock.PhoneDescription, Test);

        }









    }
}