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
        private DateTime mDateJoined;


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
        public DateTime DateJoined
        {
            get
            {
                //return the private data
                return mDateJoined;
            }
            set
            {
                //set the value of the private data member
                mDateJoined = value;
            }

        }


        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the book ref to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mContactNo = Convert.ToString(DB.DataTable.Rows[0]["ContactNo"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);


                //return an record has been found
                return true;
            }
            //if no record is found
            else
            {
                //record no record has been found
                return false;
            }
        }


        public string Valid(string title, string firstName, string lastName, string houseNo, string town, string postCode, string contactNo, string email, string dateOfBirth, string dateJoined)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporory variale to store the values
            DateTime DateTemp;
            //if the Title is blank
            if (title.Length == 0)
            {
                //record the error
                Error = Error + " The title may not be blank :  ";
            }
            //if the titel is greater than 4 characters
            if (title.Length > 4)
            {
                //record the error
                Error = Error + "The title must be less than 4 characters : ";
            }

            ////FirstName

            if (firstName.Length < 1)
            {
                Error = Error + " first name is too short :    ";
            }
            if (firstName.Length > 50)
            {
                Error = Error + " first name is too long :      ";
            }

            ////LastName

            if (lastName.Length < 1)
            {
                Error = Error + " last name is too short :      ";
            }
            if (lastName.Length > 25)
            {
                Error = Error + " last name is too long :       ";
            }

            //DateOfBirth
            try
            {
                DateTemp = Convert.ToDateTime(dateOfBirth);

                if (DateTemp >= DateTime.Now.Date.AddYears(-18))
                {
                    Error = Error + " You must be over 18 years old :      ";
                }

                if (DateTemp <= DateTime.Now.Date.AddYears(-150))
                {
                    Error = Error + " You must be under 150 years old :       ";
                }

            }
            catch
            {
                Error = Error + " Incorrect date entered :  ";
            }

            //DateJoined
            try
            {
                DateTemp = Convert.ToDateTime(dateJoined);

                if (DateTemp <= DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + " the date cannot be in the past :      ";
                }

                if (DateTemp >= DateTime.Now.Date)
                {
                    Error = Error + " the date cannot be in the future :       ";
                }

            }
            catch
            {
                Error = Error + " the date was not a valid date :  ";
            }


            // HouseNo
            //if the house no is blank
            if (houseNo.Length == 0)
            {
                //record the error
                Error = Error + " The house number may not be blank :  ";
            }
            //if the house no is greater than 30 characters
            if (houseNo.Length > 30)
            {
                //record the error
                Error = Error + "The house number must be less than 30 characters : ";
            }

            //town
            //is the town blank
            if (town.Length == 0)
            {
                //record the error
                Error = Error + " The town may not be blank :  ";
            }
            //if the titel is greater than 50 characters
            if (town.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }

            //PostCode
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + " The psot may not be blank :  ";
            }
            //if the titel is greater than 9 characters
            if (postCode.Length > 9)
            {
                //record the error
                Error = Error + "The post must be less than 9 characters : ";
            }

            //contactNo

            if (contactNo.Length < 4)
            {
                Error = Error + " Contact Number is too short : ";
            }
            if (contactNo.Length > 11)
            {
                Error = Error + " Contact Number is too long :  ";
            }

            // if statement for email 

            if (email.Length < 5)
            {
                Error = Error + " Email is too short :  ";
            }
            if (email.Length > 35)
            {
                Error = Error + " Email is too long :    ";
            }



            //return any error message
            return Error;
        }
    }


}