using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.DAL.Repository.EmployeeRepo;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.BAL.Services
{
    public class EmployeeServices
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void AddTimeSheet(TimeSheet timesheet)
        {
            _employeeRepository.AddTimeSheet(timesheet);
        }

        public void DeleteTimeSheet(int timesheetID)
        {
            _employeeRepository.DeleteTimeSheet(timesheetID);
        }

        public void UpdateTimeSheet(TimeSheet timesheet)
        {
            _employeeRepository.UpdateTimeSheet(timesheet);
        }

    }
}
