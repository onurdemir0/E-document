
namespace E_document.UI
{
	partial class frmPurchaseAndSales
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.lblTop = new System.Windows.Forms.Label();
			this.pnlDeaCust = new System.Windows.Forms.Panel();
			this.lblDeaCustTitle = new System.Windows.Forms.Label();
			this.lblDealerName = new System.Windows.Forms.Label();
			this.lblDealerAddress = new System.Windows.Forms.Label();
			this.lblDealerPhone = new System.Windows.Forms.Label();
			this.lblDealerEmail = new System.Windows.Forms.Label();
			this.lblWeb = new System.Windows.Forms.Label();
			this.lblDeaTaxAuth = new System.Windows.Forms.Label();
			this.lblDeaTaxIdentity = new System.Windows.Forms.Label();
			this.lblBillNo = new System.Windows.Forms.Label();
			this.lblBillDate = new System.Windows.Forms.Label();
			this.lblOrderNo = new System.Windows.Forms.Label();
			this.lblCustAddress = new System.Windows.Forms.Label();
			this.lblCustName = new System.Windows.Forms.Label();
			this.lblNationality = new System.Windows.Forms.Label();
			this.lblCustTaxIdentity = new System.Windows.Forms.Label();
			this.lblOrderDate = new System.Windows.Forms.Label();
			this.txtDealerName = new System.Windows.Forms.TextBox();
			this.txtTaxAuth = new System.Windows.Forms.TextBox();
			this.txtDeaAddress = new System.Windows.Forms.TextBox();
			this.txtDeaTaxIdentity = new System.Windows.Forms.TextBox();
			this.txtDealerEmail = new System.Windows.Forms.TextBox();
			this.txtBillNo = new System.Windows.Forms.TextBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtDealerPhone = new System.Windows.Forms.TextBox();
			this.txtNationalityIdentity = new System.Windows.Forms.TextBox();
			this.txtCustomerTaxIdentity = new System.Windows.Forms.TextBox();
			this.txtCustomerAddress = new System.Windows.Forms.TextBox();
			this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
			this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
			this.txtDealerWeb = new System.Windows.Forms.TextBox();
			this.txtOrderNo = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblProductTitle = new System.Windows.Forms.Label();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtProductNo = new System.Windows.Forms.TextBox();
			this.lblUnit = new System.Windows.Forms.Label();
			this.lblProductNo = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pnlDataGrid = new System.Windows.Forms.Panel();
			this.lblGridTitle = new System.Windows.Forms.Label();
			this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
			this.pnlCalculation = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblGrandTotal = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lblVat = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblCalculationTitle = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.pnlDeaCust.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlDataGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
			this.pnlCalculation.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Controls.Add(this.lblTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1261, 35);
			this.panel1.TabIndex = 1;
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1214, 3);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(35, 27);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 2;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTop.Location = new System.Drawing.Point(550, 3);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(172, 21);
			this.lblTop.TabIndex = 1;
			this.lblTop.Text = "PURCHASE And SALES ";
			// 
			// pnlDeaCust
			// 
			this.pnlDeaCust.Controls.Add(this.txtOrderNo);
			this.pnlDeaCust.Controls.Add(this.txtDealerWeb);
			this.pnlDeaCust.Controls.Add(this.dtpOrderDate);
			this.pnlDeaCust.Controls.Add(this.dtpBillDate);
			this.pnlDeaCust.Controls.Add(this.txtCustomerAddress);
			this.pnlDeaCust.Controls.Add(this.txtCustomerTaxIdentity);
			this.pnlDeaCust.Controls.Add(this.txtNationalityIdentity);
			this.pnlDeaCust.Controls.Add(this.txtDealerPhone);
			this.pnlDeaCust.Controls.Add(this.txtBillNo);
			this.pnlDeaCust.Controls.Add(this.txtDealerEmail);
			this.pnlDeaCust.Controls.Add(this.txtDeaTaxIdentity);
			this.pnlDeaCust.Controls.Add(this.txtDeaAddress);
			this.pnlDeaCust.Controls.Add(this.txtTaxAuth);
			this.pnlDeaCust.Controls.Add(this.txtDealerName);
			this.pnlDeaCust.Controls.Add(this.lblOrderDate);
			this.pnlDeaCust.Controls.Add(this.lblCustTaxIdentity);
			this.pnlDeaCust.Controls.Add(this.lblNationality);
			this.pnlDeaCust.Controls.Add(this.lblCustName);
			this.pnlDeaCust.Controls.Add(this.lblCustAddress);
			this.pnlDeaCust.Controls.Add(this.lblOrderNo);
			this.pnlDeaCust.Controls.Add(this.lblBillDate);
			this.pnlDeaCust.Controls.Add(this.lblBillNo);
			this.pnlDeaCust.Controls.Add(this.lblDeaTaxIdentity);
			this.pnlDeaCust.Controls.Add(this.lblDeaTaxAuth);
			this.pnlDeaCust.Controls.Add(this.lblWeb);
			this.pnlDeaCust.Controls.Add(this.lblDealerEmail);
			this.pnlDeaCust.Controls.Add(this.lblDealerPhone);
			this.pnlDeaCust.Controls.Add(this.lblDealerAddress);
			this.pnlDeaCust.Controls.Add(this.lblDealerName);
			this.pnlDeaCust.Controls.Add(this.lblDeaCustTitle);
			this.pnlDeaCust.Location = new System.Drawing.Point(13, 39);
			this.pnlDeaCust.Name = "pnlDeaCust";
			this.pnlDeaCust.Size = new System.Drawing.Size(1236, 170);
			this.pnlDeaCust.TabIndex = 2;
			// 
			// lblDeaCustTitle
			// 
			this.lblDeaCustTitle.AutoSize = true;
			this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDeaCustTitle.Location = new System.Drawing.Point(8, 2);
			this.lblDeaCustTitle.Name = "lblDeaCustTitle";
			this.lblDeaCustTitle.Size = new System.Drawing.Size(167, 15);
			this.lblDeaCustTitle.TabIndex = 4;
			this.lblDeaCustTitle.Text = "Dealer And Customer Details";
			// 
			// lblDealerName
			// 
			this.lblDealerName.AutoSize = true;
			this.lblDealerName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDealerName.Location = new System.Drawing.Point(22, 22);
			this.lblDealerName.Name = "lblDealerName";
			this.lblDealerName.Size = new System.Drawing.Size(72, 13);
			this.lblDealerName.TabIndex = 5;
			this.lblDealerName.Text = "Dealer Name";
			// 
			// lblDealerAddress
			// 
			this.lblDealerAddress.AutoSize = true;
			this.lblDealerAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDealerAddress.Location = new System.Drawing.Point(275, 22);
			this.lblDealerAddress.Name = "lblDealerAddress";
			this.lblDealerAddress.Size = new System.Drawing.Size(84, 13);
			this.lblDealerAddress.TabIndex = 6;
			this.lblDealerAddress.Text = "Dealer Address";
			// 
			// lblDealerPhone
			// 
			this.lblDealerPhone.AutoSize = true;
			this.lblDealerPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDealerPhone.Location = new System.Drawing.Point(783, 22);
			this.lblDealerPhone.Name = "lblDealerPhone";
			this.lblDealerPhone.Size = new System.Drawing.Size(76, 13);
			this.lblDealerPhone.TabIndex = 7;
			this.lblDealerPhone.Text = "Dealer Phone";
			// 
			// lblDealerEmail
			// 
			this.lblDealerEmail.AutoSize = true;
			this.lblDealerEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDealerEmail.Location = new System.Drawing.Point(525, 22);
			this.lblDealerEmail.Name = "lblDealerEmail";
			this.lblDealerEmail.Size = new System.Drawing.Size(70, 13);
			this.lblDealerEmail.TabIndex = 8;
			this.lblDealerEmail.Text = "Dealer Email";
			// 
			// lblWeb
			// 
			this.lblWeb.AutoSize = true;
			this.lblWeb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblWeb.Location = new System.Drawing.Point(1042, 22);
			this.lblWeb.Name = "lblWeb";
			this.lblWeb.Size = new System.Drawing.Size(89, 13);
			this.lblWeb.TabIndex = 9;
			this.lblWeb.Text = "Dealer Web Site";
			// 
			// lblDeaTaxAuth
			// 
			this.lblDeaTaxAuth.AutoSize = true;
			this.lblDeaTaxAuth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDeaTaxAuth.Location = new System.Drawing.Point(22, 73);
			this.lblDeaTaxAuth.Name = "lblDeaTaxAuth";
			this.lblDeaTaxAuth.Size = new System.Drawing.Size(74, 13);
			this.lblDeaTaxAuth.TabIndex = 10;
			this.lblDeaTaxAuth.Text = "Tax Authority";
			// 
			// lblDeaTaxIdentity
			// 
			this.lblDeaTaxIdentity.AutoSize = true;
			this.lblDeaTaxIdentity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDeaTaxIdentity.Location = new System.Drawing.Point(275, 73);
			this.lblDeaTaxIdentity.Name = "lblDeaTaxIdentity";
			this.lblDeaTaxIdentity.Size = new System.Drawing.Size(101, 13);
			this.lblDeaTaxIdentity.TabIndex = 11;
			this.lblDeaTaxIdentity.Text = "Dealer Tax Identity";
			// 
			// lblBillNo
			// 
			this.lblBillNo.AutoSize = true;
			this.lblBillNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillNo.Location = new System.Drawing.Point(525, 73);
			this.lblBillNo.Name = "lblBillNo";
			this.lblBillNo.Size = new System.Drawing.Size(40, 13);
			this.lblBillNo.TabIndex = 12;
			this.lblBillNo.Text = "Bill No";
			// 
			// lblBillDate
			// 
			this.lblBillDate.AutoSize = true;
			this.lblBillDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillDate.Location = new System.Drawing.Point(783, 73);
			this.lblBillDate.Name = "lblBillDate";
			this.lblBillDate.Size = new System.Drawing.Size(49, 13);
			this.lblBillDate.TabIndex = 13;
			this.lblBillDate.Text = "Bill Date";
			this.lblBillDate.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblOrderNo
			// 
			this.lblOrderNo.AutoSize = true;
			this.lblOrderNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOrderNo.Location = new System.Drawing.Point(1042, 122);
			this.lblOrderNo.Name = "lblOrderNo";
			this.lblOrderNo.Size = new System.Drawing.Size(55, 13);
			this.lblOrderNo.TabIndex = 14;
			this.lblOrderNo.Text = "Order No";
			// 
			// lblCustAddress
			// 
			this.lblCustAddress.AutoSize = true;
			this.lblCustAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCustAddress.Location = new System.Drawing.Point(275, 124);
			this.lblCustAddress.Name = "lblCustAddress";
			this.lblCustAddress.Size = new System.Drawing.Size(100, 13);
			this.lblCustAddress.TabIndex = 15;
			this.lblCustAddress.Text = "Customer Address";
			// 
			// lblCustName
			// 
			this.lblCustName.AutoSize = true;
			this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCustName.Location = new System.Drawing.Point(22, 122);
			this.lblCustName.Name = "lblCustName";
			this.lblCustName.Size = new System.Drawing.Size(88, 13);
			this.lblCustName.TabIndex = 16;
			this.lblCustName.Text = "Customer Name";
			// 
			// lblNationality
			// 
			this.lblNationality.AutoSize = true;
			this.lblNationality.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblNationality.Location = new System.Drawing.Point(525, 124);
			this.lblNationality.Name = "lblNationality";
			this.lblNationality.Size = new System.Drawing.Size(105, 13);
			this.lblNationality.TabIndex = 17;
			this.lblNationality.Text = "Nationality Identity";
			// 
			// lblCustTaxIdentity
			// 
			this.lblCustTaxIdentity.AutoSize = true;
			this.lblCustTaxIdentity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCustTaxIdentity.Location = new System.Drawing.Point(783, 122);
			this.lblCustTaxIdentity.Name = "lblCustTaxIdentity";
			this.lblCustTaxIdentity.Size = new System.Drawing.Size(117, 13);
			this.lblCustTaxIdentity.TabIndex = 18;
			this.lblCustTaxIdentity.Text = "Customer Tax Identity";
			// 
			// lblOrderDate
			// 
			this.lblOrderDate.AutoSize = true;
			this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOrderDate.Location = new System.Drawing.Point(1042, 73);
			this.lblOrderDate.Name = "lblOrderDate";
			this.lblOrderDate.Size = new System.Drawing.Size(64, 13);
			this.lblOrderDate.TabIndex = 19;
			this.lblOrderDate.Text = "Order Date";
			// 
			// txtDealerName
			// 
			this.txtDealerName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDealerName.Location = new System.Drawing.Point(25, 40);
			this.txtDealerName.Name = "txtDealerName";
			this.txtDealerName.Size = new System.Drawing.Size(168, 22);
			this.txtDealerName.TabIndex = 3;
			// 
			// txtTaxAuth
			// 
			this.txtTaxAuth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTaxAuth.Location = new System.Drawing.Point(25, 89);
			this.txtTaxAuth.Name = "txtTaxAuth";
			this.txtTaxAuth.Size = new System.Drawing.Size(168, 22);
			this.txtTaxAuth.TabIndex = 20;
			// 
			// txtDeaAddress
			// 
			this.txtDeaAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDeaAddress.Location = new System.Drawing.Point(278, 40);
			this.txtDeaAddress.Name = "txtDeaAddress";
			this.txtDeaAddress.Size = new System.Drawing.Size(168, 22);
			this.txtDeaAddress.TabIndex = 21;
			// 
			// txtDeaTaxIdentity
			// 
			this.txtDeaTaxIdentity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDeaTaxIdentity.Location = new System.Drawing.Point(278, 89);
			this.txtDeaTaxIdentity.Name = "txtDeaTaxIdentity";
			this.txtDeaTaxIdentity.Size = new System.Drawing.Size(168, 22);
			this.txtDeaTaxIdentity.TabIndex = 22;
			// 
			// txtDealerEmail
			// 
			this.txtDealerEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDealerEmail.Location = new System.Drawing.Point(528, 40);
			this.txtDealerEmail.Name = "txtDealerEmail";
			this.txtDealerEmail.Size = new System.Drawing.Size(168, 22);
			this.txtDealerEmail.TabIndex = 23;
			// 
			// txtBillNo
			// 
			this.txtBillNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillNo.Location = new System.Drawing.Point(528, 89);
			this.txtBillNo.Name = "txtBillNo";
			this.txtBillNo.Size = new System.Drawing.Size(168, 22);
			this.txtBillNo.TabIndex = 24;
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerName.Location = new System.Drawing.Point(38, 177);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(168, 22);
			this.txtCustomerName.TabIndex = 26;
			// 
			// txtDealerPhone
			// 
			this.txtDealerPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDealerPhone.Location = new System.Drawing.Point(786, 40);
			this.txtDealerPhone.Name = "txtDealerPhone";
			this.txtDealerPhone.Size = new System.Drawing.Size(168, 22);
			this.txtDealerPhone.TabIndex = 25;
			// 
			// txtNationalityIdentity
			// 
			this.txtNationalityIdentity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtNationalityIdentity.Location = new System.Drawing.Point(528, 138);
			this.txtNationalityIdentity.Name = "txtNationalityIdentity";
			this.txtNationalityIdentity.Size = new System.Drawing.Size(168, 22);
			this.txtNationalityIdentity.TabIndex = 26;
			// 
			// txtCustomerTaxIdentity
			// 
			this.txtCustomerTaxIdentity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerTaxIdentity.Location = new System.Drawing.Point(786, 138);
			this.txtCustomerTaxIdentity.Name = "txtCustomerTaxIdentity";
			this.txtCustomerTaxIdentity.Size = new System.Drawing.Size(168, 22);
			this.txtCustomerTaxIdentity.TabIndex = 27;
			// 
			// txtCustomerAddress
			// 
			this.txtCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerAddress.Location = new System.Drawing.Point(278, 138);
			this.txtCustomerAddress.Name = "txtCustomerAddress";
			this.txtCustomerAddress.Size = new System.Drawing.Size(168, 22);
			this.txtCustomerAddress.TabIndex = 28;
			// 
			// dtpBillDate
			// 
			this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpBillDate.Location = new System.Drawing.Point(786, 90);
			this.dtpBillDate.Name = "dtpBillDate";
			this.dtpBillDate.Size = new System.Drawing.Size(168, 23);
			this.dtpBillDate.TabIndex = 29;
			// 
			// dtpOrderDate
			// 
			this.dtpOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpOrderDate.Location = new System.Drawing.Point(1045, 90);
			this.dtpOrderDate.Name = "dtpOrderDate";
			this.dtpOrderDate.Size = new System.Drawing.Size(168, 23);
			this.dtpOrderDate.TabIndex = 30;
			// 
			// txtDealerWeb
			// 
			this.txtDealerWeb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDealerWeb.Location = new System.Drawing.Point(1045, 40);
			this.txtDealerWeb.Name = "txtDealerWeb";
			this.txtDealerWeb.Size = new System.Drawing.Size(168, 22);
			this.txtDealerWeb.TabIndex = 31;
			// 
			// txtOrderNo
			// 
			this.txtOrderNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtOrderNo.Location = new System.Drawing.Point(1045, 138);
			this.txtOrderNo.Name = "txtOrderNo";
			this.txtOrderNo.Size = new System.Drawing.Size(168, 22);
			this.txtOrderNo.TabIndex = 32;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.txtQuantity);
			this.panel2.Controls.Add(this.lblQuantity);
			this.panel2.Controls.Add(this.txtPrice);
			this.panel2.Controls.Add(this.txtProductName);
			this.panel2.Controls.Add(this.lblPrice);
			this.panel2.Controls.Add(this.lblProductName);
			this.panel2.Controls.Add(this.txtUnit);
			this.panel2.Controls.Add(this.txtProductNo);
			this.panel2.Controls.Add(this.lblUnit);
			this.panel2.Controls.Add(this.lblProductNo);
			this.panel2.Controls.Add(this.lblProductTitle);
			this.panel2.Location = new System.Drawing.Point(13, 215);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(720, 112);
			this.panel2.TabIndex = 27;
			// 
			// lblProductTitle
			// 
			this.lblProductTitle.AutoSize = true;
			this.lblProductTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductTitle.Location = new System.Drawing.Point(8, 2);
			this.lblProductTitle.Name = "lblProductTitle";
			this.lblProductTitle.Size = new System.Drawing.Size(92, 15);
			this.lblProductTitle.TabIndex = 33;
			this.lblProductTitle.Text = "Product Details";
			// 
			// txtUnit
			// 
			this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUnit.Location = new System.Drawing.Point(25, 81);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(168, 22);
			this.txtUnit.TabIndex = 38;
			// 
			// txtProductNo
			// 
			this.txtProductNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtProductNo.Location = new System.Drawing.Point(25, 33);
			this.txtProductNo.Name = "txtProductNo";
			this.txtProductNo.Size = new System.Drawing.Size(168, 22);
			this.txtProductNo.TabIndex = 34;
			// 
			// lblUnit
			// 
			this.lblUnit.AutoSize = true;
			this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUnit.Location = new System.Drawing.Point(22, 65);
			this.lblUnit.Name = "lblUnit";
			this.lblUnit.Size = new System.Drawing.Size(29, 13);
			this.lblUnit.TabIndex = 36;
			this.lblUnit.Text = "Unit";
			// 
			// lblProductNo
			// 
			this.lblProductNo.AutoSize = true;
			this.lblProductNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductNo.Location = new System.Drawing.Point(22, 17);
			this.lblProductNo.Name = "lblProductNo";
			this.lblProductNo.Size = new System.Drawing.Size(65, 13);
			this.lblProductNo.TabIndex = 35;
			this.lblProductNo.Text = "Product No";
			this.lblProductNo.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPrice.Location = new System.Drawing.Point(278, 81);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(168, 22);
			this.txtPrice.TabIndex = 42;
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtProductName.Location = new System.Drawing.Point(278, 33);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(168, 22);
			this.txtProductName.TabIndex = 39;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPrice.Location = new System.Drawing.Point(275, 65);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(31, 13);
			this.lblPrice.TabIndex = 41;
			this.lblPrice.Text = "Price";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductName.Location = new System.Drawing.Point(275, 17);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(79, 13);
			this.lblProductName.TabIndex = 40;
			this.lblProductName.Text = "Product Name";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtQuantity.Location = new System.Drawing.Point(528, 33);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(168, 22);
			this.txtQuantity.TabIndex = 43;
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblQuantity.Location = new System.Drawing.Point(525, 17);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(51, 13);
			this.lblQuantity.TabIndex = 44;
			this.lblQuantity.Text = "Quantity";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(528, 71);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(115, 36);
			this.btnAdd.TabIndex = 45;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// pnlDataGrid
			// 
			this.pnlDataGrid.Controls.Add(this.dgvAddedProducts);
			this.pnlDataGrid.Controls.Add(this.lblGridTitle);
			this.pnlDataGrid.Location = new System.Drawing.Point(12, 333);
			this.pnlDataGrid.Name = "pnlDataGrid";
			this.pnlDataGrid.Size = new System.Drawing.Size(721, 204);
			this.pnlDataGrid.TabIndex = 28;
			// 
			// lblGridTitle
			// 
			this.lblGridTitle.AutoSize = true;
			this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGridTitle.Location = new System.Drawing.Point(14, 2);
			this.lblGridTitle.Name = "lblGridTitle";
			this.lblGridTitle.Size = new System.Drawing.Size(95, 15);
			this.lblGridTitle.TabIndex = 34;
			this.lblGridTitle.Text = "Added Products";
			// 
			// dgvAddedProducts
			// 
			this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddedProducts.Location = new System.Drawing.Point(17, 20);
			this.dgvAddedProducts.Name = "dgvAddedProducts";
			this.dgvAddedProducts.Size = new System.Drawing.Size(680, 181);
			this.dgvAddedProducts.TabIndex = 35;
			// 
			// pnlCalculation
			// 
			this.pnlCalculation.Controls.Add(this.btnSave);
			this.pnlCalculation.Controls.Add(this.textBox2);
			this.pnlCalculation.Controls.Add(this.lblGrandTotal);
			this.pnlCalculation.Controls.Add(this.textBox3);
			this.pnlCalculation.Controls.Add(this.lblVat);
			this.pnlCalculation.Controls.Add(this.textBox4);
			this.pnlCalculation.Controls.Add(this.lblDiscount);
			this.pnlCalculation.Controls.Add(this.txtSubTotal);
			this.pnlCalculation.Controls.Add(this.lblSubTotal);
			this.pnlCalculation.Controls.Add(this.lblCalculationTitle);
			this.pnlCalculation.Location = new System.Drawing.Point(739, 215);
			this.pnlCalculation.Name = "pnlCalculation";
			this.pnlCalculation.Size = new System.Drawing.Size(510, 322);
			this.pnlCalculation.TabIndex = 31;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox2.Location = new System.Drawing.Point(25, 184);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(462, 22);
			this.textBox2.TabIndex = 52;
			// 
			// lblGrandTotal
			// 
			this.lblGrandTotal.AutoSize = true;
			this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGrandTotal.Location = new System.Drawing.Point(22, 168);
			this.lblGrandTotal.Name = "lblGrandTotal";
			this.lblGrandTotal.Size = new System.Drawing.Size(67, 13);
			this.lblGrandTotal.TabIndex = 51;
			this.lblGrandTotal.Text = "Grand Total";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox3.Location = new System.Drawing.Point(25, 137);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(462, 22);
			this.textBox3.TabIndex = 50;
			// 
			// lblVat
			// 
			this.lblVat.AutoSize = true;
			this.lblVat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblVat.Location = new System.Drawing.Point(22, 121);
			this.lblVat.Name = "lblVat";
			this.lblVat.Size = new System.Drawing.Size(43, 13);
			this.lblVat.TabIndex = 49;
			this.lblVat.Text = "VAT (%)";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox4.Location = new System.Drawing.Point(25, 92);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(462, 22);
			this.textBox4.TabIndex = 48;
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDiscount.Location = new System.Drawing.Point(22, 76);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(71, 13);
			this.lblDiscount.TabIndex = 45;
			this.lblDiscount.Text = "Discount (%)";
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSubTotal.Location = new System.Drawing.Point(25, 45);
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.Size = new System.Drawing.Size(462, 22);
			this.txtSubTotal.TabIndex = 44;
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.AutoSize = true;
			this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSubTotal.Location = new System.Drawing.Point(22, 29);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(55, 13);
			this.lblSubTotal.TabIndex = 43;
			this.lblSubTotal.Text = "Sub Total";
			// 
			// lblCalculationTitle
			// 
			this.lblCalculationTitle.AutoSize = true;
			this.lblCalculationTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCalculationTitle.Location = new System.Drawing.Point(8, 7);
			this.lblCalculationTitle.Name = "lblCalculationTitle";
			this.lblCalculationTitle.Size = new System.Drawing.Size(108, 15);
			this.lblCalculationTitle.TabIndex = 35;
			this.lblCalculationTitle.Text = "Calculation Details";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSave.Location = new System.Drawing.Point(25, 229);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(462, 69);
			this.btnSave.TabIndex = 46;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// frmPurchaseAndSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1261, 549);
			this.Controls.Add(this.pnlCalculation);
			this.Controls.Add(this.pnlDataGrid);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.pnlDeaCust);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmPurchaseAndSales";
			this.Text = "frmPurchaseAndSales";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.pnlDeaCust.ResumeLayout(false);
			this.pnlDeaCust.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnlDataGrid.ResumeLayout(false);
			this.pnlDataGrid.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
			this.pnlCalculation.ResumeLayout(false);
			this.pnlCalculation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Panel pnlDeaCust;
		private System.Windows.Forms.Label lblDealerEmail;
		private System.Windows.Forms.Label lblDealerPhone;
		private System.Windows.Forms.Label lblDealerAddress;
		private System.Windows.Forms.Label lblDealerName;
		private System.Windows.Forms.Label lblDeaCustTitle;
		private System.Windows.Forms.Label lblBillDate;
		private System.Windows.Forms.Label lblBillNo;
		private System.Windows.Forms.Label lblDeaTaxIdentity;
		private System.Windows.Forms.Label lblDeaTaxAuth;
		private System.Windows.Forms.Label lblWeb;
		private System.Windows.Forms.TextBox txtDealerName;
		private System.Windows.Forms.Label lblOrderDate;
		private System.Windows.Forms.Label lblCustTaxIdentity;
		private System.Windows.Forms.Label lblNationality;
		private System.Windows.Forms.Label lblCustName;
		private System.Windows.Forms.Label lblCustAddress;
		private System.Windows.Forms.Label lblOrderNo;
		private System.Windows.Forms.TextBox txtBillNo;
		private System.Windows.Forms.TextBox txtDealerEmail;
		private System.Windows.Forms.TextBox txtDeaTaxIdentity;
		private System.Windows.Forms.TextBox txtDeaAddress;
		private System.Windows.Forms.TextBox txtTaxAuth;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtNationalityIdentity;
		private System.Windows.Forms.TextBox txtDealerPhone;
		private System.Windows.Forms.TextBox txtOrderNo;
		private System.Windows.Forms.TextBox txtDealerWeb;
		private System.Windows.Forms.DateTimePicker dtpOrderDate;
		private System.Windows.Forms.DateTimePicker dtpBillDate;
		private System.Windows.Forms.TextBox txtCustomerAddress;
		private System.Windows.Forms.TextBox txtCustomerTaxIdentity;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtProductNo;
		private System.Windows.Forms.Label lblUnit;
		private System.Windows.Forms.Label lblProductNo;
		private System.Windows.Forms.Label lblProductTitle;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel pnlDataGrid;
		private System.Windows.Forms.DataGridView dgvAddedProducts;
		private System.Windows.Forms.Label lblGridTitle;
		private System.Windows.Forms.Panel pnlCalculation;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblGrandTotal;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lblVat;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.TextBox txtSubTotal;
		private System.Windows.Forms.Label lblSubTotal;
		private System.Windows.Forms.Label lblCalculationTitle;
		private System.Windows.Forms.Button btnSave;
	}
}