using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5_Final.Services
{
    public partial class Services : System.Web.UI.Page
    {
        string[] states = new string[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        protected void Page_Load(object sender, EventArgs e)
        {
           
                foreach (string s in states)
                {
                    DropDownList1.Items.Add(s);
                }
        }
        protected void Go(object sender, EventArgs e)
        {
            if (true)
            {
                HttpContext.Current.Response.Cookies.Remove("State");
                HttpContext.Current.Response.Cookies.Remove("City");
                Response.Cookies["State"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["City"].Expires = DateTime.Now.AddDays(30);
            }

            Response.Cookies["State"].Value = DropDownList1.SelectedItem.Text.Trim();
            Response.Cookies["City"].Value = TextBox1.Text.Trim();

            Response.Redirect("~/ServiceList/ServiceList.aspx");
        }
    }
}