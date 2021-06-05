using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UPT.DataAccess.DbModels
{
    public class Deposits :BaseEntity
    {
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public Users Users { get; set; }
        public int SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public Subscriptions Subscriptions { get; set; }
        public decimal ReturnedTotal { get; set; }

    }
}
