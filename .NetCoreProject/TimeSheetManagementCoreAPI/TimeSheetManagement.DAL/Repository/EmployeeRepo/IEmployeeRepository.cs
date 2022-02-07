using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.EmployeeRepo
{
    public interface IEmployeeRepository
    {
        public void AddTimeSheet(TimeSheet timesheet);
        public void DeleteTimeSheet(int timesheetID);
        public void UpdateTimeSheet(TimeSheet timesheet);

    }
}
