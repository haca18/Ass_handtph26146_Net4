using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Ass_handtph26146.Services;
using System.Linq;

namespace Ass_handtph26146.Controllers
{
	public class CartController : Controller
	{
		private readonly IHoaService hoaService;
		private readonly ILogger<CartController> _logger;
		private HoaDBContext db;
		private readonly IThemGhService _themghService;

		public CartController(ILogger<CartController> logger)
		{
			_logger = logger;
			
			db = new HoaDBContext();
			_themghService = new ThemGhService();

		}

		public IActionResult Index()
		{
			return View();
		}

		//[Route("Addcart/{hoaid:Guid}",Name ="Addcart")]
		public IActionResult AddCart(Guid id)
		{
			var hoa = hoaService.GetHoaByID(id);
			if (hoa == null)
			{
				return NotFound("Không có sản phẩm này");
			}

			//Xử lý đưa vào cart
			var gh = _themghService.GetCartItems(HttpContext.Session);

			var ghct = gh.Find(p => p.IdHoa == id);
			if (ghct != null)
			{
				ghct.SoLuong++;//Đã tồn tại thì thêm 1
			}
			else
			{
				gh.Add(new GioHangCT() { SoLuong = 1, IdHoa = id, DonGia = hoa.GiaNhap, Name = hoa.Ten, DonGiaKhiGiam = hoa.SoLuongTon });
			}

			//Lưu vào session
			_themghService.SaveCartSession(gh, HttpContext.Session);

			//Chuyển đến trang hiển thị Cart
			return RedirectToAction("Cart");
		}

		[Route("/", Name = "cart")]
		public IActionResult Cart()
		{
			return View(_themghService.GetCartItems(HttpContext.Session));
		}

		//Xóa 
		public IActionResult RemoveCart(Guid id)
		{
			var cart = _themghService.GetCartItems(HttpContext.Session);
			var cartitem = cart.Find(p => p.IdHoa == id);
			if (cartitem != null)
			{

				cart.Remove(cartitem);
			}

			_themghService.SaveCartSession(cart, HttpContext.Session);
			return RedirectToAction(nameof(Cart));
		}

		/// Cập nhật
		[Route("/updatecart", Name = "updatecart")]
		[HttpPost]
		public IActionResult UpdateCart(Guid productid, [FromForm] int quantity)
		{
			// Cập nhật Cart thay đổi số lượng quantity ...
			var cart = _themghService.GetCartItems(HttpContext.Session);
			var cartitem = cart.Find(p => p.IdHoa == productid);
			if (cartitem != null)
			{

				cartitem.SoLuong = quantity;
			}
			_themghService.SaveCartSession(cart, HttpContext.Session);
			// Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
			return Ok();
		}

		public IActionResult Checkout()
		{
			return Content("Đơn đặt hàng thành công");
		}
	}
}
