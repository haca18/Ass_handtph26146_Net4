using Ass_handtph26146.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ass_handtph26146.Configuartions
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NgayTao).HasColumnType("Datetime");
            builder.Property(x => x.NgayThanhToan).HasColumnType("Datetime"); builder.Property(x => x.NgayShip).HasColumnType("Datetime");
            builder.Property(x => x.NguoiNhan).HasColumnType("nvarchar(100)");
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Sdt).HasColumnType("nvarchar(100)");

        }
    }
}
