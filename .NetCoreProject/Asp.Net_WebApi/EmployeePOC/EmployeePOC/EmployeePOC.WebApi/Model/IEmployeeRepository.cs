using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePOC.WebApi.Model
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeTable EmployeeTable);
        IEnumerable<EmployeeTable> GetEmployees();
        EmployeeTable GetEmployeeById(int EmpId);
        EmployeeTable UpdateEmployee(int EmpId);
        void UpdateEmployee(EmployeeTable EmployeeTable);
        void DeleteEmployee(int EmpId);
        
    }
}
