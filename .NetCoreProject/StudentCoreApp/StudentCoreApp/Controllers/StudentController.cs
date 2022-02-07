using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentCoreApp.Controllers
{
    public class StudentController : Controller
    {
        StudentDbContext _studentDbContext;
        public StudentController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;

        }
       public IActionResult Index()
        {
            var studentList = _studentDbContext.Student.ToList();
            return View(studentList);
        }
        public IActionResult StudentEntry()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult StudentEntry(Student student)
        {
            _studentDbContext.Student.Add(student);
            _studentDbContext.SaveChanges();
            ViewBag.message = "Student details saved automatically";
            return View();
        }
        public IActionResult EditStudent(int Roll)
        {
            var result = _studentDbContext.Student.Find(Roll);
            return View(result);
        }
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            _studentDbContext.Entry(student).State = EntityState.Modified;
            _studentDbContext.SaveChanges();
            ViewBag.message = "Tutorial Details Updated successfully";
            return View();
        }
        public IActionResult DeleteStudent(int Roll)
        {
            var result = _studentDbContext.Student.Find(Roll);
            return View();
        }
    }
}
