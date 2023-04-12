using System;
using System.Collections.Generic;
using System.Data;

namespace Ass_handtph26146.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public Guid IdCV { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
        public virtual ChucVu ChucVu { get; set; }
         

    }
}
