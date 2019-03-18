using System;
using ClassLibrary;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member this customer
        private clsCustomer mThisCustomer = new clsCustomer();



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

    }
}