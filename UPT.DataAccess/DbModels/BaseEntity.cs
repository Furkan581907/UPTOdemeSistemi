using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UPT.DataAccess.DbModels
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime CreateUserTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateUserTime { get; set; }
    }
}
