using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using Ass_handtph26146.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly ILogger<SanPhamController> _logger;
        private readonly IHoaService hoaServices;//Interface

        public SanPhamController(ILogger<SanPhamController> logger)
        {
            _logger = logger;
            hoaServices = new HoaService();
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult
        public IActionResult ShowListHoa()
        {
            List<Hoa> hoas = hoaServices.GetAllHoa().Where(x => x.TinhTrang < 3).ToList();
            return View(hoas);
        }

        public IActionResult Hoa()
        {
            List<Hoa> hoas = hoaServices.GetAllHoa();
            return View(hoas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Hoa p)
        {
            if (hoaServices.CreateHoa(p))
            {
                return RedirectToAction("ShowListHoa");
            }
            else return BadRequest();
        }

        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            Hoa hoa = hoaServices.GetHoaByID(Id);
            return View(hoa);
        }

        public IActionResult Edit(Hoa hoa)
        {
            if (hoaServices.UpdateHoa(hoa))
            {
                return RedirectToAction("ShowListHoa");
            }
            else return NotFound();
        }
        public IActionResult Details(Guid id)
        {
            HoaDBContext hoaDbContext = new HoaDBContext();
            var hoa = hoaDbContext.Hoas.Find(id);

            return View(hoa);
        }

    }
}
