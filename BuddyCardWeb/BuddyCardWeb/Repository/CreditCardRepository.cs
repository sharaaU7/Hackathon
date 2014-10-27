using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuddyCardWeb.Models;
using BuddyCardWeb.Utils;
using PayPal;
using PaypalModels=PayPal.Api.Payments;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PayPal.Util;

namespace BuddyCardWeb.Repository
{
	public class CreditCardRepository
	{
		public static CreditCard Create(CreditCard card)
		{
			PaypalModels.CreditCard creditCard = new PaypalModels.CreditCard();
			creditCard.expire_month = card.Expiration.Month;
			creditCard.expire_year = card.Expiration.Year;
			creditCard.number = card.CreditCardNumber;
			creditCard.type = card.Vendor;

			var apiContext = new APIContext(Security.AccessToken);
			PaypalModels.CreditCard createdCreditCard = creditCard.Create(apiContext);
			card.PaypalId = createdCreditCard.id;
			return card;
		}
	}
}