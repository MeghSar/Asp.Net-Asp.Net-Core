using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TimeSheetManagement.Entity.Models;
using TimeSheetManagement.DAL.Data;
using System.Text;

namespace TimeSheetManagementCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly TimeSheetDBContext _context;

        public TokenController(IConfiguration config, TimeSheetDBContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost("AdminLogin")]
        public async Task<IActionResult> Post(Employee _empData)
        {

            if (_empData != null && _empData.EmpEmailID != null && _empData.EmpPsw != null)
            {
                var emp = await GetEmployee(_empData.EmpEmailID, _empData.EmpPsw);

                if (emp != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("EmpID", emp.EmpID.ToString()),
                    new Claim("EmpName", emp.EmpName),
                    new Claim("EmpDesig", emp.EmpDesig),
                    new Claim("EmpEmailID", emp.EmpEmailID),
                    new Claim("EmpPhone", emp.EmpPhone),
                    new Claim("EmpUserName", emp.EmpUserName),
                    new Claim("EmpPsw", emp.EmpPsw),
                    new Claim("EmpDOJ", emp.EmpDOJ),
                    new Claim("MgrID", emp.MgrID.ToString()),
                    new Claim("CurrentProjectID", emp.CurrentProjectID.ToString()),
                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<Employee> GetEmployee(string email, string password)
        {
            Employee employee = null;
            var result = _context.employee.Where(u => u.EmpEmailID == email && u.EmpPsw == password);
            foreach (var item in result)
            {
                employee = new Employee();
                employee.EmpID = item.EmpID;
                employee.EmpName = item.EmpName;
                employee.EmpDesig = item.EmpDesig;
                employee.EmpEmailID= item.EmpEmailID;
                employee.EmpPhone = item.EmpPhone;
                employee.EmpUserName = item.EmpUserName;
                employee.EmpPsw = item.EmpPsw;
                employee.EmpDOJ = item.EmpDOJ;
                employee.MgrID = item.MgrID;
                employee.CurrentProjectID = item.CurrentProjectID;
            }
            return employee;

        }
    }
}
