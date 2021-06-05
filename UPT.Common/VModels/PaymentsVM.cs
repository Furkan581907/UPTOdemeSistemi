using System;
using System.Collections.Generic;
using System.Text;

namespace UPT.Common.VModels
{
    public class PaymentsVM:BaseVM
    {
        public string PayingId { get; set; } // Ödeyen Id
        public UsersVM PayingVM { get; set; }
        public int PayerId { get; set; } // Ödemeyi gişe mi kendi mi yapmış. Kendi ise payingId, değil ise UserId
        public UsersVM PayerVM { get; set; }
        public string PayType { get; set; } // Kredi kartı, Nakit, Havale
        public int SubscriptionId { get; set; }
        public SubscriptionsVM SubscriptionsVM { get; set; }
        public decimal Total { get; set; }
    }
}
