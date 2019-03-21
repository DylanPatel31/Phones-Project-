using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstContract
    {
        public string TestContract;

        string ContractNo = "1";
        string CustomerNo = "33";
        string PhoneID = "2";
        string ContractType = "36 months";
        string StartDateOfContract =Convert.ToString( DateTime.Now.Date);
        string EndDateOfContract = Convert.ToString(DateTime.Now.Date.AddMonths(36));



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
            int TestData = 123;
            //assign the data to the property
            AnContract.ContractNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.ContractNo, TestData);

        }
        [TestMethod]
        public void StartDateOfContractPropertyOK()
        {
            //create an instance of the class we want to create 
            clsContract AnContract = new clsContract();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnContract.StartDateOfContract = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.StartDateOfContract, TestData);
        }

        [TestMethod]
        public void EndDateOfContractPropertyOK()
        {
            //create an instance of the class we want to create 
            clsContract AnContract = new clsContract();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnContract.EndDateOfContract = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.EndDateOfContract, TestData);
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
        public void CustomerNoOK()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //create some test data to assign to the property
            Int32 TestData = 33;
            //assign the data to the property
            AnContract.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.CustomerNo, TestData);
        }

        [TestMethod]
        public void ContractTypeOK()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //create some test data to assign to the property
            string TestData = "36";
            //assign the data to the property
            AnContract.ContractType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnContract.ContractType, TestData);
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
        [TestMethod]
        public void TestContractNoFound()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ContractNo = 21;
            //invoke the method
            Found = AnContract.Find(ContractNo);
            //CHECK THE CONTRACT NO
            if (AnContract.ContractNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ContractNo = 21;
            //invoke the method
            Found = AnContract.Find(ContractNo);
            //CHECK THE CONTRACT NO
            if (AnContract.CustomerNo != 33)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateOfContractFound()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ContractNo = 21;
            //invoke the method
            Found = AnContract.Find(ContractNo);
            //check the contract no
            if (AnContract.StartDateOfContract != Convert.ToDateTime("01/02/2005"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEndDateOfContractFound()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ContractNo = 21;
            //invoke the method
            Found = AnContract.Find(ContractNo);
            //check the contract no
            if (AnContract.EndDateOfContract != Convert.ToDateTime("01/02/2011"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneIDFound()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ContractNo = 21;
            //invoke the method
            Found = AnContract.Find(ContractNo);
            //CHECK THE CONTRACT NO
            if (AnContract.PhoneID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContractTypeFound()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ContractNo = 21;
            //invoke the method
            Found = AnContract.Find(ContractNo);
            //CHECK THE CONTRACT NO
            if (AnContract.ContractType != "36")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void validmethodOK()
        {
            //create an instance of the new class we want to create
            clsContract AnContract = new clsContract();
            //create a string variable to store the results of the method
            string Error = "";
            //invoke the method
            Error = AnContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is ok i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = ""; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContractNoMin()
        {

            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = "1"; //this should trigger an error
                                     //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContractNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = "2"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = "23"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractNoMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = "445"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContractNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = "4456"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ContractNoMid()
        {
            //create an instance of the class we want to create 
            clsContract ACustomer = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = "23"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractNoExtremeMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractNo = "7";
            ContractNo = ContractNo.PadRight(700, 'A');//this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string CustomerNo = ""; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMin()
        {

            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "1";
            //create some test to data to pass to the method
            string CustomerNo = "1"; //this should trigger an error
                                     //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string CustomerNo = "2"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string CustomerNo = "2"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string CustomerNo = "3"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string CustomerNo = "4567"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void CustomerNoMid()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string CustomerNo = "2"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoExtremeMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string CustomerNo = "5";
            CustomerNo = CustomerNo.PadRight(450, 'A');//this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = ""; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneIDMin()
        {

            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = "1"; //this should trigger an error
                                     //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneIDMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = "23"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneIDMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = "2"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneIDMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = "3"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PhoneIDMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = "4564"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void PhoneIDMid()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = "2"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneIDExtremeMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PhoneID = "5";
            PhoneID = PhoneID.PadRight(500, 'A');//this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ContractTypeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractType = ""; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContractTypeMin()
        {

            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "1";
            //create some test to data to pass to the method
            string ContractType = "1"; //this should trigger an error
                                     //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContractTypeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractType = "2"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractTypeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractType = "8"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractTypeMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractType = "9"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContractTypeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractType = "1234567897"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ContractTypeMid()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractType = "5"; //this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractTypeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContractType = "30";
            ContractType = ContractType.PadRight(450, 'A');//this should trigger an error
            //invoke the method
            Error = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void StartDateOfContractMinLessOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //create a variable to store the test date data
            DateTime SomeDate;
            //set the date totaldays date
            SomeDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 today
            SomeDate = SomeDate.AddDays(-1);
            //convert the date variable to a string variable
            string StartDateOfContract = SomeDate.ToString();
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }

      
        [TestMethod]
        public void StartDateOfContractMin()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(OK, "");

        }


        [TestMethod]
        public void StartDateOfContractMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(+1);
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(OK, "");

        }



        //[TestMethod]
        //public void StartDateOfContractMaxMinusOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsContract AContract = new clsContract();
        //    //string variable to store the results of the validation
        //    String OK = "";
        //    //set the date totaldays date
        //    DateTime SomeDate;
        //    SomeDate = DateTime.Now.Date;
        //    //change to date the whatever date is 100 years in the future
        //    SomeDate = SomeDate.AddDays(1);
        //    //Convert data  to a string variable
        //    string DateAdded = SomeDate.ToString();
        //    //invoke the method
        //    OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(OK, "");

        //}



        public void StartDateOfContractMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(OK, "");

        }



        [TestMethod]
        public void StartDateOfContractMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(+1);
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");
            //m
        }



        //[TestMethod]
        //public void StartDateOfContractExtremeMax()
        //{
        //    //create an instance of the class we want to create 
        //    clsContract AContract = new clsContract();
        //    //string variable to store the results of the validation
        //    String OK = "";
        //    //set the date totaldays date
        //    DateTime SomeDate;
        //    //set test date as todays date
        //    SomeDate = DateTime.Now.Date;
        //    //change to date the whatever date is 100 years in the future
        //    SomeDate = SomeDate.AddYears(+100);
        //    //Convert data  to a string variable
        //    string DateAdded = SomeDate.ToString();
        //    //invoke the method
        //    OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(OK, "");

        //}



        //[TestMethod]
        //public void StartDateOfContractExtremeMin()
        //{
        //    //create an instance of the class we want to create 
        //    clsContract AContract = new clsContract();
        //    //string variable to store the results of the validation
        //    String OK = "";
        //    //set the date totaldays date
        //    DateTime SomeDate;
        //    //set test date as todays date
        //    SomeDate = DateTime.Now.Date;
        //    //change to date then whatever date is 100 days in the past
        //    SomeDate = SomeDate.AddYears(-100);
        //    //Convert data  to a string variable
        //    string EndDateOfContract = SomeDate.ToString();
        //    EndDateOfContract = Convert.ToString(SomeDate);
        //    //invoke the method
        //    OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
        //    //test to see that the result is correct
        //    Assert.AreEqual(OK, "");

        //}





        //[TestMethod]
        //public void EndDateOfContractMinLessOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsContract AContract = new clsContract();
        //    //string variable to store the results of the validation
        //    String OK = "";
        //    //create a variable to store the test date data
        //    DateTime SomeDate;
        //    //set the date totaldays date
        //    SomeDate = DateTime.Now.Date;
        //    //change the date to whatever the date is less 1 today
        //    SomeDate = SomeDate.AddDays(-1);
        //    //convert the date variable to a string variable
        //    string EndDateOfContract = SomeDate.ToString();
        //    EndDateOfContract =Convert.ToString( SomeDate);
        //    //invoke the method
        //    OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
        //    //test to see that the result is correct
        //    Assert.AreEqual(OK, "");

        //}


        [TestMethod]
        public void EndDateOfContractMin()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(OK, "");

        }


        [TestMethod]
        public void EndDateOfContractMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(+1);
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreEqual(OK, "");

        }



        //[TestMethod]
        //public void EndDateOfContractMaxMinusOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsContract AContract = new clsContract();
        //    //string variable to store the results of the validation
        //    String OK = "";
        //    //set the date totaldays date
        //    DateTime SomeDate;
        //    SomeDate = DateTime.Now.Date;
        //    //change to date the whatever date is 100 years in the future
        //    SomeDate = SomeDate.AddDays(1);
        //    //Convert data  to a string variable
        //    string DateAdded = SomeDate.ToString();
        //    //invoke the method
        //    OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(OK, "");




        //[TestMethod]
        //public void EndDateOfContractMax()
        //    {
        //        //create an instance of the class we want to create 
        //        clsContract AContract = new clsContract();
        //        //string variable to store the results of the validation
        //        String OK = "";
        //        //set the date totaldays date
        //        DateTime SomeDate;
        //        //set test date as todays daye
        //        SomeDate = DateTime.Now.Date;
        //        //Convert data  to a string variable
        //        string DateAdded = SomeDate.ToString();
        //        //invoke the method
        //        OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
        //        //test to see that the result is correct
        //        Assert.AreEqual(OK, "");

        //    }



        //[TestMethod]
        //public void EndDateOfContractPlusOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsContract AContract = new clsContract();
        //    //string variable to store the results of the validation
        //    String OK = "";
        //    //set the date totaldays date
        //    DateTime SomeDate;
        //    //set test date as todays daye
        //    SomeDate = DateTime.Now.Date;
        //    //change to date the whatever date is 100 years in the future
        //    SomeDate = SomeDate.AddDays(+1);
        //    //Convert data  to a string variable
        //    string DateAdded = SomeDate.ToString();
        //    //invoke the method
        //    OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(OK, "");
        //    //m
        //}



        [TestMethod]
        public void EndDateOfContractExtremeMax()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddYears(+100);
            //Convert data  to a string variable
            string EndDateOfContract = SomeDate.ToString();
            EndDateOfContract = Convert.ToString(SomeDate);
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }



        [TestMethod]
        public void EndDateOfContractExtremeMin()
        {
            //create an instance of the class we want to create 
            clsContract AContract = new clsContract();
            //string variable to store the results of the validation
            String OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays date
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(-100);
            //Convert data  to a string variable
            string EndDateOfContract = SomeDate.ToString();
            EndDateOfContract = Convert.ToString(SomeDate);
            //invoke the method
            OK = AContract.Valid(ContractNo, CustomerNo, PhoneID, ContractType, StartDateOfContract, EndDateOfContract);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }

    }




    }



    
