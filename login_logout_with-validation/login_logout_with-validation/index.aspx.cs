using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_logout_with_validation
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["x"] = TextBox1.Text;
            //Session["y"] = TextBox2.Text;

            Response.Redirect("Dashboard.aspx");
        }
    }
}