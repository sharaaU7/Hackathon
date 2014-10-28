namespace BuddyCardWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankAccount")]
    public partial class BankAccount
    {
        [StringLength(500)]
        public string account_name { get; set; }

        [StringLength(500)]
        public string account_number { get; set; }

        [StringLength(500)]
        public string account_number_type { get; set; }

        [StringLength(500)]
        public string account_type { get; set; }

        [StringLength(500)]
        public string auth_capture_timestamp { get; set; }

        [StringLength(500)]
        public string auth_type { get; set; }

        [StringLength(500)]
        public string bank_name { get; set; }

        [StringLength(500)]
        public string birth_date { get; set; }

        [StringLength(500)]
        public string check_type { get; set; }

        [StringLength(500)]
        public string confirmation_status { get; set; }

        [StringLength(500)]
        public string country_code { get; set; }

        [StringLength(500)]
        public string create_time { get; set; }

        [StringLength(500)]
        public string external_customer_id { get; set; }

        [StringLength(500)]
        public string first_name { get; set; }

        public int id { get; set; }

        [StringLength(500)]
        public string last_name { get; set; }

        [StringLength(500)]
        public string merchant_id { get; set; }

        [StringLength(500)]
        public string payer_id { get; set; }

        [StringLength(500)]
        public string routing_number { get; set; }

        [StringLength(500)]
        public string state { get; set; }

        [StringLength(500)]
        public string update_time { get; set; }

        [StringLength(500)]
        public string valid_until { get; set; }

        [StringLength(200)]
        public string PaypalId { get; set; }
    }
}
