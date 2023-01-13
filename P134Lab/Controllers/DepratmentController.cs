using Microsoft.AspNetCore.Mvc;
using P134Lab.Data;
using P134Lab.Models;
using System.Collections.Generic;
using System.Linq;

namespace P134Lab.Controllers
{
    public class DepratmentController : Controller
    {
        private readonly Context _context;

        public DepratmentController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Department> departments = _context.Departments.ToList();
            return View(departments);
        }
    }
}
