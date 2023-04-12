using Ass_handtph26146.Models;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.IServices
{
	public interface INhanVienService
	{
		public bool CreateNv(NhanVien nv);

		public bool DeleteNv(Guid id);
		public bool UpdateNv(NhanVien nv);
		public List<NhanVien> GetAllNv();
		public NhanVien GetNvByID(Guid id);
		public List<NhanVien> GetNvByName(string name);
	}
}
