using System;

namespace Ass_handtph26146.Models
{
    public class GioHangCT
    {
        public Guid IdGioHang { get; set; }
        public Guid IdHoa { get; set; }
        public string Name { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int DonGiaKhiGiam { get; set; }
        public virtual GioHang GioHang { get; set; }

        public virtual Hoa Hoa { get; set; }
    }
}
