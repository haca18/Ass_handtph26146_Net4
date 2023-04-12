using Ass_handtph26146.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ass_handtph26146.Configuartions
{
    public class GioHangConfiguration : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TenNguoiNhan).HasColumnType("nvarchar(100)");
            builder.Property(x => x.NgayTao).HasColumnType("DateTime");
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Sdt).HasColumnType("nvarchar(100)");
            builder.Property(x => x.TenNguoiNhan).HasColumnType("nvarchar(100)");

            builder.HasOne(p => p.KhachHang).WithOne(p => p.GioHang).HasForeignKey<GioHang>(p=>p.IdKH);
        }
    }
}
