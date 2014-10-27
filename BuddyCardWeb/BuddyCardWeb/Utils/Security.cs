using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayPal;
using PayPal.Api.Payments;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PayPal.Util;

namespace BuddyCardWeb.Utils
{
	public static class Security
	{
		private static string _accessToken;
		public static string AccessToken
		{
			get
			{
				// TODO need to cache this
				// Get a reference to the config
				var config = PayPal.Manager.ConfigManager.Instance.GetProperties();

				// Read the clientId and clientSecret stored in the config
				var clientId = config[BaseConstants.ClientId];
				var clientSecret = config[BaseConstants.ClientSecret];

				// Use OAuthTokenCredential to request an access token from PayPal
				_accessToken = new OAuthTokenCredential(clientId, clientSecret, config).GetAccessToken();
				return _accessToken;
			}
		}
	}
}