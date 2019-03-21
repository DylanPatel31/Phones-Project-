using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibrary
{
    public class clsContractCollection
    {
        //private data member for the list
        List<clsContract> mContractList = new List<clsContract>();

        //public property for the Contract list
        public List<clsContract> ContractList
        {
            get
            {
                //return the private data
                return mContractList;
            }
            set
            {
                //set the private data 
                mContractList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mContractList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        private clsContract mThisContract = new clsContract();
        public clsContract ThisContract
        {
            get
            {
                //return the private data
                return mThisContract;
            }
            set
            {
                //set the private data
                mThisContract = value;
            }




        }

        //constructor for the class
        public clsContractCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblContract_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Contract
                clsContract AnContract = new clsContract();
                //read in the field from the current record
                AnContract.ContractNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ContractNo"]);
                AnContract.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnContract.ContractType = Convert.ToString(DB.DataTable.Rows[Index]["ContractType"]);
                AnContract.PhoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneID"]);
                AnContract.StartDateOfContract = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDateOfContract"]);
                AnContract.EndDateOfContract = Convert.ToDateTime(DB.DataTable.Rows[Index]["EndDateOfContract"]);

                //add the records into a private data member
                mContractList.Add(AnContract);
                //Point to the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record in to the database depending on the values of mThisContract
            //connect to the database.
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ContractNo", mThisContract.ContractNo);
            DB.AddParameter("@CustomerNo", mThisContract.CustomerNo);
            DB.AddParameter("@PhoneID", mThisContract.PhoneID);
            DB.AddParameter("@ContractType", mThisContract.ContractType);
            DB.AddParameter("@StartDateOfContract", mThisContract.StartDateOfContract);
            DB.AddParameter("@EndDateOfContract", mThisContract.EndDateOfContract);

            //execute the query returning primary key of new record
            return DB.Execute("sproc_tblContract_Insert");

        }

        public void Delete()
        {
            //delete the record pointed to by ThisContract
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ContractNo", mThisContract.ContractNo);
            //execute the stored procdure
            DB.Execute("sproc_tblContract_Insert");
        }

        public void Update()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //set the parameters for the stored procedure
            DB.AddParameter("@ContractNo", mThisContract.ContractNo);
            DB.AddParameter("@CustomerNo", mThisContract.CustomerNo);
            DB.AddParameter("@PhoneID", mThisContract.PhoneID);
            DB.AddParameter("@ContractType", mThisContract.ContractType);
            DB.AddParameter("@StartDateOfContract", mThisContract.StartDateOfContract);
            DB.AddParameter("@EndDateOfContract", mThisContract.EndDateOfContract);

            //execute the query returning primary key of new record
            DB.Execute("sproc_tblContract_Insert");

        }
        public void FilterbyContractType(string ContractType)
        {
            //filters the records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@ContractType", ContractType);
            // execute the stored procedure 
            DB.Execute("sproc_tblContract_FilterByContractType");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count.
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array lsit
            mContractList = new List<clsContract>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Contract
                clsContract AnContract = new clsContract();
                AnContract.ContractNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ContractNo"]);
                AnContract.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnContract.ContractType = Convert.ToString(DB.DataTable.Rows[Index]["ContractType"]);
                AnContract.PhoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneID"]);
                AnContract.StartDateOfContract = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDateOfContract"]);
                AnContract.EndDateOfContract = Convert.ToDateTime(DB.DataTable.Rows[Index]["EndDateOfContract"]);

                //add the records into a private data member
                mContractList.Add(AnContract);
                //point to the next record
                Index++;
            }
        }
    }
}