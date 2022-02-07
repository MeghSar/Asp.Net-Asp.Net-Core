using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.DAL.Repository.AdminRepo;
using TimeSheetManagement.Entity;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.BAL.Services
{
    public class AdminServices
    {
        IAdminRepository _adminRepository;
        public AdminServices(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        #region Employee
        public void AddEmployee(Employee employee)
        {
            _adminRepository.AddEmployee(employee);
            
        }

        public void DeleteEmployee(int empID)
        {
            _adminRepository.DeleteEmployee(empID);

        }

        public Employee GetEmployeeByID(int empID)
        {
           return _adminRepository.GetEmployeeByID(empID);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _adminRepository.GetEmployees();
        }

        public void UpdateEmployee(Employee employee)
        {
            _adminRepository.UpdateEmployee(employee);
        }
        #endregion

        #region Project
        public void AddProject(Project project)
        {
            _adminRepository.AddProject(project);
        }

        public void UpdateProject(Project project)
        {
            _adminRepository.UpdateProject(project);
        }

        public void DeleteProject(int projID)
        {
            _adminRepository.DeleteProject(projID);
        }

        public Project GetProjectByID(int projID)
        {
            return _adminRepository.GetProjectByID(projID);
        }

        public IEnumerable<Project> GetProjects()
        {
            return _adminRepository.GetProjects();
        }
        #endregion
    }
}
