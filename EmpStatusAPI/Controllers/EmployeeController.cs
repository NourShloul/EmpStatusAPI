using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmpStatusAPI.Models;
namespace EmpStatusAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private ProcessStatus processStatus = new ProcessStatus();

        [HttpGet]
        [Route("api/Employee/GetEmpStatus/{nat}")]
        public IHttpActionResult GetEmpStatus(int nat)
        {
            var empInfo = processStatus.GetEmpStatus(nat);
            if (empInfo == null)
            {
                return NotFound(); // إذا لم يكن الرقم الوطني موجودًا
            }
            return Ok(empInfo);
        }
    }

}
