﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabasedApproach.Models
{
    public class EmpDept
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? EmpSalary { get; set; }
        public string DeptName { get; set; }
    }

    public partial class employeeDetail
    {
        public string deptName { get; set; }
    }
}