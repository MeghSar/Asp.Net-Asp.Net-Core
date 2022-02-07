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
    public class EmployeeController : ControllerBase
    {
        private EmployeeServices _employeeServices;
        public EmployeeController(EmployeeServices employeeService)
        {
            _employeeServices = employeeService;
        }
        [HttpPost("AddEmployee")]
        public IActionResult AddTimeSheet([FromBody] TimeSheet timesheet)
        {
            _employeeServices.AddTimeSheet(timesheet);
            return Ok("Timesheet created successfully!!");
        }
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateTimeSheet([FromBody] TimeSheet employee)
        {
            _employeeServices.UpdateTimeSheet(employee);
            return Ok("Timesheet updated successfully!!");
        }
        [HttpDelete("DeleteTimeSheet")]
        public IActionResult DeleteTimeSheet(int projID)
        {
            _employeeServices.DeleteTimeSheet(projID);
            return Ok("Timesheet deleted successfully!!");
        }
    }
}
