using EmployeePOC.WebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePOC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

       IEmployeeRepository _empRepository;
       public EmployeeController(IEmployeeRepository empRepository)
       {
                _empRepository = empRepository;
       
        }
       [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] EmployeeTable empmodel)
        {
                _empRepository.AddEmployee(empmodel);
            return Ok("Employee created successfully!!");
        }
        [HttpGet("GetEmployeeByID")]
        public EmployeeTable GetEmployeeById(int EmpId)
        {
            return _empRepository.GetEmployeeById(EmpId);

        }
        [HttpGet("UpdateEmployee")]
        public EmployeeTable UpdateEmployee(int EmpId)
        {
            return _empRepository.UpdateEmployee(EmpId);

        }
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] EmployeeTable empmodel)
        {
                _empRepository.UpdateEmployee(empmodel);
            return Ok("Employee updated successfully!!");
        }
        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int EmpID)
        {
                _empRepository.DeleteEmployee(EmpID);
            return Ok("Employee deleted successfully!!");
        }
        [HttpGet("GetEmployees")]
        public IEnumerable<EmployeeTable> GetEmployees()
        {
            return _empRepository.GetEmployees();
        }


    }
}

