﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ASP.NETCoreWebAPI.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
