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
	public class AddressBookDal : BaseDal
	{
		public bool Add(AddressBook addressBook)
		{
			bool isSuccess = false;
			SetConnection();
			try
			{
				string txtQuery = "insert into AddressBooks (TIN_NIN,Title,FirstName,LastName,Road_Street,ApartmentName,ApartmentNo,Floor,Town,District,State,Zip,Country,Phone,Fax,Email,WebSite,TaxAuthority) values (@TIN_NIN,@Title,@FirstName,@LastName,@Road_Street,@ApartmentName,@ApartmentNo,@Floor,@Town,@District,@State,@Zip,@Country,@Phone,@Fax,@Email,@WebSite,@TaxAuthority)";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				if (addressBook.TinNin.Length == 11)
				{
					sql_cmd.Parameters.AddWithValue("@Title", addressBook.FirstName + " " + addressBook.LastName);
					sql_cmd.Parameters.AddWithValue("@FirstName", addressBook.FirstName);
					sql_cmd.Parameters.AddWithValue("@LastName", addressBook.LastName);
				}
				else
				{
					sql_cmd.Parameters.AddWithValue("@Title", addressBook.Title);
					sql_cmd.Parameters.AddWithValue("@FirstName", " ");
					sql_cmd.Parameters.AddWithValue("@LastName", " ");
				}

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

		public bool Update(AddressBook addressBook)
		{
			bool isSuccess = false;
			SetConnection();
			try
			{
				string txtQuery = "update AddressBooks set TIN_NIN=@TIN_NIN, Title=@Title, FirstName=@FirstName, " +
					"LastName=@LastName, Road_Street=@Road_Street, ApartmentName=@ApartmentName, ApartmentNo=@ApartmentNo, " +
					"Floor=@Floor, Town=@Town, District=@District, State=@State, Zip=@Zip, Country=@Country, Phone=@Phone, " +
					"Fax=@Fax, Email=@Email, WebSite=@WebSite, TaxAuthority=@TaxAuthority WHERE AddressBookId=@AddressBookId";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				if (addressBook.TinNin.Length == 11)
				{
					sql_cmd.Parameters.AddWithValue("@Title", addressBook.FirstName + " " + addressBook.LastName);
					sql_cmd.Parameters.AddWithValue("@FirstName", addressBook.FirstName);
					sql_cmd.Parameters.AddWithValue("@LastName", addressBook.LastName);
				}
				else
				{
					sql_cmd.Parameters.AddWithValue("@Title", addressBook.Title);
					sql_cmd.Parameters.AddWithValue("@FirstName", " ");
					sql_cmd.Parameters.AddWithValue("@LastName", " ");
				}

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
				sql_cmd.Parameters.AddWithValue("@AddressBookId", addressBook.AddressBookId);

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

		public bool Delete(AddressBook addressBook)
		{
			bool isSuccess = false;
			SetConnection();
			try
			{
				string txtQuery = "delete from AddressBooks WHERE AddressBookId=@AddressBookId";
				sql_cmd = new SQLiteCommand(txtQuery, sql_con);

				sql_cmd.Parameters.AddWithValue("@AddressBookId", addressBook.AddressBookId);

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
