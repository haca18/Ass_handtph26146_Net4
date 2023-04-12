using Ass_handtph26146.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ass_handtph26146.Configuartions
{
    public class HoaDonCTConfiguration : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.HasKey(x => x.IdHD);
            builder.Property(x => x.SoLuong).HasColumnType("int");
            builder.Property(x => x.DonGia).HasColumnType("int");
           

            builder.HasOne(p => p.HoaDon).WithMany(p => p.HoaDonCTs).HasForeignKey(p => p.IdHD);

            builder.HasOne(p => p.Hoa).WithMany(p => p.HoaDonCTs).HasForeignKey(p => p.IdHoa);
        }
    }
}
