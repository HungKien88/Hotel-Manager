using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PhanMemQuanLyKhachSan.Table
{
    class PMQLKS:DbContext
    {
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LichLamViec> LichLamViecs { get; set; }
        public DbSet<GiaoCa> GiaoCas { get; set; }
        public DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<VatTu> VatTus { get; set; }
        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<DangNhap> DangNhaps { get; set; }
    }
}
