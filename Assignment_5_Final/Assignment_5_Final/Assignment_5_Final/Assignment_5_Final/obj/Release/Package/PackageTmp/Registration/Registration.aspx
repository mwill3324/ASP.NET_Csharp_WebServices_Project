<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Assignment_5_Final.Registration.Registration" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <h1 style="text-align:center">Welcome to the registration Page.</h1>
    <form id="form1" runat="server">
        <div>
            <center>
                <table border="1">
                    <tr>
                        <th class="auto-style1">First Name : </th>
                        <td>
                            <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name is required!" ControlToValidate="FirstName" CssClass="auto-style2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <th class="auto-style1">Last Name : </th>
                        <td>
                            <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last Name is required!" ControlToValidate="LastName" CssClass="auto-style2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <th class="auto-style1">Email : </th>
                        <td>
                            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email is required!" ControlToValidate="Email" CssClass="auto-style2"></asp:RequiredFieldValidator>
                            <br />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter a valid email." ControlToValidate="Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="auto-style2"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <th class="auto-style1">Password : </th>
                        <td>
                            <asp:TextBox ID="PassWord1" TextMode="Password" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Passsword is required!" ControlToValidate="PassWord1" CssClass="auto-style2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <th class="auto-style1">Confirm Password : </th>
                        <td>
                            <asp:TextBox ID="PassWord2" TextMode="Password" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Confirm Password is required!" ControlToValidate="Password2" CssClass="auto-style2"></asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Both passwords must be same!" ControlToCompare="Password1" ControlToValidate="Password2" CssClass="auto-style2"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <th class="auto-style1">Confirmation : </th>
                        <td colspan="2">
                            <asp:Label ID="PassResponse" runat="server" Text="Response"></asp:Label>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <th>
                            <cc1:CaptchaControl ID="Captcha1" runat="server" 
                            CaptchaBackgroundNoise="Low" CaptchaLength="5" 
                            CaptchaHeight="60" CaptchaWidth="200" 
                            CaptchaLineNoise="None" CaptchaMinTimeout="5" 
                            CaptchaMaxTimeout="240" FontColor = "#529E00" />
                        </th>
                        <td>
                            <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="You must enter image text!" ControlToValidate = "txtCaptcha" CssClass="auto-style2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <th colspan="3">
                            <asp:Button ID="Register" runat="server" Text="Register" OnClick="DoRegister" />
                        </th>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
