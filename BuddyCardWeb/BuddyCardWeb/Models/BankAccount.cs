using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayPal;
using PaypalModels = PayPal.Api.Payments;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PayPal.Util;

namespace BuddyCardWeb.Models
{
	public class BankAccount
	{
		public int BuddyId { get; set; }

		public string account_name { get; set; }
		public string account_number { get; set; }
		public string account_number_type { get; set; }
		public string account_type { get; set; }
		public string auth_capture_timestamp { get; set; }
		public string auth_type { get; set; }
		public string bank_name { get; set; }
		public string billing_address { get; set; }
		public string birth_date { get; set; }
		public string check_type { get; set; }
		public string confirmation_status { get; set; }
		public string country_code { get; set; }
		public string create_time { get; set; }
		public string external_customer_id { get; set; }
		public string first_name { get; set; }
		public string id { get; set; }
		public string last_name { get; set; }
		public string merchant_id { get; set; }
		public string payer_id { get; set; }
		public string routing_number { get; set; }
		public string state { get; set; }
		public string update_time { get; set; }
		public string valid_until { get; set; }
		public int PaypalId { get; set; }

	}
}