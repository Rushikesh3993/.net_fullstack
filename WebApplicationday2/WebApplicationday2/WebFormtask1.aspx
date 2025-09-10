<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormtask1.aspx.cs" Inherits="WebApplicationday2.WebFormtask1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <center><div class="main">
            <asp:Label ID="Label1" runat="server" Text="Enter Name - "></asp:Label>
            
            <asp:TextBox ID="TextBox1" runat="server">name</asp:TextBox><br /><br />


            <asp:Label ID="Label2" runat="server" Text="Select color - "></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="color" Text="Blue" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="color" Text="Red" />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="color" Text="Yellow" />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="color" Text="Green" /><br /><br />

            <asp:Button ID="Button1" runat="server" Text="Apply Changes" OnClick="Button1_Click" />

        </div></center>
        
    </form>
</body>
</html>
