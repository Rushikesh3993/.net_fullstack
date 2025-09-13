<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exam_portal.aspx.cs" Inherits="WebApplicationday4.exam_portal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center> <div>
            <h1>Rushi Examination Portal </h1>

           Question -&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="504px"></asp:TextBox> <br /> <br />
           Select Question -&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="134px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Question1</asp:ListItem>
                <asp:ListItem>Question2</asp:ListItem>
                <asp:ListItem>Question3</asp:ListItem>
                <asp:ListItem>Question4</asp:ListItem>
                <asp:ListItem>Question5</asp:ListItem>
                <asp:ListItem>Question6</asp:ListItem>
                <asp:ListItem>Question7</asp:ListItem>
                <asp:ListItem>Question8</asp:ListItem>
                <asp:ListItem>Question9</asp:ListItem>
                <asp:ListItem>Question10</asp:ListItem>
            </asp:DropDownList> <br /> <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="ans" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="ans" /> <br /> <br /> <br />

            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="ans" />&nbsp;&nbsp;&nbsp; &nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="ans" /> <br /> <br />
          
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label> <br /> <br />

           &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Submit" Height="37px" Width="101px" OnClick="Button2_Click" />

        </div>
            </center>
        
    </form>
</body>
</html>
