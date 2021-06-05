using System;
using System.Collections.Generic;
using System.Text;

namespace UPT.Common.VModels
{
    public class DebtsVM : BaseVM
    {
        public int SubscriptionId { get; set; }
        public SubscriptionsVM SubscriptionsVM { get; set; }
        public DateTime BillingDate { get; set; } //Fatura Kesim Tarihi
        public DateTime DueDate { get; set; } //Son Ödeme Tarihi
        public decimal Total { get; set; }
        public bool DueDateIsActive { get; set; } //Fatura Ödeme Durumu
    }
}
