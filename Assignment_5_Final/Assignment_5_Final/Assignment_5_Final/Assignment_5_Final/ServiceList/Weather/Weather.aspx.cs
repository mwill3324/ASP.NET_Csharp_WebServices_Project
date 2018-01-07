using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5_Final
{
    public partial class Weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rr.DataTextField = "";
            rr.Items.Clear();
        }
        protected void findWeather(object sender, EventArgs e)
        {
            string zip = "";
            string State = "";
            DiyaloReference1.Service1Client prox = new DiyaloReference1.Service1Client();
            if (Request.Cookies["State"] != null && Request.Cookies["City"] != null)
            {
                State = Request.Cookies["State"].Value;
                zip = Request.Cookies["City"].Value;
            }
            string[] res = prox.getWeather(zip);
            for (int i = 0; i < res.Length; i++)
            {
                if (i == 0)
                {
                    string a = res[i];
                    a = "Date and Time:     " + a;
                    rr.Items.Add(a);
                }
                else if (i == 1)
                {
                    string b = res[i];
                    b = "Temperature(f):    " + b;
                    rr.Items.Add(b);
                }
                else if (i == 2)
                {
                    string c = res[i];
                    c = "Condition:      " + c;
                    rr.Items.Add(c);
                }
            }

        }

        protected void Go_Crime(object sender, EventArgs e)
        {
            Response.Redirect("~/ServiceList/CheckCrime/CheckCrime.aspx");
        }
        protected void Go_Home(object sender, EventArgs e)
        {
            Response.Redirect("~/Root/Default.aspx");
        }
        protected void Go_Weather(object sender, EventArgs e)
        {
            Response.Redirect("~/ServiceList/Weather/Weather.aspx");
        }

        protected void Go_FindO(object sender, EventArgs e)
        {
            Response.Redirect("~/ServiceList/FindOther/FindOther.aspx");
        }

        //Staff Related
        protected void Go_FindRes(object sender, EventArgs e)
        {
            Response.Redirect("~/ServiceList/FindRest/FindRest.aspx");
        }

        protected void Go_Solar(object sender, EventArgs e)
        {
            Response.Redirect("~/ServiceList/Solar/Solar.aspx");
        }

        //Member Related 

    }
}