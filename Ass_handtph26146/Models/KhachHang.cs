using System;
using System.Collections.Generic;

namespace Ass_handtph26146.Models
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }

        public virtual List<HoaDon> HoaDons { get; set; }

        public virtual GioHang GioHang { get; set; }

    }
}
