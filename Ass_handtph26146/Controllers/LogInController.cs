using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using Ass_handtph26146.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.Controllers
{
    public class LogInController : Controller
    {
        private readonly ILogger<LogInController> _logger;
        private readonly INhanVienService nvServices;//Interface
        private readonly IKhachHangService khServices;//Interface

        public LogInController(ILogger<LogInController> logger)
        {
            _logger = logger;
            nvServices = new NhanVienService();
            khServices = new KhachHangService();
        }

        public IActionResult NhanVien()
        {
            List<NhanVien> nvs = nvServices.GetAllNv();
            return View(nvs);
        }

        public IActionResult CreateNV()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNV(NhanVien nv)
        {
            if (nvServices.CreateNv(nv))
            {
                return RedirectToAction("NhanVien");
            }
            else return BadRequest();
        }

        [HttpGet]
        public IActionResult EditNV(Guid Id)
        {
            NhanVien nv = nvServices.GetNvByID(Id);
            return View(nv);
        }

        public IActionResult EditNV(NhanVien nv)
        {
            if (nvServices.UpdateNv(nv))
            {
                return RedirectToAction("NhanVien");
            }
            else return NotFound();
        }
        public IActionResult DetailsNV(Guid id)
        {
            HoaDBContext hoaDbContext = new HoaDBContext();
            var nv = hoaDbContext.NhanViens.Find(id);
            return View(nv);
        }

    }
}
