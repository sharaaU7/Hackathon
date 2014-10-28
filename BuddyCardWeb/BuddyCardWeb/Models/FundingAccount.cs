namespace BuddyCardWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FundingAccount
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public decimal? Balance { get; set; }

        [StringLength(80)]
        public string PaypalId { get; set; }
    }
}
