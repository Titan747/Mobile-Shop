using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//ADO.NET -- 1.Connected Mode 2.Disconnected Mode 
//DataSet
namespace Mobile.Data
{
    public class DataConnection
    {
        public DataTable ExecuteQuery(string query)
		{
            DataTable dtResult = new DataTable();
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-4KI6957\\TONY;Initial Catalog=Mobile;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter(query,sqlConnection);
			adp.Fill(dtResult);
            return dtResult;
		}
        //public void Execute(string query)
		//{
        //    SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-4KI6957\\TONY;Initial Catalog=Mobile;Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand(query,sqlConnection);
        //    sqlConnection.Open();
        //    cmd.ExecuteNonQuery();
        //    sqlConnection.Close();
        //}
    }
}
