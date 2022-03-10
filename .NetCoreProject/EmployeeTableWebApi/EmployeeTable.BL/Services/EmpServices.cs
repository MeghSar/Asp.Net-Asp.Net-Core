using EmployeeTable.DL.Repository;
using EmployeeTable.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTable.BL.Services
{
    public class EmpServices
    {
        IEmpRepository _empRepository;
        public EmpServices(IEmpRepository adminRepository)
        {
            _empRepository = adminRepository;
        }
        public void AddEmployee(EmployeeModel empmodel)
        {
            _empRepository.AddEmployee(empmodel);
        }
        public EmployeeModel UpdateEmployee(int EmpID)
        {
            return _empRepository.UpdateEmployee(EmpID);
        }
        public void UpdateEmployee(EmployeeModel empmodel)
        {
            _empRepository.UpdateEmployee(empmodel);
        }
        public void DeleteEmployee(int EmpID)
        {
            _empRepository.DeleteEmployee(EmpID);
        }
        public EmployeeModel GetEmployeeByID(int EmpID)
        {
            return _empRepository.GetEmployeeByID(EmpID);

        }
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _empRepository.GetEmployees();
        }
    }
}
