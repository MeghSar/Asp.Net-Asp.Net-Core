using EmployeeTable.BL.Services;
using EmployeeTable.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTableWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private EmpServices _empServices;
        public EmpController(EmpServices empServices)
        {
            _empServices = empServices;
        }
        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] EmployeeModel empmodel)
        {
            _empServices.AddEmployee(empmodel);
            return Ok("Employee created successfully!!");
        }
        [HttpGet("GetEmployeeByID")]
        public EmployeeModel GetEmployeeByID(int EmpID)
        {
            return _empServices.GetEmployeeByID(EmpID);

        }
        [HttpGet("UpdateEmployee")]
        public EmployeeModel UpdateEmployee(int EmpID)
        {
            return _empServices.UpdateEmployee(EmpID);

        }
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] EmployeeModel empmodel)
        {
            _empServices.UpdateEmployee(empmodel);
            return Ok("Employee updated successfully!!");
        }
        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int EmpID)
        {
            _empServices.DeleteEmployee(EmpID);
            return Ok("Employee deleted successfully!!");
        }
        [HttpGet("GetEmployees")]
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _empServices.GetEmployees();
        }
    }
}
