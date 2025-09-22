<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Clinic_project.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="d-flex justify-content-center align-items-center" style="min-height:70vh;">
    <div class="col-md-4">
        <div class="card p-4 shadow">
            <h3 class="text-center mb-4">Admin Login</h3>
            <form method="post" action="AdminLoginHandler.aspx">
                <div class="mb-3">
                    <input type="text" class="form-control" name="username" placeholder="Username" required />
                </div>
                <div class="mb-3">
                    <input type="password" class="form-control" name="password" placeholder="Password" required />
                </div>
                <div class="d-grid">
                    <button type="submit" class="btn btn-primary">Login</button>
                </div>
            </form>
        </div>
    </div>
</div>


</asp:Content>
