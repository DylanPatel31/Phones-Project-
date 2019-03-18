using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {

            //create an instance of the class to see if it exists
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //here we are seeing if it exist
            Assert.IsNotNull(AllCustomers);
        }

       //[TestMethod]//
       // public void CountPropertyOK()//
       // {
            //create an instance of the class we want to create
          //  clsCustomerCollection AllCustomer = new clsCustomerCollection();//
            //create some test data
           // Int32 someCount = 2;
            //assign the data to the property
           // AllCustomer.Count = someCount;//test to see that it exists
           // Assert.AreEqual(AllCustomer.Count, someCount);
        //}//



        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ContactNo = 1;
            TestItem.Title = "Mr";
            TestItem.FirstName = "Mudrik";
            TestItem.LastName = "Mohamed";
            TestItem.ContactNo = 125985459;
            TestItem.Email = "Mudrik2018@gmail.com";
            TestItem.HouseNo = "37 Drapper street";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE2 1HL";
            TestItem.DateOfBirth = Convert.ToDateTime("06/07/1995");
            TestItem.DateAdded = Convert.ToDateTime("10/02/2019");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //add an item to the list
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.CustomerNo = 1;
            TestCustomer.Title = "Mr";
            TestCustomer.FirstName = "Mudrik";
            TestCustomer.LastName = "Mohamed";
            TestCustomer.ContactNo = 1259854590;
            TestCustomer.Email = "Mudrik2018@gmail.com";
            TestCustomer.HouseNo = "37 Drapper street";
            TestCustomer.Town = "Leicester";
            TestCustomer.PostCode = "LE2 1HL";
            TestCustomer.DateOfBirth = Convert.ToDateTime("06/07/1995");
            TestCustomer.DateAdded = Convert.ToDateTime("10/02/2019");
            //assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that it exists
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            //set its properties
            //TestItem.ContactNo = 1;
            TestItem.Title = "Mr";
            TestItem.FirstName = "Mudrik";
            TestItem.LastName = "Mohamed";
            TestItem.ContactNo = 1259854590;
            TestItem.Email = "Mudrik2018@gmail.com";
            TestItem.HouseNo = "37 Drapper street";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE2 1HL";
            TestItem.DateOfBirth = Convert.ToDateTime("06/07/1995");
            TestItem.DateAdded = Convert.ToDateTime("10/02/2019");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        //[TestMethod]//
        //public void TwoRecordsPresent()//
       // {
            //create an instance of the class we want to create
            //clsCustomerCollection AllCustomer = new clsCustomerCollection();//
            //test to see that the two values are the same
            //Assert.AreEqual(AllCustomer.Count, 2);//
        //}


    }
}
