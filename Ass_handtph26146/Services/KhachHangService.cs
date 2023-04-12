
using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
	public class KhachHangService : IKhachHangService
	{
        HoaDBContext context;
		public KhachHangService()
		{
			context= new HoaDBContext();
		}
        public bool CreateKh(KhachHang kh)
		{
            try
            {
                context.KhachHangs.Add(kh);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

		public bool DeleteKh(Guid id)
		{
            try
            {
                var kh = context.KhachHangs.Find(id);
                context.KhachHangs.Remove(kh);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

		public List<KhachHang> GetAllKh()
		{
			return context.KhachHangs.ToList();
		}

		public KhachHang GetKhByID(Guid id)
		{
            return context.KhachHangs.FirstOrDefault(p => p.Id == id);
        }

		public List<KhachHang> GetKhByName(string name)
		{
            return context.KhachHangs.Where(p => p.Ten.Contains(name)).ToList();
        }

		public bool UpdateKh(KhachHang kh)
		{
            try
            {
                var khach = context.KhachHangs.Find(kh.Id);
                khach.Id = kh.Id;
                khach.MatKhau=kh.MatKhau;
                khach.Sdt = kh.Sdt;
                khach.Ten = kh.Ten;
                context.KhachHangs.Update(khach);
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
