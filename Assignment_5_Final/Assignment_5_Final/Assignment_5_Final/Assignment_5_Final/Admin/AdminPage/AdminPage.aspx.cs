using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Assignment_5_Final.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/UserPass.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();
            */
        }

        protected void add_xml(object sender, EventArgs e)
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            string Fname = FirstName.Text;
            string Lname = LastName.Text;
            string pass1 = PassWord.Text;
            string email = Email.Text;

            if (DropDownList1.SelectedItem.Text == "Staff")
            {
                string encryptedPass = prox.Encryption(pass1);
                string fullString = Fname + "," + Lname + "," + email + "," + encryptedPass;
                if(prox.write2XML("staff.xml", fullString))
                { ErrorCodes.Text = "Admin Created"; }
                else
                { ErrorCodes.Text = "Admin Not Created"; }

            }
            if (DropDownList1.SelectedItem.Text == "Member")
            {
                string encryptedPass = prox.Encryption(pass1);
                string fullString = Fname + "," + Lname + "," + email + "," + encryptedPass;
                if (prox.write2XML("member.xml", fullString))
                { ErrorCodes.Text = "member Created"; }
                else
                { ErrorCodes.Text = "member Not Created"; }

            }

        }

        protected void update_xml(object sender, EventArgs e)
        {
        }

        protected void delete_xml(object sender, EventArgs e)
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            if(DropDownList1.SelectedItem.Text == "Member")
            {
                if (prox.deleteUser("member.xml", Email.Text))
                {
                    ErrorCodes.Text = "Account Deleted";
                }
                else
                {
                    ErrorCodes.Text = "Account Not Found";
                }
            }
            else if(DropDownList1.SelectedItem.Text == "Staff")
            {
                if (prox.deleteUser("staff.xml", Email.Text))
                {
                    ErrorCodes.Text = "Account Deleted";
                }
                else
                {
                    ErrorCodes.Text = "Account Not Found";
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}