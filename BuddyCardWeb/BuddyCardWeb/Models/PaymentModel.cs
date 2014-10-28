namespace BuddyCardWeb.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class PaymentModel : DbContext
	{
		public PaymentModel()
			: base("name=PaymentModel")
		{
		}

		public virtual DbSet<CreditCard> CreditCards { get; set; }
		public virtual DbSet<FundingAccount> FundingAccounts { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CreditCard>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.Vendor)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.CVV)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.Address1)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.ZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.CreditCardNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.PaypalId)
				.IsUnicode(false);

			modelBuilder.Entity<FundingAccount>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<FundingAccount>()
				.Property(e => e.Balance)
				.HasPrecision(38, 10);

			modelBuilder.Entity<FundingAccount>()
				.Property(e => e.PaypalId)
				.IsUnicode(false);
		}
	}
}
