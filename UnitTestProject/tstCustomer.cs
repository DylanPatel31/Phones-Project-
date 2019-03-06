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
        string DateJoined = DateTime.Now.Date.ToString();

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
            Int32 CustomerNo = 1;
            //assign the data to the property
            ACustomer.CustomerNo = CustomerNo;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, CustomerNo);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string Title = "Mr";
            //assign the data to the property
            ACustomer.Title = Title;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Title, Title);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String FirstName = "Mudrik";
            //assign the data to the property
            ACustomer.FirstName = FirstName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, FirstName);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String LastName = "Mohamed";
            //assign the data to the property
            ACustomer.LastName = LastName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, LastName);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String HouseNo = "37 Drapper street";
            //assign the data to the property
            ACustomer.HouseNo = HouseNo;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HouseNo, HouseNo);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String Town = "Leicester";
            //assign the data to the property
            ACustomer.Town = Town;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, Town);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String PostCode = "LE2 1HL";
            //assign the data to the property
            ACustomer.PostCode = PostCode;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, PostCode);
        }

        [TestMethod]
        public void ContactNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            Int32 ContactNo = 01259854590;
            //assign the data to the property
            ACustomer.ContactNo = ContactNo;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ContactNo, ContactNo);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            String Email = "Mudrik2018@gmail.com";
            //assign the data to the property
            ACustomer.Email = Email;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, Email);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            DateTime DateOfBirth = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = DateOfBirth;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, DateOfBirth);
        }


        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Mobile Number property
            DateTime DateJoined = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateJoined = DateJoined;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateJoined, DateJoined);
        }

        [TestMethod]
        public void ValidExist()
        {
            //create an instance of the class we want to create 
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
        public void TestMobileNumberFound()
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
        public void TestJoinedFound()
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
            if (ACustomer.DateJoined != Convert.ToDateTime("10/02/2019"))
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            LastName = LastName.PadRight(40, 'm'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Email = Email.PadRight(40, 'e'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
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
            Error = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create a variable to store th test date data
            DateTime DateJoined;
            //set the data totodays date
            DateJoined = DateTime.Now.Date;
            //change the dat to whatever the date is less 100 years
            DateJoined = DateJoined.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = DateJoined.ToString();
            //Invoke the method
            OK = ACustomer.Valid(Title, FirstName, LastName, HouseNo, Town, PostCode, ContactNo, Email, DateOfBirth, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }






    }


}