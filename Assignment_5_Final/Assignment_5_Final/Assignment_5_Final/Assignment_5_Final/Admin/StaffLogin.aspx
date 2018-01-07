<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="Assignment_5_Final.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
        }
    </style>
</head>
<body>
    <h1 style="text-align:center">Welcome to the staff login page.</h1>
    <form id="form1" runat="server">
        <div>
                        <table border="1">
                <tr>
                    <th class="auto-style2">Email : </th>
                    <td><asp:TextBox ID="Email" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <th class="auto-style2">Password : </th>
                    <td><asp:TextBox ID="Password" runat="server" TextMode ="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <th class="auto-style2">Remember me : </th>
                    <td class="auto-style1"><asp:CheckBox ID="RememberMe" runat="server" /><br /></td>
                </tr>
                <tr>
                    <th colspan="2">
                        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick ="StaffLogin"/>
                    </th>
                </tr>
                <tr>
                    <th colspan="2">
                        <asp:Label ID="Shiz" runat="server" Text=""></asp:Label>
                    </th>
                </tr>
                </table>
        </div>
    </form>
</body>