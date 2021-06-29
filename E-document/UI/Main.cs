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

namespace E_document.UI
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}
		public SQLiteConnection sql_con;
		public SQLiteCommand sql_cmd;
		public SQLiteDataAdapter DB;
		public DataSet DS = new DataSet();
		public DataTable DT = new DataTable();

		//Settings settings = new Settings();
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			label1.Text = Settings.CompanyName;
		}

		public void SetConnection()
		{
			sql_con = new SQLiteConnection(@"Data Source=C:\EDocument\E_Document.db;Version=3;New=False;Compress=True;");
		}

		public void ExecuteQuery(string txtQuery)
		{
			SetConnection();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSettings settings = new frmSettings();
			settings.Show();
		}

		private void createBillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCreateBill createBill = new frmCreateBill();
			createBill.Show();
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			label2.Text = Settings.Country;
		}

		private void addressBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddressBook addressBook = new frmAddressBook();
			addressBook.Show();
		}
	}
}
