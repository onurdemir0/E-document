using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_document.Entities
{
	public class Calculation
	{
		public int id { get; set; }
		public int BillId { get; set; }
		public decimal SubTotal { get; set; }
		public decimal CalculatedVAT { get; set; }
		public decimal IncludingTaxes { get; set; }
		public decimal GrandTotal { get; set; }
	}
}
