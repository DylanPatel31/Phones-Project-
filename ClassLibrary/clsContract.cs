using System;

namespace ClassLibrary
{
    public class clsContract
    {
        public bool ContractNo { get; set; }
        public DateTime DateOfContract { get; set; }
        public int PhoneID { get; set; }

        public bool Find(int contractNo)
        {
            //set the private data member to the test data value
            //mContractNo = 21;
            //always return true
            return true;
        }
    }
}