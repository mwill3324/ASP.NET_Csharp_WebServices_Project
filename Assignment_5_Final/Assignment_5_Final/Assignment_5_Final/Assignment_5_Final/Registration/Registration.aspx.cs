using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5_Final.Registration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DoRegister(object sender, EventArgs e)
        {
            MMServiceReference1.Service1Client prox = new MMServiceReference1.Service1Client();
            string Fname = FirstName.Text;
            string Lname = LastName.Text;
            string pass1 = PassWord1.Text;
            string pass2 = PassWord2.Text;
            string email = Email.Text;

            Captcha1.ValidateCaptcha(txtCaptcha.Text.Trim());
            if (pass1 == pass2 && Captcha1.UserValidated)
            {
                string encryptedPass = prox.Encryption(pass1);

                string fullString = Fname + "," + Lname + "," + email + "," + encryptedPass;
            
                if(prox.write2XML("member.xml", fullString))
                { PassResponse.Text = "Account Created";}
                else
                { PassResponse.Text = "Account Not Created"; }
               
            }
            else
            {
                PassResponse.Text = "Passwords do not match.";
            }
                
  
        }
    }
}