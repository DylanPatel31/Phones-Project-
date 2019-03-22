using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace PPFrontEnd
{
    public partial class AStaffMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void Add()
        {
            //create an instance of the address book
            clsStaffCollection Staff = new clsStaffCollection();
            //validate the data on the web form
            String Error = Staff.ThisStaff.Valid(txtTitle.Text, txtFirstName.Text, txtLastName.Text, txtDateOfBirth.Text, txtAddress1.Text, txtAddress2.Text, txtCity.Text, txtPostCode.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                Staff.ThisStaff.Title = txtTitle.Text;
                Staff.ThisStaff.FirstName = txtFirstName.Text;
                Staff.ThisStaff.LastName = txtLastName.Text;
                Staff.ThisStaff.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                Staff.ThisStaff.Address1 = txtAddress1.Text;
                Staff.ThisStaff.Address2 = txtAddress2.Text;
                Staff.ThisStaff.City = txtCity.Text;
                Staff.ThisStaff.PostCode = txtPostCode.Text;

                //add the record
                Staff.Add();
                //all done so redirect back to the main page
                Response.Redirect("StaffList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //add
            Add();
            //re direct
            Response.Redirect("StaffList.aspx");
        }
    }
}