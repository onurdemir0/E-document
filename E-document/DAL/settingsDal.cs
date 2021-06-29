using E_document.Entities;
using E_document.UI;
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
	public class settingsDal : BaseDal
	{
		public bool Add()
		{
			bool isSuccess = false;
			SetConnection();
			try
			{
				
				string txtQuery = "insert into Settings (CompanyName,Email,Mobile,WebSite,TaxAuthority,TaxIdentity,FirstAddressLine,SecondAddressLine,City,State,Zip,Country) values (@CompanyName,@Email,@Mobile,@WebSite,@TaxAuthority,@TaxIdentity,@FirstAddressLine,@SecondAddressLine,@City,@State,@Zip,@Country)";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);
				//string txtQuery = "insert into Settings (CompanyName,Email,Mobile,WebSite,TaxAuthority,TaxIdentity,FirstAddressLine,SecondAddressLine,City,State,Zip,Country)values('" + Settings.CompanyName + "','" + Settings.Email + "','" + Settings.Mobile + "','" + Settings.WebSite + "','" + Settings.TaxAuthority + "','" + Settings.TaxIdentity + "','" + Settings.FirstAddressLine + "','" + Settings.SecondAddressLine + "','" + Settings.City + "','" + Settings.State + "','" + Settings.Zip + "','" + Settings.Country + "')";


				sql_cmd.Parameters.AddWithValue("@CompanyName", Settings.CompanyName);
				sql_cmd.Parameters.AddWithValue("@Email", Settings.Email);
				sql_cmd.Parameters.AddWithValue("@Mobile", Settings.Mobile);
				sql_cmd.Parameters.AddWithValue("@WebSite", Settings.WebSite);
				sql_cmd.Parameters.AddWithValue("@TaxAuthority", Settings.TaxAuthority);
				sql_cmd.Parameters.AddWithValue("@TaxIdentity", Settings.TaxIdentity);
				sql_cmd.Parameters.AddWithValue("@FirstAddressLine", Settings.FirstAddressLine);
				sql_cmd.Parameters.AddWithValue("@SecondAddressLine", Settings.SecondAddressLine);
				sql_cmd.Parameters.AddWithValue("@City", Settings.City);
				sql_cmd.Parameters.AddWithValue("@State", Settings.State);
				sql_cmd.Parameters.AddWithValue("@Zip", Settings.Zip);
				sql_cmd.Parameters.AddWithValue("@Country", Settings.Country);

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

		public bool Update()
		{
			bool isSuccess = false;
			SetConnection();
			try
			{
				string txtQuery = "update Settings set CompanyName=@CompanyName, Email=@Email, Mobile=@Mobile, " +
				"WebSite=@WebSite, TaxAuthority=@TaxAuthority, TaxIdentity=@TaxIdentity, FirstAddressLine=@FirstAddressLine, " +
				"SecondAddressLine=@SecondAddressLine, City=@City, State=@State, Zip=@Zip, Country=@Country WHERE SettingId=@SettingId";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);


				sql_cmd.Parameters.AddWithValue("@CompanyName", Settings.CompanyName);
				sql_cmd.Parameters.AddWithValue("@Email", Settings.Email);
				sql_cmd.Parameters.AddWithValue("@Mobile", Settings.Mobile);
				sql_cmd.Parameters.AddWithValue("@WebSite", Settings.WebSite);
				sql_cmd.Parameters.AddWithValue("@TaxAuthority", Settings.TaxAuthority);
				sql_cmd.Parameters.AddWithValue("@TaxIdentity", Settings.TaxIdentity);
				sql_cmd.Parameters.AddWithValue("@FirstAddressLine", Settings.FirstAddressLine);
				sql_cmd.Parameters.AddWithValue("@SecondAddressLine", Settings.SecondAddressLine);
				sql_cmd.Parameters.AddWithValue("@City", Settings.City);
				sql_cmd.Parameters.AddWithValue("@State", Settings.State);
				sql_cmd.Parameters.AddWithValue("@Zip", Settings.Zip);
				sql_cmd.Parameters.AddWithValue("@Country", Settings.Country);
				sql_cmd.Parameters.AddWithValue("@SettingId", Settings.SettingId);

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

		public bool Delete()
		{
			bool isSuccess = false;
			SetConnection();
			try
			{
				string txtQuery = "delete from Settings WHERE SettingId=@SettingId";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				sql_cmd.Parameters.AddWithValue("@SettingId", Settings.SettingId);

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
