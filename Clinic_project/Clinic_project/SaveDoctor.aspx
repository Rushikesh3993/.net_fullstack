<%@ Import Namespace="System.Data.SqlClient" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="SaveDoctor.aspx.cs" Inherits="Clinic_project.SaveDoctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%

        String a, b, c, d, e;
        a = Request.Params["dname"];
        b = Request.Params["demail"];
        c = Request.Params["dedu"];
        d = Request.Params["dusername"];
        e = Request.Params["dpassword"];

      string path = @"Data Source=LAPTOP-J203V7TL\SQLEXPRESS; Initial Catalog=clinic; Trusted_Connection=true;";

    using(SqlConnection con = new SqlConnection(path))
    {
        con.Open();

        string query = "INSERT INTO doctor (dname, demail, dedu, username, password, isApproved) " +
                       "VALUES (@dname, @demail, @dedu, @username, @password, 0)";

        using(SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.AddWithValue("@dname", a);
            cmd.Parameters.AddWithValue("@demail", b);
            cmd.Parameters.AddWithValue("@dedu", c);
            cmd.Parameters.AddWithValue("@username", d);
            cmd.Parameters.AddWithValue("@password", e);

            int x = cmd.ExecuteNonQuery();

            if(x > 0)
                Response.Write("Registration Successful. Waiting for Admin Approval.");
            else
                Response.Write("Registration Failed. Try Again!");
        }
    }


    %>
</asp:Content>
