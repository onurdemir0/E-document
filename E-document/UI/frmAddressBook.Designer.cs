
namespace E_document.UI
{
	partial class frmAddressBook
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddressBook));
			this.pnlCustomer = new System.Windows.Forms.Panel();
			this.lblDelete = new System.Windows.Forms.Label();
			this.lblFail = new System.Windows.Forms.Label();
			this.lblSuccess = new System.Windows.Forms.Label();
			this.lblReq = new System.Windows.Forms.Label();
			this.txtApartName = new System.Windows.Forms.TextBox();
			this.lblApartName = new System.Windows.Forms.Label();
			this.txtFloor = new System.Windows.Forms.TextBox();
			this.lblFloor = new System.Windows.Forms.Label();
			this.txtApartNo = new System.Windows.Forms.TextBox();
			this.lblApartNo = new System.Windows.Forms.Label();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.chkIndividual = new System.Windows.Forms.CheckBox();
			this.chkCorporate = new System.Windows.Forms.CheckBox();
			this.lblCurrentId = new System.Windows.Forms.Label();
			this.lblCompanyId = new System.Windows.Forms.Label();
			this.txtTaxAuth = new System.Windows.Forms.TextBox();
			this.lblTaxAuth = new System.Windows.Forms.Label();
			this.txtWeb = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtDistrict = new System.Windows.Forms.TextBox();
			this.lblWeb = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblFax = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.lblZip = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.lblDistrict = new System.Windows.Forms.Label();
			this.txtTown = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtTinNin = new System.Windows.Forms.TextBox();
			this.lblTown = new System.Windows.Forms.Label();
			this.lblStreet = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblTinNin = new System.Windows.Forms.Label();
			this.lblCustomerTitle = new System.Windows.Forms.Label();
			this.btnUpdateCustomer = new System.Windows.Forms.Button();
			this.btnSaveCustomer = new System.Windows.Forms.Button();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridAddressBook = new System.Windows.Forms.DataGridView();
			this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
			this.lblCustomerType = new System.Windows.Forms.Label();
			this.lblUpdate = new System.Windows.Forms.Label();
			this.pnlCustomer.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAddressBook)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCustomer
			// 
			resources.ApplyResources(this.pnlCustomer, "pnlCustomer");
			this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlCustomer.Controls.Add(this.lblDelete);
			this.pnlCustomer.Controls.Add(this.lblFail);
			this.pnlCustomer.Controls.Add(this.lblSuccess);
			this.pnlCustomer.Controls.Add(this.lblReq);
			this.pnlCustomer.Controls.Add(this.txtApartName);
			this.pnlCustomer.Controls.Add(this.lblApartName);
			this.pnlCustomer.Controls.Add(this.txtFloor);
			this.pnlCustomer.Controls.Add(this.lblFloor);
			this.pnlCustomer.Controls.Add(this.txtApartNo);
			this.pnlCustomer.Controls.Add(this.lblApartNo);
			this.pnlCustomer.Controls.Add(this.cmbCountry);
			this.pnlCustomer.Controls.Add(this.chkIndividual);
			this.pnlCustomer.Controls.Add(this.chkCorporate);
			this.pnlCustomer.Controls.Add(this.lblCurrentId);
			this.pnlCustomer.Controls.Add(this.lblCompanyId);
			this.pnlCustomer.Controls.Add(this.txtTaxAuth);
			this.pnlCustomer.Controls.Add(this.lblTaxAuth);
			this.pnlCustomer.Controls.Add(this.txtWeb);
			this.pnlCustomer.Controls.Add(this.txtEmail);
			this.pnlCustomer.Controls.Add(this.txtZip);
			this.pnlCustomer.Controls.Add(this.txtState);
			this.pnlCustomer.Controls.Add(this.txtFax);
			this.pnlCustomer.Controls.Add(this.txtPhone);
			this.pnlCustomer.Controls.Add(this.txtDistrict);
			this.pnlCustomer.Controls.Add(this.lblWeb);
			this.pnlCustomer.Controls.Add(this.lblEmail);
			this.pnlCustomer.Controls.Add(this.lblFax);
			this.pnlCustomer.Controls.Add(this.lblPhone);
			this.pnlCustomer.Controls.Add(this.lblCountry);
			this.pnlCustomer.Controls.Add(this.lblZip);
			this.pnlCustomer.Controls.Add(this.lblState);
			this.pnlCustomer.Controls.Add(this.lblDistrict);
			this.pnlCustomer.Controls.Add(this.txtTown);
			this.pnlCustomer.Controls.Add(this.txtLastName);
			this.pnlCustomer.Controls.Add(this.txtFirstName);
			this.pnlCustomer.Controls.Add(this.txtTitle);
			this.pnlCustomer.Controls.Add(this.txtStreet);
			this.pnlCustomer.Controls.Add(this.txtTinNin);
			this.pnlCustomer.Controls.Add(this.lblTown);
			this.pnlCustomer.Controls.Add(this.lblStreet);
			this.pnlCustomer.Controls.Add(this.lblLastName);
			this.pnlCustomer.Controls.Add(this.lblFirstName);
			this.pnlCustomer.Controls.Add(this.lblTitle);
			this.pnlCustomer.Controls.Add(this.lblTinNin);
			this.pnlCustomer.Controls.Add(this.lblCustomerTitle);
			this.pnlCustomer.Name = "pnlCustomer";
			// 
			// lblDelete
			// 
			resources.ApplyResources(this.lblDelete, "lblDelete");
			this.lblDelete.Name = "lblDelete";
			// 
			// lblFail
			// 
			resources.ApplyResources(this.lblFail, "lblFail");
			this.lblFail.Name = "lblFail";
			// 
			// lblSuccess
			// 
			resources.ApplyResources(this.lblSuccess, "lblSuccess");
			this.lblSuccess.Name = "lblSuccess";
			// 
			// lblReq
			// 
			resources.ApplyResources(this.lblReq, "lblReq");
			this.lblReq.Name = "lblReq";
			// 
			// txtApartName
			// 
			resources.ApplyResources(this.txtApartName, "txtApartName");
			this.txtApartName.Name = "txtApartName";
			// 
			// lblApartName
			// 
			resources.ApplyResources(this.lblApartName, "lblApartName");
			this.lblApartName.Name = "lblApartName";
			// 
			// txtFloor
			// 
			resources.ApplyResources(this.txtFloor, "txtFloor");
			this.txtFloor.Name = "txtFloor";
			// 
			// lblFloor
			// 
			resources.ApplyResources(this.lblFloor, "lblFloor");
			this.lblFloor.Name = "lblFloor";
			// 
			// txtApartNo
			// 
			resources.ApplyResources(this.txtApartNo, "txtApartNo");
			this.txtApartNo.Name = "txtApartNo";
			// 
			// lblApartNo
			// 
			resources.ApplyResources(this.lblApartNo, "lblApartNo");
			this.lblApartNo.Name = "lblApartNo";
			// 
			// cmbCountry
			// 
			resources.ApplyResources(this.cmbCountry, "cmbCountry");
			this.cmbCountry.FormattingEnabled = true;
			this.cmbCountry.Name = "cmbCountry";
			// 
			// chkIndividual
			// 
			resources.ApplyResources(this.chkIndividual, "chkIndividual");
			this.chkIndividual.Name = "chkIndividual";
			this.chkIndividual.UseVisualStyleBackColor = true;
			this.chkIndividual.CheckedChanged += new System.EventHandler(this.chkIndividual_CheckedChanged);
			// 
			// chkCorporate
			// 
			resources.ApplyResources(this.chkCorporate, "chkCorporate");
			this.chkCorporate.Name = "chkCorporate";
			this.chkCorporate.UseVisualStyleBackColor = true;
			this.chkCorporate.CheckedChanged += new System.EventHandler(this.chkCorporate_CheckedChanged);
			// 
			// lblCurrentId
			// 
			resources.ApplyResources(this.lblCurrentId, "lblCurrentId");
			this.lblCurrentId.Name = "lblCurrentId";
			// 
			// lblCompanyId
			// 
			resources.ApplyResources(this.lblCompanyId, "lblCompanyId");
			this.lblCompanyId.Name = "lblCompanyId";
			// 
			// txtTaxAuth
			// 
			resources.ApplyResources(this.txtTaxAuth, "txtTaxAuth");
			this.txtTaxAuth.Name = "txtTaxAuth";
			// 
			// lblTaxAuth
			// 
			resources.ApplyResources(this.lblTaxAuth, "lblTaxAuth");
			this.lblTaxAuth.Name = "lblTaxAuth";
			// 
			// txtWeb
			// 
			resources.ApplyResources(this.txtWeb, "txtWeb");
			this.txtWeb.Name = "txtWeb";
			// 
			// txtEmail
			// 
			resources.ApplyResources(this.txtEmail, "txtEmail");
			this.txtEmail.Name = "txtEmail";
			// 
			// txtZip
			// 
			resources.ApplyResources(this.txtZip, "txtZip");
			this.txtZip.Name = "txtZip";
			// 
			// txtState
			// 
			resources.ApplyResources(this.txtState, "txtState");
			this.txtState.Name = "txtState";
			// 
			// txtFax
			// 
			resources.ApplyResources(this.txtFax, "txtFax");
			this.txtFax.Name = "txtFax";
			// 
			// txtPhone
			// 
			resources.ApplyResources(this.txtPhone, "txtPhone");
			this.txtPhone.Name = "txtPhone";
			// 
			// txtDistrict
			// 
			resources.ApplyResources(this.txtDistrict, "txtDistrict");
			this.txtDistrict.Name = "txtDistrict";
			// 
			// lblWeb
			// 
			resources.ApplyResources(this.lblWeb, "lblWeb");
			this.lblWeb.Name = "lblWeb";
			// 
			// lblEmail
			// 
			resources.ApplyResources(this.lblEmail, "lblEmail");
			this.lblEmail.Name = "lblEmail";
			// 
			// lblFax
			// 
			resources.ApplyResources(this.lblFax, "lblFax");
			this.lblFax.Name = "lblFax";
			// 
			// lblPhone
			// 
			resources.ApplyResources(this.lblPhone, "lblPhone");
			this.lblPhone.Name = "lblPhone";
			// 
			// lblCountry
			// 
			resources.ApplyResources(this.lblCountry, "lblCountry");
			this.lblCountry.Name = "lblCountry";
			// 
			// lblZip
			// 
			resources.ApplyResources(this.lblZip, "lblZip");
			this.lblZip.Name = "lblZip";
			// 
			// lblState
			// 
			resources.ApplyResources(this.lblState, "lblState");
			this.lblState.Name = "lblState";
			// 
			// lblDistrict
			// 
			resources.ApplyResources(this.lblDistrict, "lblDistrict");
			this.lblDistrict.Name = "lblDistrict";
			// 
			// txtTown
			// 
			resources.ApplyResources(this.txtTown, "txtTown");
			this.txtTown.Name = "txtTown";
			// 
			// txtLastName
			// 
			resources.ApplyResources(this.txtLastName, "txtLastName");
			this.txtLastName.Name = "txtLastName";
			// 
			// txtFirstName
			// 
			resources.ApplyResources(this.txtFirstName, "txtFirstName");
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
			// 
			// txtTitle
			// 
			resources.ApplyResources(this.txtTitle, "txtTitle");
			this.txtTitle.Name = "txtTitle";
			// 
			// txtStreet
			// 
			resources.ApplyResources(this.txtStreet, "txtStreet");
			this.txtStreet.Name = "txtStreet";
			// 
			// txtTinNin
			// 
			resources.ApplyResources(this.txtTinNin, "txtTinNin");
			this.txtTinNin.Name = "txtTinNin";
			this.txtTinNin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTinNin_KeyPress);
			// 
			// lblTown
			// 
			resources.ApplyResources(this.lblTown, "lblTown");
			this.lblTown.Name = "lblTown";
			// 
			// lblStreet
			// 
			resources.ApplyResources(this.lblStreet, "lblStreet");
			this.lblStreet.Name = "lblStreet";
			// 
			// lblLastName
			// 
			resources.ApplyResources(this.lblLastName, "lblLastName");
			this.lblLastName.Name = "lblLastName";
			// 
			// lblFirstName
			// 
			resources.ApplyResources(this.lblFirstName, "lblFirstName");
			this.lblFirstName.Name = "lblFirstName";
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// lblTinNin
			// 
			resources.ApplyResources(this.lblTinNin, "lblTinNin");
			this.lblTinNin.Name = "lblTinNin";
			// 
			// lblCustomerTitle
			// 
			resources.ApplyResources(this.lblCustomerTitle, "lblCustomerTitle");
			this.lblCustomerTitle.Name = "lblCustomerTitle";
			// 
			// btnUpdateCustomer
			// 
			resources.ApplyResources(this.btnUpdateCustomer, "btnUpdateCustomer");
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.UseVisualStyleBackColor = true;
			this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
			// 
			// btnSaveCustomer
			// 
			resources.ApplyResources(this.btnSaveCustomer, "btnSaveCustomer");
			this.btnSaveCustomer.Name = "btnSaveCustomer";
			this.btnSaveCustomer.UseVisualStyleBackColor = true;
			this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
			// 
			// btnDeleteCustomer
			// 
			resources.ApplyResources(this.btnDeleteCustomer, "btnDeleteCustomer");
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.dataGridAddressBook);
			this.panel1.Name = "panel1";
			// 
			// dataGridAddressBook
			// 
			resources.ApplyResources(this.dataGridAddressBook, "dataGridAddressBook");
			this.dataGridAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridAddressBook.Name = "dataGridAddressBook";
			this.dataGridAddressBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAddressBook_CellClick);
			// 
			// sqLiteCommandBuilder1
			// 
			this.sqLiteCommandBuilder1.DataAdapter = null;
			this.sqLiteCommandBuilder1.QuoteSuffix = "]";
			// 
			// lblCustomerType
			// 
			resources.ApplyResources(this.lblCustomerType, "lblCustomerType");
			this.lblCustomerType.Name = "lblCustomerType";
			// 
			// lblUpdate
			// 
			resources.ApplyResources(this.lblUpdate, "lblUpdate");
			this.lblUpdate.Name = "lblUpdate";
			// 
			// frmAddressBook
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblUpdate);
			this.Controls.Add(this.lblCustomerType);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnDeleteCustomer);
			this.Controls.Add(this.btnUpdateCustomer);
			this.Controls.Add(this.btnSaveCustomer);
			this.Controls.Add(this.pnlCustomer);
			this.Name = "frmAddressBook";
			this.Load += new System.EventHandler(this.frmAddressBook_Load);
			this.pnlCustomer.ResumeLayout(false);
			this.pnlCustomer.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridAddressBook)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlCustomer;
		private System.Windows.Forms.TextBox txtTaxAuth;
		private System.Windows.Forms.Label lblTaxAuth;
		private System.Windows.Forms.TextBox txtWeb;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtDistrict;
		private System.Windows.Forms.Label lblWeb;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblFax;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.Label lblZip;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblDistrict;
		private System.Windows.Forms.TextBox txtTown;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.Label lblTown;
		private System.Windows.Forms.Label lblStreet;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblTinNin;
		private System.Windows.Forms.Label lblCustomerTitle;
		private System.Windows.Forms.Label lblCurrentId;
		private System.Windows.Forms.Label lblCompanyId;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Button btnSaveCustomer;
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridAddressBook;
		public System.Windows.Forms.CheckBox chkIndividual;
		public System.Windows.Forms.CheckBox chkCorporate;
		private System.Windows.Forms.TextBox txtTinNin;
		private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.TextBox txtApartNo;
		private System.Windows.Forms.Label lblApartNo;
		private System.Windows.Forms.TextBox txtFloor;
		private System.Windows.Forms.Label lblFloor;
		private System.Windows.Forms.TextBox txtApartName;
		private System.Windows.Forms.Label lblApartName;
		private System.Windows.Forms.Label lblReq;
		private System.Windows.Forms.Label lblSuccess;
		private System.Windows.Forms.Label lblFail;
		private System.Windows.Forms.Label lblCustomerType;
		private System.Windows.Forms.Label lblUpdate;
		private System.Windows.Forms.Label lblDelete;
	}
}