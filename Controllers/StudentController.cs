using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BanepaNistTutorial.Models;

namespace BanepaNistTutorial.Controllers
{
    public class StudentController : Controller
    {
        private List<StudentModel> students = new List<StudentModel>();
        public StudentController()
        {
            StudentModel student = new StudentModel();
            student.StudentId = 1;
            student.StudentName = "Deependra Karki";//if it may be accessed from file or db ie other function may be called
            student.Address = "Dhulikhel";
            student.PhoneNUmber = "9849176497";
            students.Add(student);
            students.Add(new StudentModel
            {
                StudentId=2,
                StudentName = "Aarati Thap",
                Address = "Naala",
                PhoneNUmber = "9845696325",
            });
            students.Add(new StudentModel
            {
                StudentId=3,
                StudentName = "Sagar Dhoju",
                Address = "Banepa",
                PhoneNUmber = "9845696325"
            });
            students.Add(new StudentModel
            {
                StudentId=4,
                StudentName = "Sameep Banjara",
                Address = "Namo buddha",
                PhoneNUmber = "898988989"
            });
        }
        public IActionResult StudentList()
        {
            return View(students);
        }
        public IActionResult StudentProfile()
        {
            StudentModel student = new StudentModel();
            student.StudentName = "Deependra Karki";
            student.Address = "Dhulikhel";
            student.PhoneNUmber = "dipendra's phone number";
            return View(student);
        }
    }
}