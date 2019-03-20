
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList;
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {

            get
            {
                return mStockList;
            }


            set
            {
                mStockList = value;
            }

        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }




            set
            {

            }


        }
        public clsStock ThisStock

        {
            get
            {
                return mThisStock;
            }

            set
            {
                mThisStock = value;
            }


        }

        public int Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void ReportByMake(string v)
        {
            throw new NotImplementedException();
        }

        
        //constructor for the class
        //public clsStaffCollection()
        //{
        //    //var for the index
        //    Int32 Index = 0;

        //    //var to store the record count 
        //    Int32 RecordCount = 0;

        //    //object for data connection 
        //    clsDataConnection DB = new clsDataConnection();
        //    //execute the stored procedure 
        //    DB.Execute("sproc_tblStock_SelectAll");
        //    //get count of records 
        //    RecordCount = DB.Count;
        //    //while ther are records to process
        //    while (Index < RecordCount)
        //    {
        //        //create a blank address
        //        clsStock AnStock = new clsStock();
        //        //read in the fields from the current record 
        //        AnStock.PhoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneID"]);
        //        AnStock.PhoneMake = Convert.ToString(DB.DataTable.Rows[Index]["PhoneMake"]);
        //        AnStock.PhoneModel = Convert.ToString(DB.DataTable.Rows[Index]["PhoneModel"]);
        //        AnStock.PhoneDescription = Convert.ToString(DB.DataTable.Rows[Index]["PhoneDescription"]);
        //        // add the record to the private data member 
        //        mStockList.Add(AnStock);
        //        //point at the next record 
        //        Index++;

        //    }

        //}











    }

}
   




