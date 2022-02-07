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
    public class AdminController : ControllerBase
    {
        private AdminServices _adminService;
        public AdminController(AdminServices adminService)
        {
            _adminService = adminService;
        }
        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _adminService.GetEmployees();
        }
        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            _adminService.AddEmployee(employee);
            return Ok("Employee details added successfully!!");
        }
        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int empId)
        {
            _adminService.DeleteEmployee(empId);
            return Ok("Employee deleted successfully!!");
        }
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _adminService.UpdateEmployee(employee);
            return Ok("Employee updated successfully!!");
        }
        [HttpGet("GetEmployeeByID")]
        public Employee GetEmployeeByID(int empID)
        {
            return _adminService.GetEmployeeByID(empID);
        }


        [HttpGet("GetProjects")]
        public IEnumerable<Project> GetProjects()
        {
            return _adminService.GetProjects();
        }
        [HttpPost("AddProject")]
        public IActionResult AddProject([FromBody] Project project)
        {
            _adminService.AddProject(project);
            return Ok("Project details added successfully!!");
        }
        [HttpDelete("DeleteProject")]
        public IActionResult DeleteProject(int projID)
        {
            _adminService.DeleteProject(projID);
            return Ok("Project deleted successfully!!");
        }
        [HttpPut("UpdateProject")]
        public IActionResult UpdateProject([FromBody] Project project)
        {
            _adminService.UpdateProject(project);
            return Ok("Project updated successfully!!");
        }
        [HttpGet("GetProjectByID")]
        public Project GetProjectByID(int projID)
        {
            return _adminService.GetProjectByID(projID);
        }
    }
}
