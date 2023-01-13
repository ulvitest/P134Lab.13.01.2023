using Microsoft.AspNetCore.Mvc;
using P134Lab.Data;
using P134Lab.Models;
using System;
using System.Linq;
using System.Net;

namespace P134Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var stuList = _context.Student.ToList();
            return View(stuList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateForStudent(Student student)
        {

            //var name = HttpContext.Request.Form["name"];
            //var surname = HttpContext.Request.Form["surname"];
            //var age = Int32.Parse(HttpContext.Request.Form["age"]);
            //_context.Student.Add(new Student {
            //    Name = name,
            //    Surname = surname,
            //    Age = age
            //});
            _context.Student.Add(student);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Remove(int id)
        {
            //var id = int.Parse(RouteData.Values["id"].ToString());
            var student = _context.Student.Find(id);
            //var stu = _context.Student.FirstOrDefault(x=>x.Id==id);
            _context.Student.Remove(student);
            _context.SaveChanges();
            //_context.Student.Remove(_context.Student.Find(int.Parse(RouteData.Values["id"].ToString())));
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            //var id = Int32.Parse(RouteData.Values["id"].ToString());
            var student = _context.Student.Find(id);

            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student,int id)
        {
            //var id = int.Parse(HttpContext.Request.Form["id"]);
            //Student student = _context.Student.FirstOrDefault(x=>x.Id==id);
            //student.Name = HttpContext.Request.Form["name"];
            //student.Surname = HttpContext.Request.Form["surname"];
            //student.Age = int.Parse(HttpContext.Request.Form["age"].ToString());

            var findStudent = _context.Student.Find(id);
            findStudent.Name = student.Name;
            findStudent.Surname = student.Surname;
            findStudent.Age = student.Age;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
