using System;

namespace ClassLibrary
{
    public class clsStock
    {

        private string phoneMake;
        public string PhoneMake

        {

            get
            {
                return phoneMake;
            }
                       
            set
            {
                phoneMake = value;
            }



        }
        private string phoneModel;
        public string PhoneModel
        {


              get
            {
                return phoneModel;
            }
                
                
              set
            {
                phoneModel = value; 
            }
                
                
                
         }
        private int phoneID;
        public int PhoneID
        {


            get
            {
                return phoneID;

            }
            
            
            set
            {
                phoneID = value; 

            }
                
        }
        private string phoneDescription;
        public string PhoneDescription
         {
            get
            {
              return phoneDescription;
            }
               
                
            set
            {
                phoneDescription = value;
            }
                
                
        }

        public bool Find(int phoneID)
        {

            //private data member for phoneID
            PhoneID = 12;
            PhoneMake = "Iphone";
            PhoneModel = "XS";
            PhoneDescription = "256GB";
            return true;
        }

        public string Valid(int phoneID, string phoneMake, string phoneModel, string phoneDescription)
        {
            return "";
        }
    }
}