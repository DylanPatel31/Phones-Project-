using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstStock
    {

        Int32  PhoneID = 21;
        string PhoneMake = "iphone"; 
        string PhoneModel = "XS";
        string PhoneDescription = "256GB";

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create some test data 
            clsStock AnStock = new clsStock();
            //boolean varivale to store the result 
            Boolean Found = false;
            //create some test data to use the method
            Int32 PhoneID = 1;
            //invoke the method 
            Found = AnStock.Find(PhoneID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }
            
       

        [TestMethod]
        
        public void TestPhoneIDFound()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 PhoneID = 12;
            //invoke method
            Found = AnStock.Find(PhoneID);
            //check the phone ID
            if (AnStock.PhoneID != 12)
            {
                Ok = false;
            }
            // test to see the result 
            Assert.IsTrue(Ok);
        }


        [TestMethod]

        public void TestPhoneMakeFound()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 PhoneID = 12;
            //invoke method
            Found = AnStock.Find(PhoneID);
            //check the property
            if (AnStock.PhoneMake != "Iphone")
            {
                Ok = false;
            }
            // test to see the result 
            Assert.IsTrue(Ok);
        }


        [TestMethod]

        public void TestPhoneModelFound()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 PhoneID = 12;
            //invoke method
            Found = AnStock.Find(PhoneID);
            //check the property
            if (AnStock.PhoneModel != "XS")
            {
                Ok = false;
            }
            // test to see the result 
            Assert.IsTrue(Ok);
        }


        [TestMethod]

        public void TestPhoneDescriptionFound()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 PhoneID = 12;
            //invoke method
            Found = AnStock.Find(PhoneID);
            //check the property
            if (AnStock.PhoneDescription != "256GB")
            {
                Ok = false;
            }
            // test to see the result 
            Assert.IsTrue(Ok);
        }

        
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class 
            clsStock AnStock = new clsStock();
            //string to store the variable
            string Error = "";
            //invoke the method 
            Error = AnStock.Valid(PhoneID, PhoneMake, PhoneModel, PhoneDescription);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PhoneIDMin()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to pass to the method 
            string PhoneID = "s";
            //invoke the method 
            Ok = AnStock.Valid(PhoneID, PhoneMake, PhoneModel, PhoneDescription);
            //test to see that the result is correct 
            Assert.AreEqual(OK);

        }


        [TestMethod]
        public void PhoneIDMinLessOne()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //string variable to store error message 
            string Error = "";
            //create some test data to pass to the method 
            string PhoneID = "";
            //invoke the method 
            Ok = AnStock.Valid(PhoneID, PhoneMake, PhoneModel, PhoneDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(OK);

        }



        [TestMethod]
        public void PhoneIDMinPlusOne()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //string variable to store error message 
            string Error = "";
            //create some test data to pass to the method 
            string PhoneID = "ss";
            //invoke the method 
            Ok = AnStock.Valid(PhoneID, PhoneMake, PhoneModel, PhoneDescription);
            //test to see that the result is correct 
            Assert.AreEqual(OK);

        }

        [TestMethod]
        public void PhoneIDMax()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //string variable to store error message 
            string Error = "";
            //create some test data to pass to the method 
            string PhoneID = "";
            PhoneID = PhoneID.PadRight(100, 's');
            //invoke the method 
            Ok = AnStock.Valid(PhoneID, PhoneMake, PhoneModel, PhoneDescription);
            //test to see that the result is correct 
            Assert.AreEqual(OK);

        }



    }
}

