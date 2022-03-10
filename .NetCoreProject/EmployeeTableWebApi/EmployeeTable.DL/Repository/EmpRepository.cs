using EmployeeTable.DL.Data;
using EmployeeTable.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeTable.DL.Repository
{
    public class EmpRepository : IEmpRepository
    {
        EmployeeDBContext _employeeDBContext;
        public EmpRepository(EmployeeDBContext employeeDBContext)
        {
            _employeeDBContext = employeeDBContext;
        }
        public void AddEmployee(EmployeeModel empmodel)
        {
            _employeeDBContext.empmodel.Add(empmodel);
            _employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(int EmpID)
        {
            var employee = _employeeDBContext.empmodel.Find(EmpID);
            _employeeDBContext.empmodel.Remove(employee);
            _employeeDBContext.SaveChanges();
        }

        public EmployeeModel GetEmployeeByID(int EmpID)
        {
            return _employeeDBContext.empmodel.Find(EmpID);
        }

        public EmployeeModel UpdateEmployee(int EmpID)
        {
            return _employeeDBContext.empmodel.Find(EmpID);
        }

        public void UpdateEmployee(EmployeeModel empmodel)
        {
            _employeeDBContext.Entry(empmodel).State = EntityState.Modified;
            _employeeDBContext.SaveChanges();
        }
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _employeeDBContext.empmodel.ToList();
        }


    }
}
