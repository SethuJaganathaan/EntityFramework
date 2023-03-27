using System;
using System.Collections.Generic;

namespace EFdummy.Entities
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public DateTime? Dob { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
