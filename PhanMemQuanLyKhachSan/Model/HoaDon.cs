namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int HoaDonID { get; set; }

        public int? NhanVienID { get; set; }

        public int? KhachHangID { get; set; }

        public int? PhongID { get; set; }

        [StringLength(15)]
        public string TenLoai { get; set; }

        public int? SoDem { get; set; }

        public int? SoKhach { get; set; }

        [StringLength(15)]
        public string NgayHD { get; set; }

        public int? TongTien { get; set; }

        public int? BookingID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Phong Phong { get; set; }
    }

    public partial class HoaDon
    {
        public static List<HoaDon> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.HoaDons.ToList();
        }
        public static HoaDon GetHoaDon(int hoaDonId)
        {
            QLKSModel context = new QLKSModel();
            return context.HoaDons.Where(p => p.HoaDonID == hoaDonId).FirstOrDefault();
        }
        public static HoaDon GetHoaDonByPhong(int? phongId)
        {
            QLKSModel context = new QLKSModel();
            return context.HoaDons.LastOrDefault(p => p.PhongID == phongId);

        }
        
        public int InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.HoaDons.AddOrUpdate(this);
            return context.SaveChanges();
        }
    }
}
