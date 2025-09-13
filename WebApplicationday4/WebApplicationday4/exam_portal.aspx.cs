using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationday4
{
    public partial class exam_portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedItem.Text == "Question1")
            {
                TextBox1.Text = "ASP.NET is developed by ?";
                RadioButton1.Text = "Google";
                RadioButton2.Text = "Microsoft";
                RadioButton3.Text = "Oracle";
                RadioButton4.Text = "Ibm";
            }
            else if(DropDownList1.SelectedItem.Text == "Question2")
            {
                TextBox1.Text = "Which language can be used to write server-side code in ASP.NET ?";
                RadioButton1.Text = "C#";
                RadioButton2.Text = "VB.Net";
                RadioButton3.Text = "J#";
                RadioButton4.Text = "All of the above";
            }
            else if (DropDownList1.SelectedItem.Text == "Question3")
            {
                TextBox1.Text = "Which of the following is the file extension for ASP.NET web form pages ?";
                RadioButton1.Text = ".asp";
                RadioButton2.Text = ".aspx";
                RadioButton3.Text = ".html";
                RadioButton4.Text = ".cs";
            }
            else if (DropDownList1.SelectedItem.Text == "Question4")
            {
                TextBox1.Text = "In ASP.NET, which object is used to store information across multiple pages ?";
                RadioButton1.Text = "ViewSate";
                RadioButton2.Text = "Session";
                RadioButton3.Text = "Request";
                RadioButton4.Text = "Response";
            }
            else if (DropDownList1.SelectedItem.Text == "Question5")
            {
                TextBox1.Text = "Which of the following is NOT a valid ASP.NET page directive ?";
                RadioButton1.Text = "@Page";
                RadioButton2.Text = "@Control";
                RadioButton3.Text = "@Register";
                RadioButton4.Text = "@Method";
            }
            else if (DropDownList1.SelectedItem.Text == "Question6")
            {
                TextBox1.Text = "The default authentication mode in ASP.NET is: ";
                RadioButton1.Text = "Windows";
                RadioButton2.Text = "Forms";
                RadioButton3.Text = "Passport";
                RadioButton4.Text = "None";
            }
            else if (DropDownList1.SelectedItem.Text == "Question7")
            {
                TextBox1.Text = "Which of the following is used to manage state in ASP.NET ?";
                RadioButton1.Text = "ViewState";
                RadioButton2.Text = "Session";
                RadioButton3.Text = "Application";
                RadioButton4.Text = "All of the above";
            }
            else if (DropDownList1.SelectedItem.Text == "Question8")
            {
                TextBox1.Text = "Which object is used to read data sent by the client in ASP.NET ? ";
                RadioButton1.Text = "Response";
                RadioButton2.Text = "Request";
                RadioButton3.Text = "Session";
                RadioButton4.Text = "Application";
            }
            else if (DropDownList1.SelectedItem.Text == "Question9")
            {
                TextBox1.Text = "What is the default page in an ASP.NET application ?  ";
                RadioButton1.Text = "index.html";
                RadioButton2.Text = "home.aspx";
                RadioButton3.Text = "default.aspx";
                RadioButton4.Text = "main.aspx";
            }
            else if (DropDownList1.SelectedItem.Text == "Question10")
            {
                TextBox1.Text = "Which control is used to display a drop-down list in ASP.NET ? ";
                RadioButton1.Text = "ListBox";
                RadioButton2.Text = "DropDownList";
                RadioButton3.Text = "RadioButtonList";
                RadioButton4.Text = "CheckBoxList";
            }
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    if (DropDownList1.SelectedItem.Text == "Question1")
        //    {
        //        if (RadioButton2.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question2")
        //    {
        //        if (RadioButton4.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question3")
        //    {
        //        if (RadioButton2.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question4")
        //    {
        //        if (RadioButton2.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question5")
        //    {
        //        if (RadioButton4.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question6")
        //    {
        //        if (RadioButton1.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question7")
        //    {
        //        if (RadioButton4.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question8")
        //    {
        //        if (RadioButton2.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question9")
        //    {
        //        if (RadioButton3.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //    else if (DropDownList1.SelectedItem.Text == "Question10")
        //    {
        //        if (RadioButton2.Checked == true)
        //        {
        //            Label1.Text = "Answer is correct";
        //            Label1.ForeColor = System.Drawing.Color.Green;
        //        }
        //        else
        //        {
        //            Label1.Text = "Answer is Incorrect";
        //            Label1.ForeColor = System.Drawing.Color.Red;
        //        }
        //    }
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            // initialize score and attempted if first time
            if (Session["score"] == null) Session["score"] = 0;
            if (Session["attempted"] == null) Session["attempted"] = 0;

            int score = (int)Session["score"];
            int attempted = (int)Session["attempted"];

            bool isCorrect = false;

            // ✅ Check correct answers
            if (DropDownList1.SelectedItem.Text == "Question1" && RadioButton2.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question2" && RadioButton4.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question3" && RadioButton2.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question4" && RadioButton2.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question5" && RadioButton4.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question6" && RadioButton1.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question7" && RadioButton4.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question8" && RadioButton2.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question9" && RadioButton3.Checked) isCorrect = true;
            else if (DropDownList1.SelectedItem.Text == "Question10" && RadioButton2.Checked) isCorrect = true;

            // ✅ Show result for current question
            if (isCorrect)
            {
                score++;
                Label1.Text = "Correct ✅";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label1.Text = "Wrong ❌";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

            attempted++;

            // save back to session
            Session["score"] = score;
            Session["attempted"] = attempted;

            // ✅ If all 10 attempted → show final score
            if (attempted == 10)
            {
                Label1.Text = "🎉 Exam Finished! Your Score: " + score + " / 10";
                Label1.ForeColor = System.Drawing.Color.Blue;

                // reset if you want to allow retake
                Session["score"] = null;
                Session["attempted"] = null;
            }
        }
    }
}