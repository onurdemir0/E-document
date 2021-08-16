
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
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.lblTop = new System.Windows.Forms.Label();
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
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.pnlDataGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSettings)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
			this.pnlTop.Controls.Add(this.pictureBoxClose);
			this.pnlTop.Controls.Add(this.lblTop);
			resources.ApplyResources(this.pnlTop, "pnlTop");
			this.pnlTop.Name = "pnlTop";
			// 
			// pictureBoxClose
			// 
			resources.ApplyResources(this.pictureBoxClose, "pictureBoxClose");
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// lblTop
			// 
			resources.ApplyResources(this.lblTop, "lblTop");
			this.lblTop.Name = "lblTop";
			// 
			// pnlContent
			// 
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
			resources.ApplyResources(this.pnlContent, "pnlContent");
			this.pnlContent.Name = "pnlContent";
			// 
			// lblUpdate
			// 
			resources.ApplyResources(this.lblUpdate, "lblUpdate");
			this.lblUpdate.Name = "lblUpdate";
			// 
			// lblTax
			// 
			resources.ApplyResources(this.lblTax, "lblTax");
			this.lblTax.Name = "lblTax";
			// 
			// lblReq
			// 
			resources.ApplyResources(this.lblReq, "lblReq");
			this.lblReq.Name = "lblReq";
			// 
			// cmbCountry
			// 
			this.cmbCountry.FormattingEnabled = true;
			resources.ApplyResources(this.cmbCountry, "cmbCountry");
			this.cmbCountry.Name = "cmbCountry";
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
			// txtState
			// 
			resources.ApplyResources(this.txtState, "txtState");
			this.txtState.Name = "txtState";
			// 
			// lblState
			// 
			resources.ApplyResources(this.lblState, "lblState");
			this.lblState.Name = "lblState";
			// 
			// txtCity
			// 
			resources.ApplyResources(this.txtCity, "txtCity");
			this.txtCity.Name = "txtCity";
			// 
			// txtAddress2
			// 
			resources.ApplyResources(this.txtAddress2, "txtAddress2");
			this.txtAddress2.Name = "txtAddress2";
			// 
			// txtZip
			// 
			resources.ApplyResources(this.txtZip, "txtZip");
			this.txtZip.Name = "txtZip";
			// 
			// txtAddress1
			// 
			resources.ApplyResources(this.txtAddress1, "txtAddress1");
			this.txtAddress1.Name = "txtAddress1";
			// 
			// lblCity
			// 
			resources.ApplyResources(this.lblCity, "lblCity");
			this.lblCity.Name = "lblCity";
			// 
			// lblAddress2
			// 
			resources.ApplyResources(this.lblAddress2, "lblAddress2");
			this.lblAddress2.Name = "lblAddress2";
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
			// lblAddress1
			// 
			resources.ApplyResources(this.lblAddress1, "lblAddress1");
			this.lblAddress1.Name = "lblAddress1";
			// 
			// txtWeb
			// 
			resources.ApplyResources(this.txtWeb, "txtWeb");
			this.txtWeb.Name = "txtWeb";
			// 
			// lblWeb
			// 
			resources.ApplyResources(this.lblWeb, "lblWeb");
			this.lblWeb.Name = "lblWeb";
			// 
			// txtMobile
			// 
			resources.ApplyResources(this.txtMobile, "txtMobile");
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
			// 
			// txtEmail
			// 
			resources.ApplyResources(this.txtEmail, "txtEmail");
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
			// 
			// txtTaxIdentity
			// 
			resources.ApplyResources(this.txtTaxIdentity, "txtTaxIdentity");
			this.txtTaxIdentity.Name = "txtTaxIdentity";
			this.txtTaxIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxIdentity_KeyPress);
			// 
			// txtTaxAuth
			// 
			resources.ApplyResources(this.txtTaxAuth, "txtTaxAuth");
			this.txtTaxAuth.Name = "txtTaxAuth";
			// 
			// txtCompanyName
			// 
			resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
			this.txtCompanyName.Name = "txtCompanyName";
			// 
			// lblMobile
			// 
			resources.ApplyResources(this.lblMobile, "lblMobile");
			this.lblMobile.Name = "lblMobile";
			// 
			// lblEmail
			// 
			resources.ApplyResources(this.lblEmail, "lblEmail");
			this.lblEmail.Name = "lblEmail";
			// 
			// lblTaxIdentity
			// 
			resources.ApplyResources(this.lblTaxIdentity, "lblTaxIdentity");
			this.lblTaxIdentity.Name = "lblTaxIdentity";
			// 
			// lblTaxAuth
			// 
			resources.ApplyResources(this.lblTaxAuth, "lblTaxAuth");
			this.lblTaxAuth.Name = "lblTaxAuth";
			// 
			// lblCompanyName
			// 
			resources.ApplyResources(this.lblCompanyName, "lblCompanyName");
			this.lblCompanyName.Name = "lblCompanyName";
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// btnSave
			// 
			resources.ApplyResources(this.btnSave, "btnSave");
			this.btnSave.Name = "btnSave";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			resources.ApplyResources(this.btnUpdate, "btnUpdate");
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pnlDataGrid
			// 
			this.pnlDataGrid.Controls.Add(this.dataGridSettings);
			resources.ApplyResources(this.pnlDataGrid, "pnlDataGrid");
			this.pnlDataGrid.Name = "pnlDataGrid";
			// 
			// dataGridSettings
			// 
			this.dataGridSettings.AllowUserToAddRows = false;
			this.dataGridSettings.AllowUserToDeleteRows = false;
			this.dataGridSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			resources.ApplyResources(this.dataGridSettings, "dataGridSettings");
			this.dataGridSettings.Name = "dataGridSettings";
			this.dataGridSettings.ReadOnly = true;
			this.dataGridSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridSettings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSettings_CellClick);
			// 
			// btnDelete
			// 
			resources.ApplyResources(this.btnDelete, "btnDelete");
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblSuccess
			// 
			resources.ApplyResources(this.lblSuccess, "lblSuccess");
			this.lblSuccess.Name = "lblSuccess";
			// 
			// lblFail
			// 
			resources.ApplyResources(this.lblFail, "lblFail");
			this.lblFail.Name = "lblFail";
			// 
			// lblDelete
			// 
			resources.ApplyResources(this.lblDelete, "lblDelete");
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
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSettings";
			this.Load += new System.EventHandler(this.frmSettings_Load);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.pnlContent.ResumeLayout(false);
			this.pnlContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.pnlDataGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridSettings)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblTop;
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