using Ass_handtph26146.Models;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.IServices
{
	public interface IHoaDonService
	{
		public bool CreateHoaDon(HoaDon hd);

		public bool DeleteHoaDon(Guid id);
		public bool UpdateHoaDon(HoaDon p);
		public List<HoaDon> GetAllHoaDon();
		public HoaDon GetHoaDonByID(Guid id);
		public List<HoaDon> GetHoaDonByName(string name);
	}
}
