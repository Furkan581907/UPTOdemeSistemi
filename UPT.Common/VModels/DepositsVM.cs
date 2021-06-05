using System;
using System.Collections.Generic;
using System.Text;

namespace UPT.Common.VModels
{
    public class DepositsVM:BaseVM
    {
        public string UserId { get; set; }
        public UsersVM Users { get; set; }
        public int SubscriptionId { get; set; }
        public SubscriptionsVM SubscriptionsVM { get; set; }
        public decimal ReturnedTotal { get; set; }
    }
}
