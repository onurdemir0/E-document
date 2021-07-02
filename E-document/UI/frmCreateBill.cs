using E_document.DAL;
using E_document.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_document.UI
{
	public partial class frmCreateBill : Form
	{
		//List<AddressBook> _addressBook = new List<AddressBook>();
		Item _item = new Item();
		CustomerDal customerDal = new CustomerDal();
		AddressBook addressBook = new AddressBook();
		AddressBookDal addressBookDal = new AddressBookDal();
		BillDal billDal = new BillDal();
		Bill bill = new Bill();
		ItemDal itemDal = new ItemDal();

		public frmCreateBill()
		{
			InitializeComponent();
		}

		private void frmCreateBill_Load(object sender, EventArgs e)
		{
			lblEttnNo.Text = Guid.NewGuid().ToString();

			SQLiteConnection sql_con = new SQLiteConnection("Data Source = E_Document.db");
			string txtQuery = "SELECT TIN_NIN, Title FROM AddressBooks WHERE Situation='" + "+" + "'";
			SQLiteCommand sql_cmd = new SQLiteCommand(txtQuery, sql_con);

			sql_con.Open();
			SQLiteDataReader dr = sql_cmd.ExecuteReader();
			AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

			while (dr.Read())
			{
				//myCollection.Add(dr.GetString(0) + ", " + dr.GetString(1));
				myCollection.Add(dr.GetString(0));
				myCollection.Add(dr.GetString(1));
			}

			txtSearchCustomer.AutoCompleteCustomSource = myCollection;
			dr.Close();
			sql_con.Close();

			//AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
			//SQLiteConnection sql_con = new SQLiteConnection("Data Source = E_Document.db");
			//sql_con.Open();
			//SQLiteCommand sql_cmd = sql_con.CreateCommand();
			//sql_cmd.CommandType = CommandType.Text;
			//sql_cmd.CommandText = "SELECT * FROM AddressBooks";
			//SQLiteDataReader dReader = sql_cmd.ExecuteReader();

			//if (dReader.Read())
			//{
			//	while (dReader.Read())
			//	{
			//		namesCollection.Add(dReader["Title"].ToString());
			//		AddressBook book = new AddressBook
			//		{
			//			TinNin = dReader["TIN_NIN"].ToString(),
			//			Title = dReader["Title"].ToString(),
			//			FirstName = dReader["FirstName"].ToString()
			//		};
			//		_addressBook.Add(book);
			//	}
			//}
			//else
			//{
			//	MessageBox.Show("Data not found");
			//}
			//dReader.Close();
		}

		private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
		{
			//if (_addressBook.Contains(sender))
			//{
			//	txtTinNin.Text = _addressBook[Convert.ToInt32(sender)].TinNin;
			//	txtTitle.Text = _addressBook[Convert.ToInt32(sender)].Title;
			//}

			string keyword = txtSearchCustomer.Text;

			if (keyword.Length < 4)
			{
				ClearText();
				return;
			}
			else
			{
				AddressBook addressBook = customerDal.SearchCustomerForTransaction(keyword);
				txtTinNin.Text = addressBook.TinNin;
				txtTitle.Text = addressBook.Title;
				txtFirstName.Text = addressBook.FirstName;
				txtLastName.Text = addressBook.LastName;
				txtStreet.Text = addressBook.RoadStreet;
				txtApartName.Text = addressBook.ApartmentName;
				txtApartNo.Text = addressBook.ApartmentNo;
				txtFloor.Text = addressBook.Floor;
				txtTown.Text = addressBook.Town;
				txtDistrict.Text = addressBook.District;
				txtState.Text = addressBook.State;
				txtZip.Text = addressBook.Zip;
				txtCountry.Text = addressBook.Country;
				txtPhone.Text = addressBook.Phone;
				txtFax.Text = addressBook.Fax;
				txtEmail.Text = addressBook.Email;
				txtWeb.Text = addressBook.WebSite;
				txtTaxAuth.Text = addressBook.TaxAuthority;
			}
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

		private void dgvAddedProducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			dgvAddedProducts.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
		}

		private void CalculatedDetails()
		{
			decimal subTotal = decimal.Parse(txtSubTotal.Text);
			subTotal = 0;

			decimal calculatedVAT = decimal.Parse(txtCalculatedVAT.Text);
			calculatedVAT = 0;

			for (int i = 0; i < dgvAddedProducts.Rows.Count; i++)
			{
				subTotal += Convert.ToDecimal(dgvAddedProducts.Rows[i].Cells[8].Value);
				calculatedVAT += Convert.ToDecimal(dgvAddedProducts.Rows[i].Cells[7].Value);
			}

			decimal totalTax = decimal.Parse(txtIncludingTaxes.Text);
			totalTax = subTotal + calculatedVAT;

			decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
			grandTotal = subTotal + calculatedVAT;

			//subTotal += _item.Total;
			//calculatedVAT += _item.VatPrice;

			txtSubTotal.Text = subTotal.ToString();
			txtCalculatedVAT.Text = calculatedVAT.ToString();
			txtIncludingTaxes.Text = totalTax.ToString();
			txtGrandTotal.Text = grandTotal.ToString();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			GetValueToItem();

			_item.VatPrice = (_item.UnitPrice * _item.VatRate / 100) * _item.Quantity;
			_item.Total = (_item.UnitPrice * _item.Quantity);

			//decimal subTotal = decimal.Parse(txtSubTotal.Text);
			//subTotal += _item.Total;

			//decimal calculatedVAT = decimal.Parse(txtCalculatedVAT.Text);
			//calculatedVAT += _item.VatPrice;

			int n = dgvAddedProducts.Rows.Add();
			dgvAddedProducts.Rows[n].Cells[1].Value = _item.ItemNo;
			dgvAddedProducts.Rows[n].Cells[2].Value = _item.ItemName;
			dgvAddedProducts.Rows[n].Cells[3].Value = _item.Quantity;
			dgvAddedProducts.Rows[n].Cells[4].Value = _item.Unit;
			dgvAddedProducts.Rows[n].Cells[5].Value = _item.UnitPrice;
			dgvAddedProducts.Rows[n].Cells[6].Value = _item.VatRate;
			dgvAddedProducts.Rows[n].Cells[7].Value = _item.VatPrice;
			dgvAddedProducts.Rows[n].Cells[8].Value = _item.Total;

			CalculatedDetails();

			//txtSubTotal.Text = subTotal.ToString();
			//txtCalculatedVAT.Text = calculatedVAT.ToString();
		}
		private void GetValueToItem()
		{
			_item.ItemNo = txtItemNo.Text;
			_item.ItemName = txtItemName.Text;
			_item.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
			_item.Quantity = Convert.ToInt32(txtQuantity.Text);
			_item.Unit = txtUnit.Text;
			_item.VatRate = Convert.ToInt32(txtVatRate.Text);
		}
		private void GetValueToAddressBook()
		{
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
		private void GetValueToBill()
		{
			string custTinNin = txtTinNin.Text;
			AddressBook addressBook = customerDal.GetCustIdFromTinNin(custTinNin);
			bill.CustomerId = addressBook.AddressBookId;

			bill.Ettn = lblEttnNo.Text;
			bill.Type = comboBoxType.Text;
			bill.BillDate = Convert.ToDateTime(dtpBillDate.Text);
			bill.BillType = comboBoxBillType.Text;
			bill.Currency = comboBoxCurrency.Text;
			bill.OrderNo = txtOrder.Text;
			bill.OrderDate = Convert.ToDateTime(dtpOrder.Text);
			bill.WayBillNo = txtWayBillNo.Text;
			bill.WayBillDate = Convert.ToDateTime(dtpWayBillDate.Text);
		}
		private void GetItemValueToDB()
		{
			Item item = new Item();

			string billEttn = lblEttnNo.Text;
			Bill bill = billDal.GetBillIdFromEttn(billEttn);
			item.BillId = bill.BillId;

			for (int i = 0; i < dgvAddedProducts.Rows.Count; i++)
			{
				item.LineNo = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[0].Value);
				item.ItemNo = dgvAddedProducts.Rows[i].Cells[1].Value.ToString();
				item.ItemName = dgvAddedProducts.Rows[i].Cells[2].Value.ToString();
				item.Quantity = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[3].Value);
				item.Unit = dgvAddedProducts.Rows[i].Cells[4].Value.ToString();
				item.UnitPrice = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[5].Value);
				item.VatRate = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[6].Value);
				item.VatPrice = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[7].Value);
				item.Total = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[8].Value);
				bool successItem = itemDal.Add(item);
			}
		}
	
		private void btnAddToAddressBook_Click(object sender, EventArgs e)
		{
			GetValueToAddressBook();
			addressBook.Situation = "+";

			bool success = addressBookDal.Add(addressBook);

			if (success)
			{
				MessageBox.Show("Successfully Created to Address Book!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}
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

		private void btnDelete_Click(object sender, EventArgs e)
		{

			foreach (DataGridViewCell oneCell in dgvAddedProducts.SelectedCells)
			{
				if (oneCell.Selected)
				{
					dgvAddedProducts.Rows.RemoveAt(oneCell.RowIndex);
				}
			}

			CalculatedDetails();

			//decimal subTotal = decimal.Parse(txtSubTotal.Text);
			//subTotal -= _item.Total;

			//decimal calculatedVAT = decimal.Parse(txtCalculatedVAT.Text);
			//calculatedVAT -= _item.VatPrice;

			//txtSubTotal.Text = subTotal.ToString();
			//txtCalculatedVAT.Text = calculatedVAT.ToString();

			//try
			//{
			//	int rowIndex = dgvAddedProducts.CurrentCell.RowIndex;

			//	if (rowIndex > 1)
			//	{
			//		dgvAddedProducts.Rows.RemoveAt(rowIndex);
			//	}

			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			
			GetValueToAddressBook();
			addressBook.Situation = "-";
			bool success2 = addressBookDal.Add(addressBook);

			GetValueToBill();
			bool success = billDal.Add(bill);

			GetItemValueToDB();


			if (success & success2)
			{
				MessageBox.Show("Successfully Created!");
			}
			else
			{
				MessageBox.Show("Failed!");
			}
		}
	}
}
