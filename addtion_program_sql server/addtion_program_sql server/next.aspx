<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="next.aspx.cs" Inherits="addtion_program_sql_server.next" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <%
        //this is scrptlet tag
        int a, b, c;
        a = int.Parse(Request.Params["t1"]);

        b = int.Parse(Request.Params["t2"]);

        c = a + b;
        Response.Write("Addition is " + c);


        %>
</body>
</html>
