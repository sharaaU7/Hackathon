namespace BuddyCardWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserData")]
    public partial class UserData
    {
        [Key]
        [StringLength(50)]
        public string UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public int? AccountType { get; set; }
    }
}
