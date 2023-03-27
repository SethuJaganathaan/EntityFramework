using System;
using System.Collections.Generic;

namespace EFdummy.Entities
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentIncharge { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
