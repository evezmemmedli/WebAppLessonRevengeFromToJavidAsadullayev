using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAppLessonRevengeFromToJavidAsadullayev.DAL;
using WebAppLessonRevengeFromToJavidAsadullayev.Models;

namespace WebAppLessonRevengeFromToJavidAsadullayev.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }

        public IActionResult Detail(int? id)
        {
            Service service = _context.Services.FirstOrDefault(x => x.Id == id);
            return View(service);
        }
    }
}
