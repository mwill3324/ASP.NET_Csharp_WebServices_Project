using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5_Final
{
    public partial class FindRest : System.Web.UI.Page
    {

        protected void findRestMethod(object sender, EventArgs e)
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            string zip = "";
            string State = "";
            if (Request.Cookies["State"] != null && Request.Cookies["City"] != null)
            {
                State = Request.Cookies["State"].Value;
                zip = Request.Cookies["City"].Value;
            }
            string[] res = prox.foodPlace(zip);
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = res[i].Replace("</", "");
                BulletedList1.Items.Add(res[i]);
            }
        }
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

        //Member Related 

    }
}