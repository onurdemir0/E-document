
namespace E_document.UI
{
	partial class frmSettings
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
			this.pnlContent = new System.Windows.Forms.Panel();
			this.lblUpdate = new System.Windows.Forms.Label();
			this.lblTax = new System.Windows.Forms.Label();
			this.lblReq = new System.Windows.Forms.Label();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.lblCurrentId = new System.Windows.Forms.Label();
			this.lblCompanyId = new System.Windows.Forms.Label();
			this.txtState = new System.Windows.Forms.TextBox();
			this.lblState = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtAddress2 = new System.Windows.Forms.TextBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtAddress1 = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblAddress2 = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.lblZip = new System.Windows.Forms.Label();
			this.lblAddress1 = new System.Windows.Forms.Label();
			this.txtWeb = new System.Windows.Forms.TextBox();
			this.lblWeb = new System.Windows.Forms.Label();
			this.txtMobile = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTaxIdentity = new System.Windows.Forms.TextBox();
			this.txtTaxAuth = new System.Windows.Forms.TextBox();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.lblMobile = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTaxIdentity = new System.Windows.Forms.Label();
			this.lblTaxAuth = new System.Windows.Forms.Label();
			this.lblCompanyName = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnlDataGrid = new System.Windows.Forms.Panel();
			this.dataGridSettings = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblSuccess = new System.Windows.Forms.Label();
			this.lblFail = new System.Windows.Forms.Label();
			this.lblDelete = new System.Windows.Forms.Label();
			this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.pnlDataGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSettings)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlContent
			// 
			resources.ApplyResources(this.pnlContent, "pnlContent");
			this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlContent.Controls.Add(this.lblUpdate);
			this.pnlContent.Controls.Add(this.lblTax);
			this.pnlContent.Controls.Add(this.lblReq);
			this.pnlContent.Controls.Add(this.cmbCountry);
			this.pnlContent.Controls.Add(this.lblCurrentId);
			this.pnlContent.Controls.Add(this.lblCompanyId);
			this.pnlContent.Controls.Add(this.txtState);
			this.pnlContent.Controls.Add(this.lblState);
			this.pnlContent.Controls.Add(this.txtCity);
			this.pnlContent.Controls.Add(this.txtAddress2);
			this.pnlContent.Controls.Add(this.txtZip);
			this.pnlContent.Controls.Add(this.txtAddress1);
			this.pnlContent.Controls.Add(this.lblCity);
			this.pnlContent.Controls.Add(this.lblAddress2);
			this.pnlContent.Controls.Add(this.lblCountry);
			this.pnlContent.Controls.Add(this.lblZip);
			this.pnlContent.Controls.Add(this.lblAddress1);
			this.pnlContent.Controls.Add(this.txtWeb);
			this.pnlContent.Controls.Add(this.lblWeb);
			this.pnlContent.Controls.Add(this.txtMobile);
			this.pnlContent.Controls.Add(this.txtEmail);
			this.pnlContent.Controls.Add(this.txtTaxIdentity);
			this.pnlContent.Controls.Add(this.txtTaxAuth);
			this.pnlContent.Controls.Add(this.txtCompanyName);
			this.pnlContent.Controls.Add(this.lblMobile);
			this.pnlContent.Controls.Add(this.lblEmail);
			this.pnlContent.Controls.Add(this.lblTaxIdentity);
			this.pnlContent.Controls.Add(this.lblTaxAuth);
			this.pnlContent.Controls.Add(this.lblCompanyName);
			this.pnlContent.Controls.Add(this.lblTitle);
			this.errorProvider1.SetError(this.pnlContent, resources.GetString("pnlContent.Error"));
			this.errorProvider1.SetIconAlignment(this.pnlContent, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlContent.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.pnlContent, ((int)(resources.GetObject("pnlContent.IconPadding"))));
			this.pnlContent.Name = "pnlContent";
			// 
			// lblUpdate
			// 
			resources.ApplyResources(this.lblUpdate, "lblUpdate");
			this.errorProvider1.SetError(this.lblUpdate, resources.GetString("lblUpdate.Error"));
			this.errorProvider1.SetIconAlignment(this.lblUpdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUpdate.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblUpdate, ((int)(resources.GetObject("lblUpdate.IconPadding"))));
			this.lblUpdate.Name = "lblUpdate";
			// 
			// lblTax
			// 
			resources.ApplyResources(this.lblTax, "lblTax");
			this.errorProvider1.SetError(this.lblTax, resources.GetString("lblTax.Error"));
			this.errorProvider1.SetIconAlignment(this.lblTax, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTax.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblTax, ((int)(resources.GetObject("lblTax.IconPadding"))));
			this.lblTax.Name = "lblTax";
			// 
			// lblReq
			// 
			resources.ApplyResources(this.lblReq, "lblReq");
			this.errorProvider1.SetError(this.lblReq, resources.GetString("lblReq.Error"));
			this.errorProvider1.SetIconAlignment(this.lblReq, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblReq.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblReq, ((int)(resources.GetObject("lblReq.IconPadding"))));
			this.lblReq.Name = "lblReq";
			// 
			// cmbCountry
			// 
			resources.ApplyResources(this.cmbCountry, "cmbCountry");
			this.errorProvider1.SetError(this.cmbCountry, resources.GetString("cmbCountry.Error"));
			this.cmbCountry.FormattingEnabled = true;
			this.errorProvider1.SetIconAlignment(this.cmbCountry, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbCountry.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.cmbCountry, ((int)(resources.GetObject("cmbCountry.IconPadding"))));
			this.cmbCountry.Name = "cmbCountry";
			// 
			// lblCurrentId
			// 
			resources.ApplyResources(this.lblCurrentId, "lblCurrentId");
			this.errorProvider1.SetError(this.lblCurrentId, resources.GetString("lblCurrentId.Error"));
			this.errorProvider1.SetIconAlignment(this.lblCurrentId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCurrentId.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblCurrentId, ((int)(resources.GetObject("lblCurrentId.IconPadding"))));
			this.lblCurrentId.Name = "lblCurrentId";
			// 
			// lblCompanyId
			// 
			resources.ApplyResources(this.lblCompanyId, "lblCompanyId");
			this.errorProvider1.SetError(this.lblCompanyId, resources.GetString("lblCompanyId.Error"));
			this.errorProvider1.SetIconAlignment(this.lblCompanyId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCompanyId.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblCompanyId, ((int)(resources.GetObject("lblCompanyId.IconPadding"))));
			this.lblCompanyId.Name = "lblCompanyId";
			// 
			// txtState
			// 
			resources.ApplyResources(this.txtState, "txtState");
			this.errorProvider1.SetError(this.txtState, resources.GetString("txtState.Error"));
			this.errorProvider1.SetIconAlignment(this.txtState, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtState.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtState, ((int)(resources.GetObject("txtState.IconPadding"))));
			this.txtState.Name = "txtState";
			// 
			// lblState
			// 
			resources.ApplyResources(this.lblState, "lblState");
			this.errorProvider1.SetError(this.lblState, resources.GetString("lblState.Error"));
			this.errorProvider1.SetIconAlignment(this.lblState, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblState.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblState, ((int)(resources.GetObject("lblState.IconPadding"))));
			this.lblState.Name = "lblState";
			// 
			// txtCity
			// 
			resources.ApplyResources(this.txtCity, "txtCity");
			this.errorProvider1.SetError(this.txtCity, resources.GetString("txtCity.Error"));
			this.errorProvider1.SetIconAlignment(this.txtCity, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCity.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtCity, ((int)(resources.GetObject("txtCity.IconPadding"))));
			this.txtCity.Name = "txtCity";
			// 
			// txtAddress2
			// 
			resources.ApplyResources(this.txtAddress2, "txtAddress2");
			this.errorProvider1.SetError(this.txtAddress2, resources.GetString("txtAddress2.Error"));
			this.errorProvider1.SetIconAlignment(this.txtAddress2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress2.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtAddress2, ((int)(resources.GetObject("txtAddress2.IconPadding"))));
			this.txtAddress2.Name = "txtAddress2";
			// 
			// txtZip
			// 
			resources.ApplyResources(this.txtZip, "txtZip");
			this.errorProvider1.SetError(this.txtZip, resources.GetString("txtZip.Error"));
			this.errorProvider1.SetIconAlignment(this.txtZip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtZip.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtZip, ((int)(resources.GetObject("txtZip.IconPadding"))));
			this.txtZip.Name = "txtZip";
			// 
			// txtAddress1
			// 
			resources.ApplyResources(this.txtAddress1, "txtAddress1");
			this.errorProvider1.SetError(this.txtAddress1, resources.GetString("txtAddress1.Error"));
			this.errorProvider1.SetIconAlignment(this.txtAddress1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress1.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtAddress1, ((int)(resources.GetObject("txtAddress1.IconPadding"))));
			this.txtAddress1.Name = "txtAddress1";
			// 
			// lblCity
			// 
			resources.ApplyResources(this.lblCity, "lblCity");
			this.errorProvider1.SetError(this.lblCity, resources.GetString("lblCity.Error"));
			this.errorProvider1.SetIconAlignment(this.lblCity, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCity.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblCity, ((int)(resources.GetObject("lblCity.IconPadding"))));
			this.lblCity.Name = "lblCity";
			// 
			// lblAddress2
			// 
			resources.ApplyResources(this.lblAddress2, "lblAddress2");
			this.errorProvider1.SetError(this.lblAddress2, resources.GetString("lblAddress2.Error"));
			this.errorProvider1.SetIconAlignment(this.lblAddress2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAddress2.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblAddress2, ((int)(resources.GetObject("lblAddress2.IconPadding"))));
			this.lblAddress2.Name = "lblAddress2";
			// 
			// lblCountry
			// 
			resources.ApplyResources(this.lblCountry, "lblCountry");
			this.errorProvider1.SetError(this.lblCountry, resources.GetString("lblCountry.Error"));
			this.errorProvider1.SetIconAlignment(this.lblCountry, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCountry.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblCountry, ((int)(resources.GetObject("lblCountry.IconPadding"))));
			this.lblCountry.Name = "lblCountry";
			// 
			// lblZip
			// 
			resources.ApplyResources(this.lblZip, "lblZip");
			this.errorProvider1.SetError(this.lblZip, resources.GetString("lblZip.Error"));
			this.errorProvider1.SetIconAlignment(this.lblZip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblZip.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblZip, ((int)(resources.GetObject("lblZip.IconPadding"))));
			this.lblZip.Name = "lblZip";
			// 
			// lblAddress1
			// 
			resources.ApplyResources(this.lblAddress1, "lblAddress1");
			this.errorProvider1.SetError(this.lblAddress1, resources.GetString("lblAddress1.Error"));
			this.errorProvider1.SetIconAlignment(this.lblAddress1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAddress1.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblAddress1, ((int)(resources.GetObject("lblAddress1.IconPadding"))));
			this.lblAddress1.Name = "lblAddress1";
			// 
			// txtWeb
			// 
			resources.ApplyResources(this.txtWeb, "txtWeb");
			this.errorProvider1.SetError(this.txtWeb, resources.GetString("txtWeb.Error"));
			this.errorProvider1.SetIconAlignment(this.txtWeb, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtWeb.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtWeb, ((int)(resources.GetObject("txtWeb.IconPadding"))));
			this.txtWeb.Name = "txtWeb";
			// 
			// lblWeb
			// 
			resources.ApplyResources(this.lblWeb, "lblWeb");
			this.errorProvider1.SetError(this.lblWeb, resources.GetString("lblWeb.Error"));
			this.errorProvider1.SetIconAlignment(this.lblWeb, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblWeb.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblWeb, ((int)(resources.GetObject("lblWeb.IconPadding"))));
			this.lblWeb.Name = "lblWeb";
			// 
			// txtMobile
			// 
			resources.ApplyResources(this.txtMobile, "txtMobile");
			this.errorProvider1.SetError(this.txtMobile, resources.GetString("txtMobile.Error"));
			this.errorProvider1.SetIconAlignment(this.txtMobile, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtMobile.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtMobile, ((int)(resources.GetObject("txtMobile.IconPadding"))));
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
			// 
			// txtEmail
			// 
			resources.ApplyResources(this.txtEmail, "txtEmail");
			this.errorProvider1.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
			this.errorProvider1.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
			// 
			// txtTaxIdentity
			// 
			resources.ApplyResources(this.txtTaxIdentity, "txtTaxIdentity");
			this.errorProvider1.SetError(this.txtTaxIdentity, resources.GetString("txtTaxIdentity.Error"));
			this.errorProvider1.SetIconAlignment(this.txtTaxIdentity, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTaxIdentity.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtTaxIdentity, ((int)(resources.GetObject("txtTaxIdentity.IconPadding"))));
			this.txtTaxIdentity.Name = "txtTaxIdentity";
			this.txtTaxIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxIdentity_KeyPress);
			// 
			// txtTaxAuth
			// 
			resources.ApplyResources(this.txtTaxAuth, "txtTaxAuth");
			this.errorProvider1.SetError(this.txtTaxAuth, resources.GetString("txtTaxAuth.Error"));
			this.errorProvider1.SetIconAlignment(this.txtTaxAuth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTaxAuth.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtTaxAuth, ((int)(resources.GetObject("txtTaxAuth.IconPadding"))));
			this.txtTaxAuth.Name = "txtTaxAuth";
			// 
			// txtCompanyName
			// 
			resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
			this.errorProvider1.SetError(this.txtCompanyName, resources.GetString("txtCompanyName.Error"));
			this.errorProvider1.SetIconAlignment(this.txtCompanyName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCompanyName.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.txtCompanyName, ((int)(resources.GetObject("txtCompanyName.IconPadding"))));
			this.txtCompanyName.Name = "txtCompanyName";
			// 
			// lblMobile
			// 
			resources.ApplyResources(this.lblMobile, "lblMobile");
			this.errorProvider1.SetError(this.lblMobile, resources.GetString("lblMobile.Error"));
			this.errorProvider1.SetIconAlignment(this.lblMobile, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblMobile.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblMobile, ((int)(resources.GetObject("lblMobile.IconPadding"))));
			this.lblMobile.Name = "lblMobile";
			// 
			// lblEmail
			// 
			resources.ApplyResources(this.lblEmail, "lblEmail");
			this.errorProvider1.SetError(this.lblEmail, resources.GetString("lblEmail.Error"));
			this.errorProvider1.SetIconAlignment(this.lblEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblEmail.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblEmail, ((int)(resources.GetObject("lblEmail.IconPadding"))));
			this.lblEmail.Name = "lblEmail";
			// 
			// lblTaxIdentity
			// 
			resources.ApplyResources(this.lblTaxIdentity, "lblTaxIdentity");
			this.errorProvider1.SetError(this.lblTaxIdentity, resources.GetString("lblTaxIdentity.Error"));
			this.errorProvider1.SetIconAlignment(this.lblTaxIdentity, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTaxIdentity.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblTaxIdentity, ((int)(resources.GetObject("lblTaxIdentity.IconPadding"))));
			this.lblTaxIdentity.Name = "lblTaxIdentity";
			// 
			// lblTaxAuth
			// 
			resources.ApplyResources(this.lblTaxAuth, "lblTaxAuth");
			this.errorProvider1.SetError(this.lblTaxAuth, resources.GetString("lblTaxAuth.Error"));
			this.errorProvider1.SetIconAlignment(this.lblTaxAuth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTaxAuth.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblTaxAuth, ((int)(resources.GetObject("lblTaxAuth.IconPadding"))));
			this.lblTaxAuth.Name = "lblTaxAuth";
			// 
			// lblCompanyName
			// 
			resources.ApplyResources(this.lblCompanyName, "lblCompanyName");
			this.errorProvider1.SetError(this.lblCompanyName, resources.GetString("lblCompanyName.Error"));
			this.errorProvider1.SetIconAlignment(this.lblCompanyName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCompanyName.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblCompanyName, ((int)(resources.GetObject("lblCompanyName.IconPadding"))));
			this.lblCompanyName.Name = "lblCompanyName";
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.errorProvider1.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
			this.errorProvider1.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
			this.lblTitle.Name = "lblTitle";
			// 
			// btnSave
			// 
			resources.ApplyResources(this.btnSave, "btnSave");
			this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
			this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
			this.btnSave.Name = "btnSave";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			resources.ApplyResources(this.btnUpdate, "btnUpdate");
			this.errorProvider1.SetError(this.btnUpdate, resources.GetString("btnUpdate.Error"));
			this.errorProvider1.SetIconAlignment(this.btnUpdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnUpdate.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.btnUpdate, ((int)(resources.GetObject("btnUpdate.IconPadding"))));
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			resources.ApplyResources(this.errorProvider1, "errorProvider1");
			// 
			// pnlDataGrid
			// 
			resources.ApplyResources(this.pnlDataGrid, "pnlDataGrid");
			this.pnlDataGrid.Controls.Add(this.dataGridSettings);
			this.errorProvider1.SetError(this.pnlDataGrid, resources.GetString("pnlDataGrid.Error"));
			this.errorProvider1.SetIconAlignment(this.pnlDataGrid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlDataGrid.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.pnlDataGrid, ((int)(resources.GetObject("pnlDataGrid.IconPadding"))));
			this.pnlDataGrid.Name = "pnlDataGrid";
			// 
			// dataGridSettings
			// 
			resources.ApplyResources(this.dataGridSettings, "dataGridSettings");
			this.dataGridSettings.AllowUserToAddRows = false;
			this.dataGridSettings.AllowUserToDeleteRows = false;
			this.dataGridSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.errorProvider1.SetError(this.dataGridSettings, resources.GetString("dataGridSettings.Error"));
			this.errorProvider1.SetIconAlignment(this.dataGridSettings, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridSettings.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.dataGridSettings, ((int)(resources.GetObject("dataGridSettings.IconPadding"))));
			this.dataGridSettings.Name = "dataGridSettings";
			this.dataGridSettings.ReadOnly = true;
			this.dataGridSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridSettings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSettings_CellClick);
			// 
			// btnDelete
			// 
			resources.ApplyResources(this.btnDelete, "btnDelete");
			this.errorProvider1.SetError(this.btnDelete, resources.GetString("btnDelete.Error"));
			this.errorProvider1.SetIconAlignment(this.btnDelete, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnDelete.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.btnDelete, ((int)(resources.GetObject("btnDelete.IconPadding"))));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblSuccess
			// 
			resources.ApplyResources(this.lblSuccess, "lblSuccess");
			this.errorProvider1.SetError(this.lblSuccess, resources.GetString("lblSuccess.Error"));
			this.errorProvider1.SetIconAlignment(this.lblSuccess, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSuccess.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblSuccess, ((int)(resources.GetObject("lblSuccess.IconPadding"))));
			this.lblSuccess.Name = "lblSuccess";
			// 
			// lblFail
			// 
			resources.ApplyResources(this.lblFail, "lblFail");
			this.errorProvider1.SetError(this.lblFail, resources.GetString("lblFail.Error"));
			this.errorProvider1.SetIconAlignment(this.lblFail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblFail.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblFail, ((int)(resources.GetObject("lblFail.IconPadding"))));
			this.lblFail.Name = "lblFail";
			// 
			// lblDelete
			// 
			resources.ApplyResources(this.lblDelete, "lblDelete");
			this.errorProvider1.SetError(this.lblDelete, resources.GetString("lblDelete.Error"));
			this.errorProvider1.SetIconAlignment(this.lblDelete, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDelete.IconAlignment"))));
			this.errorProvider1.SetIconPadding(this.lblDelete, ((int)(resources.GetObject("lblDelete.IconPadding"))));
			this.lblDelete.Name = "lblDelete";
			// 
			// sqLiteCommandBuilder1
			// 
			this.sqLiteCommandBuilder1.DataAdapter = null;
			this.sqLiteCommandBuilder1.QuoteSuffix = "]";
			// 
			// frmSettings
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.Controls.Add(this.lblDelete);
			this.Controls.Add(this.lblFail);
			this.Controls.Add(this.lblSuccess);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.pnlDataGrid);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.pnlContent);
			this.Name = "frmSettings";
			this.Load += new System.EventHandler(this.frmSettings_Load);
			this.pnlContent.ResumeLayout(false);
			this.pnlContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.pnlDataGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridSettings)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtTaxIdentity;
		private System.Windows.Forms.Label lblMobile;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblTaxIdentity;
		private System.Windows.Forms.Label lblTaxAuth;
		private System.Windows.Forms.Label lblCompanyName;
		private System.Windows.Forms.TextBox txtMobile;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtWeb;
		private System.Windows.Forms.Label lblWeb;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtAddress2;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.TextBox txtAddress1;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblAddress2;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.Label lblZip;
		private System.Windows.Forms.Label lblAddress1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel pnlDataGrid;
		private System.Windows.Forms.DataGridView dataGridSettings;
		private System.Windows.Forms.Label lblCompanyId;
		private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
		private System.Windows.Forms.Label lblCurrentId;
		private System.Windows.Forms.Button btnDelete;
		public System.Windows.Forms.TextBox txtCompanyName;
		public System.Windows.Forms.TextBox txtTaxAuth;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label lblReq;
		private System.Windows.Forms.Label lblTax;
		private System.Windows.Forms.Label lblSuccess;
		private System.Windows.Forms.Label lblFail;
		private System.Windows.Forms.Label lblUpdate;
		private System.Windows.Forms.Label lblDelete;
	}
}