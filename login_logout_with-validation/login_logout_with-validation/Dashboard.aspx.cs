using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_logout_with_validation
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["x"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                //Response.Write("Username is " + Session["x"]);
                Label1.Text= Application["x"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["x"] = null;

            Response.Redirect("index.aspx");
        }
    }
}