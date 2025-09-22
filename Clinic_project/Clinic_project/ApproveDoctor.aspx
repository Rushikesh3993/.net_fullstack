<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="ApproveDoctor.aspx.cs" Inherits="Clinic_project.ApproveDoctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%
    string did = Request.Form["did"];

    string path = @"Data Source=LAPTOP-J203V7TL\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";
    using (SqlConnection con = new SqlConnection(path))
    {
        con.Open();
        string query = "UPDATE doctor SET isApproved = 1 WHERE did = @id";
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.AddWithValue("@id", did);
            cmd.ExecuteNonQuery();
        }
    }

    Response.Redirect("Admin_aprove.aspx"); // reload page
%>
</asp:Content>
