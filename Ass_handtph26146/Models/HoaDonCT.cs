using System;
using System.Collections.Generic;

namespace Ass_handtph26146.Models
{
    public class HoaDonCT
    {
        public Guid IdHD { get; set; }
        public Guid IdHoa { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual Hoa Hoa { get; set; }
    }
}
