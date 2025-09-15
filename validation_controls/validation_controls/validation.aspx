<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="validation_controls.validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 314px;
        }

        </style>
</head>
<body>

    <form id="form1" runat="server">
        <fieldset style="width: 668px">
            <legend>
                <h1>Student Registration From</h1>
            </legend>
           <center>  <div>
                <table border="2px">
                    <tr>
                        <td>Enter Name -</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox1" runat="server" Width="259px"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Please Enter Your Name" ForeColor="#CC3300" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        </td>

                    </tr>

                    <tr>
                        <td>Enter Email -</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox2" runat="server" Width="257px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Please Enter Your Email Id" Font-Italic="True" ForeColor="#CC3300" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Invalid Email Id" Font-Italic="True" ForeColor="#CC3300" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        </td>

                    </tr>

                    <tr>
                        <td>Enter Pass -</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox3" runat="server" Width="257px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Please Enter Pass" ForeColor="#CC3300" Font-Italic="True">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Enter Confirm Pass -</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox4" runat="server" Width="257px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Confirm Pass" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Please Enter Valid Pass" Font-Italic="True" ForeColor="#CC3300" SetFocusOnError="True">*</asp:CompareValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Enter Age -</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox5" runat="server" Width="257px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Enter Age." ControlToValidate="TextBox5" Display="Dynamic" Font-Italic="True" ForeColor="#CC3300" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="The Age Should Be 18 to 40" Font-Italic="True" ForeColor="#CC3300" MaximumValue="40" MinimumValue="18" SetFocusOnError="True">*</asp:RangeValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Enter Phone Number -</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox6" runat="server" Width="257px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please Enter Phone Number" ControlToValidate="TextBox6" Display="Dynamic" Font-Italic="True" ForeColor="#CC3300" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Please Enter 10 Digit Number" Font-Italic="True" ForeColor="#CC3300" SetFocusOnError="True" ValidationExpression="^[6-9]\d{9}$">*</asp:RegularExpressionValidator>
                        </td>
                    </tr>


                </table>
            </div></center>
            <br />
        <center><asp:Button ID="Button2" runat="server" Text="Registration" BackColor="#3366FF" Font-Bold="True" ForeColor="White" Height="37px" /></center>

        </fieldset>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="#000066" ForeColor="#CC3300" />
    </form>
</body>
</html>
