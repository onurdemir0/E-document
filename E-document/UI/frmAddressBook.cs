using E_document.DAL;
using E_document.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

		private void GetValue()
		{
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
			addressBook.Country = cmbCountry.Text;
			addressBook.Phone = txtPhone.Text;
			addressBook.Fax = txtFax.Text;
			addressBook.Email = txtEmail.Text;
			addressBook.WebSite = txtWeb.Text;
			addressBook.TaxAuthority = txtTaxAuth.Text;
			addressBook.Situation = "+";
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
			cmbCountry.Text = "";
			txtPhone.Clear();
			txtFax.Clear();
			txtEmail.Clear();
			txtWeb.Clear();
			txtTaxAuth.Clear();
		}

		private void LoadData()
		{
			DataTable dt = dal.LoadData("select * from AddressBooks WHERE Situation='" + "+" + "'");
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

		private void GetCustomerType()
		{
			if (chkIndividual.Checked == true)
			{
				addressBook.Title = addressBook.FirstName + " " + addressBook.LastName;
			}
			else if (chkCorporate.Checked == true)
			{
				addressBook.FirstName = " ";
				addressBook.LastName = " ";
			}
		}

		private void btnSaveCustomer_Click(object sender, EventArgs e)
		{
			GetValue();
			GetCustomerType();

			if (chkCorporate.Checked == true)
			{
				if (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtTitle.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text))
				{
					//MessageBox.Show("Please fill in the required fields!");
					MessageBox.Show(lblReq.Text);
				}
				else
				{
					addressBook.FirstName = "";
					addressBook.LastName = "";
					bool success = dal.Add(addressBook);
					
					if (success)
					{
						//MessageBox.Show("Successfully Created to Address Book!");
						MessageBox.Show(lblSuccess.Text);
						ClearText();
					}
					else
					{
						//MessageBox.Show("Failed!");
						MessageBox.Show(lblFail.Text);
					}

					LabelVisibleFalse();
					LoadData();
				}
			}
			else if (chkIndividual.Checked == true)
			{
				if (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text))
				{
					//MessageBox.Show("Please fill in the required fields!");
					MessageBox.Show(lblReq.Text);
				}
				else
				{
					bool success = dal.Add(addressBook);

					if (success)
					{
						//MessageBox.Show("Successfully Created to Address Book!");
						MessageBox.Show(lblSuccess.Text);
						ClearText();
					}
					else
					{
						//MessageBox.Show("Failed!");
						MessageBox.Show(lblFail.Text);
					}

					LabelVisibleFalse();
					LoadData();
				}
			}
			else
			{
				//MessageBox.Show("Please select which customer type you want to add");
				MessageBox.Show(lblCustomerType.Text);
			}
		}

		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			GetValue();
			GetCustomerType();

			if (chkCorporate.Checked == true)
			{
				if (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtTitle.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text))
				{
					//MessageBox.Show("Please fill in the required fields!");
					MessageBox.Show(lblReq.Text);
				}
				else
				{
					addressBook.FirstName = "";
					addressBook.LastName = "";
					bool success = dal.Update(addressBook);

					if (success)
					{
						//MessageBox.Show("Successfully Updated to Address Book!");
						MessageBox.Show(lblUpdate.Text);
						ClearText();
					}
					else
					{
						//MessageBox.Show("Failed!");
						MessageBox.Show(lblFail.Text);
					}

					LabelVisibleFalse();
					LoadData();
				}
			}

			else if (chkIndividual.Checked == true)
			{
				if (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text))
				{
					//MessageBox.Show("Please fill in the required fields!");
					MessageBox.Show(lblReq.Text);
				}
				else
				{
					bool success = dal.Update(addressBook);

					if (success)
					{
						//MessageBox.Show("Successfully Updated to Address Book!");
						MessageBox.Show(lblUpdate.Text);
						ClearText();
					}
					else
					{
						//MessageBox.Show("Failed!");
						MessageBox.Show(lblFail.Text);
					}

					LabelVisibleFalse();
					LoadData();
				}
			}
		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			addressBook.AddressBookId = Convert.ToInt32(lblCurrentId.Text);
			bool success = dal.Delete(addressBook);

			if (success)
			{
				//MessageBox.Show("Successfully Deleted to Address Book!");
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

		private void LoadDeCountryToCmb()
		{
			List<Country> countries = Country.GetCountriesToDe();

			foreach (Country country in countries)
			{
				cmbCountry.Items.Add(country.Name);
			}
		}

		private void LoadEnCountryToCmb()
		{
			List<Country> countries = Country.GetCountriesToEn();

			foreach (Country country in countries)
			{
				cmbCountry.Items.Add(country.Name);
			}
		}

		private void frmAddressBook_Load(object sender, EventArgs e)
		{
			LoadData();

			var culture = Thread.CurrentThread.CurrentUICulture.ToString();

			if (culture == "en")
			{
				LoadEnCountryToCmb();
			}
			else if (culture == "de")
			{
				LoadDeCountryToCmb();
			}
		}

		private void dataGridAddressBook_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			LabelVisibleTrue();

			//int indexRow = e.RowIndex;
			//int indexColumn = e.ColumnIndex;

			//if (indexRow > 0 && indexColumn > 0)
			//{
			//	lblCurrentId.Text = dataGridAddressBook.SelectedRows[0].Cells[0].Value.ToString();
			//	txtTinNin.Text = dataGridAddressBook.SelectedRows[0].Cells[1].Value.ToString();
			//	txtTitle.Text = dataGridAddressBook.SelectedRows[0].Cells[2].Value.ToString();
			//	txtFirstName.Text = dataGridAddressBook.SelectedRows[0].Cells[3].Value.ToString();
			//	txtLastName.Text = dataGridAddressBook.SelectedRows[0].Cells[4].Value.ToString();
			//	txtStreet.Text = dataGridAddressBook.SelectedRows[0].Cells[5].Value.ToString();
			//	txtApartName.Text = dataGridAddressBook.SelectedRows[0].Cells[6].Value.ToString();

			//	txtApartNo.Text = dataGridAddressBook.SelectedRows[0].Cells[7].Value.ToString();
			//	txtFloor.Text = dataGridAddressBook.SelectedRows[0].Cells[8].Value.ToString();
			//	txtTown.Text = dataGridAddressBook.SelectedRows[0].Cells[9].Value.ToString();
			//	txtDistrict.Text = dataGridAddressBook.SelectedRows[0].Cells[10].Value.ToString();
			//	txtState.Text = dataGridAddressBook.SelectedRows[0].Cells[11].Value.ToString();
			//	txtZip.Text = dataGridAddressBook.SelectedRows[0].Cells[12].Value.ToString();

			//	cmbCountry.Text = dataGridAddressBook.SelectedRows[0].Cells[13].Value.ToString();
			//	txtPhone.Text = dataGridAddressBook.SelectedRows[0].Cells[14].Value.ToString();
			//	txtFax.Text = dataGridAddressBook.SelectedRows[0].Cells[15].Value.ToString();
			//	txtEmail.Text = dataGridAddressBook.SelectedRows[0].Cells[16].Value.ToString();
			//	txtWeb.Text = dataGridAddressBook.SelectedRows[0].Cells[17].Value.ToString();
			//	txtTaxAuth.Text = dataGridAddressBook.SelectedRows[0].Cells[18].Value.ToString();
			//}

			//dataGridAddressBook.CurrentCell.Selected = true;

			try
			{
				lblCurrentId.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtTinNin.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtTitle.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtFirstName.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtLastName.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtStreet.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[5].Value.ToString();
				txtApartName.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[6].Value.ToString();

				txtApartNo.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[7].Value.ToString();
				txtFloor.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[8].Value.ToString();
				txtTown.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[9].Value.ToString();
				txtDistrict.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[10].Value.ToString();
				txtState.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[11].Value.ToString();
				txtZip.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[12].Value.ToString();

				cmbCountry.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[13].Value.ToString();
				txtPhone.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[14].Value.ToString();
				txtFax.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[15].Value.ToString();
				txtEmail.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[16].Value.ToString();
				txtWeb.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[17].Value.ToString();
				txtTaxAuth.Text = dataGridAddressBook.Rows[e.RowIndex].Cells[18].Value.ToString();
			}
			catch (Exception)
			{
				return;
			}
		}

		private void chkIndividual_CheckedChanged(object sender, EventArgs e)
		{
			if (chkIndividual.Checked == true)
			{
				chkCorporate.Checked = false;
				txtTitle.Enabled = false;


				txtFirstName.Enabled = true;
				txtLastName.Enabled = true;
			}
		}

		private void chkCorporate_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCorporate.Checked == true)
			{
				chkIndividual.Checked = false;
				txtTitle.Enabled = true;
				txtFirstName.Enabled = false;
				txtLastName.Enabled = false;
			}
		}

		private void txtTinNin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtFirstName_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtFirstName.Text))
			{
				chkCorporate.Checked = false;
				chkIndividual.Checked = true;
			}
			else if (String.IsNullOrEmpty(txtFirstName.Text))
			{
				chkIndividual.Checked = false;
				chkCorporate.Checked = true;
			}
		}

		private void txtFloor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
	}
}
