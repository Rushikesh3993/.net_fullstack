<%@ Import Namespace ="System.Data.SqlClient" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="SavepatientInfo.aspx.cs" Inherits="Clinic_project.SavepatientInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%
    string a = Request.Params["t1"];
    string b = Request.Params["t2"];
    string c = Request.Params["t3"];
    string d = Request.Params["t4"];
    string e = Request.Params["t5"];
    string f = Request.Params["t6"];
    string g = Request.Params["t7"];

    string path = @"Data Source=LAPTOP-J203V7TL\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";
    using(SqlConnection con = new SqlConnection(path))
    {
        con.Open();
        string query = "INSERT INTO patientapp (pname, pemail, pphone, did, app_date, app_time, notes) " +
                       "VALUES (@a, @b, @c, @d, @e, @f, @g)";
        using(SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@e", e);
            cmd.Parameters.AddWithValue("@f", f);
            cmd.Parameters.AddWithValue("@g", g);

            int x = cmd.ExecuteNonQuery();

            if(x > 0)
            {
                // Show alert and redirect
                Response.Write("<script>alert('Appointment Booked Successfully!');window.location='PatientApp.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Booking Failed. Please try again.');window.location='PatientApp.aspx';</script>");
            }
        }
    }
%>
</asp:Content>
