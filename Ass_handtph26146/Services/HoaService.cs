using Ass_handtph26146.IServices;
using Ass_handtph26146.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ass_handtph26146.Services
{
    public class HoaService : IHoaService
    {
        HoaDBContext context;
        public HoaService()
        {
            context = new HoaDBContext();
        }
        public bool CreateHoa(Hoa p)
        {
            try
            {
                context.Hoas.Add(p);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteHoa(Guid id)
        {
            try
            {
                var hoa = context.Hoas.Find(id);
                context.Hoas.Remove(hoa);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Hoa> GetAllHoa()
        {
            return context.Hoas.ToList();
        }

        public Hoa GetHoaByID(Guid id)
        {

            return context.Hoas.FirstOrDefault(p => p.Id == id);
        }

        public List<Hoa> GetHoaByName(string name)
        {
            return context.Hoas.Where(p => p.Ten.Contains(name)).ToList();
        }

        public bool UpdateHoa(Hoa p)
        {
            try
            {
                var hoa = context.Hoas.Find(p.Id);
                    hoa.Ten = p.Ten;
                    hoa.Nsx = p.Nsx;
                    hoa.Loai = p.Loai;
                    hoa.MoTa = p.MoTa;
                    hoa.SoLuongTon = p.SoLuongTon;
                    hoa.GiaNhap = p.GiaNhap;
                    hoa.GiaBan = p.GiaBan;
                    hoa.TinhTrang = p.TinhTrang;
                    context.Hoas.Update(hoa);
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
