using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
            service.GetAllClients();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(111);
         
        }
    }
}