using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Data
{
   public class TimeSheetDBContext:DbContext
    {
        public TimeSheetDBContext(DbContextOptions<TimeSheetDBContext> options) : base(options)
        {

        }

        public DbSet<Project> project { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<TimeSheet> timesheet { get; set; }
        
      
    }
}
