<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="DoctorDashboard.aspx.cs" Inherits="Clinic_project.DoctorDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
            display: flex;
            flex-direction: column;
        }
        #ContentPlaceHolder1 {
            flex: 1 0 auto;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 70vh;
        }
        .dashboard-container {
            width: 100%;
            max-width: 900px;
            padding: 1rem;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <%
        // Prevent direct access if doctor is not logged in
        if (Session["doctor"] == null)
        {
            Response.Redirect("DoctorLogin.aspx"); // redirect to doctor login
        }
    %>
    <div class="d-flex justify-content-center align-items-center" style="min-height:70vh;">
        <div class="card shadow-sm p-4 w-100" style="max-width:900px;">
            <div class="card-header bg-primary text-white text-center">
                <h2>Welcome <%= Session["dname"] ?? "Doctor" %></h2>
                <p class="mb-0">Here are your upcoming appointments</p>
            </div>
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-striped table-hover table-bordered mb-0">
                        <thead class="table-dark">
                            <tr>
                                <th>Patient Name</th>
                                <th>Email</th>
                                <th>Phone</th>
                                <th>Appointment Date</th>
                                <th>Appointment Time</th>
                                <th>Notes</th>
                            </tr>
                        </thead>
                        <tbody>
                            <%
                                if (Session["did"] != null)
                                {
                                    string did = Session["did"].ToString();
                                    string connectionString = @"Data Source=LAPTOP-J203V7TL\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";
                                    using (SqlConnection con = new SqlConnection(connectionString))
                                    {
                                        con.Open();
                                        SqlCommand cmd = new SqlCommand("SELECT * FROM patientapp WHERE did = @d ORDER BY app_date, app_time", con);
                                        cmd.Parameters.AddWithValue("@d", did);
                                        SqlDataReader dr = cmd.ExecuteReader();
                                        while (dr.Read())
                                        {
                            %>
                            <tr>
                                <td><%= dr["pname"].ToString() %></td>
                                <td><%= dr["pemail"].ToString() %></td>
                                <td><%= dr["pphone"].ToString() %></td>
                                <td><%= Convert.ToDateTime(dr["app_date"]).ToString("dd MMM yyyy") %></td>
                                <td><%= dr["app_time"].ToString() %></td>
                                <td><%= dr["notes"].ToString() %></td>
                            </tr>
                            <%
                                        }
                                        dr.Close();
                                    }
                                }
                                else
                                {
                                    Response.Redirect("DoctorLogin.aspx");
                                }
                            %>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
