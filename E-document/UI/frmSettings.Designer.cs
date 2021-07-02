
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
			this.lblCurrentId = new System.Windows.Forms.Label();
			this.lblCompanyId = new System.Windows.Forms.Label();
			this.txtState = new System.Windows.Forms.TextBox();
			this.lblState = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtAddress2 = new System.Windows.Forms.TextBox();
			this.txtCountry = new System.Windows.Forms.TextBox();
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
			this.btnUse = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dataGridSettings = new System.Windows.Forms.DataGridView();
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
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(665, 30);
			this.pnlTop.TabIndex = 2;
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(630, 0);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(35, 30);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 2;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTop.Location = new System.Drawing.Point(300, 3);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(79, 21);
			this.lblTop.TabIndex = 1;
			this.lblTop.Text = "SETTINGS";
			// 
			// pnlContent
			// 
			this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlContent.Controls.Add(this.lblCurrentId);
			this.pnlContent.Controls.Add(this.lblCompanyId);
			this.pnlContent.Controls.Add(this.txtState);
			this.pnlContent.Controls.Add(this.lblState);
			this.pnlContent.Controls.Add(this.txtCity);
			this.pnlContent.Controls.Add(this.txtAddress2);
			this.pnlContent.Controls.Add(this.txtCountry);
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
			this.pnlContent.Location = new System.Drawing.Point(12, 36);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(642, 260);
			this.pnlContent.TabIndex = 3;
			// 
			// lblCurrentId
			// 
			this.lblCurrentId.AutoSize = true;
			this.lblCurrentId.Location = new System.Drawing.Point(439, 10);
			this.lblCurrentId.Name = "lblCurrentId";
			this.lblCurrentId.Size = new System.Drawing.Size(13, 13);
			this.lblCurrentId.TabIndex = 51;
			this.lblCurrentId.Text = "1";
			this.lblCurrentId.Visible = false;
			// 
			// lblCompanyId
			// 
			this.lblCompanyId.AutoSize = true;
			this.lblCompanyId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCompanyId.Location = new System.Drawing.Point(341, 10);
			this.lblCompanyId.Name = "lblCompanyId";
			this.lblCompanyId.Size = new System.Drawing.Size(21, 13);
			this.lblCompanyId.TabIndex = 50;
			this.lblCompanyId.Text = "ID:";
			// 
			// txtState
			// 
			this.txtState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtState.Location = new System.Drawing.Point(442, 147);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(168, 22);
			this.txtState.TabIndex = 32;
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblState.Location = new System.Drawing.Point(341, 150);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(88, 13);
			this.lblState.TabIndex = 48;
			this.lblState.Text = "State/Province*:";
			// 
			// txtCity
			// 
			this.txtCity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCity.Location = new System.Drawing.Point(442, 111);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(168, 22);
			this.txtCity.TabIndex = 31;
			// 
			// txtAddress2
			// 
			this.txtAddress2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAddress2.Location = new System.Drawing.Point(442, 74);
			this.txtAddress2.Name = "txtAddress2";
			this.txtAddress2.Size = new System.Drawing.Size(168, 22);
			this.txtAddress2.TabIndex = 30;
			// 
			// txtCountry
			// 
			this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCountry.Location = new System.Drawing.Point(442, 222);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(168, 22);
			this.txtCountry.TabIndex = 34;
			// 
			// txtZip
			// 
			this.txtZip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtZip.Location = new System.Drawing.Point(442, 183);
			this.txtZip.Name = "txtZip";
			this.txtZip.Size = new System.Drawing.Size(168, 22);
			this.txtZip.TabIndex = 33;
			// 
			// txtAddress1
			// 
			this.txtAddress1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAddress1.Location = new System.Drawing.Point(442, 38);
			this.txtAddress1.Name = "txtAddress1";
			this.txtAddress1.Size = new System.Drawing.Size(168, 22);
			this.txtAddress1.TabIndex = 29;
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCity.Location = new System.Drawing.Point(340, 114);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(34, 13);
			this.lblCity.TabIndex = 43;
			this.lblCity.Text = "City*:";
			// 
			// lblAddress2
			// 
			this.lblAddress2.AutoSize = true;
			this.lblAddress2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAddress2.Location = new System.Drawing.Point(341, 77);
			this.lblAddress2.Name = "lblAddress2";
			this.lblAddress2.Size = new System.Drawing.Size(84, 13);
			this.lblAddress2.TabIndex = 42;
			this.lblAddress2.Text = "Address Line 2:";
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCountry.Location = new System.Drawing.Point(341, 225);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(56, 13);
			this.lblCountry.TabIndex = 41;
			this.lblCountry.Text = "Country*:";
			// 
			// lblZip
			// 
			this.lblZip.AutoSize = true;
			this.lblZip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblZip.Location = new System.Drawing.Point(341, 186);
			this.lblZip.Name = "lblZip";
			this.lblZip.Size = new System.Drawing.Size(90, 13);
			this.lblZip.TabIndex = 40;
			this.lblZip.Text = "ZIP/Postal Code:";
			// 
			// lblAddress1
			// 
			this.lblAddress1.AutoSize = true;
			this.lblAddress1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAddress1.Location = new System.Drawing.Point(340, 41);
			this.lblAddress1.Name = "lblAddress1";
			this.lblAddress1.Size = new System.Drawing.Size(84, 13);
			this.lblAddress1.TabIndex = 39;
			this.lblAddress1.Text = "Address Line 1:";
			// 
			// txtWeb
			// 
			this.txtWeb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtWeb.Location = new System.Drawing.Point(113, 147);
			this.txtWeb.Name = "txtWeb";
			this.txtWeb.Size = new System.Drawing.Size(168, 22);
			this.txtWeb.TabIndex = 26;
			// 
			// lblWeb
			// 
			this.lblWeb.AutoSize = true;
			this.lblWeb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblWeb.Location = new System.Drawing.Point(12, 150);
			this.lblWeb.Name = "lblWeb";
			this.lblWeb.Size = new System.Drawing.Size(56, 13);
			this.lblWeb.TabIndex = 35;
			this.lblWeb.Text = "Web Site:";
			// 
			// txtMobile
			// 
			this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMobile.Location = new System.Drawing.Point(113, 111);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new System.Drawing.Size(168, 22);
			this.txtMobile.TabIndex = 25;
			this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmail.Location = new System.Drawing.Point(113, 74);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(168, 22);
			this.txtEmail.TabIndex = 24;
			this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
			// 
			// txtTaxIdentity
			// 
			this.txtTaxIdentity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTaxIdentity.Location = new System.Drawing.Point(113, 222);
			this.txtTaxIdentity.Name = "txtTaxIdentity";
			this.txtTaxIdentity.Size = new System.Drawing.Size(168, 22);
			this.txtTaxIdentity.TabIndex = 28;
			// 
			// txtTaxAuth
			// 
			this.txtTaxAuth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTaxAuth.Location = new System.Drawing.Point(113, 183);
			this.txtTaxAuth.Name = "txtTaxAuth";
			this.txtTaxAuth.Size = new System.Drawing.Size(168, 22);
			this.txtTaxAuth.TabIndex = 27;
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCompanyName.Location = new System.Drawing.Point(113, 38);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(168, 22);
			this.txtCompanyName.TabIndex = 23;
			// 
			// lblMobile
			// 
			this.lblMobile.AutoSize = true;
			this.lblMobile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMobile.Location = new System.Drawing.Point(11, 114);
			this.lblMobile.Name = "lblMobile";
			this.lblMobile.Size = new System.Drawing.Size(46, 13);
			this.lblMobile.TabIndex = 29;
			this.lblMobile.Text = "Mobile:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEmail.Location = new System.Drawing.Point(12, 77);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(42, 13);
			this.lblEmail.TabIndex = 28;
			this.lblEmail.Text = "E-Mail:";
			// 
			// lblTaxIdentity
			// 
			this.lblTaxIdentity.AutoSize = true;
			this.lblTaxIdentity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTaxIdentity.Location = new System.Drawing.Point(12, 225);
			this.lblTaxIdentity.Name = "lblTaxIdentity";
			this.lblTaxIdentity.Size = new System.Drawing.Size(73, 13);
			this.lblTaxIdentity.TabIndex = 27;
			this.lblTaxIdentity.Text = "Tax Identity*:";
			// 
			// lblTaxAuth
			// 
			this.lblTaxAuth.AutoSize = true;
			this.lblTaxAuth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTaxAuth.Location = new System.Drawing.Point(12, 186);
			this.lblTaxAuth.Name = "lblTaxAuth";
			this.lblTaxAuth.Size = new System.Drawing.Size(77, 13);
			this.lblTaxAuth.TabIndex = 26;
			this.lblTaxAuth.Text = "Tax Authority:";
			// 
			// lblCompanyName
			// 
			this.lblCompanyName.AutoSize = true;
			this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCompanyName.Location = new System.Drawing.Point(11, 41);
			this.lblCompanyName.Name = "lblCompanyName";
			this.lblCompanyName.Size = new System.Drawing.Size(95, 13);
			this.lblCompanyName.TabIndex = 24;
			this.lblCompanyName.Text = "Company Name*:";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTitle.Location = new System.Drawing.Point(11, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(158, 15);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Save Company Information";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(547, 301);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 35;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(426, 302);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 36;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pnlDataGrid
			// 
			this.pnlDataGrid.Controls.Add(this.btnUse);
			this.pnlDataGrid.Controls.Add(this.btnDelete);
			this.pnlDataGrid.Controls.Add(this.dataGridSettings);
			this.pnlDataGrid.Location = new System.Drawing.Point(12, 331);
			this.pnlDataGrid.Name = "pnlDataGrid";
			this.pnlDataGrid.Size = new System.Drawing.Size(642, 130);
			this.pnlDataGrid.TabIndex = 37;
			// 
			// btnUse
			// 
			this.btnUse.Location = new System.Drawing.Point(535, 104);
			this.btnUse.Name = "btnUse";
			this.btnUse.Size = new System.Drawing.Size(75, 23);
			this.btnUse.TabIndex = 38;
			this.btnUse.Text = "USE";
			this.btnUse.UseVisualStyleBackColor = true;
			this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(414, 104);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 37;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dataGridSettings
			// 
			this.dataGridSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridSettings.Location = new System.Drawing.Point(16, 3);
			this.dataGridSettings.Name = "dataGridSettings";
			this.dataGridSettings.Size = new System.Drawing.Size(595, 98);
			this.dataGridSettings.TabIndex = 0;
			this.dataGridSettings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSettings_CellClick);
			// 
			// sqLiteCommandBuilder1
			// 
			this.sqLiteCommandBuilder1.DataAdapter = null;
			this.sqLiteCommandBuilder1.QuoteSuffix = "]";
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(665, 473);
			this.Controls.Add(this.pnlDataGrid);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SETTINGS";
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

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtTaxIdentity;
		private System.Windows.Forms.TextBox txtTaxAuth;
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
		private System.Windows.Forms.TextBox txtCountry;
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
		private System.Windows.Forms.Button btnUse;
		public System.Windows.Forms.TextBox txtCompanyName;
	}
}