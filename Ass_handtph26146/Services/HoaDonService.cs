using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
	public class HoaDonService : IHoaDonService
	{
		HoaDBContext context;
		public HoaDonService()
		{
			context = new HoaDBContext();
		}
		public bool CreateHoaDon(HoaDon hd)
		{
			try
			{
				context.HoaDons.Add(hd);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteHoaDon(Guid id)
		{
			try
			{
				var hoadon = context.HoaDons.Find(id);
				context.HoaDons.Remove(hoadon);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<HoaDon> GetAllHoaDon()
		{
			return context.HoaDons.ToList();
		}

		public HoaDon GetHoaDonByID(Guid id)
		{
			return context.HoaDons.FirstOrDefault(p => p.Id == id);
		}

		public List<HoaDon> GetHoaDonByName(string name)
		{
			throw new NotImplementedException();
		}

		public bool UpdateHoaDon(HoaDon p)
		{
			try
			{
				var hd = context.HoaDons.Find(p.Id);
				hd.Id=p.Id;
				hd.IdKH = p.IdKH;
				hd.NgayShip = p.NgayShip;
				hd.IdNV=p.IdNV;
				hd.NgayTao = p.NgayTao;
				hd.NgayThanhToan = p.NgayThanhToan;
				hd.NguoiNhan = p.NguoiNhan;
				hd.Sdt=p.Sdt;
				hd.TinhTrang = p.TinhTrang;
				context.HoaDons.Update(hd);
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
