using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string Title = "Mr";
        string FirstName = "Mudrik";
        string LastName = "Mohamed";
        string HouseNo = "37 Drapper street";
        string Town = "Leicester";
        string PostCode = "LE2 1HL";
        string ContactNo = "01259854590";
        string Email = "Mudrik2018@gmail.com";
        string DateOfBirth = DateTime.Now.Date.ToString();
        string DateAdded = DateTime.Now.Date.ToString();

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
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Mr";
            //assign the data to the property
            ACustomer.Title = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Title, TestData);
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
        public void PropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            Int32 TestData = 01259854590;
            //assign the data to the property
            ACustomer.ContactNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ContactNo, TestData);
        }

        [TestMethod]
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

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }


        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the results of the method
            Boolean Found = false;
            //create some test data to test the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the Customer no
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the Title property
            if (ACustomer.Title != "Mr")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the FirstName property
            if (ACustomer.FirstName != "Mudrik")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the LastName property
            if (ACustomer.LastName != "Mohamed")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the House number property
            if (ACustomer.HouseNo != "37 Drapper street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the Town property
            if (ACustomer.Town != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the Post Code property
            if (ACustomer.PostCode != "LE2 1HL")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNoFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the mobile number property
            if (ACustomer.ContactNo != 01259854590)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailCodeFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the email property
            if (ACustomer.Email != "Mudrik2018@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the date of birth property
            if (ACustomer.DateOfBirth != Convert.ToDateTime("06/07/1995"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store results
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create sme test to use with methood
            Int32 CustomerNo = 1;
            //invoke method 
            Found = ACustomer.Find(CustomerNo);
            //check the date joined property
            if (ACustomer.DateAdded != Convert.ToDateTime("10/02/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }



        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }





        [TestMethod]
        public void TitleMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void TitleMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = "M"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = "Mr"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = "Mrs"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TitleMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = "Miss"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = "Misss"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void TitleMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = "Mr"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Title = "";
            Title = Title.PadRight(100, 'm');//this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string FirstName = "M"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string FirstName = "Mo"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(40, 'm'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'm'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string LastName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string LastName = "M"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string LastName = "Mo"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'm'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(51, 'm'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void EmailNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Email = "e"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Email = "em"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(49, 'e'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(50, 'e'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(51, 'e'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(25, 'e'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'e'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string HouseNo = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string HouseNo = "d"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string HouseNo = "dr"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(29, 'd'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(30, 'd'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(31, 'd'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(15, 'd'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(500, 'd'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Town = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Town = "l"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string Town = "le"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(19, 'l'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(20, 'l'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(21, 'l'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(10, 'l'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TownExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(500, 'l'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PostCode = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PostCode = "L"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string PostCode = "LE"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(9, 'L'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(10, 'L'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(11, 'L'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(5, 'L'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(500, 'L'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void ContactNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContactNo = "12"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContactNo = "123"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test to data to pass to the method
            string ContactNo = "1234"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(10, '1'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(11, '1'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContactNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(12, '1'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ContactNoMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(5, '1'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //sting variable to store an error message
            string Error = "";
            //create some test data to pass to the method
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(500, '1'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        



        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the validation
            string OK = "";
            //create a variable to store the test date data
            DateTime SomeDate;
            //set the date totaldays date
            SomeDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 today
            SomeDate = SomeDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }


        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the validation
            string OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the validation
            string OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(+1);
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void DateAddedMaxMinusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the validation
            string OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(-1);
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void DateAddedMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the validation
            string OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void DateAddedMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the validation
            string OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddDays(+1);
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }



        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the validation
            string OK = "";
            //set the date totaldays date
            DateTime SomeDate;
            //set test date as todays daye
            SomeDate = DateTime.Now.Date;
            //change to date the whatever date is 100 years in the future
            SomeDate = SomeDate.AddYears(+100);
            //Convert data  to a string variable
            string DateAdded = SomeDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(OK, "");

        }

        

    }

}