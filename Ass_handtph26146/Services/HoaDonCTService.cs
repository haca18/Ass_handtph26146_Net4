using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
	public class HoaDonCTService : IHoaDonCTService
	{
		HoaDBContext context;

		public HoaDonCTService()
		{
			context = new HoaDBContext();
		}
		public bool CreateHoaDonCT(HoaDonCT hdCT)
		{
			try
			{
				context.HoaDonCTs.Add(hdCT);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public bool DeleteHoaDonCT(Guid id)
		{
			try
			{
				var hdCT = context.HoaDonCTs.Find(id);
				context.HoaDonCTs.Remove(hdCT);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public List<HoaDonCT> GetAllHoaDonCT()
		{
			return context.HoaDonCTs.ToList();
		}

		public HoaDonCT GetHoaDonCTByID(Guid id)
		{
			return context.HoaDonCTs.FirstOrDefault(p => p.IdHD == id);
		}

		public List<HoaDonCT> GetHoaDonCTByName(string name)
		{
			throw new NotImplementedException();
		}

		public bool UpdateHoaDonCT(HoaDonCT hdCT)
		{
			try
			{
				var hoadonCT = context.HoaDonCTs.Find(hdCT.IdHD);
				hoadonCT.IdHD=hdCT.IdHD;
				hoadonCT.IdHoa=hdCT.IdHoa;
				hoadonCT.SoLuong=hdCT.SoLuong;
				hoadonCT.DonGia=hdCT.DonGia;
				context.HoaDonCTs.Update(hoadonCT);
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
