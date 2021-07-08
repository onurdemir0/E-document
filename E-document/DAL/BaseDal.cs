using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_document.DAL
{
	public class BaseDal
	{
		public SQLiteConnection sql_con;
		public SQLiteCommand sql_cmd;
		public SQLiteDataAdapter DB;
		public DataSet DS = new DataSet();
		public DataTable DT = new DataTable();
		public SQLiteDataReader DR;

		public void SetConnection()
		{
			sql_con = new SQLiteConnection("Data Source = E_Document.db");
		}

		public void ExecuteQuery(string txtQuery)
		{
			SetConnection();
			sql_con.Open();
			sql_cmd = sql_con.CreateCommand();
			sql_cmd.CommandText = txtQuery;
			sql_cmd.ExecuteNonQuery();
			sql_con.Close();
		}

		public DataTable LoadData(string commandTxt)
		{
			try
			{
				SetConnection();
				sql_con.Open();
				sql_cmd = sql_con.CreateCommand();
				//string CommandText = "select * from " + commandTxt;
				string CommandText = commandTxt;
				DB = new SQLiteDataAdapter(CommandText, sql_con);
				DS.Reset();
				DB.Fill(DS);
				DT = DS.Tables[0];
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				sql_con.Close();
			}

			return DT;
		}
	}
}
