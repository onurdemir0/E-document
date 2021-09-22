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

			//xsltString = Transformer.EncodeTo64(xsltString);

			if (bill.XmlString == null)
			{
				MessageBox.Show(lblViewCheck.Text);
			}
			else if (bill.XmlString == "")
			{
				MessageBox.Show(lblNotValid.Text);
			}
			else
			{
				MessageBox.Show(bill.XmlString);
				//richTextBox1.Text = bill.XmlString;

				//string htmlString = Transformer.TransformXMLToHTML(bill.XmlString, box, encoded, removePreambles, barcode, showAttachments);
				string html = Transformer.TransformXMLToHTM(bill.XmlString, xsltString);

				//MessageBox.Show(html);
				richTextBox1.Text = html;


				SaveFileDialog save = new SaveFileDialog();
				save.Filter = "PDF File|*.pdf";
				save.OverwritePrompt = true;
				save.CreatePrompt = true;

				if (save.ShowDialog() == DialogResult.OK)
				{
					StreamWriter streamWriter = new StreamWriter(save.FileName);
					streamWriter.WriteLine(xmlString);
					MessageBox.Show("Successfully Created!");

					streamWriter.Close();
				}
			}			
		}
	}
}