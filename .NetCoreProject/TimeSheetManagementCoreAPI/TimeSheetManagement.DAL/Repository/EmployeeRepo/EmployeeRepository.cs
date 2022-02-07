using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.DAL.Data;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.EmployeeRepo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        TimeSheetDBContext _timeSheetDBContext;
        public EmployeeRepository(TimeSheetDBContext timeSheetDBContext)
        {
            _timeSheetDBContext = timeSheetDBContext;
        }
        public void AddTimeSheet(TimeSheet timesheet)
        {
            _timeSheetDBContext.timesheet.Add(timesheet);
            _timeSheetDBContext.SaveChanges();
        }

        public void DeleteTimeSheet(int timesheetID)
        {
            var timesheet = _timeSheetDBContext.timesheet.Find(timesheetID);
            _timeSheetDBContext.timesheet.Remove(timesheet);
            _timeSheetDBContext.SaveChanges();
        }

        public void UpdateTimeSheet(TimeSheet timesheet)
        {
            _timeSheetDBContext.Entry(timesheet).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }
    }
}
