using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entityframework_CodeFirst.Models
{
    public partial class Role
    {
        [Key]
        public int RoleId { get; set; }

        [StringLength(20)]
        public string RoleName { get; set; }
    }
}
