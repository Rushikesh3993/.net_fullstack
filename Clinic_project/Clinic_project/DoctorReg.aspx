<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="DoctorReg.aspx.cs" Inherits="Clinic_project.DoctorReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card shadow p-4">
                    <h3 class="text-center mb-4">Doctor Registration</h3>

                    <form action="SaveDoctor.aspx" method="post">
                        <div class="mb-3">
                            <label for="name" class="form-label">Full Name</label>
                            <input type="text" class="form-control" id="name" name="dname" required>
                        </div>

                        <div class="mb-3">
                            <label for="email" class="form-label">Email</label>
                            <input type="email" class="form-control" id="email" name="demail" required>
                        </div>

                        <div class="mb-3">
                            <label for="edu" class="form-label">Qualification/Education</label>
                            <input type="text" class="form-control" id="edu" name="dedu" required>
                        </div>

                        <div class="mb-3">
                            <label for="username" class="form-label">Username</label>
                            <input type="text" class="form-control" id="username" name="dusername" required>
                        </div>

                        <div class="mb-3">
                            <label for="password" class="form-label">Password</label>
                            <input type="password" class="form-control" id="password" name="dpassword" required>
                        </div>

                        <div class="d-grid">
                            <button type="submit" class="btn btn-primary">Register</button>
                        </div>

                        <div class="text-center mt-3">
                            Already registered? 
                          <a href="DoctorLogin.aspx">Login here</a>
                        </div>

                    </form>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
