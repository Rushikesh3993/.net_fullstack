using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace custom_validator
{
    public partial class palendrome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int x = int.Parse(args.Value);
            int temp = x;
            int rev = 0;

            while (x > 0) {
                int ldg = x % 10;
                rev = rev * 10 + ldg;
                x = x / 10;
            }

            if(temp == rev)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }

        }
    }
}