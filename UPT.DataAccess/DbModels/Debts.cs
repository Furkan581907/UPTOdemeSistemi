using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UPT.DataAccess.DbModels
{
    public class Debts:BaseEntity
    {
        public int SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public Subscriptions Subscriptions { get; set; }
        public DateTime BillingDate { get; set; } //Fatura Kesim Tarihi
        public DateTime DueDate { get; set; } //Son Ödeme Tarihi
        public decimal Total { get; set; }
        public bool DueDateIsActive { get; set; } //Fatura Ödeme Durumu
    }
}
