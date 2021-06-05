using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace UPT.DataAccess.DbModels
{
    public class Users:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountType { get; set; } // Abone-Gişe Görevlisi
        public string SubsType { get; set; } // Bireysel,Tüzel
        public long? TCNumber { get; set; }
        public long? TaxNumber { get; set; } // vergi no
        public int? CreateUserId { get; set; }
        public DateTime CreateUserTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateUserTime { get; set; }

    }
}
