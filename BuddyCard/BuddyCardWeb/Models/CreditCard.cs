using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuddyCardWeb.Models
{
	public class CreditCard
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Vendor { get; set; }

		public string CVV { get; set; }

		public decimal Balance { get; set; }

		public DateTime Expiration { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string PaypalId { get; set; }
	}
}