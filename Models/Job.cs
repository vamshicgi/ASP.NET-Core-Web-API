﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ASP.NETCoreWebAPI.Models
{
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
