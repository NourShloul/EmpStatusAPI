using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpStatusAPI.Models
{
    public class DataAccess
    {
        private EmpDBEntities db = new EmpDBEntities();

        // جلب المستخدم بناءً على الرقم الوطني
        public User GetUserByNAT(int nat)
        {
            return db.Users.FirstOrDefault(u => u.NationalNumber == nat);
        }

        // جلب جميع الرواتب لموظف معين
        public List<int> GetSalariesByUserId(int userId)
        {
            return db.Salaries.Where(s => s.UserID == userId).Select(s => s.SalaryAmount).ToList();
        }
    }

}