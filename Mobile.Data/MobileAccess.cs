using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Data
{
	public class MobileAccess
	{
		public DataTable InsertMobile(int Id ,string Mobile, string Model, int Price, string Description)
		{
			DataConnection dataConnection = new DataConnection();
			string query = "INSERT INTO tblMobile VALUES("+Id+",'"+Mobile+"','"+Model+"',"+Price+",'"+Description+"')";
			DataTable dtResult = dataConnection.ExecuteQuery(query);
			return dtResult;
		}

		public DataTable UpdateMobile(int Id,string Mobile, string Model, int Price, string Description)
		{
			DataConnection dataConnection = new DataConnection();
			string query = "UPDATE tblMobile SET Mobile = '" + Mobile + "',Model = '" + Model + "',Price = " + Price + ",Description = '" + Description + "' WHERE Id="+Id+"";
			DataTable dtResult = dataConnection.ExecuteQuery(query);
			return dtResult;
		}

		public DataTable DeleteMobileById(int Id)
		{
			DataConnection dataConnection = new DataConnection();
			string query = "DELETE FROM tblMobile WHERE Id="+Id+"";
			DataTable dtResult = dataConnection.ExecuteQuery(query);
			return dtResult;
		}

		public DataTable DeleteAllMobiles()
		{
			DataConnection dataConnection = new DataConnection();
			string query = "DELETE FROM tblMobile";
			DataTable dtResult = dataConnection.ExecuteQuery(query);
			return dtResult;
		}

		public DataTable SelectAllMobiles()
		{
			DataConnection dataConnection = new DataConnection();
			string query = "SELECT * FROM tblMobile";
			DataTable dtResult = dataConnection.ExecuteQuery(query);
			return dtResult;
		}

		public DataTable SelectMobileById(int Id)
		{
			DataConnection dataConnection = new DataConnection();
			string query = "SELECT * FROM tblMobile WHERE id=" + Id + "";
			DataTable dtResult = dataConnection.ExecuteQuery(query);
			return dtResult;
		}
	}
}
