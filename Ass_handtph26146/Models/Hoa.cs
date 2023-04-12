using System;
using System.Collections.Generic;

namespace Ass_handtph26146.Models
{
    public class Hoa
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Nsx { get; set; }
        public string Loai { get; set; }
        public string MoTa { get; set; }
        public int SoLuongTon { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
         public int TinhTrang { get; set; }

        public virtual List<HoaDonCT> HoaDonCTs { get; set; }
        public virtual List<GioHangCT> GioHangCTs { get; set; }
    }
}
