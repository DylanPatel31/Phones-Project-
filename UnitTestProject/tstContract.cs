using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstContract
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsContract AnContract = new clsContract();
            //test to see that it exists
            Assert.IsNotNull(AnContract);
        }
        [TestMethod]
        public void ContractNoPropertyOK()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnContract.ContractNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.ContractNo, TestData);

        }
        [TestMethod]
        public void DateOfContractPropertyOK()
        {
            //create an instance of the class we want to create 
            clsContract AnContract = new clsContract();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnContract.DateOfContract = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.DateOfContract, TestData);
        }
        [TestMethod]
        public void PhoneIDOK()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnContract.PhoneID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.PhoneID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //boolen variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ContractNo = 1;
            //invoke the method 
            Found = AnContract.Find(ContractNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }
   
    }
    

}


    
