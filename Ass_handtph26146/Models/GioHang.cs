using System;
using System.Collections.Generic;

namespace Ass_handtph26146.Models
{
    [Serializable]
    public class GioHang
    {
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public Guid IdNV { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public int TinhTrang { get; set; }

        public virtual List<GioHangCT> GioHangCTs { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
