<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menucard.aspx.cs" Inherits="WebApplication3.menucard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .main {
            width: 500px;
            height: 500px;
            border: groove;
            background-image: url(https://cf.bstatic.com/xdata/images/hotel/max1024x768/459886623.jpg?k=c3fca0dc8cd1d736671a7393bd77db1b00d439657d9edfe8da5d6cd7c028d324&o=&hp=1);
            background-size: cover;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div class="main">
                <h1 style="font-size: xx-large; font-weight: bold; font-style: italic; text-decoration: underline;">Hotel Bagyshree MH11</h1>
                <br />
                <br />

                <asp:CheckBox ID="CheckBox1" runat="server" Text="Chole Bature" Font-Bold="True" ForeColor="White" />
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp; <span style="color: white; font-weight: bold;">50rs</span>
                <br />
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Pav Bhaji" Font-Bold="True" ForeColor="White" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: white; font-weight: bold;">90rs</span>
                <br />
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Veg Biryani" Font-Bold="True" ForeColor="White" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: white; font-weight: bold;">120rs</span>
                <br />
                <br />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Dalchya Rice" Font-Bold="True" ForeColor="White" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: white; font-weight: bold;">40rs</span>
                <br />
                <br />
                <br />
                <br />

                <asp:Button ID="Button1" runat="server" Text="Total Bill" Height="36px" style="margin-left: 0px" Width="131px" OnClick="Button1_Click" /> <br /> <br /> <br /> <br />


                <asp:Label ID="Label1" runat="server"  Font-Bold="True" Font-Size="Large" ForeColor="#FF0066"></asp:Label>

            </div>
        </center>
    </form>
</body>
</html>
