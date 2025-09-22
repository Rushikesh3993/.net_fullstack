<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="AdminLoginHandler.aspx.cs" Inherits="Clinic_project.AdminLoginHandler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%
    string user = Request.Form["username"];
    string pass = Request.Form["password"];

    if (!string.IsNullOrEmpty(user)) // form submitted
    {
        if(user == "admin" && pass == "admin123")
        {
            Session["admin"] = "true";
            Response.Redirect("Admin_aprove.aspx");
        }
        else
        {
            Response.Write("<script>alert('Invalid Credentials');window.location='AdminLogin.aspx';</script>");
        }
    }
    else // direct access
    {
        Response.Redirect("AdminLogin.aspx");
    }
%>
</asp:Content>  