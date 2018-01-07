<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_5_Final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CSE 445 Login</title>
</head>
    <!--Adapted from https://msdn.microsoft.com/en-us/library/system.web.security.formsauthenticationticket.name(v=vs.110).aspx -->
    <script runat="server">
        private void Page_Load(Object Src, EventArgs e)
        {
            Welcome.InnerHtml = Server.HtmlEncode(User.Identity.Name);
            if(HttpContext.Current.User.IsInRole("Admin"))
            {
                 Label1.Text = "You are an Administrator.";
                
            }
            if(HttpContext.Current.User.IsInRole("Member"))
            {
                Label1.Text = "You are a Member.";
                toStaffPage.Visible = false;
                toStaffPage.Enabled = false;
            }
        }
        private void Signout_Click(Object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
            cookie.Expires = DateTime.Now.AddSeconds(-10);
            Response.Cookies.Add(cookie);
            Response.Write("Logged out - cookie deleted.");
        }
    </script>

<body style="background-color:lightblue;">
    <form runat="server">
        <h1 style="text-align:center">Welcome! <span id="Welcome" runat="server"/></h1>
        <hr />
        <br />
        <br />
        <div style="text-align:center;">
            <asp:Button ID="toMemberPage" runat="server" OnClick="toMemberPage_Click" Text="Member Page" Width="250px" />
            <br />
        </div>
        <br />
        <div style="text-align:center;">
            <asp:Button ID="toStaffPage" runat="server" OnClick="toStaffPage_Click" Text="Staff Page"/>
        </div>
        <br />
        <br />
        <div style="text-align:center;">
            <asp:Label ID="Label1" runat="server" Text="" Font-Italic="true"></asp:Label><br />
            <br />
            <input type="submit" OnServerClick="Signout_Click" value="Signout" runat="server"/>
        </div>
    </form>
</body>
</html>


