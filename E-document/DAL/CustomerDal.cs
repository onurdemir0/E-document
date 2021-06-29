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
	public class CustomerDal : BaseDal
	{
		public AddressBook SearchCustomerForTransaction(string keyword)
		{
			AddressBook addressBook = new AddressBook();
			SQLiteConnection sql_con = new SQLiteConnection("Data Source = E_Document.db");

			DataTable dt = new DataTable();

			try
			{
				//CONTAINS
				string txtQuery = "SELECT TIN_NIN, Title, FirstName, LastName, Road_Street, ApartmentName, ApartmentNo, Floor, Town, District, State, Zip, Country, Phone, Fax, Email, WebSite, TaxAuthority from AddressBooks WHERE TIN_NIN LIKE '%" + keyword + "%' OR Title LIKE '%" + keyword + "%'";
				SQLiteDataAdapter adapter = new SQLiteDataAdapter(txtQuery, sql_con);
				
				sql_con.Open();
				adapter.Fill(dt);

				if (dt.Rows.Count>0)
				{
					addressBook.TinNin = dt.Rows[0]["TIN_NIN"].ToString();
					addressBook.Title = dt.Rows[0]["Title"].ToString();
					addressBook.FirstName = dt.Rows[0]["FirstName"].ToString();
					addressBook.LastName = dt.Rows[0]["LastName"].ToString();
					addressBook.RoadStreet = dt.Rows[0]["Road_Street"].ToString();
					addressBook.ApartmentName = dt.Rows[0]["ApartmentName"].ToString();
					addressBook.ApartmentNo = dt.Rows[0]["ApartmentNo"].ToString();
					addressBook.Floor = dt.Rows[0]["Floor"].ToString();
					addressBook.Town = dt.Rows[0]["Town"].ToString();
					addressBook.District = dt.Rows[0]["District"].ToString();
					addressBook.State = dt.Rows[0]["State"].ToString();
					addressBook.Zip = dt.Rows[0]["Zip"].ToString();
					addressBook.Country = dt.Rows[0]["Country"].ToString();
					addressBook.Phone = dt.Rows[0]["Phone"].ToString();
					addressBook.Fax = dt.Rows[0]["Fax"].ToString();
					addressBook.Email = dt.Rows[0]["Email"].ToString();
					addressBook.WebSite = dt.Rows[0]["WebSite"].ToString();
					addressBook.TaxAuthority = dt.Rows[0]["TaxAuthority"].ToString();
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
			return addressBook;
		}
	}
}
