using Ass_handtph26146.Models;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.IServices
{
	public interface IHoaDonCTService
	{
		public bool CreateHoaDonCT(HoaDonCT hdCT);

		public bool DeleteHoaDonCT(Guid id);
		public bool UpdateHoaDonCT(HoaDonCT hdCT);
		public List<HoaDonCT> GetAllHoaDonCT();
		public HoaDonCT GetHoaDonCTByID(Guid id);
		public List<HoaDonCT> GetHoaDonCTByName(string name);
	}
}
