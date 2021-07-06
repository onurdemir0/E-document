using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_document.Entities
{
	public class Dealer
	{
		public int SettingId { get; set; }
		public string CompanyName { get; set; }
		public string Email { get; set; }
		public string Mobile { get; set; }
		public string WebSite { get; set; }
		public string TaxAuthority { get; set; }
		public string TaxIdentity { get; set; }
		public string FirstAddressLine { get; set; }
		public string SecondAddressLine { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
	}
}
