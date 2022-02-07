using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheetManagement.DAL.Data;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.ManagerRepo
{
    public class ManagerRepository : IManagerRepository
    {
        TimeSheetDBContext _timeSheetDBContext;
        public ManagerRepository(TimeSheetDBContext timeSheetDBContext)
        {
            _timeSheetDBContext = timeSheetDBContext;
        }
        public void AllocateProject(Employee employee)
        {
            _timeSheetDBContext.Entry(employee).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }

        public void ChangeEmpPsw(Employee employee)
        {
            _timeSheetDBContext.Entry(employee).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployees(int mgrID)
        {
            return _timeSheetDBContext.employee.Where(obj => obj.EmpID == mgrID).ToList();
        }

        public TimeSheet GetTimeSheetByID(int empID)
        {
            return _timeSheetDBContext.timesheet.Find(empID);
        }

        public void TimeSheetRelease(TimeSheet timeSheet)
        {
            _timeSheetDBContext.Entry(timeSheet).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }
    }
}
