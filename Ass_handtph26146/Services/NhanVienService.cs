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
            context = new HoaDBContext();
        }

        public bool CreateNv(NhanVien nv)
        {

            try
            {
                nv.IdCV = Guid.Parse("c10001e7-5761-489e-ec00-08db2a824f89");
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
            try
            {
                var nhanvien = context.NhanViens.Find(nv.Id);
                nhanvien.Id = nv.Id;
                nhanvien.IdCV = nv.IdCV;
                nhanvien.MatKhau = nv.MatKhau;
                nhanvien.Sdt = nv.Sdt;
                nhanvien.Ten = nv.Ten;
                nhanvien.TrangThai = nv.TrangThai;
                context.NhanViens.Update(nhanvien);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }

        public bool LoginNV(string user, string pass)
        {
            try
            {
                foreach (var x in GetAllNv())
                {
                    if (x.Ten == user && x.MatKhau == pass)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
    }
}
