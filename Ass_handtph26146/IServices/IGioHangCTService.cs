using Ass_handtph26146.Models;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.IServices
{
	public interface IGioHangCTService
	{
		public bool CreateGioHangCT(GioHangCT ghCT);

		public bool DeleteGioHangCT(Guid id);
		public bool UpdateGioHangCT(GioHangCT ghCT);
		public List<GioHangCT> GetAllGioHangCT();
		public GioHangCT GetGioHangCTByID(Guid id);
		public List<GioHangCT> GetGioHangCTByName(string name);
	}
}
