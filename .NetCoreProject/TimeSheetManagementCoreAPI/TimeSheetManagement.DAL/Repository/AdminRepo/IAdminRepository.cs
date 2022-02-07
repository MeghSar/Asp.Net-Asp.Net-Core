using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.AdminRepo
{
    public interface IAdminRepository
    {
        #region Employee
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int empID);
        Employee GetEmployeeByID(int empID);
        IEnumerable<Employee> GetEmployees();
        #endregion
        #region Project
        void AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(int projID);
        Project GetProjectByID(int projID);
        IEnumerable<Project> GetProjects();
        #endregion




    }
}
