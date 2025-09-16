<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="login_logout_with_validation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style type="text/css">
        body {
            margin: 0;
            padding: 0;
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            background: #f2f2f2;
            font-family: Arial, sans-serif;
        }

        .login-box {
            width: 400px;
            padding: 20px;
            border: 3px solid ;   
            border-radius: 10px;
            background: #fff;
            box-shadow: 0px 0px 15px rgba(0,0,0,0.2); 
        }

        h1 {
            margin-bottom: 20px;
            color: #333;
            text-align: center;
        }

        table {
            width: 100%;
            border-collapse: collapse;
        }

        td {
            padding: 5px;
            font-size:larger;
        }

        asp\:TextBox {
            width: 100%;
            padding: 6px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-box">
            <h1>Login</h1>
            <table>
                <tr>
                    <td>Enter Username:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox1" Display="Dynamic" 
                            ErrorMessage="Please Enter User Name" ForeColor="Red" Font-Italic="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Enter Password:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox2" Display="Dynamic" 
                            ErrorMessage="Please Enter the Password" ForeColor="Red" 
                            SetFocusOnError="True">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
            <center>
                <asp:Button ID="Button1" runat="server" BackColor="#3333FF" Font-Bold="True" 
                    ForeColor="White" Text="Login" OnClick="Button1_Click" Width="120px" Height="35px" />
            </center>
        </div>
    </form>
</body>
</html>
