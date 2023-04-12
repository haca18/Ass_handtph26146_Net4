using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ass_handtph26146.Migrations
{
    public partial class Lan1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Nsx = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Loai = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanViens_ChucVus_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangs_KhachHangs_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayShip = table.Column<DateTime>(type: "Datetime", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false),
                    NguoiNhan = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GioHangCTs",
                columns: table => new
                {
                    IdHoa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    DonGiaKhiGiam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangCTs", x => x.IdHoa);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_GioHangs_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_Hoas_IdHoa",
                        column: x => x.IdHoa,
                        principalTable: "Hoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCTs",
                columns: table => new
                {
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCTs", x => x.IdHD);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_HoaDons_IdHD",
                        column: x => x.IdHD,
                        principalTable: "HoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_Hoas_IdHoa",
                        column: x => x.IdHoa,
                        principalTable: "Hoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_IdGioHang",
                table: "GioHangCTs",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_IdKH",
                table: "GioHangs",
                column: "IdKH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_IdHoa",
                table: "HoaDonCTs",
                column: "IdHoa");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienId",
                table: "HoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IdCV",
                table: "NhanViens",
                column: "IdCV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangCTs");

            migrationBuilder.DropTable(
                name: "HoaDonCTs");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "Hoas");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "ChucVus");
        }
    }
}
