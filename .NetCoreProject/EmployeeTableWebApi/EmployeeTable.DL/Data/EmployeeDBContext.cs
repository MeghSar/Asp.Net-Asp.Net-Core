using System;
using System.Collections.Generic;
using System.Text;
using EmployeeTable.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTable.DL.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }
        public DbSet<EmployeeModel> empmodel { get; set; }
    }
}
