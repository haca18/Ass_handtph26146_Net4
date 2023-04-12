using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
	public class NhanVienService : INhanVienService
	{
		HoaDBContext context;

		public NhanVienService()
		{
			context= new HoaDBContext();
		}

		public bool CreateNv(NhanVien nv)
		{

			try
			{
				context.NhanViens.Add(nv);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public bool DeleteNv(Guid id)
		{
			try
			{
				var nv = context.NhanViens.Find(id);
				context.NhanViens.Remove(nv);
				context.SaveChanges();
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public List<NhanVien> GetAllNv()
		{
			return context.NhanViens.ToList();
		}

		public NhanVien GetNvByID(Guid id)
		{
			return context.NhanViens.FirstOrDefault(p => p.Id == id);
		}

		public List<NhanVien> GetNvByName(string name)
		{
			return context.NhanViens.Where(p => p.Ten.Contains(name)).ToList();
		}

		public bool UpdateNv(NhanVien nv)
		{
			throw new NotImplementedException();
		}
	}
}
