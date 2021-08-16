
namespace E_document.UI
{
	partial class frmInvoices
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
			this.dgvInvoices = new System.Windows.Forms.DataGridView();
			this.lblViewCheck = new System.Windows.Forms.Label();
			this.lblNotValid = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnView = new E_document.ButtonControls.RJButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInvoices
			// 
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.AllowUserToDeleteRows = false;
			this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			resources.ApplyResources(this.dgvInvoices, "dgvInvoices");
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.ReadOnly = true;
			this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
			// 
			// lblViewCheck
			// 
			resources.ApplyResources(this.lblViewCheck, "lblViewCheck");
			this.lblViewCheck.Name = "lblViewCheck";
			// 
			// lblNotValid
			// 
			resources.ApplyResources(this.lblNotValid, "lblNotValid");
			this.lblNotValid.Name = "lblNotValid";
			// 
			// richTextBox1
			// 
			resources.ApplyResources(this.richTextBox1, "richTextBox1");
			this.richTextBox1.Name = "richTextBox1";
			// 
			// btnView
			// 
			this.btnView.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
			this.btnView.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnView.BorderRadius = 10;
			this.btnView.BorderSize = 0;
			this.btnView.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnView, "btnView");
			this.btnView.ForeColor = System.Drawing.Color.White;
			this.btnView.Name = "btnView";
			this.btnView.TextColor = System.Drawing.Color.White;
			this.btnView.UseVisualStyleBackColor = false;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// frmInvoices
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lblNotValid);
			this.Controls.Add(this.lblViewCheck);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.dgvInvoices);
			this.Name = "frmInvoices";
			this.Load += new System.EventHandler(this.frmInvoices_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvInvoices;
		private ButtonControls.RJButton btnView;
		private System.Windows.Forms.Label lblViewCheck;
		private System.Windows.Forms.Label lblNotValid;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}