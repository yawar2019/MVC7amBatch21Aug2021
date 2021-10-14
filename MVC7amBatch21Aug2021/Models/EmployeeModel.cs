﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC7amBatch21Aug2021.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
       
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public bool Status { get; set; }

        public int StateId { get; set; }
    }
}