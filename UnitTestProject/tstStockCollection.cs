using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]

        public void StockListOk()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list 
            //create the item of the test
            clsStock TestItem = new clsStock();
            //set its properties 
            TestItem.PhoneID = 1;
            TestItem.PhoneMake = "s";
            TestItem.PhoneModel = "s";
            TestItem.PhoneDescription = "s";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.StockList, TestList);

        }



        [TestMethod]

        public void ThisStockPropertyOk()

        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign the property 
            clsStock TestStock = new clsStock();
            //set the properties of the test object 
            TestStock.PhoneID = 1;
            TestStock.PhoneMake = "sa";
            TestStock.PhoneModel = "w";
            TestStock.PhoneDescription = "s";
            //assign the data to the property 
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }

        [TestMethod]

        public void ListAndCountOK()
        {

            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign property, need to be a list in this case
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list, create the item of test data 
            clsStock TestItem = new clsStock();
            //set the properties 
            TestItem.PhoneID = 1;
            TestItem.PhoneMake = "Iphone";
            TestItem.PhoneModel = "XS";
            TestItem.PhoneDescription = "256GB";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        

       [TestMethod]

       public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.PhoneID = 1;
            TestItem.PhoneMake = "Iphone";
            TestItem.PhoneModel = "XS";
            TestItem.PhoneDescription = "256GB";
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.PhoneID = PrimaryKey;
            //find the record 
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }






    }


}