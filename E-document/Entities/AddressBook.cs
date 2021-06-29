using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_document.Entities
{
	public class AddressBook
	{
		public int AddressBookId { get; set; }
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
	}
}
