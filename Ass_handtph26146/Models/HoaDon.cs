using System;
using System.Collections.Generic;

namespace Ass_handtph26146.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public Guid IdNV { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public DateTime NgayShip  { get; set; }
        public int TinhTrang { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
          public virtual List<HoaDonCT> HoaDonCTs{ get; set; }

    }
}
