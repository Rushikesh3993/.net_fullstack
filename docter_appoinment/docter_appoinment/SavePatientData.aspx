<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SavePatientData.aspx.cs" Inherits="docter_appoinment.SavePatientData" %>
<%@ Import Namespace ="System.Data.SqlClient"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%
        string a, b, c, d, e, f;
        a = Request.Params["pname"];
        b = Request.Params["pemail"];
        c = Request.Params["pphone"];
        d = Request.Params["pdate"];
        e = Request.Params["ptime"];
        f = Request.Params["preason"];

        String path;
        path = "Data Source=LAPTOP-J203V7TL\\SQLEXPRESS; Initial Catalog = rushikesh_clinic; Trusted_Connection = true; ";

        SqlConnection con = new SqlConnection(path);
        con.Open();

        //Response.Write("Db connect");
        SqlCommand cmd = new SqlCommand("insert into Patient values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "')", con);

        cmd.ExecuteNonQuery();

        //Response.Write("Appoitment Booked Successfull !");
        //Response.Redirect("index.aspx");


        // Show success popup and then redirect
        Response.Write("<script>alert('Appointment booked successfully!'); window.location='index.aspx';</script>");

        %>
</body>
</html>
