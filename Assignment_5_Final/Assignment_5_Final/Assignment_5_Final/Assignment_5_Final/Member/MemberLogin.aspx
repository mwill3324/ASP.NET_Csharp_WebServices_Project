<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="Assignment_5_Final.MemberLogin" %>

<!DOCTYPE html>
<style>
  .tableOne {
    margin:auto;
  }
    .auto-style1 {
        text-align: right;
    }
</style>
<html xmlns="http://www.w3.org/1999/xhtml">

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Web.Security " %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace = "System.Security.Principal"%>

<script runat="server">
    private void Logon_Click(Object sender, EventArgs e)
    {
        if( !Page.IsValid )
        {
            Msg.Text = "Some required fields are invalid.";
            return;
        }
        String cmd = "Email='" + UserEmail.Value + "'";
        string pass = AdminLogin();
        string theRole = "Member";
        if(pass == "Not found")
        {
            pass = MemLogin();
            theRole = "Member";
        }
        else
        {
            theRole = "Admin";
        }
        if(pass != "Not found")
        {
            string hashedpwd = enc(UserPass.Value.ToString());
            if (0 != String.Compare(pass, hashedpwd, false))
            {
                Msg.Text = "Invalid Credentials: Please try again.";
            }
            else
            {
                FormsAuthenticationTicket myticket = new FormsAuthenticationTicket(
                      1,
                      UserEmail.Value,// + " "+theRole
                      DateTime.Now,
                      DateTime.Now.AddMinutes(30),  // expiry
                      true,  //do not remember
                      theRole,
                      FormsAuthentication.FormsCookiePath);
                string encTicket = FormsAuthentication.Encrypt(myticket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
                Response.Redirect("~/Root/Default.aspx");
            }
        }
        else
        {
            Response.Redirect("~/Registration/Registration.aspx");
        }
    }
</script>
 <head runat="server">
<title>Forms Authentication</title>
</head>

<body style="background-color:lightblue">
    <h1 style="text-align:center">Welcome to the Group_WE login page.</h1>
    <hr />
    <form id="form1" runat="server">
        <div style="text-align:center">
            <p style="font-style:italic">
                Notes:<br />
                Welcome to WE services, please login as appropriate to continue.<br />
                For TA: Email is: TA@gmail.com and Password is: Cse445ta!<br />
                This can be used for Admin and member login.<br />
                Admin takes precedence over member login.<br />
                You can check the box to remember your credentials for the next time you log in.
            </p>
            <br />
            <table class="tableOne">
                <tr>
                    <td class="auto-style1">Email:</td>
                    <td><input id="UserEmail" type="text" runat="server"/></td>         
                    <td>
                        <asp:RegularExpressionValidator id="RegexValidator" 
                         ControlToValidate="UserEmail"
                         ValidationExpression="^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                         EnableClientScript="false"
                         Display="Static"
                         ErrorMessage="Invalid format for e-mail address."
                         runat="server"/>
                    </td>
                </tr>
                <tr>    
                     <td class="auto-style1">Password:</td>
                    <td><input id="UserPass" type="password" runat="server"/></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1">Persistent Cookies:</td>
                    <td>
                        <asp:CheckBox id="Persist" runat="server" autopostback="true"/>
                    </td>
                    <td></td>
                </tr>
            </table>
            <br />
            <input type="submit" OnServerClick="Logon_Click" value="Login" runat="server"/>
            <br />
            <br />
            <asp:Label id="Msg" ForeColor="red" Font-Name="Verdana" Font-Size="10" runat="server"/>
        </div>
        <br />
        <div style="text-align:center">
            <asp:Button ID="toRegistration" runat="server" OnClick="toRegistration_Click" Text="Member Registration" Width="250px" />
        </div>
    </form>
</body>
</html>
