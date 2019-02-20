using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the StaffNo property
        private Int32 mStaffNo;
        //private data member for the Title property
        private string mTitle;
        ////private data member for the FirstName property
        private string mFirstName;
        //private data member for the LastName property
        private string mLastName;
        ////private data member for the DateOfBirth property
        private DateTime mDateOfBirth;
        //private data member for the Address1 property
        private string mAddress1;
        //private data member for the Address2 property
        private string mAddress2;
        //private data member for the City property
        private string mCity;
        //private data member for the PostCode property
        private string mPostCode;
        public clsStaff()
        {
        }

        //public property for staffno
        public int StaffNo
        {
            get
            {
                //return the private data
                return mStaffNo;
            }
            set
            {
                //set the private data
                mStaffNo = value;
            }
        }
        public string Address1
        {
            get
            {
                //return the private data
                return mAddress1;
            }
            set
            {
                //set the data
                mAddress1 = value;
            }
        }
        public string Address2
        {
            get
            {
                //return the data
                return mAddress2;
            }
            set
            {
                //set the data
                mAddress2 = value;
            }
        }
        public string City
        {
            get
            {
                //return the data
                return mCity;

            }
            set
            {
                //set the data
                mCity = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                //return the data
                return mDateOfBirth;
            }
            set
            {
                //set the data
                mDateOfBirth = value;
            }
        }
        public string FirstName
        {
            get
            {
                //return the data 
                return mFirstName;
            }
            set
            {
                //setr the data
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                //return the data 
                return mLastName;
            }
            set
            {
                //set the data
                mLastName = value;
            }
        }
        public string PostCode
        {
            get
            {
                //return the data
                return mPostCode;
            }
            set
            {
                //set the data
                mPostCode = value;
            }
        }
        
        //public property for title
        public string Title
        {
            get
            {
                //return the data
                return mTitle;
            }
            set
            {
                //set the data
                mTitle = value;
            }
        }


        public bool Find(int staffNo)
        {
            //set the private data members to the test data value
            mStaffNo = 1;
            mTitle = "Mr";
            mFirstName = "John";
            mLastName = "Taylor";
            mDateOfBirth = Convert.ToDateTime("01/01/1998");
            mAddress1 = "18 Some Street";
            mAddress2 = "36 Some Street";
            mCity = "Leicester";
            mPostCode = "LE2 9AK";

            //always return true
            return true;
        }

        public string Valid(string title, string firstName, string lastName, string dateOfBirth, string address1, string address2, string city, string postCode)
        {
            //create a string variable to store the error
            String Error = "";
            //if the Title is blank
            if (title.Length == 0)
            {
                //record the error
                Error = Error + "The title may not be blank";
            }
            //if the titel is greater than 4 characters
            if(title.Length > 4)
            {
                //record the error
                Error = Error + "The title must ne less than 4 characters : ";
            }
            //return any error message
            return Error;
        }
    }
}