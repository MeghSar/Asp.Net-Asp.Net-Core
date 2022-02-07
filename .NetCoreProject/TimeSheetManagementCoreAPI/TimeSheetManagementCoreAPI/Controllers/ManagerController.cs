using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetManagement.BAL.Services;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagementCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private ManagerServices _managerServices;
        public ManagerController(ManagerServices managerService)
        {
            _managerServices = managerService;
        }
        [HttpPut("AllocateProject")]
        public void AllocateProject([FromBody] Employee employee)
        {
            _managerServices.AllocateProject(employee);
        }

        [HttpPut("ChangeEmpPsw")]
        public void ChangeEmpPsw([FromBody] Employee employee)
        {
            _managerServices.ChangeEmpPsw(employee);
        }

        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> GetEmployees(int mgrID)
        {
            return _managerServices.GetEmployees(mgrID);
        }

        [HttpGet(" GetTimeSheetByID")]
        public TimeSheet GetTimeSheetByID(int empID)
        {
            return _managerServices.GetTimeSheetByID(empID);
        }

        [HttpPut("TimeSheetRelease")]
        public void TimeSheetRelease([FromBody] TimeSheet timeSheet)
        {
            _managerServices.TimeSheetRelease(timeSheet);
        }

    }
}
