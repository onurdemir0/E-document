using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_document.Entities
{
	public class Item
	{
		public int LineNo { get; set; }
		public string ItemNo { get; set; }
		public string ItemName { get; set; }
		public int Quantity { get; set; }
		public string Unit { get; set; }
		public decimal UnitPrice { get; set; }
		public int MyProperty { get; set; }
		public int VatRate { get; set; }
		public decimal VatPrice { get; set; }
		public decimal Total { get; set; }
	}
}
