<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormstyle1.aspx.cs" Inherits="WebApplicationday2.WebFormstyle1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .main{
            height:300px;
            width:500px;
            border-style:groove;
            background-image: url(https://png.pngtree.com/thumb_back/fh260/background/20230411/pngtree-nature-forest-sun-ecology-image_2256183.jpg);
            background-size: cover;
           
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
           
            <div class="main">
                <h2 style="text-decoration: underline;">Simple Login Form</h2> <br /><br />

                <asp:Label ID="Label1" runat="server" Text="Enter User Name - " Font-Bold="True" Font-Size="Medium"></asp:Label> &nbsp;

                <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 0px"></asp:TextBox> <br /> <br />

                <asp:Label ID="Label2" runat="server" Text="Enter Password - " Font-Bold="True" Font-Size="Medium"></asp:Label> &nbsp;

                <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px"></asp:TextBox><br /> <br />


                <asp:Button ID="Button1" runat="server" Height="37px" Text="Check" Width="157px" Font-Bold="True" Font-Italic="True" Font-Names="Freestyle Script" OnClick="Button1_Click"/> <br /> <br />
                <asp:Label ID="Label3" runat="server" Font-Bold="True"></asp:Label>

            </div>

         </center>
    </form>
</body>
</html>
