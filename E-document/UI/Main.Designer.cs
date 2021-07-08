
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
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.createBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addressBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStripTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripTop
			// 
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBillToolStripMenuItem,
            this.addressBookToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(691, 24);
			this.menuStripTop.TabIndex = 0;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// createBillToolStripMenuItem
			// 
			this.createBillToolStripMenuItem.Name = "createBillToolStripMenuItem";
			this.createBillToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.createBillToolStripMenuItem.Text = "Create Invoice";
			this.createBillToolStripMenuItem.Click += new System.EventHandler(this.createBillToolStripMenuItem_Click);
			// 
			// addressBookToolStripMenuItem
			// 
			this.addressBookToolStripMenuItem.Name = "addressBookToolStripMenuItem";
			this.addressBookToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.addressBookToolStripMenuItem.Text = "Address Book";
			this.addressBookToolStripMenuItem.Click += new System.EventHandler(this.addressBookToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(679, 395);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 436);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStripTop);
			this.MainMenuStrip = this.menuStripTop;
			this.Name = "Main";
			this.Text = "MDP Group";
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.ToolStripMenuItem createBillToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addressBookToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}