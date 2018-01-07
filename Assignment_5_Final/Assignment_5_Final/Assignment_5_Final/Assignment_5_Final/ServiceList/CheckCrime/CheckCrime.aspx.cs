using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5_Final
{
    public partial class CheckCrime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void findCrime(object sender, EventArgs e)
        {
            MarcusReference1.ServiceClient prox = new MarcusReference1.ServiceClient();
            string State = "";
            string zip = "";
           
            if (Request.Cookies["State"] != null && Request.Cookies["City"] != null)
                {
                    State = Request.Cookies["State"].Value;
                    zip = Request.Cookies["City"].Value;
                }
         

            string res = prox.getCoordinates(zip);
            string[] rem = { "<lat>","</lng>" };
            string[] Split1 = res.Split(rem, StringSplitOptions.RemoveEmptyEntries);
            string[] sep = { "</lat><lng>" };
            string[] Split2 = Split1[0].Split(sep,StringSplitOptions.RemoveEmptyEntries);
            string[] crimeStats = prox.getCrime(Split2[0],Split2[1]);

            BulletedList1.Items.Clear();
            for (int i = 0; i < crimeStats.Length; i++)
            {
                BulletedList1.Items.Add(crimeStats[i].ToString());
            }
        }

        //Member Related 

    }
}