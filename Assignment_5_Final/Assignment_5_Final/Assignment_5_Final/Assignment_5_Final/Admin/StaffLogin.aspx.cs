using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary2;

namespace Assignment_5_Final
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
                {
                    Email.Text = Request.Cookies["UserName"].Value;
                    Password.Attributes["value"] = Request.Cookies["Password"].Value;
                }
            }
            Shiz.Text = "";
        }

        protected void log(object sender, EventArgs e)
        {
            if (RememberMe.Checked)
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(30);
                Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(30);
            }
            else
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);

            }
            Response.Cookies["UserName"].Value = Email.Text.Trim();
            Response.Cookies["Password"].Value = Password.Text.Trim();
        }

        protected void StaffLogin(object sender, EventArgs e)
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            string result = prox.searchXML("staff.xml", Email.Text);
            if (result == "Not found")
            {
                Shiz.Text = "Account Not Found";
            }
            else
            {
                string[] resultComponents = result.Split(' ');
                string encrPass = ClassLibrary2.Class1.Encryption(Password.Text);
                if (encrPass == resultComponents[3])
                {
                    //Login Success
                    Shiz.Text = "Login Successful";
                    Response.Redirect("~/Admin/AdminPage/AdminPage.aspx");
                }
                else
                {
                    Shiz.Text = "Incorrect Password";
                }

            }
        }
    }
}