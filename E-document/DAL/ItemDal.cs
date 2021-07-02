using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_document.Entities;


namespace E_document.DAL
{
	public class ItemDal : BaseDal
	{
		public bool Add(Item item)
		{
			bool isSuccess = false;
			SetConnection();

			try
			{
				string txtQuery = "insert into Items (BillId,LineNo,ItemNo,ItemName,Quantity,Unit,UnitPrice,VatRate,VatPrice,Total) values (@BillId,@LineNo,@ItemNo,@ItemName,@Quantity,@Unit,@UnitPrice,@VatRate,@VatPrice,@Total)";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				sql_cmd.Parameters.AddWithValue("@BillId", item.BillId);
				sql_cmd.Parameters.AddWithValue("@LineNo", item.LineNo);
				sql_cmd.Parameters.AddWithValue("@ItemNo", item.ItemNo);
				sql_cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
				sql_cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
				sql_cmd.Parameters.AddWithValue("@Unit", item.Unit);
				sql_cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
				sql_cmd.Parameters.AddWithValue("@VatRate", item.VatRate);
				sql_cmd.Parameters.AddWithValue("@VatPrice", item.VatPrice);
				sql_cmd.Parameters.AddWithValue("@Total", item.Total);

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
			catch (Exception)
			{

				throw;
			}
			finally
			{
				sql_con.Close();
			}

			return isSuccess;
		}
	}
}
