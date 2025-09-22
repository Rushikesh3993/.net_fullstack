<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="DoctorLoginHandler.aspx.cs" Inherits="Clinic_project.DoctorLoginHandler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%
    string username = Request.Form["username"];
    string password = Request.Form["password"];
    string path = @"Data Source=LAPTOP-J203V7TL\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";
    
    using(SqlConnection con = new SqlConnection(path))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM doctor WHERE username=@u AND password=@p AND isApproved=1", con);
        cmd.Parameters.AddWithValue("@u", username);
        cmd.Parameters.AddWithValue("@p", password);
        SqlDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
        {
            Session["did"] = dr["did"];
            Session["dname"] = dr["dname"];
            Response.Redirect("DoctorDashboard.aspx");
        }
        else
        {
            Response.Write("<script>alert('Invalid or Not Approved');window.location='DoctorLogin.aspx';</script>");
        }
    }
%>
</asp:Content>
