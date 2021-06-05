using System;
using System.Collections.Generic;
using System.Text;

namespace UPT.Common.VModels
{
    public class SubscriptionsVM:BaseVM
    {
        public string SubscribeName { get; set; }
        public string SubscribeDesc { get; set; }
        public string InvoiceNo { get; set; } //Fatura No
        public bool IsActive { get; set; }
        public string UserId { get; set; }
        public UsersVM UsersVM { get; set; }
    }
}
