using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayPal;
using PayPal.Api.Payments;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PayPal.Util;
using BuddyCard.Models;

namespace BuddyCard.Providers
{
	public class FundingAccountProvider
	{
		public List<FundingAccount> GetAllFundingAccounts()
		{
			// See [Configuration.cs](/Source/Configuration.html) to know more about APIContext..
			APIContext apiContext = Configuration.GetAPIContext();

			Dictionary<string, string> parameters = new Dictionary<string, string>();
			parameters.Add("count", "10");
			parameters.Add("startIndex", "0");

			PayPal.Api.Payment

			// ###Retrieve
			// Retrieve the PaymentHistory by calling the
			// static `List` method
			// on the Payment resource, and pass the
			// APIContext and the map containing the query parameters 
			// for paginations and filtering.
			// Refer the API documentation
			// for valid values for keys
			PaymentHistory payHistory = Payment.List(apiContext, parameters);
			List<FundingAccount> fundingAccounts = new List<FundingAccount>();
			foreach (Payment payment in payHistory.payments)
			{
				FundingAccount fa = new FundingAccount()
				{
					Name = payment.id
				};
				fundingAccounts.Add(fa);
			}
			
			return fundingAccounts;
		}
	}
}