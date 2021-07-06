using E_document.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using E_document.DAL;

namespace E_document.UI
{
	public partial class frmSettings : Form
	{
		public frmSettings()
		{
			InitializeComponent();
		}

		settingsDal dal = new settingsDal();


		/*public SQLiteConnection sql_con;
		public SQLiteCommand sql_cmd;
		public SQLiteDataAdapter DB;
		public DataSet DS = new DataSet();
		public DataTable DT = new DataTable();*/

		//Settings settings = new Settings();
		public void GetValue()
		{
			/*settings.CompanyName = txtCompanyName.Text;
			settings.Email = txtEmail.Text;
			settings.Mobile = txtMobile.Text;
			settings.WebSite = txtWeb.Text;
			settings.TaxAuthority = txtTaxAuth.Text;
			settings.TaxIdentity = txtTaxIdentity.Text;
			settings.FirstAddressLine = txtAddress1.Text;
			settings.SecondAddressLine = txtAddress2.Text;
			settings.City = txtCity.Text;
			settings.State = txtState.Text;
			settings.Zip = txtZip.Text;
			settings.Country = txtCountry.Text;*/

			Settings.SettingId = Convert.ToInt32(lblCurrentId.Text);
			Settings.CompanyName = txtCompanyName.Text;
			Settings.Email = txtEmail.Text;
			Settings.Mobile = txtMobile.Text;
			Settings.WebSite = txtWeb.Text;
			Settings.TaxAuthority = txtTaxAuth.Text;
			Settings.TaxIdentity = txtTaxIdentity.Text;
			Settings.FirstAddressLine = txtAddress1.Text;
			Settings.SecondAddressLine = txtAddress2.Text;
			Settings.City = txtCity.Text;
			Settings.State = txtState.Text;
			Settings.Zip = txtZip.Text;
			Settings.Country = txtCountry.Text;
		}
		private void LoadValue()
		{
			txtCompanyName.Text = Settings.CompanyName;
			txtEmail.Text = Settings.Email;
			txtMobile.Text = Settings.Mobile;
			txtWeb.Text = Settings.WebSite;
			txtTaxAuth.Text = Settings.TaxAuthority;
			txtTaxIdentity.Text = Settings.TaxIdentity;
			txtAddress1.Text = Settings.FirstAddressLine;
			txtAddress2.Text = Settings.SecondAddressLine;
			txtCity.Text = Settings.City;
			txtState.Text = Settings.State;
			txtZip.Text = Settings.Zip;
			txtCountry.Text = Settings.Country;
		}
		private void ClearText()
		{
			txtCompanyName.Text = "";
			txtEmail.Text = "";
			txtMobile.Text = "";
			txtWeb.Text = "";
			txtTaxAuth.Text = "";
			txtTaxIdentity.Text = "";
			txtAddress1.Text = "";
			txtAddress2.Text = "";
			txtCity.Text = "";
			txtState.Text = "";
			txtZip.Text = "";
			txtCountry.Text = "";
		}
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/*private void SetConnection()
		{
			sql_con = new SQLiteConnection("Data Source = E_Document.db");
		}*/

		private void LabelVisibleFalse()
		{
			lblCurrentId.Visible = false;
		}

		private void LabelVisibleTrue()
		{
			lblCurrentId.Visible = true;
		}
		private void TextBoxEnableFalse()
		{
			txtCompanyName.Enabled = false;
			txtEmail.Enabled = false;
			txtMobile.Enabled = false;
			txtWeb.Enabled = false;
			txtTaxAuth.Enabled = false;
			txtTaxIdentity.Enabled = false;
			txtAddress1.Enabled = false;
			txtAddress2.Enabled = false;
			txtCity.Enabled = false;
			txtState.Enabled = false;
			txtZip.Enabled = false;
			txtCountry.Enabled = false;
		}
		private void TextBoxEnableTrue()
		{
			txtCompanyName.Enabled = true;
			txtEmail.Enabled = true;
			txtMobile.Enabled = true;
			txtWeb.Enabled = true;
			txtTaxAuth.Enabled = true;
			txtTaxIdentity.Enabled = true;
			txtAddress1.Enabled = true;
			txtAddress2.Enabled = true;
			txtCity.Enabled = true;
			txtState.Enabled = true;
			txtZip.Enabled = true;
			txtCountry.Enabled = true;
		}

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
			string CommandText = "select * from Settings";
			DB = new SQLiteDataAdapter(CommandText, sql_con);
			DS.Reset();
			DB.Fill(DS);
			DT = DS.Tables[0];
			dataGridSettings.DataSource = DT;
			sql_con.Close();
		}*/

		private void LoadData()
		{
			DataTable dt = dal.LoadData("Settings");
			dataGridSettings.DataSource = dt;
		}
		private void frmSettings_Load(object sender, EventArgs e)
		{
			LoadData();
			if (Settings.CompanyName != null)
			{
				LoadValue();
				TextBoxEnableFalse();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			
			GetValue();

			//string txtQuery = "insert into Settings (CompanyName,Email,Mobile,WebSite,TaxAuthority,TaxIdentity,FirstAddressLine,SecondAddressLine,City,State,Zip,Country)values('" + Settings.CompanyName + "','" + Settings.Email + "','" + Settings.Mobile + "','" + Settings.WebSite + "','" + Settings.TaxAuthority + "','" + Settings.TaxIdentity + "','" + Settings.FirstAddressLine + "','" + Settings.SecondAddressLine + "','" + Settings.City + "','" + Settings.State + "','" + Settings.Zip + "','" + Settings.Country + "')";
			//ExecuteQuery(txtQuery);

			//dal.Add();
			//dal.ExecuteQuery(txtQuery);

			bool success = dal.Add();

			if (success)
			{
				MessageBox.Show("Successfully Created!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}

			ClearText();
			LabelVisibleFalse();
			LoadData();

			MessageBox.Show("Saved!");
		}

		private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		//private void txtEmail_Leave(object sender, EventArgs e)
		//{
		//	string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
		//	if (Regex.IsMatch(txtEmail.Text,pattern))
		//	{
		//		errorProvider1.Clear();
		//	}
		//	else
		//	{
		//		errorProvider1.SetError(this.txtEmail, "Please provide valid Mail address");
		//	}
		//}

		private void txtEmail_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtEmail.Text))
			{
				e.Cancel = true;
				txtEmail.Focus();
				errorProvider1.SetError(this.txtEmail, "Please enter your E-mail");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtEmail, null);
			}
		}

		private void dataGridSettings_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			TextBoxEnableTrue();
			//txtCompanyId.Text = dataGridSettings.SelectedRows[0].Cells[0].Value.ToString();
			LabelVisibleTrue();
			lblCurrentId.Text = dataGridSettings.SelectedRows[0].Cells[0].Value.ToString();
			txtCompanyName.Text = dataGridSettings.SelectedRows[0].Cells[1].Value.ToString();
			txtEmail.Text = dataGridSettings.SelectedRows[0].Cells[2].Value.ToString();
			txtMobile.Text = dataGridSettings.SelectedRows[0].Cells[3].Value.ToString();
			txtWeb.Text = dataGridSettings.SelectedRows[0].Cells[4].Value.ToString();
			txtTaxAuth.Text = dataGridSettings.SelectedRows[0].Cells[5].Value.ToString();
			txtTaxIdentity.Text = dataGridSettings.SelectedRows[0].Cells[6].Value.ToString();

			txtAddress1.Text = dataGridSettings.SelectedRows[0].Cells[7].Value.ToString();
			txtAddress2.Text = dataGridSettings.SelectedRows[0].Cells[8].Value.ToString();
			txtCity.Text = dataGridSettings.SelectedRows[0].Cells[9].Value.ToString();
			txtState.Text = dataGridSettings.SelectedRows[0].Cells[10].Value.ToString();
			txtZip.Text = dataGridSettings.SelectedRows[0].Cells[11].Value.ToString();
			txtCountry.Text = dataGridSettings.SelectedRows[0].Cells[12].Value.ToString();

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			GetValue();
			//string txtQuery = "update Settings set CompanyName='" + txtCompanyName.Text + "', Email='" + txtEmail.Text + "', " +
			//	"Mobile='" + txtMobile.Text + "', WebSite='" + txtWeb.Text + "', TaxAuthority='" + txtTaxAuth.Text + "', " +
			//	"TaxIdentity='" + txtTaxIdentity.Text + "', FirstAddressLine='" + txtAddress1.Text + "', " +
			//	"SecondAddressLine='" + txtAddress2.Text + "', City='" + txtCity.Text + "', State='" + txtState.Text + "'," +
			//	"Zip='" + txtZip.Text + "', Country='" + txtCountry.Text + "' WHERE SettingId='" + lblCurrentId.Text + "'";

			//ExecuteQuery(txtQuery);
			//dal.ExecuteQuery(txtQuery);

			bool success = dal.Update();

			if (success)
			{
				MessageBox.Show("Successfully Updated!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}

			ClearText();
			LabelVisibleFalse();
			LoadData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Settings.SettingId = Convert.ToInt32(lblCurrentId.Text);
			//string txtQuery = "delete from Settings WHERE SettingId='" + lblCurrentId.Text + "'";
			//ExecuteQuery(txtQuery);
			//dal.ExecuteQuery(txtQuery);

			bool success = dal.Delete();

			if (success)
			{
				MessageBox.Show("Deleted Successfully!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}

			ClearText();
			LabelVisibleFalse();
			LoadData();
		}

		private void btnUse_Click(object sender, EventArgs e)
		{
			GetValue();
			TextBoxEnableFalse();

			MessageBox.Show("Successful");
		}

		private void txtCompanyName_Validating(object sender, CancelEventArgs e)
		{
			//if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
			//{
			//	txtCompanyName.Focus();
			//	MessageBox.Show("Please enter Company Name");
			//}
		}
	}
}
