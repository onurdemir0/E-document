using E_document.Entities;
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
	public class BillDal : BaseDal
	{
		public bool Add(Bill bill)
		{
			bool isSuccess = false;
			SetConnection();
			try
			{

				//string txtQuery = "insert into Bills (CustomerId,SettingsId,Ettn,Type,BillDate,BillType,Currency,OrderNo,OrderDate,WayBillNo,WaybillDate) values (@CustomerId,@SettingsId,@Ettn,@Type,@BillDate,@BillType,@Currency,@OrderNo,@OrderDate,@WayBillNo,@WaybillDate)";

				//string txtQuery = "insert into Bills (CustomerId,SettingsId,Ettn,Type,BillDate,BillType,Currency,OrderNo,OrderDate,WayBillNo,WaybillDate,TIN_NIN,Title,FirstName,LastName,Road_Street,ApartmentName,ApartmentNo,Floor,Town,District,State,Zip,Country,Phone,Fax,Email,WebSite,TaxAuthority) values (@CustomerId,@SettingsId,@Ettn,@Type,@BillDate,@BillType,@Currency,@OrderNo,@OrderDate,@WayBillNo,@WaybillDate,@TIN_NIN,@Title,@FirstName,@LastName,@Road_Street,@ApartmentName,@ApartmentNo,@Floor,@Town,@District,@State,@Zip,@Country,@Phone,@Fax,@Email,@WebSite,@TaxAuthority)";

				string txtQuery = "insert into Bills (CustomerId,SettingsId,Ettn,Type,BillDate,BillType,Currency,OrderNo,OrderDate,WayBillNo,WaybillDate,TIN_NIN,Title,FirstName,LastName,Road_Street,ApartmentName,ApartmentNo,Floor,Town,District,State,Zip,Country,Phone,Fax,Email,WebSite,TaxAuthority,CompanyName,CompanyEmail,CompanyMobile,CompanyWebSite,CompanyTaxAuthority,CompanyTaxIdentity,FirstAddressLine,SecondAddressLine,CompanyCity,CompanyState,CompanyZip,CompanyCountry,Note) values (@CustomerId,@SettingsId,@Ettn,@Type,@BillDate,@BillType,@Currency,@OrderNo,@OrderDate,@WayBillNo,@WaybillDate,@TIN_NIN,@Title,@FirstName,@LastName,@Road_Street,@ApartmentName,@ApartmentNo,@Floor,@Town,@District,@State,@Zip,@Country,@Phone,@Fax,@Email,@WebSite,@TaxAuthority,@CompanyName,@CompanyEmail,@CompanyMobile,@CompanyWebSite,@CompanyTaxAuthority,@CompanyTaxIdentity,@FirstAddressLine,@SecondAddressLine,@CompanyCity,@CompanyState,@CompanyZip,@CompanyCountry,@Note)";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				sql_cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
				sql_cmd.Parameters.AddWithValue("@SettingsId", bill.SettingsId);
				sql_cmd.Parameters.AddWithValue("@Ettn", bill.Ettn);
				sql_cmd.Parameters.AddWithValue("@Type", bill.Type);
				sql_cmd.Parameters.AddWithValue("@BillDate", bill.BillDate);
				sql_cmd.Parameters.AddWithValue("@BillType", bill.BillType);
				sql_cmd.Parameters.AddWithValue("@Currency", bill.Currency);
				sql_cmd.Parameters.AddWithValue("@OrderNo", bill.OrderNo);
				sql_cmd.Parameters.AddWithValue("@OrderDate", bill.OrderDate);
				sql_cmd.Parameters.AddWithValue("@WayBillNo", bill.WayBillNo);
				sql_cmd.Parameters.AddWithValue("@WayBillDate", bill.WayBillDate);

				sql_cmd.Parameters.AddWithValue("@TIN_NIN", bill.TinNin);
				sql_cmd.Parameters.AddWithValue("@Title", bill.Title);
				sql_cmd.Parameters.AddWithValue("@FirstName", bill.FirstName);
				sql_cmd.Parameters.AddWithValue("@LastName", bill.LastName);
				sql_cmd.Parameters.AddWithValue("@Road_Street", bill.RoadStreet);
				sql_cmd.Parameters.AddWithValue("@ApartmentName", bill.ApartmentName);
				sql_cmd.Parameters.AddWithValue("@ApartmentNo", bill.ApartmentNo);
				sql_cmd.Parameters.AddWithValue("@Floor", bill.Floor);
				sql_cmd.Parameters.AddWithValue("@Town", bill.Town);
				sql_cmd.Parameters.AddWithValue("@District", bill.District);
				sql_cmd.Parameters.AddWithValue("@State", bill.State);
				sql_cmd.Parameters.AddWithValue("@Zip", bill.Zip);
				sql_cmd.Parameters.AddWithValue("@Country", bill.Country);
				sql_cmd.Parameters.AddWithValue("@Phone", bill.Phone);
				sql_cmd.Parameters.AddWithValue("@Fax", bill.Fax);
				sql_cmd.Parameters.AddWithValue("@Email", bill.Email);
				sql_cmd.Parameters.AddWithValue("@WebSite", bill.WebSite);
				sql_cmd.Parameters.AddWithValue("@TaxAuthority", bill.TaxAuthority);

				sql_cmd.Parameters.AddWithValue("@CompanyName", bill.CompanyName);
				sql_cmd.Parameters.AddWithValue("@CompanyEmail", bill.CompanyEmail);
				sql_cmd.Parameters.AddWithValue("@CompanyMobile", bill.CompanyMobile);
				sql_cmd.Parameters.AddWithValue("@CompanyWebSite", bill.CompanyWebSite);
				sql_cmd.Parameters.AddWithValue("@CompanyTaxAuthority", bill.CompanyTaxAuthority);
				sql_cmd.Parameters.AddWithValue("@CompanyTaxIdentity", bill.CompanyTaxIdentity);
				sql_cmd.Parameters.AddWithValue("@FirstAddressLine", bill.FirstAddressLine);
				sql_cmd.Parameters.AddWithValue("@SecondAddressLine", bill.SecondAddressLine);
				sql_cmd.Parameters.AddWithValue("@CompanyCity", bill.CompanyCity);
				sql_cmd.Parameters.AddWithValue("@CompanyState", bill.CompanyState);
				sql_cmd.Parameters.AddWithValue("@CompanyZip", bill.CompanyZip);
				sql_cmd.Parameters.AddWithValue("@CompanyCountry", bill.CompanyCountry);

				sql_cmd.Parameters.AddWithValue("@Note", bill.Note);

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

		public Bill GetBillIdFromEttn(string ettn)
		{
			Bill bill = new Bill();
			SQLiteConnection sql_con = new SQLiteConnection("Data Source = E_Document.db");

			DataTable dt = new DataTable();

			try
			{
				string txtQuery = "SELECT Billid from Bills WHERE Ettn='" + ettn + "'";
				SQLiteDataAdapter adapter = new SQLiteDataAdapter(txtQuery, sql_con);

				sql_con.Open();

				adapter.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					bill.BillId = int.Parse(dt.Rows[0]["Billid"].ToString());
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

			return bill;
		}

		public bool AddCustToAddressBook(AddressBook addressBook)
		{
			bool isSuccess = false;
			SetConnection();

			try
			{
				string txtQuery = "insert into AddressBooks (TIN_NIN,Title,FirstName,LastName,Road_Street,ApartmentName,ApartmentNo,Floor,Town,District,State,Zip,Country,Phone,Fax,Email,WebSite,TaxAuthority,Situation) values (@TIN_NIN,@Title,@FirstName,@LastName,@Road_Street,@ApartmentName,@ApartmentNo,@Floor,@Town,@District,@State,@Zip,@Country,@Phone,@Fax,@Email,@WebSite,@TaxAuthority,@Situation)";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				sql_cmd.Parameters.AddWithValue("@Title", addressBook.Title);
				sql_cmd.Parameters.AddWithValue("@FirstName", addressBook.FirstName);
				sql_cmd.Parameters.AddWithValue("@LastName", addressBook.LastName);
				sql_cmd.Parameters.AddWithValue("@TIN_NIN", addressBook.TinNin);
				sql_cmd.Parameters.AddWithValue("@Road_Street", addressBook.RoadStreet);
				sql_cmd.Parameters.AddWithValue("@ApartmentName", addressBook.ApartmentName);
				sql_cmd.Parameters.AddWithValue("@ApartmentNo", addressBook.ApartmentNo);
				sql_cmd.Parameters.AddWithValue("@Floor", addressBook.Floor);
				sql_cmd.Parameters.AddWithValue("@Town", addressBook.Town);
				sql_cmd.Parameters.AddWithValue("@District", addressBook.District);
				sql_cmd.Parameters.AddWithValue("@State", addressBook.State);
				sql_cmd.Parameters.AddWithValue("@Zip", addressBook.Zip);
				sql_cmd.Parameters.AddWithValue("@Country", addressBook.Country);
				sql_cmd.Parameters.AddWithValue("@Phone", addressBook.Phone);
				sql_cmd.Parameters.AddWithValue("@Fax", addressBook.Fax);
				sql_cmd.Parameters.AddWithValue("@Email", addressBook.Email);
				sql_cmd.Parameters.AddWithValue("@WebSite", addressBook.WebSite);
				sql_cmd.Parameters.AddWithValue("@TaxAuthority", addressBook.TaxAuthority);
				sql_cmd.Parameters.AddWithValue("@Situation", addressBook.Situation);

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
