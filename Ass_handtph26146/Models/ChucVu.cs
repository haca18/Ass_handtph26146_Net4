using System;
using System.Collections.Generic;

namespace Ass_handtph26146.Models
{
    public class ChucVu
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }

        public virtual List<NhanVien> NhanViens { get; set; }
       
    }
}
