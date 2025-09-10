using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class menucard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0 , c = 0, d = 0;
            int itemcount = 0;


            if (CheckBox1.Checked == true)
            {
                a = 50;
                itemcount++;
            }
            if (CheckBox2.Checked == true) {
                b = 90;
                itemcount++;
            }
            if (CheckBox3.Checked == true)
            {
                c = 120;
                itemcount++;
            }
            if (CheckBox4.Checked == true)
            {
                d = 40;
                itemcount++;
            }


            int total = a + b + c + d;

            if (itemcount > 2)
            {
                total = (int)(total * 9.0);
                Label1.Text = "Total Bill after discount of 10% :-  " + total;
            }
            else
            {
                Label1.Text = "Total Bill Is " + total;
            }
        }
    }
}