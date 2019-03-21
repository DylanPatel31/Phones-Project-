using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
namespace FrontEnd
{
    public partial class Delete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerNo;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of orders to be deleted from the sessions object
            CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
            //if this is not an instruction to add a new record
            if (CustomerNo != -1)
            {
                if (IsPostBack != true)
                {
                    //display the existing data
                    DeleteCustomer(CustomerNo);
                }
            }
        }


        void DeleteCustomer(Int32 CustomerNo)
        {
            //function to delete the selected record

            //create a a new instance of the collection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //find the record to delete 
            Customers.ThisCustomer.Find(CustomerNo);
            //display the PhoneID
            lblDelete.Text = "Are you sure that you want to Delete this Customer off the system?";
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //create an instance of the class clsPhone called MyPhones
            clsCustomerCollection MyCustomers = new clsCustomerCollection();
            //declare a variable to store the PhoneID to delete

            //declare a boolean variable to record success of the delete operation
            Boolean Found;
            //try and find the record to delete
            Found = MyCustomers.ThisCustomer.Find(CustomerNo);
            //if the record is found
            if (Found)
            {
                //invoke the delete method of the object
                MyCustomers.Delete();
            }
            Response.Redirect("frmCustomerMain.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("frmCustomerMain.aspx");
        }
    }
}