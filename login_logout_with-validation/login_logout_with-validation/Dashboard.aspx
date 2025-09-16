<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="login_logout_with_validation.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul class="nav bg-dark py-4 px-3">
                
                <li class="nav-item me-auto d-flex align-items-center">
                    <asp:Label ID="Label1" runat="server"
                        Font-Bold="True"
                        Font-Size="Large"
                        ForeColor="White">Name</asp:Label>
                </li>

                
                <li class="nav-item">
                    <a class="nav-link text-white" href="#">About Us</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link text-white" href="#">Contact</a>
                </li>
                <li class="nav-item bg-dark  px-3">
                    <asp:Button ID="Button1" runat="server" Text="Log Out" BackColor="#CCFFCC" Font-Bold="True" ForeColor="Black" Height="40px" OnClick="Button1_Click" Width="130px" />
                </li>
            </ul>
            
        </div>
    </form>
    <center>  <h1 style="font-weight: bolder; text-decoration: underline; font-style: italic; font-family: 'Times New Roman', Times, serif; height: 70px;">Welcome To Dashboard!</h1></center>
</body>
</html>
