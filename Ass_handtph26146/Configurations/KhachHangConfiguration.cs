using Ass_handtph26146.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ass_handtph26146.Configuartions
{
    public class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Sdt).HasColumnType("nvarchar(100)");
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)");
 builder.Property(x => x.MatKhau).HasColumnType("nvarchar(100)");

           
        }
    }
}
