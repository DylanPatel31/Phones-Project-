using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace UnitTestProject
{
    [TestClass]
    public class tstContractCollection
    {
        private object mContractList;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsContractCollection AnContract = new clsContractCollection();
            //test to see that it exists
            Assert.IsNotNull(AnContract);
        }
        [TestMethod]
        public void ContractListOK()
        {
            //create an instance of the class we want to create 
            clsContractCollection AllContracts = new clsContractCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsContract> TestList = new List<clsContract>();
            //add an item to the list
            //create the item of test data
            clsContract TestItem = new clsContract();
            //set its properties

            TestItem.ContractNo = 21;
            TestItem.CustomerNo = 1;
            TestItem.PhoneID = 1;
            TestItem.ContractType = 36;
            TestItem.StartDateOfContract = DateTime.Now.Date;
            TestItem.EndDateOfContract = DateTime.Now.Date;

        }


        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsContractCollection AllContracts = new clsContractCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllContracts.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.Count, SomeCount);

        }

        [TestMethod]
        public void ThisContractPropertyOK()
        {
            //create an instance of the class we want to create
            clsContractCollection AllContracts = new clsContractCollection();
            //create some test data to assign to the property
            clsContract TestContract = new clsContract();
            //set the properties of the test object
            TestContract.ContractNo = 21;
            TestContract.CustomerNo = 1;
            TestContract.PhoneID = 1;
            TestContract.ContractType = 36;
            TestContract.StartDateOfContract = DateTime.Now.Date;
            TestContract.EndDateOfContract = DateTime.Now.Date;
            //assign the data to the property
            AllContracts.ThisContract = TestContract;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.ThisContract, TestContract);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsContractCollection AllContracts = new clsContractCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsContract> TestList = new List<clsContract>();
            //add an item to the list
            //create the item of test data
            clsContract TestItem = new clsContract();
            //set its properties
            TestItem.ContractNo = 21;
            TestItem.CustomerNo = 1;
            TestItem.PhoneID = 1;
            TestItem.ContractType = 36;
            TestItem.StartDateOfContract = DateTime.Now.Date;
            TestItem.EndDateOfContract = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllContracts.ContractList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllContracts.ContractList, TestList);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsContractCollection AllContracts = new clsContractCollection();
            //test to see the two values are the same
            Assert.AreEqual(AllContracts.Count, 2);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Ccreate an instance of the class we want to create
            clsContractCollection AllContracts = new clsContractCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllContracts.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.Count, SomeCount);

        }

        
    }


}
   

