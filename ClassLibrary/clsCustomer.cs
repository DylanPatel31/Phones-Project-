using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the MobileNumber property
        private Int32 mContactNo;
        //private data member for the CustomerNo property
        private Int32 mCustomerNo;
        //private data member for the CustomerNo property
        private String mFirstName;
        //private data member for the CustomerNo property
        private String mLastName;
        //private data member for the CustomerNo property
        private String mTitle;
        //private data member for the CustomerNo property
        private String mHouseNo;
        //private data member for the CustomerNo property
        private String mPostCode;
        //private data member for the CustomerNo property
        private String mTown;
        //private data member for the CustomerNo property
        private String mEmail;
        //private data member for the CustomerNo property
        private DateTime mDateOfBirth;
        //private data member for the CustomerNo property
        private DateTime mDateAdded;


        //public property for Mobile number
        public int ContactNo
        {
            get
            {
                //return the private data
                return mContactNo;
            }


            set
            {
                //set the value of the private data member
                mContactNo = value;
            }
        }

        //public property for Customer Number
        public int CustomerNo
        {
            get
            {
                //return the private data
                return mCustomerNo;
            }
            set
            {
                //set the value of the private data member
                mCustomerNo = value;
            }
        }

        //public property for First Name
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }

         }

        //public property for Last Name
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the private data member
                mLastName = value;
            }

        }

        //public property for Title
        public string Title
        {
            get
            {
                //return the private data
                return mTitle;
            }
            set
            {
                //set the value of the private data member
                mTitle = value;
            }

        }

        //public property for House Number
        public string HouseNo
        {
            get
            {
                //return the private data
                return mHouseNo;
            }
            set
            {
                //set the value of the private data member
                mHouseNo = value;
            }

        }

        //public property for Post Code
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the value of the private data member
                mPostCode = value;
            }

        }

        //public property for Town
        public string Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the value of the private data member
                mTown = value;
            }

        }

        //public property for Email
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the value of the private data member
                mEmail = value;
            }

        }

        //public property for Date Of Birth
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the value of the private data member
                mDateOfBirth = value;
            }

        }


        //public property for Date Joined
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the value of the private data member
                mDateAdded = value;
            }

        }


        public bool Find(int CustomerNo)
        {
            //set the private data member to test data value
            mCustomerNo = 1;
            mContactNo = 01259854590;
            mFirstName = "Mudrik";
            mLastName = "Mohamed";
            mTitle = "Mr";
            mPostCode = "LE2 1HL";
            mTown = "Leicester";
            mHouseNo = "37 Drapper street";
            mEmail = "Mudrik2018@gmail.com";
            mDateOfBirth = Convert.ToDateTime("06/07/1995");
            mDateAdded = Convert.ToDateTime("10/02/2019");
            //always return true
            return true;
        }

        public string Valid(string title, string firstName, string lastName, string houseNo, string town, string postCode, string contactNo, string email, string dateOfBirth, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporory variale to store the values
            DateTime DateTemp;
            //if the Title is blank
            if (title.Length == 0)
            {
                //record the error
                Error = Error + "The title may not be blank :";
            }
            //if the titel is greater than 4 characters
            if (title.Length > 4)
            {
                //record the error
                Error = Error + "The title must ne less than 4 characters : ";
            }


           

        ////FirstName

            if (firstName.Length== 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (firstName.Length > 50)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }

            

         ////LastName

            if (lastName.Length== 0)
            {
                Error = Error + "The last name may not be blank";
            }
            if (lastName.Length > 50)
            {
                Error = Error + " The last name must be less than 50 characters :   ";
            }

            //Email
            if (email.Length == 0)
            {
                Error = Error + "The last name may not be blank";
            }
            if (email.Length > 50)
            {
                Error = Error + " The last name must be less than 50 characters :   ";
            }


            //HouseNo
            if (houseNo.Length == 0)
            {
                Error = Error + "The house number may not be blank";
            }
            if (houseNo.Length > 30)
            {
                Error = Error + " The house name must be less than 30 characters :   ";
            }


            //Town
            if (town.Length == 0)
            {
                Error = Error + "The town may not be blank";
            }
            if (town.Length > 20)
            {
                Error = Error + " The town must be less than 20 characters :   ";
            }


            //PostCode
            if (postCode.Length == 0)
            {
                Error = Error + "The post code may not be blank";
            }
            if (postCode.Length > 10)
            {
                Error = Error + " The post code must be less than 10 characters :   ";
            }

            // if statement for contactNo

            if (contactNo.Length < 3)
            {
                Error = Error + " Contact Number is too short : ";
            }
            if (contactNo.Length > 11)
            {
                Error = Error + " Contact Number is too long :  ";
            }



            //DateAdded
            try //try to see if the date entered is valid
            {
                //tempory variable to store the date
                DateTemp = Convert.ToDateTime(dateAdded);
                //if the datetemp is greater then todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //flag an error
                    Error = Error + "Date in past. Please enter todays date : ";
                }

                //if the datetemp is less then todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //flag an error
                    Error = Error + "Date in Future. Please enter todays date : ";
                }

            }
            catch // if an error has failed to be caught
            {
                //flag an error
                Error = Error + "Incorrect Date Format entered : ";
            }

           


            //return any error message
            return Error;
        }
    }


}