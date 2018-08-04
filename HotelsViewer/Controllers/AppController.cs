using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsViewer.Data;
using Microsoft.AspNetCore.Mvc;


namespace HotelsViewer.Controllers
{
    public class AppController : Controller
    {
        private readonly HotelsViewerDbContext _context;
        public AppController(HotelsViewerDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var resutls = _context.Hotels.OrderBy(h => h.Price).ToList();

            return View(resutls);
        }
    }
}
