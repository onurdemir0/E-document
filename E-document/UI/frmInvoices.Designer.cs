
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
			this.lblBillId = new System.Windows.Forms.Label();
			this.btnView = new E_document.ButtonControls.RJButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInvoices
			// 
			resources.ApplyResources(this.dgvInvoices, "dgvInvoices");
			this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
			// 
			// lblBillId
			// 
			resources.ApplyResources(this.lblBillId, "lblBillId");
			this.lblBillId.Name = "lblBillId";
			// 
			// btnView
			// 
			resources.ApplyResources(this.btnView, "btnView");
			this.btnView.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
			this.btnView.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnView.BorderRadius = 10;
			this.btnView.BorderSize = 0;
			this.btnView.FlatAppearance.BorderSize = 0;
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
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.lblBillId);
			this.Controls.Add(this.dgvInvoices);
			this.Name = "frmInvoices";
			this.Load += new System.EventHandler(this.frmInvoices_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvInvoices;
		private System.Windows.Forms.Label lblBillId;
		private ButtonControls.RJButton btnView;
	}
}