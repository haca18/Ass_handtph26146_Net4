using Ass_handtph26146.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ass_handtph26146.Configuartions
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Sdt).HasColumnType("nvarchar(100)");
            builder.Property(x => x.MatKhau).HasColumnType("nvarchar(100)");
             builder.Property(x => x.TrangThai).HasColumnType("int");

            builder.HasOne(p => p.ChucVu).WithMany(p => p.NhanViens).HasForeignKey(p => p.IdCV);

            
        }
    }
}
