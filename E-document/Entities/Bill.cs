using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_document.Entities
{
	public class Bill
	{
		public int BillId { get; set; }
		public string Ettn { get; set; }
		public string Type { get; set; }
		public DateTime BillDate { get; set; }
		public string BillType { get; set; }
		public string Currency { get; set; }
		public string OrderNo { get; set; }
		public DateTime OrderDate { get; set; }
		public string WayBillNo { get; set; }
		public DateTime WayBillDate { get; set; }
	}
}
