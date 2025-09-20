<%@ Import Namespace=" System.Data.SqlClient" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="PatientApp.aspx.cs" Inherits="Clinic_project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card shadow p-4">
                    <h3 class="text-center mb-4">Book an Appointment</h3>

                    <form action="SavepatientInfo.aspx" method="post">
                        <div class="mb-3">
                            <label for="name" class="form-label">Full Name</label>
                            <input type="text" class="form-control" id="name" name="t1" placeholder="Enter your name">
                        </div>

                        <div class="mb-3">
                            <label for="email" class="form-label">Email</label>
                            <input type="email" class="form-control" id="email" name="t2" placeholder="Enter your email">
                        </div>

                        <div class="mb-3">
                            <label for="phone" class="form-label">Phone Number</label>
                            <input type="tel" class="form-control" id="phone" name="t3" placeholder="Enter your phone number">
                        </div>

                        <div class="mb-3">
                            <label for="doctor" class="form-label">Select Doctor</label>
                            <select class="form-select" id="doctor" name="t4">
                                <%




                                    String path = "Data Source= LAPTOP-J203V7TL\\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";
                                    SqlConnection con = new SqlConnection(path);
                                    con.Open();


                                    SqlCommand cmd = new SqlCommand("select did ,dname from doctor", con);

                                    SqlDataReader br = cmd.ExecuteReader();

                                    while (br.Read())
                                    {
                                %>
                                <option value="<% Response.Write(br["did"]); %>"><% Response.Write(br["dname"]); %></option>


                                <%
                                    }
                                %>
                            </select>
                        </div>

                        <div class="mb-3">
                            <label for="date" class="form-label">Appointment Date</label>
                            <input type="date" class="form-control" id="date" name="t5">
                        </div>

                        <div class="mb-3">
                            <label for="time" class="form-label">Appointment Time</label>
                            <input type="time" class="form-control" id="time" name="t6">
                        </div>

                        <div class="mb-3">
                            <label for="message" class="form-label">Additional Notes</label>
                            <textarea class="form-control" id="message" rows="3" name="t7" placeholder="Any specific concern..."></textarea>
                        </div>

                        <div class="d-grid">
                            <button type="submit" class="btn btn-primary">Book Appointment</button>
                        </div>
                    </form>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
