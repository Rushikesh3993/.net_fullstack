<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Clinic_project.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%
    Session.Clear();   // Remove all sessions
    Session.Abandon(); // End session
    Response.Redirect("index_home.aspx"); // Send back to homepage
%>
</asp:Content>
