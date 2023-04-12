using Ass_handtph26146.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ass_handtph26146.Configuartions
{
    public class GioHangCTConfiguration : IEntityTypeConfiguration<GioHangCT>
    {
        public void Configure(EntityTypeBuilder<GioHangCT> builder)
        {
            builder.HasKey(x => x.IdHoa);
			builder.Property(x => x.Name).HasColumnType("nvarchar(100)");
			builder.Property(x => x.SoLuong).HasColumnType("int");
            builder.Property(x => x.DonGia).HasColumnType("int");
 builder.Property(x => x.DonGiaKhiGiam).HasColumnType("int");

            builder.HasOne(p=>p.GioHang).WithMany(p=>p.GioHangCTs).HasForeignKey(p=>p.IdGioHang);

            builder.HasOne(p => p.Hoa).WithMany(p => p.GioHangCTs).HasForeignKey(p => p.IdHoa);

        }
    }
}
