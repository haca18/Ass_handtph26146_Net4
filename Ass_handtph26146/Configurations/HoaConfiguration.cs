using Ass_handtph26146.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass_handtph26146.Configuartions
{
    public class HoaConfiguration : IEntityTypeConfiguration<Hoa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Hoa> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Nsx).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Loai).HasColumnType("nvarchar(100)");
             builder.Property(x => x.MoTa).HasColumnType("nvarchar(100)");
           
            builder.Property(x => x.SoLuongTon).HasColumnType("int");
            builder.Property(x => x.GiaNhap).HasColumnType("int");
            builder.Property(x => x.GiaBan).HasColumnType("int");

           
        }
    }
}
