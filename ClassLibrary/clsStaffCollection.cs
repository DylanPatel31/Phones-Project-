using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();


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



        
        public clsStaff ThisStaff { get; set; }
    }

    




}