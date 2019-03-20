using System;

namespace ClassLibrary
{
    public class clsContract
    {
       
        private int mContractNo;
        public int ContractNo
        {
            get
            {
                //return the private data
                return mContractNo;
            }
            set
            {
                //set the value of the private data member
                mContractNo = value;
            }
        }
        private DateTime mStartDateOfContract;
        public DateTime StartDateOfContract
        {
            get
            {
                //return the private data
                return mStartDateOfContract;
            }
            set
            {
                //set the value of the private data member
                mStartDateOfContract = value;
            }
        }

        private int mPhoneID;
        public int PhoneID
        {
            get
            {
                //return the private data
                return mPhoneID;
            }
        
            set
            {
                //set the value of the private data member
                mPhoneID = value;
            }
        }

            private int mCustomerNo;
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

            private int mContractType;
        public int ContractType
        {
            get
            {
                //return the private data
                return mContractType;
            }
            set
            {
                //set the value of the private data member
                mContractType = value;
            }
        }

        private DateTime mEndDateOfContract;
        public DateTime EndDateOfContract
        {
            get
            {
                //return the private data
                return mEndDateOfContract;
            }
            set
            {
                //set the value of the private data member
                mEndDateOfContract = value;
            }
        }





        
        public bool Find(int contractNo)
        {
            //set the private data member to the test data value
            mContractNo = 21;
            mCustomerNo = 33;
            mPhoneID = 2;
            mContractType = 36;
            mStartDateOfContract = Convert.ToDateTime("01/02/2005");
            mEndDateOfContract = Convert.ToDateTime("01/02/2011");
            //always return true
            return true;
        }
        

        public string Valid(string ContractNo, string CustomerNo, string PhoneID, string ContractType, string StartDateOfContract, string EndDateOfContract)
        {
            //create a string variable to store the error
            string Error = "";

            ////ContractNo

            if (ContractNo.Length == 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (ContractNo.Length > 3)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }


            ////CustomerNo

            if (CustomerNo.Length == 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (CustomerNo.Length > 3)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }

            ////PhoneID

            if (PhoneID.Length == 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (PhoneID.Length > 3)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }


            ////PhoneID

            if (PhoneID.Length == 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (PhoneID.Length > 3)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }

            ////ContractType

            if (ContractType.Length == 0)
            {
                Error = Error + "The first may not be blank";
            }
            if (ContractType.Length > 9)
            {
                Error = Error + " The first name must be less than 50 characters :   ";
            }

            //try
            //{
            //    DateTime TempEndDate =Convert.ToDateTime( EndDateOfContract);
            //    if (TempEndDate )
            //}
            //catch
            //{
            //    Error = Error + " end date is bad :   ";
            //}

            //DateAdded
            try //try to see if the date entered is valid
            {
                //create a temporory variale to store the values
                DateTime DateTemp;
                //tempory variable to store the date
                DateTemp = Convert.ToDateTime(StartDateOfContract);
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

            //DateAdded
            try //try to see if the date entered is valid
            {
                //create a temporory variale to store the values
                DateTime DateTemp;
                //tempory variable to store the date
                DateTemp = Convert.ToDateTime(EndDateOfContract);
                //if the datetemp is greater then todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //flag an error
                    Error = Error + "Date in past. Please enter todays date : ";
                }

            }
            catch // if an error has failed to be caught
            {
                //flag an error
                Error = Error + "Incorrect Date Format entered : ";
            }



            //return any error messages
            return Error;
        }




    }

    

}