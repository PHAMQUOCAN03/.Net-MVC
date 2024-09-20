using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers
using DemoMvc.Models.Entities;
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string StudentID, string FullName )
        {
            ViewBag.massage = StudentID + "-" + FullName;
            return View();
        }
        // public IActionResult Index(Student std )
        // {
            // ViewBag.massage = std.StudentID + "-" + std.FullName;
            // return View();
        // }

        public IActionResult Demo()
        {
            return View();
        }

    }
}