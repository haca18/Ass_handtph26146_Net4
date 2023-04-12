using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
	public class ThemGhService:IThemGhService
	{
		//Key lưu chuỗi json của Cart
		public const string CartKey = "cart";

		//private readonly IHttpContextAccessor _context;

		//private readonly ISession session;

		public ThemGhService()
		{
			//_context = context;
			//HttpContext= context.HttpContext;
			
		}

		//Lấy cart từ session(danh sách Giỏ hàng cT)
		public	List<GioHangCT> GetCartItems(ISession session)
		{			
			string jsonCart=session.GetString(CartKey);
			if (jsonCart!=null)
			{
				return JsonConvert.DeserializeObject<List<GioHangCT>>(jsonCart);
			}
			return new List<GioHangCT>();
		}

		//Xóa Cart khỏi session
		public void ClearCart(ISession session)
		{
			
			session.Remove(CartKey);
		}

		//Lưu Cart vào session
		public void SaveCartSession(List<GioHangCT> lst, ISession session)
		{
			
			string jsonCart=JsonConvert.SerializeObject(lst);
			session.SetString(CartKey,jsonCart);
		}

       
    }
}
