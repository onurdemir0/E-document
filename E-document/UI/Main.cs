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
		frmCreateBill createBill;
		frmAddressBook addressBook;
		frmSettings settings;
		frmInvoices invoices;


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

		//public static string DefaultLanguage = "en";
		private void Main_Load(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
		}

		private void btnDe_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");

			//DefaultLanguage = "German";

			this.Controls.Clear();
			InitializeComponent();
		}

		private void btnEn_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

			this.Controls.Clear();
			InitializeComponent();
		}

		private bool CheckOpened(string formName)
		{
			FormCollection formCollection = Application.OpenForms;

			foreach (Form form in formCollection)
			{
				if (form.Text == formName)
				{
					return true;
				}
			}
			return false;
		}

		private void FormSet(Form form)
		{
			form.WindowState = FormWindowState.Normal;
			form.Dock = DockStyle.Fill;
			form.Show();
			form.Focus();
		}

		//private void OpenForm(Form form)
		//{
		//	if (form == null || form.Text == "")
		//	{
		//		form = new Form();
		//		form.Show();
		//	}

		//	else if (CheckOpened(form.Text))
		//	{
		//		form.WindowState = FormWindowState.Normal;
		//		form.Dock = DockStyle.Fill;
		//		form.Show();
		//		form.Focus();
		//	}
		//}

		private void btnCreateInvoice_Click(object sender, EventArgs e)
		{
			if (createBill == null || createBill.Text == "")
			{
				createBill = new frmCreateBill();
				createBill.Show();
			}

			else if (CheckOpened(createBill.Text))
			{
				FormSet(createBill);
			}

			//OpenForm(createBill);
		}

		private void btnAddressBook_Click(object sender, EventArgs e)
		{
			if (addressBook == null || addressBook.Text == "")
			{
				addressBook = new frmAddressBook();
				addressBook.Show();
			}

			else if (CheckOpened(addressBook.Text))
			{
				FormSet(addressBook);
			}
		}

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			if (settings == null || settings.Text == "")
			{
				settings = new frmSettings();
				settings.Show();
			}
			else if (CheckOpened(settings.Text))
			{
				FormSet(settings);
			}
		}

		private void btnInvoices_Click(object sender, EventArgs e)
		{
			if (invoices == null || invoices.Text == "")
			{
				invoices = new frmInvoices();
				invoices.Show();
			}
			else if (CheckOpened(invoices.Text))
			{
				FormSet(invoices);
			}
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
	}
}
