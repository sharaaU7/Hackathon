using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuddyCardWeb.Models
{
	public class CreditCardList
	{
		public int Id { get; set; }
		public CreditCard[] Cards { get; set; }
	}
}