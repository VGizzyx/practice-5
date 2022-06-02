using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = (DataTable)Cache["SQLCache"];

            if (GridView1.DataSource == null)
            {
                ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
                GridView1.DataSource = server.GetAllClients().Tables[0];
                GridView1.DataBind();
                Cache["SQLCache"] = server.GetAllClients().Tables[0];
                TextBox1.Text = "111";
            }
            else
            {
                TextBox1.Text = "222";
            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            TextBox2.Text = server.GetAllClients().ToString();
        }
    }
}