using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationday4
{
    public partial class even_odd_prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x;

            x = int.Parse(TextBox1.Text);
            ListBox1.Items.Add(x.ToString());
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {

            int z = int.Parse(ListBox1.SelectedItem.Text);

            if (z % 2 == 0)
            {
                ListBox2.Items.Add(z.ToString());

            }
            else
            {
                Response.Write("Number is Odd");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(ListBox1.SelectedItem.Text);
            int count = 0;
            if(num > 1)
            {
                for (int i = 2; i <= num/2; i++)
                {
                    if(num % i == 0)
                    {
                        count = 1;
                        break;
                    }

                }

            }
            if (count == 0)
            {
                ListBox2.Items.Add(num.ToString());
            }
        }
    }
}
