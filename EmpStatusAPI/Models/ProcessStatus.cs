using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpStatusAPI.Models
{
    public class ProcessStatus
    {
        private DataAccess dataAccess = new DataAccess();

        public EmpInfo GetEmpStatus(int nat)
        {
            var user = dataAccess.GetUserByNAT(nat);

            if (user == null)
            {
                return null;
            }

            var salaries = dataAccess.GetSalariesByUserId(user.ID);
            int highestSalary = salaries.Any() ? salaries.Max() : 0;
            double avgSalary = salaries.Any() ? salaries.Average() : 0;
            int totalSalary = salaries.Any() ? salaries.Sum() : 0;

            string status = totalSalary > 2000 ? "GREEN" :
                            totalSalary < 2000 ? "RED" : "ORANGE";

            return new EmpInfo
            {
                Username = user.Username,
                NationalNumber = user.NationalNumber,
                Email = user.Email,
                Phone = user.Phone,
                IsActive = user.IsActive,
                HighestSalary = highestSalary,
                AverageSalary = avgSalary,
                Status = status
            };
        }
    }

}
