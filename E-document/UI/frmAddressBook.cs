using E_document.DAL;
using E_document.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_document.UI
{
	public partial class frmAddressBook : Form
	{
		public frmAddressBook()
		{
			InitializeComponent();
		}

		AddressBookDal dal = new AddressBookDal();
		AddressBook addressBook = new AddressBook();

		/*public SQLiteConnection sql_con;
		public SQLiteCommand sql_cmd;
		public SQLiteDataAdapter DB;
		public DataSet DS = new DataSet();
		public DataTable DT = new DataTable();*/

		private void GetValue()
		{
			/*AddressBook.TinNin = txtTinNin.Text;
			AddressBook.Title = txtTitle.Text;
			AddressBook.FirstName = txtFirstName.Text;
			AddressBook.LastName = txtLastName.Text;
			AddressBook.RoadStreet = txtStreet.Text;
			AddressBook.ApartmentName = txtApartName.Text;
			AddressBook.ApartmentNo = txtApartNo.Text;
			AddressBook.Floor = txtFloor.Text;
			AddressBook.Town = txtTown.Text;
			AddressBook.District = txtDistrict.Text;
			AddressBook.State = txtState.Text;
			AddressBook.Zip = txtZip.Text;
			AddressBook.Country = txtCountry.Text;
			AddressBook.Phone = txtPhone.Text;
			AddressBook.Fax = txtFax.Text;
			AddressBook.Email = txtEmail.Text;
			AddressBook.WebSite = txtWeb.Text;
			AddressBook.TaxAuthority = txtTaxAuth.Text;*/

			addressBook.AddressBookId = Convert.ToInt32(lblCurrentId.Text);
			addressBook.TinNin = txtTinNin.Text;
			addressBook.Title = txtTitle.Text;
			addressBook.FirstName = txtFirstName.Text;
			addressBook.LastName = txtLastName.Text;
			addressBook.RoadStreet = txtStreet.Text;
			addressBook.ApartmentName = txtApartName.Text;
			addressBook.ApartmentNo = txtApartNo.Text;
			addressBook.Floor = txtFloor.Text;
			addressBook.Town = txtTown.Text;
			addressBook.District = txtDistrict.Text;
			addressBook.State = txtState.Text;
			addressBook.Zip = txtZip.Text;
			addressBook.Country = txtCountry.Text;
			addressBook.Phone = txtPhone.Text;
			addressBook.Fax = txtFax.Text;
			addressBook.Email = txtEmail.Text;
			addressBook.WebSite = txtWeb.Text;
			addressBook.TaxAuthority = txtTaxAuth.Text;
		}
		private void ClearText()
		{
			txtTinNin.Clear();
			txtTitle.Clear();
			txtFirstName.Clear();
			txtLastName.Clear();
			txtStreet.Clear();
			txtApartName.Clear();
			txtApartNo.Clear();
			txtFloor.Clear();
			txtTown.Clear();
			txtDistrict.Clear();
			txtState.Clear();
			txtZip.Clear();
			txtCountry.Clear();
			txtPhone.Clear();
			txtFax.Clear();
			txtEmail.Clear();
			txtWeb.Clear();
			txtTaxAuth.Clear();
		}
		/*private void SetConnection()
		{
			sql_con = new SQLiteConnection("Data Source = E_Document.db");
		}*/
		/*private void ExecuteQuery(string txtQuery)
		{
			SetConnection();
			sql_con.Open();
			sql_cmd = sql_con.CreateCommand();
			sql_cmd.CommandText = txtQuery;
			sql_cmd.ExecuteNonQuery();
			sql_con.Close();
		}*/
		/*private void LoadData()
		{
			SetConnection();
			sql_con.Open();
			sql_cmd = sql_con.CreateCommand();
			string CommandText = "select * from AddressBooks";
			DB = new SQLiteDataAdapter(CommandText, sql_con);
			DS.Reset();
			DB.Fill(DS);
			DT = DS.Tables[0];
			dataGridAddressBook.DataSource = DT;
			sql_con.Close();
		}*/

		private void LoadData()
		{
			DataTable dt = dal.LoadData("AddressBooks");
			dataGridAddressBook.DataSource = dt;
		}
	
		private void LabelVisibleFalse()
		{
			lblCurrentId.Visible = false;
		}

		private void LabelVisibleTrue()
		{
			lblCurrentId.Visible = true;
		}

		private void txtTinNin_TextChanged(object sender, EventArgs e)
		{
			if (txtTinNin.TextLength == 10)
			{
				txtTitle.Enabled = true;
				txtFirstName.Enabled = false;
				txtLastName.Enabled = false;
			}
			else if (txtTinNin.TextLength == 11)
			{
				txtFirstName.Enabled = true;
				txtLastName.Enabled = true;
				txtTitle.Enabled = false;
			}
			else
			{
				txtTitle.Enabled = false;
				txtFirstName.Enabled = false;
				txtLastName.Enabled = false;
			}
		}

		private void btnSaveCustomer_Click(object sender, EventArgs e)
		{
			GetValue();

			/*if (AddressBook.TinNin.Length == 11)
			{
				string txtQuery = "insert into AddressBooks (TIN_NIN,Title,FirstName,LastName,Road_Street,ApartmentName,ApartmentNo,Floor,Town,District,State,Zip,Country,Phone,Fax,Email,WebSite,TaxAuthority)" +
				"values('" + txtTinNin.Text + "','" + (AddressBook.FirstName + " " + AddressBook.LastName) + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtStreet.Text + "','" + txtApartName.Text + "','" + txtApartNo.Text + "','" + txtFloor.Text + "','" + txtTown.Text + "','" + txtDistrict.Text + "'," +
				"'" + txtState.Text + "','" + txtZip.Text + "','" + txtCountry.Text + "','" + txtPhone.Text + "','" + txtFax.Text + "','" + txtEmail.Text + "','" + txtWeb.Text + "','" + txtTaxAuth.Text + "')";
				
				dal.ExecuteQuery(txtQuery);
			}
			else
			{
				string txtQuery = "insert into AddressBooks (TIN_NIN,Title,FirstName,LastName,Road_Street,ApartmentName,ApartmentNo,Floor,Town,District,State,Zip,Country,Phone,Fax,Email,WebSite,TaxAuthority)" +
				"values('" + txtTinNin.Text + "','" + txtTitle.Text + "','" + " " + "','" + " " + "','" + txtStreet.Text + "','" + txtApartName.Text + "','" + txtApartNo.Text + "','" + txtFloor.Text + "','" + txtTown.Text + "','" + txtDistrict.Text + "'," +
				"'" + txtState.Text + "','" + txtZip.Text + "','" + txtCountry.Text + "','" + txtPhone.Text + "','" + txtFax.Text + "','" + txtEmail.Text + "','" + txtWeb.Text + "','" + txtTaxAuth.Text + "')";
				
				dal.ExecuteQuery(txtQuery);
			}*/

			bool success = dal.Add(addressBook);

			if (success)
			{
				MessageBox.Show("Successfully Created to Address Book!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}
			
			ClearText();
			LabelVisibleFalse();
			LoadData();
		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			//string txtQuery = "delete from AddressBooks WHERE AddressBookId='" + lblCurrentId.Text + "'";
			//dal.ExecuteQuery(txtQuery);

			addressBook.AddressBookId = Convert.ToInt32(lblCurrentId.Text);
			bool success = dal.Delete(addressBook);

			if (success)
			{
				MessageBox.Show("Successfully Deleted to Address Book!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}

			ClearText();
			LabelVisibleFalse();
			LoadData();
		}

		private void frmAddressBook_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dataGridAddressBook_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			LabelVisibleTrue();
			lblCurrentId.Text = dataGridAddressBook.SelectedRows[0].Cells[0].Value.ToString();
			txtTinNin.Text = dataGridAddressBook.SelectedRows[0].Cells[1].Value.ToString();
			txtTitle.Text = dataGridAddressBook.SelectedRows[0].Cells[2].Value.ToString();
			txtFirstName.Text = dataGridAddressBook.SelectedRows[0].Cells[3].Value.ToString();
			txtLastName.Text = dataGridAddressBook.SelectedRows[0].Cells[4].Value.ToString();
			txtStreet.Text = dataGridAddressBook.SelectedRows[0].Cells[5].Value.ToString();
			txtApartName.Text = dataGridAddressBook.SelectedRows[0].Cells[6].Value.ToString();

			txtApartNo.Text = dataGridAddressBook.SelectedRows[0].Cells[7].Value.ToString();
			txtFloor.Text = dataGridAddressBook.SelectedRows[0].Cells[8].Value.ToString();
			txtTown.Text = dataGridAddressBook.SelectedRows[0].Cells[9].Value.ToString();
			txtDistrict.Text = dataGridAddressBook.SelectedRows[0].Cells[10].Value.ToString();
			txtState.Text = dataGridAddressBook.SelectedRows[0].Cells[11].Value.ToString();
			txtZip.Text = dataGridAddressBook.SelectedRows[0].Cells[12].Value.ToString();

			txtCountry.Text = dataGridAddressBook.SelectedRows[0].Cells[13].Value.ToString();
			txtPhone.Text = dataGridAddressBook.SelectedRows[0].Cells[14].Value.ToString();
			txtFax.Text = dataGridAddressBook.SelectedRows[0].Cells[15].Value.ToString();
			txtEmail.Text = dataGridAddressBook.SelectedRows[0].Cells[16].Value.ToString();
			txtWeb.Text = dataGridAddressBook.SelectedRows[0].Cells[17].Value.ToString();
			txtTaxAuth.Text = dataGridAddressBook.SelectedRows[0].Cells[18].Value.ToString();
		}

		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			GetValue();

			/*if (AddressBook.TinNin.Length == 11)
			{
				string txtQuery = "update AddressBooks set TIN_NIN='" + AddressBook.TinNin + "', Title='" + (AddressBook.FirstName + " " + AddressBook.LastName) + "', " +
				"FirstName='" + AddressBook.FirstName + "', LastName='" + AddressBook.LastName + "', Road_Street='" + AddressBook.RoadStreet + "', " +
				"ApartmentName='" + AddressBook.ApartmentName + "', ApartmentNo='" + AddressBook.ApartmentNo + "', " +
				"Floor='" + AddressBook.Floor + "', Town='" + AddressBook.Town + "', District='" + AddressBook.District + "'," +
				"State='" + AddressBook.State + "', Zip='" + AddressBook.Zip + "', Country='" + AddressBook.Country + "'," +
				"Phone='" + AddressBook.Phone + "', Fax='" + AddressBook.Fax + "', Email='" + AddressBook.Email + "'," +
				"WebSite='" + AddressBook.WebSite + "', TaxAuthority='" + AddressBook.TaxAuthority + "' WHERE AddressBookId='" + lblCurrentId.Text + "'";
				
				dal.ExecuteQuery(txtQuery);
			}
			else
			{
				/*string txtQuery = "update AddressBooks set TIN_NIN='" + AddressBook.TinNin + "', Title='" + AddressBook.Title + "', " +
				"FirstName='" + " " + "', LastName='" + " " + "', Road_Street='" + AddressBook.RoadStreet + "', " +
				"ApartmentName='" + AddressBook.ApartmentName + "', ApartmentNo='" + AddressBook.ApartmentNo + "', " +
				"Floor='" + AddressBook.Floor + "', Town='" + AddressBook.Town + "', District='" + AddressBook.District + "'," +
				"State='" + AddressBook.State + "', Zip='" + AddressBook.Zip + "', Country='" + AddressBook.Country + "'," +
				"Phone='" + AddressBook.Phone + "', Fax='" + AddressBook.Fax + "', Email='" + AddressBook.Email + "'," +
				"WebSite='" + AddressBook.WebSite + "', TaxAuthority='" + AddressBook.TaxAuthority + "' WHERE AddressBookId='" + lblCurrentId.Text + "'";
				
				dal.ExecuteQuery(txtQuery);
			}*/

			bool success = dal.Update(addressBook);

			if (success)
			{
				MessageBox.Show("Successfully Updated to Address Book!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}

			ClearText();
			LabelVisibleFalse();
			LoadData();
		}
	}
}
