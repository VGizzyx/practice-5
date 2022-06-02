using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        public void GetAllClients()
        {
            /*DataSet dataSet = new DataSet();
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["MyTradeDB"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Clients", connection);
                adapter.Fill(dataSet);
            }
            return dataSet;*/

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\DOTNET\pracktic5\WebApplication1\WebApplication2\App_Data\TradeDBpractik3.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT* FROM Clients", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Console.WriteLine(dataTable);
        }
    }
}
