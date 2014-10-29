namespace BuddyCardWeb.Models
	{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class PaymentModel : DbContext
		{
		public PaymentModel ( )
			: base("name=PaymentModel")
			{
			}

		public virtual DbSet<BankAccount> BankAccounts { get; set; }
		public virtual DbSet<CreditCard> CreditCards { get; set; }
		public virtual DbSet<UserData> UserDatas { get; set; }

		protected override void OnModelCreating ( DbModelBuilder modelBuilder )
			{
			modelBuilder.Entity<BankAccount>()
				.Property(e => e.account_name)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.account_number)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.account_number_type)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.account_type)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.auth_capture_timestamp)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.auth_type)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.bank_name)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.birth_date)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.check_type)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.confirmation_status)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.country_code)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.create_time)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.external_customer_id)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.first_name)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.last_name)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.merchant_id)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.payer_id)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.routing_number)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.state)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.update_time)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.valid_until)
				.IsUnicode(false);

			modelBuilder.Entity<BankAccount>()
				.Property(e => e.PaypalId)
				.IsUnicode(false);

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

			modelBuilder.Entity<CreditCard>()
				.Property(e => e.UserId)
				.IsUnicode(false);

			modelBuilder.Entity<UserData>()
				.Property(e => e.UserId)
				.IsUnicode(false);

			modelBuilder.Entity<UserData>()
				.Property(e => e.Password)
				.IsUnicode(false);
			}
		}
	}
