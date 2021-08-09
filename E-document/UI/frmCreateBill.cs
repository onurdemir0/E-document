using E_document.DAL;
using E_document.Entities;
using E_document.FileHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace E_document.UI
{
	public partial class frmCreateBill : Form
	{
		Item _item = new Item();
		CustomerDal customerDal = new CustomerDal();
		AddressBook addressBook = new AddressBook();
		AddressBookDal addressBookDal = new AddressBookDal();
		BillDal billDal = new BillDal();
		Bill bill = new Bill();
		ItemDal itemDal = new ItemDal();
		settingsDal _settingsDal = new settingsDal();

		public frmCreateBill()
		{
			InitializeComponent();
		}

		private void DateTimePickerSetting()
		{
			dtpOrder.Format = DateTimePickerFormat.Custom;
			dtpOrder.CustomFormat = " ";			
			dtpOrder.MaxDate = DateTime.Now;

			dtpWayBillDate.Format = DateTimePickerFormat.Custom;
			dtpWayBillDate.CustomFormat = " ";
			dtpWayBillDate.MaxDate = DateTime.Now;

			dtpBillDate.MaxDate = DateTime.Now;
		}

		private void ComboBoxItemSetting()
		{
			comboBoxScenario.SelectedIndex = 0;
			comboBoxBillType.SelectedIndex = 0;
			comboBoxCurrency.SelectedItem = ("Euro");
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

		private void LoadCurrenciesToCmb()
		{
			List<Currency> currencies = Currency.GetCurrencies();

			foreach (Currency currency in currencies)
			{
				comboBoxCurrency.Items.Add(currency.Name);
			}
		}

		private void LoadDeUnitsToCmb()
		{
			List<MeasurementUnit> units = MeasurementUnit.GetUnitsToDe();

			foreach (MeasurementUnit unit in units)
			{
				cmbUnit.Items.Add(unit.Name);
			}
		}

		private void LoadEnUnitsToCmb()
		{
			List<MeasurementUnit> units = MeasurementUnit.GetUnitsToEn();

			foreach (MeasurementUnit unit in units)
			{
				cmbUnit.Items.Add(unit.Name);
			}
		}
		private void frmCreateBill_Load(object sender, EventArgs e)
		{
			lblEttnNo.Text = Guid.NewGuid().ToString();

			var culture = Thread.CurrentThread.CurrentUICulture.ToString();

			if (culture == "en")
			{
				LoadEnUnitsToCmb();
				LoadEnCountryToCmb();
			}
			else if (culture == "de")
			{
				LoadDeUnitsToCmb();
				LoadDeCountryToCmb();
			}

			DateTimePickerSetting();

			LoadCurrenciesToCmb();

			ComboBoxItemSetting();

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


			string txtQuery2 = "SELECT CompanyName FROM Settings";
			SQLiteCommand sql_cmd2 = new SQLiteCommand(txtQuery2, sql_con);

			SQLiteDataReader dr2 = sql_cmd2.ExecuteReader();
			AutoCompleteStringCollection myCollection2 = new AutoCompleteStringCollection();

			while (dr2.Read())
			{
				myCollection2.Add(dr2.GetString(0));
			}

			txtSenderSearch.AutoCompleteCustomSource = myCollection2;
			dr.Close();

			sql_con.Close();
		}

		private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
		{
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
				cmbCountry.Text = addressBook.Country;
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
			cmbCountry.Text = "";
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

			txtSubTotal.Text = subTotal.ToString();
			txtCalculatedVAT.Text = calculatedVAT.ToString();
			txtIncludingTaxes.Text = totalTax.ToString();
			txtGrandTotal.Text = grandTotal.ToString();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			if (String.IsNullOrEmpty(txtItemNo.Text) || String.IsNullOrEmpty(txtItemName.Text) || String.IsNullOrEmpty(txtUnitPrice.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(cmbUnit.Text))
			{
				MessageBox.Show("Please fill in the required fields!");
			}
			else
			{
				GetValueToItem();
				_item.VatPrice = (_item.UnitPrice * _item.VatRate / 100) * _item.Quantity;
				_item.Total = (_item.UnitPrice * _item.Quantity);

				int n = dgvAddedProducts.Rows.Add();
				dgvAddedProducts.Rows[n].Cells[1].Value = _item.ItemNo;
				dgvAddedProducts.Rows[n].Cells[2].Value = _item.ItemName;
				dgvAddedProducts.Rows[n].Cells[3].Value = _item.Quantity;
				dgvAddedProducts.Rows[n].Cells[4].Value = _item.Unit;
				dgvAddedProducts.Rows[n].Cells[5].Value = _item.UnitPrice;
				dgvAddedProducts.Rows[n].Cells[6].Value = _item.VatRate;
				dgvAddedProducts.Rows[n].Cells[7].Value = _item.VatPrice;
				dgvAddedProducts.Rows[n].Cells[8].Value = _item.Total;

				ClearItemText();
			}

			CalculatedDetails();
		}

		private void ClearItemText()
		{
			txtItemNo.Clear();
			txtItemName.Clear();
			txtQuantity.Clear();
			cmbUnit.Text = "";
			txtUnitPrice.Clear();
			txtVatRate.Clear();
		}
		private void GetValueToItem()
		{
			_item.ItemNo = txtItemNo.Text;
			_item.ItemName = txtItemName.Text;
			_item.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
			_item.Quantity = Convert.ToInt32(txtQuantity.Text);
			_item.Unit = cmbUnit.Text;
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
			addressBook.Country = cmbCountry.Text;
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

			bill.SettingsId = Settings.SettingId;

			bill.Ettn = lblEttnNo.Text;
			bill.Type = comboBoxScenario.Text;
			bill.BillDate = Convert.ToDateTime(dtpBillDate.Text);
			bill.BillType = comboBoxBillType.Text;
			bill.Currency = comboBoxCurrency.Text;

			bill.OrderNo = txtOrder.Text;
			if (!String.IsNullOrEmpty(txtOrder.Text))
			{
				bill.OrderDate = Convert.ToDateTime(dtpOrder.Text);		
			}

			bill.WayBillNo = txtWayBillNo.Text;
			if (!String.IsNullOrEmpty(txtWayBillNo.Text))
			{
				if (dtpWayBillDate.Text == " ")
				{
					//MessageBox.Show("Please fill the WayBill Date");
					MessageBox.Show(lblWaybillVal.Text);
				}
				else
				{
					bill.WayBillDate = Convert.ToDateTime(dtpWayBillDate.Text);
				}
			}

			bill.PayeeAccount = txtPayeeAcc.Text;
			bill.Note = txtNote.Text;

			bill.TinNin = txtTinNin.Text;
			bill.Title = txtTitle.Text;
			bill.FirstName = txtFirstName.Text;
			bill.LastName = txtLastName.Text;
			bill.RoadStreet = txtStreet.Text;
			bill.ApartmentName = txtApartName.Text;
			bill.ApartmentNo = txtApartNo.Text;
			bill.Floor = txtFloor.Text;
			bill.Town = txtTown.Text;
			bill.District = txtDistrict.Text;
			bill.State = txtState.Text;
			bill.Zip = txtZip.Text;
			bill.Country = cmbCountry.Text;
			bill.Phone = txtPhone.Text;
			bill.Fax = txtFax.Text;
			bill.Email = txtEmail.Text;
			bill.WebSite = txtWeb.Text;
			bill.TaxAuthority = txtTaxAuth.Text;

			
			bill.CompanyName = Settings.CompanyName;
			bill.CompanyEmail = Settings.Email;
			bill.CompanyMobile = Settings.Mobile;
			bill.CompanyWebSite = Settings.WebSite;
			bill.CompanyTaxAuthority = Settings.TaxAuthority;
			bill.CompanyTaxIdentity = Settings.TaxIdentity;
			bill.FirstAddressLine = Settings.FirstAddressLine;
			bill.SecondAddressLine = Settings.SecondAddressLine;
			bill.CompanyCity = Settings.City;
			bill.CompanyState = Settings.State;
			bill.CompanyZip = Settings.Zip;
			bill.CompanyCountry = Settings.Country;
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

		public void GetCustomerType()
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
	
		private void btnAddToAddressBook_Click(object sender, EventArgs e)
		{
			GetValueToAddressBook();
			GetCustomerType();
			addressBook.Situation = "+";

			if (chkCorporate.Checked == true)
			{
				if (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtTitle.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text))
				{
					MessageBox.Show("Please fill in the required fields!");
				}
				else
				{
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
			}
			else if (chkIndividual.Checked == true)
			{
				if (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text))
				{
					MessageBox.Show("Please fill in the required fields!");
				}
				else
				{
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
			}
			else
			{
				MessageBox.Show("Please select which customer type you want to add");
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
		}

		private void CreateXML()
		{
			//XML OLUŞTUR
			Invoice invoice = new Invoice();
			invoice.ID = new ID() { Value = bill.BillId.ToString() };
			//invoice.InvoiceTypeCode = Convert.ToUInt16(bill.BillType);
			invoice.IssueDate = bill.BillDate;
			invoice.PaymentTerms = new PaymentTerms() { Note = bill.Note };
			invoice.TaxCurrencyCode = bill.Currency;
			invoice.OrderReference = new OrderReference() { ID = { Value = bill.OrderNo } };
			invoice.BuyerReference = bill.CustomerId.ToString();
			invoice.Note = new List<string> { bill.Note };

			invoice.InvoiceLine = new List<InvoiceLine>();
			InvoiceLine line = new InvoiceLine();

			Item item = new Item();

			for (int i = 0; i < dgvAddedProducts.Rows.Count; i++)
			{
				item.LineNo = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[0].Value);
				item.ItemName = dgvAddedProducts.Rows[i].Cells[2].Value.ToString();
				item.Quantity = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[3].Value);
				item.Unit = dgvAddedProducts.Rows[i].Cells[4].Value.ToString();
				item.UnitPrice = Convert.ToInt32(dgvAddedProducts.Rows[i].Cells[5].Value);

				line.ID = new ID()
				{
					Value = item.ItemId.ToString()
				};
				line.Item = new InvoiceLineItem()
				{
					Name = item.ItemName
				};
				line.Price = new InvoiceLinePrice()
				{
					PriceAmount =
						{
							Value = item.UnitPrice.ToString()
						}
				};
				line.InvoicedQuantity = new InvoicedQuantity()
				{
					unitCode = item.Unit,
					Value = item.Quantity.ToString()
				};
				line.LineExtensionAmount = new LineExtensionAmount()
				{
					currencyID = bill.Currency,
					Value = item.LineNo.ToString()
				};

				invoice.InvoiceLine.Add(line);
			}

			invoice.PaymentMeans = new PaymentMeans()
			{
				PayeeFinancialAccount =
					{
						Name = bill.PayeeAccount
					}
			};

			invoice.AccountingSupplierParty = new AccountingSupplierParty()
			{
				Party =
					{
						PostalAddress =
						{
							PostalZone = bill.CompanyZip,
							CityName=bill.CompanyCity,
							StreetName = bill.FirstAddressLine,
							Country =
							{
								IdentificationCode =  bill.CompanyCountry
							}
						},
						Contact =
						{
							ElectronicMail = bill.CompanyEmail,
							Telephone = bill.CompanyMobile,
							Name = bill.CompanyName
						},
						PartyTaxScheme =
						{
							CompanyID = bill.SettingsId.ToString()
						}
					}
			};

			invoice.AccountingCustomerParty = new AccountingCustomerParty()
			{
				Party =
					{
						PostalAddress =
						{
							CityName = bill.State,
							StreetName = bill.RoadStreet,
							PostalZone = bill.Zip,
							Country =
							{
								IdentificationCode = bill.Country
							}
						},
						Contact =
						{
							ElectronicMail = bill.Email,
							Name = bill.FirstName + " " + bill.LastName,
							Telephone = bill.Phone
						},
						PartyLegalEntity =
						{
							RegistrationName = bill.Title
						}
					}
			};

			invoice.TaxTotal = new TaxTotal()
			{
				TaxAmount =
					{
						currencyID = comboBoxCurrency.Text,
						Value = _item.VatRate.ToString()
					},
				TaxSubtotal = new List<TaxTotalTaxSubtotal>() { }
			};

			invoice.BillingReference = new BillingReference()
			{
				InvoiceDocumentReference =
					{
						ID =
						{

						},
						IssueDate = bill.BillDate
					}
			};

			//invoice.CustomizationID = ??
			//invoice.DocumentCurrencyCode = ??
			//invoice.DueDate = ??

			//invoice.ProjectReference = new ProjectReference()
			//{
			//	ID =
			//	{
			//		???
			//	}
			//}
			//invoice.TaxPointDate = ??

			bill.XmlString = invoice.Serialize();
			string xmlString = invoice.Serialize();

			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Text File|*.xml";
			save.OverwritePrompt = true;
			save.CreatePrompt = true;

			if (save.ShowDialog() == DialogResult.OK)
			{
				StreamWriter streamWriter = new StreamWriter(save.FileName);
				streamWriter.WriteLine(xmlString);
				MessageBox.Show("Successfully Created!");

				streamWriter.Close();
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (dtpOrder.Enabled == true && dtpOrder.Text == " ")
			{
				//MessageBox.Show("Please fill for the Order Date");
				MessageBox.Show(lblOrderVal.Text);
			}
			else if(dtpWayBillDate.Enabled == true && dtpWayBillDate.Text == " ")
			{
				//MessageBox.Show("Please fill for the WayBill Date");
				MessageBox.Show(lblWaybillVal.Text);
			}

			else if (String.IsNullOrEmpty(Settings.CompanyName))
			{
				//MessageBox.Show("Please enter the Sender Informations");
				MessageBox.Show(lblSenderVal.Text);
			}

			else if (!(chkCorporate.Checked || chkIndividual.Checked))
			{
				//MessageBox.Show("Please select which customer type you want to add");
				//MessageBox.Show(lblcus)
			}
			else if ((chkCorporate.Checked == true) && (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtTitle.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text)))
			{
				//MessageBox.Show("Please fill in the required fields for the corporate customer!");
				MessageBox.Show(lblCorporateVal.Text);
			}
			else if ((chkIndividual.Checked == true) && (String.IsNullOrEmpty(txtTinNin.Text) || String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtDistrict.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(cmbCountry.Text) || String.IsNullOrEmpty(txtTaxAuth.Text)))
			{
				//MessageBox.Show("Please fill in the required fields for the individual customer!");
				MessageBox.Show(lblIndividualVal.Text);

			}

			else if (dgvAddedProducts.Rows.Count == 0)
			{
				//MessageBox.Show("You must add at least one Item");
				MessageBox.Show(lblItemVal.Text);
			}
			else
			{
				GetValueToAddressBook();
				GetCustomerType();

				addressBook.Situation = "-";
				bool success2 = billDal.AddCustToAddressBook(addressBook);

				
				GetValueToBill();
				bool success = billDal.Add(bill);

				if (success & success2)
				{
					CreateXML();
					GetItemValueToDB();
				}
				else
				{
					MessageBox.Show("Failed!");
				}
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
				//ClearText();
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
				//ClearText();
			}
		}

		private void txtSenderSearch_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSenderSearch.Text;

			if (keyword.Length >=3)
			{
				Dealer dealer = _settingsDal.SearchSenderForTransaction(keyword);
				Settings.SettingId = dealer.SettingId;
				Settings.CompanyName = dealer.CompanyName;
				Settings.Email = dealer.Email;
				Settings.Mobile = dealer.Mobile;
				Settings.WebSite = dealer.WebSite;
				Settings.TaxAuthority = dealer.TaxAuthority;
				Settings.TaxIdentity = dealer.TaxIdentity;
				Settings.FirstAddressLine = dealer.FirstAddressLine;
				Settings.SecondAddressLine = dealer.SecondAddressLine;
				Settings.City = dealer.City;
				Settings.State = dealer.State;
				Settings.Zip = dealer.Zip;
				Settings.Country = dealer.Country;
			}
			else
			{
				Settings.CompanyName = null;
			}
		}

		private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtVatRate_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtVatRate_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txtVatRate.Text))
			{
				txtVatRate.Text = 0.ToString();
			}
		}

		private void dtpOrder_ValueChanged(object sender, EventArgs e)
		{
			dtpOrder.CustomFormat = "dd/MM/yyyy hh:mm:ss";
		}

		private void dtpWayBillDate_ValueChanged(object sender, EventArgs e)
		{
			dtpWayBillDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			dgvAddedProducts.Rows.Clear();
			CalculatedDetails();
		}

		private void txtTinNin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtOrder_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtWayBillNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtOrder_TextChanged(object sender, EventArgs e)
		{
			if (txtOrder.Text.Length > 0)
			{
				dtpOrder.Enabled = true;
			}
			else
			{
				dtpOrder.Enabled = false;
				dtpOrder.CustomFormat = " ";
			}
		}

		private void txtWayBillNo_TextChanged(object sender, EventArgs e)
		{
			if (txtWayBillNo.Text.Length > 0)
			{
				dtpWayBillDate.Enabled = true;
			}
			else
			{
				dtpWayBillDate.Enabled = false;
				dtpOrder.CustomFormat = " ";
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
	}
}
