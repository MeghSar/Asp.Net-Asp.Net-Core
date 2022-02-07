using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.ManagerRepo
{
    public interface IManagerRepository
    {
        public IEnumerable<Employee> GetEmployees(int mgrID);
        public TimeSheet GetTimeSheetByID(int mgrID);
        public void TimeSheetRelease(TimeSheet timeSheet);
        public void ChangeEmpPsw(Employee employee);
        public void AllocateProject(Employee employee);
        
    }
}
