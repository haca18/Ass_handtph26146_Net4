using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using Ass_handtph26146.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ass_handtph26146.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHoaService hoaServices;//Interface
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            hoaServices = new HoaService(); //Class Service
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       


        public IActionResult Create()
        {
            return View();
        }

       

    }
}
