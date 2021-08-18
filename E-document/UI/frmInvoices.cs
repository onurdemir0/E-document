using E_document.DAL;
using E_document.Entities;
using E_document.FileHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

		string box = "";
		Boolean encoded = false;
		bool removePreambles = true;
		string barcode = "";
		bool showAttachments = true;

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
			try
			{
				bill.XmlString = dgvInvoices.Rows[e.RowIndex].Cells[44].Value.ToString();
			}
			catch (Exception)
			{
				return;
			}
		}

		private void btnView_Click(object sender, EventArgs e)
		{
			string xmlString = bill.XmlString;
			string xsltString = File.ReadAllText("sablon.xslt");

			xsltString = Transformer.EncodeTo64(xsltString);

			if (bill.XmlString == null)
			{
				MessageBox.Show(lblViewCheck.Text);
			}
			else if (bill.XmlString == "")
			{
				//MessageBox.Show("Please select a valid invoice");
				MessageBox.Show(lblNotValid.Text);
			}
			else
			{
				MessageBox.Show(bill.XmlString);
				//string htmlString = Transformer.TransformXMLToHTML(xmlString, box, encoded, removePreambles, barcode, showAttachments);
				//MessageBox.Show(htmlString);
			}			
		}
	}
}