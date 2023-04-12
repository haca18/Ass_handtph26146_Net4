using System.Collections.Generic;
using System;
using Ass_handtph26146.Models;

namespace Ass_handtph26146.IServices
{
    public interface IHoaService
    {
        public bool CreateHoa(Hoa p);

        public bool DeleteHoa(Guid id);
        public bool UpdateHoa(Hoa p);
        public List<Hoa> GetAllHoa();
        public Hoa GetHoaByID(Guid id);
        public List<Hoa> GetHoaByName(string name);

        public void SLuongSauMua(Hoa p, int soLuong);
    }
}
