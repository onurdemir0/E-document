using E_document.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_document.DAL
{
	public class BillDal : BaseDal
	{
		public bool Add(Bill bill)
		{
			bool isSuccess = false;
			SetConnection();
			try
			{
				string txtQuery = "insert into Bills (CustomerId,Ettn,Type,BillDate,BillType,Currency,OrderNo,OrderDate,WayBillNo,WaybillDate) values (@CustomerId,@Ettn,@Type,@BillDate,@BillType,@Currency,@OrderNo,@OrderDate,@WayBillNo,@WaybillDate)";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				sql_cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
				sql_cmd.Parameters.AddWithValue("@Ettn", bill.Ettn);
				sql_cmd.Parameters.AddWithValue("@Type", bill.Type);
				sql_cmd.Parameters.AddWithValue("@BillDate", bill.BillDate);
				sql_cmd.Parameters.AddWithValue("@BillType", bill.BillType);
				sql_cmd.Parameters.AddWithValue("@Currency", bill.Currency);
				sql_cmd.Parameters.AddWithValue("@OrderNo", bill.OrderNo);
				sql_cmd.Parameters.AddWithValue("@OrderDate", bill.OrderDate);
				sql_cmd.Parameters.AddWithValue("@WayBillNo", bill.WayBillNo);
				sql_cmd.Parameters.AddWithValue("@WayBillDate", bill.WayBillDate);

				sql_con.Open();

				int rows = sql_cmd.ExecuteNonQuery();

				if (rows > 0)
				{
					isSuccess = true;
				}
				else
				{
					isSuccess = false;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				sql_con.Close();
			}

			return isSuccess;
		}
	}
}
