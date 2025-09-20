<%@ Import Namespace ="System.Data.SqlClient" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="SavepatientInfo.aspx.cs" Inherits="Clinic_project.SavepatientInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%

        String a, b, c, d, e, f, g;
        a = Request.Params["t1"];
        b = Request.Params["t2"];
        c = Request.Params["t3"];
        d = Request.Params["t4"];
        e = Request.Params["t5"];
        f = Request.Params["t6"];  
        g = Request.Params["t7"];


        String path = "Data Source=LAPTOP-J203V7TL\\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";
        SqlConnection con = new SqlConnection(path);
        con.Open();

        SqlCommand cmd = new SqlCommand("insert into patientapp values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "','" + g + "')",con);
        int x = cmd.ExecuteNonQuery();

        Response.Write("Appointment Book Suuccessful");
         




        %>
</asp:Content>
