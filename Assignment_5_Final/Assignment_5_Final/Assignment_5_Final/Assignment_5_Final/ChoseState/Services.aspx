<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="Assignment_5_Final.Services.Services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:lightblue;">
     <style>
                .button {
                    background-color: #4CAF50; /* Green */
                    border: none;
                    color: white;
                    padding: 16px 32px;
                    text-align: center;
                    text-decoration: none;
                    display: inline-block;
                    font-size: 16px;
                    margin: 4px 2px;
                    -webkit-transition-duration: 0.4s; /* Safari */
                    transition-duration: 0.4s;
                    cursor: pointer;
                }

                .button1 {
                    background-color: forestgreen; 
                    color: black; 
                    border: 2px solid #4CAF50;
                }
                .button1:hover {
                    background-color: #4CAF50;
                    color: white;
                }
    </style>
    <h1 style="text-align:center">You can use the following services below.</h1>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <p style="font-style:italic;">Please enter state and a zip Code to continue to our services</p>
            <p>
                <asp:DropDownList ID="DropDownList1" runat="server" Width ="200"></asp:DropDownList>
                &emsp;&emsp;ZipCode:&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width ="200"></asp:TextBox>
            </p>
            <p>
                 <asp:Button ID="GoButton" class="button button1" runat="server" OnClick="Go" Text="Go" />
            </p>
        </div>
    </form>
</body>
</html>
