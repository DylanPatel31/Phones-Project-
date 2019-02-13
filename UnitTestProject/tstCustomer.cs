using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {

            //create an instance of the class to see if it exists
            clsCustomer ACustomer = new clsCustomer();
            //here we are seeing if it exist
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "Mudrik";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "Mohamed";
            //assign the data to the property
            ACustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "37 Drapper street";
            //assign the data to the property
            ACustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HouseNo, TestData);
        }

        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "Leicester";
            //assign the data to the property
            ACustomer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, TestData);
        }

        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "LE2 1HL";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            Int32 TestData = 01259854590;
            //assign the data to the property
            ACustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "Mudrik2018@gmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "06/06/1996";
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }


        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String TestData = "06/02/2019";
            //assign the data to the property
            ACustomer.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateJoined, TestData);
        }
    }

}