using System;
using ClassLibrary;
using System.Collections.Generic;

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
        }
    }
}