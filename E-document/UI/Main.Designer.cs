
namespace E_document.UI
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnEn = new System.Windows.Forms.Button();
			this.btnDe = new System.Windows.Forms.Button();
			this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
			this.lblExit = new System.Windows.Forms.Label();
			this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
			this.lblMinimized = new System.Windows.Forms.Label();
			this.BtnSettings = new E_document.ButtonControls.RJButton();
			this.btnAddressBook = new E_document.ButtonControls.RJButton();
			this.btnCreateInvoice = new E_document.ButtonControls.RJButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// btnEn
			// 
			resources.ApplyResources(this.btnEn, "btnEn");
			this.btnEn.FlatAppearance.BorderSize = 0;
			this.btnEn.Name = "btnEn";
			this.btnEn.UseVisualStyleBackColor = true;
			this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
			// 
			// btnDe
			// 
			resources.ApplyResources(this.btnDe, "btnDe");
			this.btnDe.FlatAppearance.BorderSize = 0;
			this.btnDe.Name = "btnDe";
			this.btnDe.UseVisualStyleBackColor = true;
			this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
			// 
			// entityCommand1
			// 
			this.entityCommand1.CommandTimeout = 0;
			this.entityCommand1.CommandTree = null;
			this.entityCommand1.Connection = null;
			this.entityCommand1.EnablePlanCaching = true;
			this.entityCommand1.Transaction = null;
			// 
			// lblExit
			// 
			resources.ApplyResources(this.lblExit, "lblExit");
			this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblExit.Name = "lblExit";
			this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
			// 
			// sqLiteCommandBuilder1
			// 
			this.sqLiteCommandBuilder1.DataAdapter = null;
			this.sqLiteCommandBuilder1.QuoteSuffix = "]";
			// 
			// lblMinimized
			// 
			resources.ApplyResources(this.lblMinimized, "lblMinimized");
			this.lblMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMinimized.Name = "lblMinimized";
			this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
			// 
			// BtnSettings
			// 
			resources.ApplyResources(this.BtnSettings, "BtnSettings");
			this.BtnSettings.BackColor = System.Drawing.Color.DarkCyan;
			this.BtnSettings.BackgroundColor = System.Drawing.Color.DarkCyan;
			this.BtnSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.BtnSettings.BorderRadius = 15;
			this.BtnSettings.BorderSize = 0;
			this.BtnSettings.FlatAppearance.BorderSize = 0;
			this.BtnSettings.ForeColor = System.Drawing.Color.White;
			this.BtnSettings.Name = "BtnSettings";
			this.BtnSettings.TextColor = System.Drawing.Color.White;
			this.BtnSettings.UseVisualStyleBackColor = false;
			this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
			// 
			// btnAddressBook
			// 
			resources.ApplyResources(this.btnAddressBook, "btnAddressBook");
			this.btnAddressBook.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnAddressBook.BackgroundColor = System.Drawing.Color.LightSeaGreen;
			this.btnAddressBook.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnAddressBook.BorderRadius = 15;
			this.btnAddressBook.BorderSize = 0;
			this.btnAddressBook.FlatAppearance.BorderSize = 0;
			this.btnAddressBook.ForeColor = System.Drawing.Color.White;
			this.btnAddressBook.Name = "btnAddressBook";
			this.btnAddressBook.TextColor = System.Drawing.Color.White;
			this.btnAddressBook.UseVisualStyleBackColor = false;
			this.btnAddressBook.Click += new System.EventHandler(this.btnAddressBook_Click);
			// 
			// btnCreateInvoice
			// 
			resources.ApplyResources(this.btnCreateInvoice, "btnCreateInvoice");
			this.btnCreateInvoice.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnCreateInvoice.BackgroundColor = System.Drawing.Color.MediumTurquoise;
			this.btnCreateInvoice.BorderColor = System.Drawing.Color.Black;
			this.btnCreateInvoice.BorderRadius = 15;
			this.btnCreateInvoice.BorderSize = 0;
			this.btnCreateInvoice.FlatAppearance.BorderSize = 0;
			this.btnCreateInvoice.ForeColor = System.Drawing.Color.White;
			this.btnCreateInvoice.Name = "btnCreateInvoice";
			this.btnCreateInvoice.TextColor = System.Drawing.Color.White;
			this.btnCreateInvoice.UseVisualStyleBackColor = false;
			this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
			// 
			// Main
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lblMinimized);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.BtnSettings);
			this.Controls.Add(this.btnAddressBook);
			this.Controls.Add(this.btnCreateInvoice);
			this.Controls.Add(this.btnDe);
			this.Controls.Add(this.btnEn);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btnEn;
		private System.Windows.Forms.Button btnDe;
		private ButtonControls.RJButton btnCreateInvoice;
		private ButtonControls.RJButton btnAddressBook;
		private ButtonControls.RJButton BtnSettings;
		private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
		private System.Windows.Forms.Label lblExit;
		private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
		private System.Windows.Forms.Label lblMinimized;
	}
}