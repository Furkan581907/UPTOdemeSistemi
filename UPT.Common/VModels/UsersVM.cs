using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UPT.Common.VModels
{
    public class UsersVM
    {
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string AccountType { get; set; } // Abone-Gişe Görevlisi
        [Required]
        public string SubsType { get; set; } // Bireysel,Tüzel
        public long? TCNumber { get; set; }
        public long? TaxNumber { get; set; } // vergi no
        [Required]
        public int? CreateUserId { get; set; }
        public DateTime CreateUserTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateUserTime { get; set; }
    }
}
