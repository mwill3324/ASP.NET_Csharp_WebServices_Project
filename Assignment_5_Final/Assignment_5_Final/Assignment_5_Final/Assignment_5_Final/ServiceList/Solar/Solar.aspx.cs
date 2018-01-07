using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5_Final
{
    public partial class Solar : System.Web.UI.Page
    {
        protected void findSolar(object sender, EventArgs e)
        {
            DiyaloReference1.Service1Client prox = new DiyaloReference1.Service1Client();
            MarcusReference1.ServiceClient prox2 = new MarcusReference1.ServiceClient();
            string zip = "";
            string State = "";
            if (Request.Cookies["State"] != null && Request.Cookies["City"] != null)
            {
                State = Request.Cookies["State"].Value;
                zip = Request.Cookies["City"].Value;
            }
            string res = prox2.getCoordinates(zip);
            string[] rem = { "<lat>", "</lng>" };
            string[] Split1 = res.Split(rem, StringSplitOptions.RemoveEmptyEntries);
            string[] sep = { "</lat><lng>" };
            string[] Split2 = Split1[0].Split(sep, StringSplitOptions.RemoveEmptyEntries);
            string solarIntensity = prox.avgSolarIntensity(Split2[0], Split2[1]);
            Label1.Text = ("Average Solar Intensity (ASI):\t" + solarIntensity);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }
        protected void Go_Home(object sender, EventArgs e)
        {
            Response.Redirect("~/Root/Default.aspx");
        }
        protected void Go_Crime(object sender, EventArgs e)
        {
            Response.Redirect("~/ServiceList/CheckCrime/CheckCrime.aspx");
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