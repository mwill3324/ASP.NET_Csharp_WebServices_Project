using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Assignment_5_Final
{
    public class Global : System.Web.HttpApplication
    {
        public void Application_AuthenticateRequest(Object src, EventArgs e)
        {
            if (!(HttpContext.Current.User == null))
            {
                if (HttpContext.Current.User.Identity.AuthenticationType == "Forms")
                {
                    System.Web.Security.FormsIdentity id;
                    id = (System.Web.Security.FormsIdentity)HttpContext.Current.User.Identity;
                    String[] myRoles = new String[2];
                    String[] Bananas = HttpContext.Current.User.Identity.Name.Split(' ');
                    string userData = ((FormsIdentity)this.User.Identity).Ticket.UserData;

                    if (userData=="Member")
                    {
                        myRoles[0] = "Member";
                    }
                    else if(userData == "Admin")
                    {
                        myRoles[0] = "Admin";
                    }
                    HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(id, myRoles);
                }
            }
        }
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}