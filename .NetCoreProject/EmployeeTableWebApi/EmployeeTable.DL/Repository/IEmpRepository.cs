using System;
using System.Collections.Generic;
using System.Text;
using EmployeeTable.Entity.Models;

namespace EmployeeTable.DL.Repository
{
    public interface IEmpRepository
    {
        void AddEmployee(EmployeeModel empmodel);
        EmployeeModel GetEmployeeByID(int EmpID);
        EmployeeModel UpdateEmployee(int EmpID);
        void UpdateEmployee(EmployeeModel empmodel);
        void DeleteEmployee(int EmpID);
        IEnumerable<EmployeeModel> GetEmployees();
    }
}
