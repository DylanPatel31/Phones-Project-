using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
namespace FrontEnd
{
    public partial class frmAddEditCust : System.Web.UI.Page
    {
        //var to store the PhoneID
        Int32 CustomerNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //copy the data from the query string to the text box txtPhoneID
            CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
            //if this is not an instruction to add a new record

            if (IsPostBack == false)
            {
                if (CustomerNo != -1)
                {
                    // display the existing data
                    DisplayCustomers(CustomerNo);
                }
            }
        }

        void DisplayCustomers(Int32 CustomerNo)
        {
            //create an instance of the phone class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //find the record we want to display
            Customers.ThisCustomer.Find(CustomerNo);
            //display the house no
            txtCustomerNo.Text = Customers.ThisCustomer.CustomerNo.ToString();
            txtTitle.Text = Customers.ThisCustomer.Title.ToString();
            txtFirstName.Text = Customers.ThisCustomer.FirstName;
            txtLastName.Text = Customers.ThisCustomer.LastName;
            txtHouseNo.Text = Customers.ThisCustomer.HouseNo;
            txtTown.Text = Customers.ThisCustomer.Town;
            txtPostCode.Text = Customers.ThisCustomer.PostCode;
            txtContactNo.Text = Customers.ThisCustomer.ContactNo.ToString();
            txtEmail.Text = Customers.ThisCustomer.Email;
            txtDateOfBirth.Text = Customers.ThisCustomer.DateOfBirth.ToString("dd/mm/yyyy");
            txtDateAdded.Text = Customers.ThisCustomer.DateAdded.ToString("dd/mm/yyyy");  
        }


        //function for adding new records
        void Add()
        {
            //create an instance of the OrderCollection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //validate the data on the web form
            String Error = Customers.ThisCustomer.Valid(txtTitle.Text, txtFirstName.Text, txtLastName.Text, txtHouseNo.Text, txtTown.Text, txtPostCode.Text, txtContactNo.Text, txtEmail.Text, txtDateOfBirth.Text, txtDateAdded.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //copy the data from the interface to the object
                Customers.ThisCustomer.Title = txtTitle.Text;
                Customers.ThisCustomer.FirstName = txtFirstName.Text;
                Customers.ThisCustomer.LastName = txtLastName.Text;
                Customers.ThisCustomer.HouseNo = txtHouseNo.Text;
                Customers.ThisCustomer.Town = txtTown.Text;
                Customers.ThisCustomer.PostCode = txtPostCode.Text;
                Customers.ThisCustomer.ContactNo = Convert.ToInt32(txtContactNo.Text);
                Customers.ThisCustomer.Email = txtEmail.Text;
                Customers.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                Customers.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //add the new record
                Customers.Add();
                //all done so redirect back to the main page
                Response.Redirect("frmCustomerMain.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }


        void Update()
        {
            //create an instance of the OrderCollection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //validate the data on the web form
            String Error = Customers.ThisCustomer.Valid(txtTitle.Text, txtFirstName.Text, txtLastName.Text, txtHouseNo.Text, txtTown.Text, txtPostCode.Text, txtContactNo.Text, txtEmail.Text, txtDateOfBirth.Text, txtDateAdded.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                Customers.ThisCustomer.Find(CustomerNo);
                //copy the data from the interface to the object
                Customers.ThisCustomer.Title = txtTitle.Text;
                Customers.ThisCustomer.FirstName = txtFirstName.Text;
                Customers.ThisCustomer.LastName = txtLastName.Text;
                Customers.ThisCustomer.HouseNo = txtHouseNo.Text;
                Customers.ThisCustomer.Town = txtTown.Text;
                Customers.ThisCustomer.PostCode = txtPostCode.Text;
                Customers.ThisCustomer.ContactNo = Convert.ToInt32(txtContactNo.Text);
                Customers.ThisCustomer.Email = txtEmail.Text;
                Customers.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                Customers.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //update the new record
                Customers.Update();
                //all done so redirect back to the main page
                Response.Redirect("frmCustomerMain.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }


        }



        protected void btnEnter_Click(object sender, EventArgs e)
        {
            if (CustomerNo == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("frmCustomerMain.aspx");
        }
    }
}