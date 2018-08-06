using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsViewer.Data;
using HotelsViewer.Services;
using Microsoft.AspNetCore.Mvc;


namespace HotelsViewer.Controllers
{
    public class AppController : Controller
    {
        private readonly HotelsViewerDbContext _context;
        private readonly IMailService _mailService;

        public AppController(HotelsViewerDbContext context, IMailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            var resutls = _context.Hotels.OrderBy(h => h.Price).ToList();

            _mailService.SendMessage("test@test.com" , "Index Page" , "Generated");
            return View(resutls);
        }
    }
}
