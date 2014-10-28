namespace BuddyCardWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCard")]
    public partial class CreditCard
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Vendor { get; set; }

        [StringLength(5)]
        public string CVV { get; set; }

        [StringLength(3000)]
        public string Address1 { get; set; }

        [StringLength(8)]
        public string ZipCode { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        public DateTime? Expiration { get; set; }

        [StringLength(255)]
        public string CreditCardNumber { get; set; }

        [StringLength(50)]
        public string PaypalId { get; set; }
    }
}
