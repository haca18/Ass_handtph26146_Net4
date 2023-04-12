using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ass_handtph26146.Models
{
    public class HoaDBContext : DbContext
    {
        public HoaDBContext()
        {

        }

        public HoaDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangCT> GioHangCTs { get; set; }
        public DbSet<Hoa> Hoas { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LDAM7DR\SQLEXPRESS;Initial Catalog=BanCaNet4;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
