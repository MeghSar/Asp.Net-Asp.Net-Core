using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheetManagement.DAL.Data;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.AdminRepo
{
    public class AdminRepository : IAdminRepository
    {
        TimeSheetDBContext _timeSheetDBContext;
        public AdminRepository(TimeSheetDBContext timeSheetDBContext)
        {
            _timeSheetDBContext = timeSheetDBContext;
        }
        #region Employee
        public void AddEmployee(Employee employee)
        {
            _timeSheetDBContext.employee.Add(employee);
            _timeSheetDBContext.SaveChanges();
        }

        public void DeleteEmployee(int empID)
        {
            var employee = _timeSheetDBContext.employee.Find(empID);
            _timeSheetDBContext.employee.Remove(employee);
            _timeSheetDBContext.SaveChanges();

        }

        public Employee GetEmployeeByID(int empID)
        {
            return _timeSheetDBContext.employee.Find(empID);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _timeSheetDBContext.employee.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _timeSheetDBContext.Entry(employee).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }
        #endregion
        #region Project
        public void AddProject(Project project)
        {
            _timeSheetDBContext.project.Add(project);
            _timeSheetDBContext.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            _timeSheetDBContext.Entry(project).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }

        public void DeleteProject(int projID)
        {
            var project = _timeSheetDBContext.project.Find(projID);
            _timeSheetDBContext.project.Remove(project);
            _timeSheetDBContext.SaveChanges();
        }

        public Project GetProjectByID(int projID)
        {
            return _timeSheetDBContext.project.Find(projID);
        }

        public IEnumerable<Project> GetProjects()
        {
            return _timeSheetDBContext.project.ToList();
        }
        #endregion



    }
}
