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


        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsContractCollection AllContracts = new clsContractCollection();
        //    //test to see the two values are the same
        //    Assert.AreEqual(AllContracts.Count, 2);
        //}

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

        [TestMethod]
        public void AddMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clsContractCollection AllContracts = new clsContractCollection();
            //create an instance of test data
            clsContract TestItem = new clsContract();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.ContractNo = 21;
            TestItem.CustomerNo = 1;
            TestItem.PhoneID = 1;
            TestItem.ContractType = 36;
            TestItem.StartDateOfContract = DateTime.Now.Date;
            TestItem.EndDateOfContract = DateTime.Now.Date;

            //Set thisContract to test the data    
            AllContracts.ThisContract = TestItem;
            //add the record
            PrimaryKey = AllContracts.Add();

            //find the record
            AllContracts.ThisContract.Find(PrimaryKey);
            //test to see that it exists
            Assert.AreEqual(AllContracts.ThisContract, TestItem);
            
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsContractCollection AllContract = new clsContractCollection();
            //create an instance of test data
            clsContract TestItem = new clsContract();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set the properties
            //TestItem.CustomerNo = 3;
            TestItem.ContractNo = 21;
            TestItem.CustomerNo = 1;
            TestItem.PhoneID = 1;
            TestItem.ContractType = 36;
            TestItem.StartDateOfContract = DateTime.Now.Date;
            TestItem.EndDateOfContract = DateTime.Now.Date;
            //set ThisCustomer to validate test data
            AllContract.ThisContract = TestItem;
            //add the record
            PrimaryKey = AllContract.Add();
            //set primary key of test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllContract.ThisContract.Find(PrimaryKey);
            //delete the record
            AllContract.Delete();
            //now find the record
            Boolean Found = AllContract.ThisContract.Find(PrimaryKey);
            //test to see that it exists
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsContractCollection AllContract = new clsContractCollection();
            //create an instance of test data
            clsContract TestItem = new clsContract();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //TestItem.ContractNo = 3;
            //TestItem.ContractNo = 1;
            TestItem.ContractNo = 21;
            TestItem.CustomerNo = 1;
            TestItem.PhoneID = 1;
            TestItem.ContractType = 36;
            TestItem.StartDateOfContract = DateTime.Now.Date;
            TestItem.EndDateOfContract = DateTime.Now.Date;
            //set ThisCustomer to validate test data
            AllContract.ThisContract = TestItem;
            //add the record
            PrimaryKey = AllContract.Add();
            //set primary key of test data
            TestItem.ContractNo = PrimaryKey;
            //modify the record
            //TestItem.ContractNo = 1;
            TestItem.ContractNo = 21;
            TestItem.CustomerNo = 1;
            TestItem.PhoneID = 1;
            TestItem.ContractType = 36;
            TestItem.StartDateOfContract = DateTime.Now.Date;
            TestItem.EndDateOfContract = DateTime.Now.Date;
            //set the record based on the new record
            AllContract.ThisContract = TestItem;
            //update the record
            AllContract.Update();
            //find the record
            AllContract.ThisContract.Find(PrimaryKey);
            //test to see that it exists
            Assert.AreEqual(AllContract.ThisContract, TestItem);
        }

        [TestMethod]
        public void FilterbyPostCodeMethodOK()
        {
            clsContract TestItem = new clsContract();
            //create an instance of the class we want to create
            clsContractCollection AllContract = new clsContractCollection();
            //create an instance of the filtered data
            clsContractCollection FilteredContracts = new clsContractCollection();
            //apply a blank string (should return all records)
            FilteredContracts.FilterbyContractType("");
            //test to see the two values are the same
            Assert.AreEqual(AllContract.Count, FilteredContracts.Count);
        }
        [TestMethod]
        public void FilterbyContractTypeNoneFound()
        {
            //create an instance of the filtered data
            clsContractCollection FilteredContracts = new clsContractCollection();
            //apply a blank string (should return all records)
            FilteredContracts.FilterbyContractType("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, FilteredContracts.Count);
        }

        [TestMethod]
        public void FilterbyContractTypeTestDataFound()
        {
            //create an instance of the filtered data
            clsContractCollection FilteredContract = new clsContractCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a primary key value 
            FilteredContract.FilterbyContractType("24 months");
            //check the correct number of records are found
            if (FilteredContract.Count == 2)
            {
                //check the first record is ID 2
                if (FilteredContract.ContractList[0].ContractNo != 4)
                {
                    OK = false;
                }
                // check that the first record is ID
                if (FilteredContract.ContractList[1].ContractNo != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see there are records
            Assert.IsTrue(OK);
        }


    }


}
   

