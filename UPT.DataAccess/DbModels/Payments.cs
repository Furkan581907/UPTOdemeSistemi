using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UPT.DataAccess.DbModels
{
    public class Payments:BaseEntity
    {
        public string PayingId { get; set; } // Ödeyen Id
        [ForeignKey("PayingId")]
        public Users Paying { get; set; }
        public int PayerId { get; set; } // Ödemeyi gişe mi kendi mi yapmış. Kendi ise payingId, değil ise UserId
        public Users Payer { get; set; }
        public string PayType { get; set; } // Kredi kartı, Nakit, Havale
        public int SubscriptionId { get; set; }
        public Subscriptions Subscriptions { get; set; }
        public decimal Total { get; set; }
    }
}
