using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UPT.Common.VModels
{
    public class BaseVM
    {
        [Key]
        public int Id { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime CreateUserTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateUserTime { get; set; }
    }
}
