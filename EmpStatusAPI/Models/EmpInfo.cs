using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpStatusAPI.Models
{
    public class EmpInfo
    {
        public string Username { get; set; }
        public int NationalNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public int HighestSalary { get; set; }
        public double AverageSalary { get; set; }
        public string Status { get; set; }
    }

}