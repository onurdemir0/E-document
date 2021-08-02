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
		BaseDal baseDal = new BaseDal();

		public void GetValue()
		{
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
			Settings.Country = cmbCountry.Text;
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
			cmbCountry.Text = Settings.Country;
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
			cmbCountry.Text = "";
		}
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

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
			cmbCountry.Enabled = false;
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
			cmbCountry.Enabled = true;
		}

		private void LoadCountryToCmb()
		{
			List<Country> countries = Country.GetCountries();

			foreach (Country country in countries)
			{
				cmbCountry.Items.Add(country.Name);
			}
		}

		private void LoadData()
		{
			DataTable dt = baseDal.LoadData("select * from Settings");
			dataGridSettings.DataSource = dt;
		}
		private void frmSettings_Load(object sender, EventArgs e)
		{
			LoadData();
			LoadCountryToCmb();
			if (Settings.CompanyName != null)
			{
				LoadValue();
				TextBoxEnableFalse();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			GetValue();
			
			if (String.IsNullOrEmpty(txtCompanyName.Text) || String.IsNullOrEmpty(txtTaxAuth.Text) || String.IsNullOrEmpty(txtTaxIdentity.Text) || String.IsNullOrEmpty(txtCity.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text))
			{
				//MessageBox.Show("Please fill in the required fields!");
				MessageBox.Show(lblReq.Text);
			}
			else if (txtTaxIdentity.Text.Length != 10)
			{
				//MessageBox.Show("Tax Identity must be 10 characters");
				MessageBox.Show(lblTax.Text);
			}
			else
			{
				bool success = dal.Add();

				if (success)
				{
					//MessageBox.Show("Successfully Created!");
					MessageBox.Show(lblSuccess.Text);

					ClearText();
				}
				else
				{
					//MessageBox.Show("Failed!");
					MessageBox.Show(lblFail.Text);
				}
			}
		
			LabelVisibleFalse();
			LoadData();
		}

		private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

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
			cmbCountry.Text = dataGridSettings.SelectedRows[0].Cells[12].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			GetValue();

			if (String.IsNullOrEmpty(txtCompanyName.Text) || String.IsNullOrEmpty(txtTaxAuth.Text) || String.IsNullOrEmpty(txtTaxIdentity.Text) || String.IsNullOrEmpty(txtCity.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text))
			{
				//MessageBox.Show("Please fill in the required fields!");
				MessageBox.Show(lblReq.Text);
			}
			else if (txtTaxIdentity.Text.Length != 10)
			{
				//MessageBox.Show("Tax Identity Number must be 10 characters");
				MessageBox.Show(lblTax.Text);
			}
			else
			{
				bool success = dal.Update();

				if (success)
				{
					//MessageBox.Show("Successfully Updated!");
					MessageBox.Show(lblUpdate.Text);
					ClearText();
				}
				else
				{
					//MessageBox.Show("Failed!");
					MessageBox.Show(lblFail.Text);
				}
			}

			LabelVisibleFalse();
			LoadData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Settings.SettingId = Convert.ToInt32(lblCurrentId.Text);

			bool success = dal.Delete();

			if (success)
			{
				//MessageBox.Show("Deleted Successfully!");
				MessageBox.Show(lblDelete.Text);
			}
			else
			{
				//MessageBox.Show("Failed!");
				MessageBox.Show(lblFail.Text);
			}

			ClearText();
			LabelVisibleFalse();
			LoadData();
		}

		//private void btnUse_Click(object sender, EventArgs e)
		//{
		//	GetValue();
		//	TextBoxEnableFalse();

		//	MessageBox.Show("Successful");
		//}

		private void txtTaxIdentity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
	}
}
