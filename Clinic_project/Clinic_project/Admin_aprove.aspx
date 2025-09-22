<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" Inherits="Clinic_project.Admin_aprove" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%
    // Block direct access if not logged in
    if (Session["admin"] == null)
    {
        Response.Redirect("AdminLogin.aspx");
    }
%>
    <div class="container mt-5">
        <h2 class="text-center mb-4">Pending Doctor Approvals</h2>

        <table class="table table-bordered table-striped">
            <thead class="table-dark">
                <tr>
                    <th>ID</th>
                    <th>Doctor Name</th>
                    <th>Email</th>
                    <th>Education</th>
                    <th>Username</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <%
                    string path = @"Data Source=LAPTOP-J203V7TL\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";
                    using (SqlConnection con = new SqlConnection(path))
                    {
                        con.Open();
                        string query = "SELECT did, dname, demail, dedu, username FROM doctor WHERE isApproved = 0";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                %>
                <tr>
                    <td><%= dr["did"] %></td>
                    <td><%= dr["dname"] %></td>
                    <td><%= dr["demail"] %></td>
                    <td><%= dr["dedu"] %></td>
                    <td><%= dr["username"] %></td>
                    <td>
                        <form action="ApproveDoctor.aspx" method="post" style="display:inline;">
                            <input type="hidden" name="did" value="<%= dr["did"] %>" />
                            <button type="submit" class="btn btn-success btn-sm">Approve</button>
                        </form>
                    </td>
                </tr>
                <%
                        }
                        dr.Close();
                    }
                %>
            </tbody>
        </table>
    </div>
</asp:Content>
