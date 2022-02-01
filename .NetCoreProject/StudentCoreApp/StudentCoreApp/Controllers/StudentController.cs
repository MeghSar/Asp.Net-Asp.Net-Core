using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        public IActionResult DeleteStudent(int Roll)
        {
            return View();
        }
    }
}
