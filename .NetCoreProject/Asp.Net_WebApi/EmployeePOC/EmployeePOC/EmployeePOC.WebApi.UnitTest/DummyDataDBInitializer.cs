using EmployeePOC.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePOC.WebApi.UnitTest
{
    class DummyDataDBInitializer
    {
        public DummyDataDBInitializer()
        {
        }

        public void Seed(EmployeeDbContext context)

        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.EmployeeTable.AddRange(
                new EmployeeTable() { EmpId = 1001, EmpName = "Meghna", EmpContact = "9876543210", EmpEmailId = "meghna1@gmail.com", EmpAddress ="CRJ"},
                new EmployeeTable() { EmpId = 1002, EmpName = "Riya", EmpContact = "9786543210", EmpEmailId = "riya1@gmail.com" , EmpAddress ="RNP"}
            );
            context.SaveChanges();
        }
    }
}
