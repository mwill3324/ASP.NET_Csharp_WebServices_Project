<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceList.aspx.cs" Inherits="Assignment_5_Final.ServiceList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CSE 445 Login</title>
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
            background-color: white; 
            color: black; 
            border: 2px solid #4CAF50;
        }

        .button1:hover {
            background-color: #4CAF50;
            color: white;
        }

        .button2 {
            background-color: white; 
            color: black; 
            border: 2px solid #008CBA;
        }

        .button2:hover {
            background-color: #008CBA;
            color: white;
        }

        .button3 {
            background-color: white; 
            color: black; 
            border: 2px solid #f44336;
        }

        .button3:hover {
            background-color: #f44336;
            color: white;
        }

        .button4 {
            background-color: white;
            color: black;
            border: 2px solid #e7e7e7;
        }

        .button4:hover {background-color: #e7e7e7;}

        .button5 {
            background-color: white;
            color: black;
            border: 2px solid #555555;
        }

        .button5:hover {
            background-color: #555555;
            color: white;
        }
        .auto-style1 {
            text-align: right;
        }
    </style>
</head>
<body style="background-color:lightblue;">
    <form id="form1" runat="server">
        <h1 style="text-align:center">Group_WE Services</h1>
        <div style="text-align:center;">
            <asp:Button ID ="CrimeButton" class="button button1" runat="server" Text="Check Crime" OnClick ="Go_Crime" />
            <asp:Button ID="WeatherButton" class="button button2" runat="server" Text="Weather Forecast" OnClick ="Go_Weather" />
            <asp:Button ID="FindOButton" class="button button3" runat="server" Text="Find Shoppe" OnClick ="Go_FindO" />
            <asp:Button ID="SolarButton" class="button button4" runat="server" Text="Solar Intensity" OnClick="Go_Solar" />
            <asp:Button ID="FindResButton" class="button button5" runat="server" Text="Find Resturants" OnClick ="Go_FindRes" />
            <br />
            <br />
            <br />
            <center>
                <table border="1">
                    <tr>
                        <th class="auto-style1">State : </th>
                        <td><asp:Label ID="StateLabel" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <th class="auto-style1">Zipcode : </th>
                        <td><asp:Label ID="CityLabel" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>

</html>
