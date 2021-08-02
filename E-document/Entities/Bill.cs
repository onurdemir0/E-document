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
		public int CustomerId { get; set; }
		public int SettingsId { get; set; }
		public string Ettn { get; set; }
		public string Type { get; set; }
		public DateTime BillDate { get; set; }
		public string BillType { get; set; }
		public string Currency { get; set; }
		public string OrderNo { get; set; }
		public DateTime OrderDate { get; set; }
		public string WayBillNo { get; set; }
		public DateTime WayBillDate { get; set; }
		public string Note { get; set; }

		public string TinNin { get; set; }
		public string Title { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string RoadStreet { get; set; }
		public string ApartmentName { get; set; }
		public string ApartmentNo { get; set; }
		public string Floor { get; set; }
		public string Town { get; set; }
		public string District { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
		public string WebSite { get; set; }
		public string TaxAuthority { get; set; }

		public string CompanyName { get; set; }
		public string CompanyEmail { get; set; }
		public string CompanyMobile { get; set; }
		public string CompanyWebSite { get; set; }
		public string CompanyTaxAuthority { get; set; }
		public string CompanyTaxIdentity { get; set; }
		public string FirstAddressLine { get; set; }
		public string SecondAddressLine { get; set; }
		public string CompanyCity { get; set; }
		public string CompanyState { get; set; }
		public string CompanyZip { get; set; }
		public string CompanyCountry { get; set; }

		public string PayeeAccount { get; set; }
		public string XmlString { get; set; }
	}
}
