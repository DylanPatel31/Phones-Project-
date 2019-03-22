using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private dta member thisStaff
        clsStaff mThisStaff = new clsStaff();
        //private data member to connect to the database
        private clsDataConnection DB = new clsDataConnection();

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while ther are records to process
            while (Index < RecordCount)
            {

                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fileds from teh current record
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AStaff.Address1 = Convert.ToString(DB.DataTable.Rows[Index]["Address1"]);
                AStaff.Address2 = Convert.ToString(DB.DataTable.Rows[Index]["Address2"]);
                AStaff.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }

        }


        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the private data
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

       

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Title", mThisStaff.Title);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Address1", mThisStaff.Address1);
            DB.AddParameter("@Address2", mThisStaff.Address2);
            DB.AddParameter("@City", mThisStaff.City);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }


    }

    




}