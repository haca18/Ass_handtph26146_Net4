using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
	public class GioHangCTService : IGioHangCTService
	{
		HoaDBContext context;

		public GioHangCTService()
		{
			context = new HoaDBContext();
		}
		public bool CreateGioHangCT(GioHangCT ghCT)
		{
			try
			{
				context.GioHangCTs.Add(ghCT);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public bool DeleteGioHangCT(Guid id)
		{
			try
			{
				var ghCT = context.GioHangCTs.Find(id);
				context.GioHangCTs.Remove(ghCT);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public List<GioHangCT> GetAllGioHangCT()
		{
			return context.GioHangCTs.ToList();
		}

		public GioHangCT GetGioHangCTByID(Guid id)
		{
			return context.GioHangCTs.FirstOrDefault(p => p.IdGioHang == id);
		}

		public List<GioHangCT> GetGioHangCTByName(string name)
		{
			throw new NotImplementedException();
		}

		public bool UpdateGioHangCT(GioHangCT ghCT)
		{
			try
			{
				var p = context.GioHangCTs.Find(ghCT.IdGioHang);
				p.IdGioHang = ghCT.IdGioHang;
				p.IdHoa= ghCT.IdHoa;	
				p.SoLuong = ghCT.SoLuong;
				p.DonGia= ghCT.DonGia;
				p.DonGiaKhiGiam=ghCT.DonGiaKhiGiam;
				context.GioHangCTs.Update(p);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
