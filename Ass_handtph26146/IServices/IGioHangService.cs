using Ass_handtph26146.Models;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.IServices
{
	public interface IGioHangService
	{
		public bool CreateGioHang(GioHang gh);

		public bool DeleteGioHang(Guid id);
		public bool UpdateGioHang(GioHang gh);
		public List<GioHang> GetAllGioHang();
		public GioHang GetGioHangByID(Guid id);
		public List<GioHang> GetGioHangByName(string name);

		public void AddCart(GioHangCT ghct, int soLuong);

		public void Remove(Guid id);

		public void UpdateSoLuong(Guid id, int soLuong);

		public int GetTongGia();

		public int GetTongSoLuong();
		public void ClearGH();
	}
}
