using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationday2
{
    public partial class WebFormstyle1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a, b;
            
            a=TextBox1.Text;
            b=TextBox2.Text;

            if(a.Equals("Rushi") && b.Equals("rushi@123")){
                //Response.Write("Login Succesful");
                Label3.Text = "Login Succesful";
            }
            else
            {
                //Response.Write("Login Failed");
                Label3.Text = "Login Failed";
            }
        }
    }
}