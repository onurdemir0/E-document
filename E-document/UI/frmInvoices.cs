using E_document.DAL;
using E_document.Entities;
using E_document.FileHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_document.UI
{
	public partial class frmInvoices : Form
	{
		BaseDal baseDal = new BaseDal();
		Bill bill = new Bill();

		public frmInvoices()
		{
			InitializeComponent();
		}

		private void LoadData()
		{
			DataTable dt = baseDal.LoadData("select * from Bills");
			dgvInvoices.DataSource = dt;
			//dgvInvoices.Columns[1].HeaderText = lblBillId.Text;
		}
		private void frmInvoices_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bill.XmlString = dgvInvoices.SelectedRows[0].Cells[44].Value.ToString();
		}

		private void btnView_Click(object sender, EventArgs e)
		{
			//const string xsltString = @" ";

			//Transform.TransformXMLToHTML(bill.XmlString, xsltString);

			if (bill.XmlString == null)
			{
				MessageBox.Show("Please select the invoice you want to view");

			}
			else if (bill.XmlString == "")
			{
				MessageBox.Show("Please select a valid invoice");
			}
			else
			{
				MessageBox.Show(bill.XmlString);
			}
		}
	}
}
