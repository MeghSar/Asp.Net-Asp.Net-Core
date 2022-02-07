using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.DAL.Repository.AdminRepo;
using TimeSheetManagement.DAL.Repository.ManagerRepo;
using TimeSheetManagement.Entity;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.BAL.Services
{
    public class ManagerServices
    {
        IManagerRepository _managerRepository;
        public ManagerServices(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }
        public void AllocateProject(Employee employee)
        {
            _managerRepository.AllocateProject(employee);
        }

        public void ChangeEmpPsw(Employee employee)
        {
            _managerRepository.ChangeEmpPsw(employee);
        }

        public IEnumerable<Employee> GetEmployees(int mgrID)
        {
            return _managerRepository.GetEmployees(mgrID);
        }

        public TimeSheet GetTimeSheetByID(int empID)
        {
            return _managerRepository.GetTimeSheetByID(empID);
        }

        public void TimeSheetRelease(TimeSheet timeSheet)
        {
            _managerRepository.TimeSheetRelease(timeSheet);
        }
    }
}
