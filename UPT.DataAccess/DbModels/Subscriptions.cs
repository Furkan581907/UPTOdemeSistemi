using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UPT.DataAccess.DbModels
{
    public class Subscriptions:BaseEntity
    {
        public string SubscribeName { get; set; }
        public string SubscribeDesc { get; set; }
        public string InvoiceNo { get; set; } //Fatura No
        public bool IsActive { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public Users Users { get; set; }
    }
}
