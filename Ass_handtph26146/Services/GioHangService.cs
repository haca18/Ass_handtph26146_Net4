using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
	public class GioHangService : IGioHangService
	{
		HoaDBContext context;
		List<GioHangCT> lstghCT;
		public GioHangService()
		{
			context = new HoaDBContext();
			lstghCT = new List<GioHangCT>();
		}

		public bool CreateGioHang(GioHang gh)
		{
			try
			{
				context.GioHangs.Add(gh);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public bool DeleteGioHang(Guid id)
		{
			try
			{
				var gh = context.GioHangs.Find(id);
				context.GioHangs.Remove(gh);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public List<GioHang> GetAllGioHang()
		{
			return context.GioHangs.ToList();
		}

		public GioHang GetGioHangByID(Guid id)
		{
			return context.GioHangs.FirstOrDefault(p => p.Id == id);
		}

		public List<GioHang> GetGioHangByName(string name)
		{
			throw new NotImplementedException();
		}

		public bool UpdateGioHang(GioHang gh)
		{
			try
			{
				var giohang = context.GioHangs.Find(gh.Id);
				giohang.Id = gh.Id;
				giohang.IdKH = gh.IdKH;
				giohang.IdNV = gh.IdNV;
				giohang.NgayTao = gh.NgayTao;
				giohang.Sdt = gh.Sdt;
				giohang.TenNguoiNhan = gh.TenNguoiNhan;
				giohang.TinhTrang = gh.TinhTrang;
				context.GioHangs.Update(giohang);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}

		public void AddCart(GioHangCT ghct, int soLuong)
		{
			var checkExits = lstghCT.FirstOrDefault(x => x.IdHoa == ghct.IdHoa);
			if (checkExits != null)
			{
				checkExits.SoLuong += soLuong;
				checkExits.DonGiaKhiGiam = checkExits.DonGia * checkExits.SoLuong;
			}
			else
			{
				lstghCT.Add(ghct);
			}
		}

		public void Remove(Guid id)
		{
			var checkExits = lstghCT.SingleOrDefault(x => x.IdHoa == id);
			if (checkExits!=null)
			{
				lstghCT.Remove(checkExits);
			}
		}

		public void UpdateSoLuong(Guid id, int soLuong)
		{
			var checkExits = lstghCT.SingleOrDefault(x => x.IdHoa == id);
			if (checkExits!=null)
			{
				checkExits.SoLuong = soLuong;
				checkExits.DonGiaKhiGiam = checkExits.DonGia * checkExits.SoLuong;
			}


		}

		public int GetTongGia()
		{
			return lstghCT.Sum(x=>x.DonGiaKhiGiam);
		}

		public int GetTongSoLuong()
		{
			return lstghCT.Sum(x => x.SoLuong);
		}
		public void ClearGH()
		{
			lstghCT.Clear();
		}

	}
}
