using System;
using ClassLibrary;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member this customer
        clsCustomer mThisCustomer = new clsCustomer();



        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;

            }
            set
            {
                //set the private data
                mCustomerList = value;
            }

        }

        //public property count       
        public int Count
        {
            get
            {
                //return count of the list
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procodure
            DB.Execute("sproc_tblCustomers_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Customer
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AnCustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnCustomer.ContactNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ContactNo"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the records into a private data member
                mCustomerList.Add(AnCustomer);
                //point to the next record
                Index++;

            }
        }

        public int Add()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database.
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Title", mThisCustomer.Title);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@ContactNo", mThisCustomer.ContactNo);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);

            //execute the query returning primary key of new record
            return DB.Execute("sproc_tblCustomers_Insert");

        }


        public void Delete()
        {
            //delete the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //execute the stored procdure
            DB.Execute("sproc_tblCustomers_Delete");
        }


        public void Update()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@Title", mThisCustomer.Title);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@ContactNo", mThisCustomer.ContactNo);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            //execute the query returning primary key of new record
            DB.Execute("sproc_tblCustomers_Update");

        }


        public void FilterbyPostCode(string PostCode)
        {
            //filters the records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            // execute the stored procedure 
            DB.Execute("sproc_tblCustomers_FilterByPostcode");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count.
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array lsit
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Customer
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AnCustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnCustomer.ContactNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ContactNo"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the records into a private data member
                mCustomerList.Add(AnCustomer);
                //point to the next record
                Index++;

            }
        }


    }
}