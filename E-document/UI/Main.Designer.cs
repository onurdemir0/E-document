
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
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.createBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addressBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGet = new System.Windows.Forms.Button();
			this.menuStripTop.SuspendLayout();
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
			this.menuStripTop.Size = new System.Drawing.Size(768, 24);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(215, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(334, 104);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(75, 23);
			this.btnGet.TabIndex = 3;
			this.btnGet.Text = "button1";
			this.btnGet.UseVisualStyleBackColor = true;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 507);
			this.Controls.Add(this.btnGet);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStripTop);
			this.MainMenuStrip = this.menuStripTop;
			this.Name = "Main";
			this.Text = "MDP Group";
			this.Load += new System.EventHandler(this.Main_Load);
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.ToolStripMenuItem createBillToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.ToolStripMenuItem addressBookToolStripMenuItem;
	}
}