using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5_Final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           ////This one doesn't do anything, use the one in Default.aspx
        }

        //Member Related 
        protected void toMemberLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Member/MemberLogin.aspx");
        }

        protected void toMemberPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ChoseState/Services.aspx");
        }

        //Staff Related
        protected void toStaffLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/StaffLogin.aspx");
        }

        protected void toStaffPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AdminPage/AdminPage.aspx");
        }
    }
}