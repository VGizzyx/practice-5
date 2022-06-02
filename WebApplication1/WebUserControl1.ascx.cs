using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public double Result
        {
            get { return Convert.ToDouble(Label1.Text); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                TextBox1.Text = 0.ToString();
            }
            else if (TextBox2.Text == "")
            {
                TextBox2.Text = 0.ToString();
            }
            else
            {
                double a = Convert.ToDouble(TextBox1.Text);
                double b = Convert.ToDouble(TextBox2.Text);
                Label1.Text = Convert.ToString(a + b);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                TextBox1.Text = 0.ToString();
            }
            else if (TextBox2.Text == "")
            {
                TextBox2.Text = 0.ToString();
            }
            else
            {
                double a = Convert.ToDouble(TextBox1.Text);
                double b = Convert.ToDouble(TextBox2.Text);
                Label1.Text = Convert.ToString(a - b);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                TextBox1.Text = 0.ToString();
            }
            else if (TextBox2.Text == "")
            {
                TextBox2.Text = 0.ToString();
            }
            else
            {
                double a = Convert.ToDouble(TextBox1.Text);
                double b = Convert.ToDouble(TextBox2.Text);
                Label1.Text = Convert.ToString(a * b);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                TextBox1.Text = 0.ToString();
            }
            else if (TextBox2.Text == "")
            {
                TextBox2.Text = 0.ToString();
            }
            else
            {
                double a = Convert.ToDouble(TextBox1.Text);
                double b = Convert.ToDouble(TextBox2.Text);
                Label1.Text = Convert.ToString(a / b);
            }
        }
    }
}