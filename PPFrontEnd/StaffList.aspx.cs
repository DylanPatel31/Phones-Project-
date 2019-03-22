using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PPFrontEnd
{
    public partial class StaffList : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first appearence of this form
            if (IsPostBack == false)
            {
                //display all Laptops
                //DisplayStaff("");
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //store -1 into the session object
            Session["StaffNo"] = -1;
            //redirect 
            Response.Redirect("AStaffMember.aspx");
        }
    }


}