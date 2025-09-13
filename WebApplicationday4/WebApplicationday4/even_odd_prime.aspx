<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="even_odd_prime.aspx.cs" Inherits="WebApplicationday4.even_odd_prime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Number:-
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br />
            <br />

            


        </div>

        <asp:ListBox ID="ListBox1" runat="server" Height="198px" Width="125px"></asp:ListBox>
        <asp:Button ID="Button2" runat="server" Text="Check even" OnClick="Button2_Click" />

        <asp:Button ID="Button3" runat="server" Text="Check Prime" OnClick="Button3_Click" />

        <asp:ListBox ID="ListBox2" runat="server" Height="198px" Width="140px"></asp:ListBox>
    </form>
</body>
</html>
