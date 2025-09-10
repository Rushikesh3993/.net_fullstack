using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationday2
{
    public partial class WebFormtask1 : System.Web.UI.Page
    {
        private object response;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                TextBox1.ForeColor = System.Drawing.Color.Blue;

            }
            else if (RadioButton2.Checked == true)
            {
                TextBox1.ForeColor = System.Drawing.Color.Red;
            }
            else if (RadioButton3.Checked == true)
            {
                TextBox1.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (RadioButton4.Checked == true) {
                TextBox1.ForeColor = System.Drawing.Color.Green;
            }

        }
    }
}