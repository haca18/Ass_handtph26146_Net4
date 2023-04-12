using Ass_handtph26146.Models;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.IServices
{
	public interface IKhachHangService
	{
		public bool CreateKh(KhachHang kh);

		public bool DeleteKh(Guid id);
		public bool UpdateKh(KhachHang kh);
		public List<KhachHang> GetAllKh();
		public KhachHang GetKhByID(Guid id);
		public List<KhachHang> GetKhByName(string name);
	}
}
