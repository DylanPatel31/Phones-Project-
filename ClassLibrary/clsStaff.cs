using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostCode { get; set; }
        public int StaffNo { get; set; }
        public string Title { get; set; }

        public bool Find(int staffNo)
        {
            //always return true
            return true;
        }

        public string Valid(string title, string firstName, string lastName, string dateOfBirth, string address1, string address2, string city, string postCode)
        {
            return "";
        }
    }
}