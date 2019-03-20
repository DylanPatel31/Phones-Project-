using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace FrontEnd
{
    public partial class frmCustomerMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //display all phones
                DisplayCustomers("");
            }
        }

        Int32 DisplayCustomers(string CustomerPostCode)
        {
            Int32 CustomerNo;//var to store the primary key
            String LastName; //var to store the Device Name
            String PostCode; //var to store the Device Name
           
            ;//create an instance of the phone class
            clsCustomerCollection Customer = new clsCustomerCollection();
            Customer.FilterbyPostCode(CustomerPostCode);
            Int32 RecordCount;//var to store the count of records
            Int32 Index = 0;//var to store the index for the loop
            RecordCount = Customer.Count;// get the count of records
            lstCust.Items.Clear(); //clear the list box
            while (Index < RecordCount)//while there are records to process
            {
                CustomerNo = Customer.CustomerList[Index].CustomerNo;//get the primary key
                LastName = Customer.CustomerList[Index].LastName; //get the Device Name
                PostCode = Customer.CustomerList[Index].PostCode; //get the Operating System
                                                          //create a new entry for the list box
                ListItem NewEntry = new ListItem(LastName + ", " + PostCode, CustomerNo.ToString());
                lstCust.Items.Add(NewEntry);//add the phone to the list
                Index++;//move the index to the next record
            }
            return RecordCount;//return the count of the records found
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // sttore -1 into the session object to indicate this is a new record
            Session["CustomerNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("frmAddEditCust.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            //var to store the primary key value
            Int32 CustomerNo;
            if (lstCust.SelectedIndex != -1)
            {
                //get the primary key value from the list box
                CustomerNo = Convert.ToInt32(lstCust.SelectedValue);
                //store the data in the sessions object
                Session["CustomerNo"] = CustomerNo;
                //redirect to the Delete page
                Response.Redirect("Delete.aspx?CustomerNo=" + CustomerNo);
            }
            else
            {
                //display an error
                lblError.Text = "You must select a Customer off the list first in order to delete.";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 CustomerNo;
            if (lstCust.SelectedIndex != -1)
            {
                //get the primary key value from the list box
                CustomerNo = Convert.ToInt32(lstCust.SelectedValue);
                //store the data in the sessions object
                Session["CustomerNo"] = CustomerNo;
                //redirect to the editing page
                Response.Redirect("frmAddEditCust.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "You must select a Customer off the list first to edit it.";
            }
        }

        protected void btnFilterbyPostcode_Click(object sender, EventArgs e)
        {
            //display only Orders mattching the text in the Customer Name text box
            DisplayCustomers(txtFilter.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all phones
            DisplayCustomers("");
        }
    }
}