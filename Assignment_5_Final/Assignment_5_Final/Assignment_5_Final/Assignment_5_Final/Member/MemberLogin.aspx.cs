using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Assignment_5_Final
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
            cookie.Expires = DateTime.Now.AddSeconds(-10);
            Response.Cookies.Add(cookie);
        }
        protected string MemLogin()
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            string result = prox.searchXML("member.xml", UserEmail.Value);
            if(result == "")
            {
                return "Not found";
            }
            else
            {
                string[] resultComponents = result.Split(' ');
                return resultComponents[3];
            }
        }
        protected string AdminLogin()
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            string result = prox.searchXML("staff.xml", UserEmail.Value);
            if (result == "")
            {
                return "Not found";
            }
            else
            {
                string[] resultComponents = result.Split(' ');
                return resultComponents[3];
            }
        }
        protected void toRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration/Registration.aspx");
        }
        protected string enc(string t)
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            return  ClassLibrary2.Class1.Encryption(t);
        }
    }
}