using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePOC.WebApi.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDbContext _employeeDBContext;
        public EmployeeRepository(EmployeeDbContext employeeDBContext)
        {
            _employeeDBContext = employeeDBContext;
        }
        public void AddEmployee(EmployeeTable EmployeeTable)
        {
            _employeeDBContext.EmployeeTable.Add(EmployeeTable);
            _employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(int EmpID)
        {
            var employee = _employeeDBContext.EmployeeTable.Find(EmpID);
            _employeeDBContext.EmployeeTable.Remove(employee);
            _employeeDBContext.SaveChanges();
        }

        public EmployeeTable GetEmployeeById(int EmpId)
        {
            return _employeeDBContext.EmployeeTable.Find(EmpId);
        }
        public EmployeeTable UpdateEmployee(int EmpID)
        {
            return _employeeDBContext.EmployeeTable.Find(EmpID);
        }

        public void UpdateEmployee(EmployeeTable EmployeeTable)
        {
            _employeeDBContext.Entry(EmployeeTable).State = EntityState.Modified;
            _employeeDBContext.SaveChanges();
        }
        public IEnumerable<EmployeeTable> GetEmployees()
        {
            return _employeeDBContext.EmployeeTable.ToList();
        }

        
    }
}
