using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ado.netstart
{
    public partial class connection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //**for sql server**

            //string path;
            //path = "Data Source=LAPTOP-J203V7TL\\SQLEXPRESS; Initial Catalog=companyes; Trusted_Connection=true;";

            //SqlConnection connection = new SqlConnection(path);

            //connection.Open();
            //Response.Write("Database is connetected succesfully");

            //**for xampp**
            string path;
            path = "Server=localhost; Database=enjoy; Uid=root; Password=rm8@39; ";

            MySqlConnection con = new MySqlConnection(path);
            con.Open();
            Response.Write("DB Connected");
        }
    }
}