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
            //create string variable to store the error 
            string Error = "";

            if(phoneID == 0)
            {
                Error = Error + "PhoneId can not be left blank : ";
            }

            if(phoneID >100)
            {
                Error = Error + "PhoneID must be less than 100 : ";
            }



            if(phoneMake.Length==0)
            {
                Error = Error + "Phone make cannot be empty :";
            }

            if(phoneMake.Length>100)
            {
                Error = Error + "phone make cannot be bigger than 100: ";
            }

            //Phone Model
            if(PhoneModel.Length==0)
            {
                Error = Error + "phone model cannot be empty:";
            }
            if(phoneModel.Length>100)
            {
                Error = Error + "phone model cannot be bigger than 100:";
            }




            if(phoneDescription.Length==0)
            {
                Error = Error + "Phone description cannot be empty:";
            }
            
            if(phoneDescription.Length>1000)
            {
                Error = Error + "Phone description cannot be bigger than 100:";
            }



            return Error;

        }
    }
}