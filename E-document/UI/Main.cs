using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using E_document.Entities;
using System.Threading;
using System.Runtime.InteropServices;

namespace E_document.UI
{
	public partial class Main : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
		   int nLeftRect,  
		   int nTopRect,      
		   int nRightRect,    
		   int nBottomRect,  
		   int nWidthEllipse, 
		   int nHeightEllipse 
		);
		public Main()
		{
			InitializeComponent();
			this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}

		private void btnDe_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");

			this.Controls.Clear();
			InitializeComponent();
		}

		private void btnEn_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

			this.Controls.Clear();
			InitializeComponent();
		}

		private void btnCreateInvoice_Click(object sender, EventArgs e)
		{
			frmCreateBill createBill = new frmCreateBill();
			createBill.Show();
		}

		private void btnAddressBook_Click(object sender, EventArgs e)
		{
			frmAddressBook addressBook = new frmAddressBook();
			addressBook.Show();
		}

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			frmSettings settings = new frmSettings();
			settings.Show();
		}

		private void lblExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void lblMinimized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}


		Point lastPoint;
		private void Main_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void Main_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void Main_Load(object sender, EventArgs e)
		{

		}
	}
}
