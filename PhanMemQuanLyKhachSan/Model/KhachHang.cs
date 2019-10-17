namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();

        }

        public int KhachHangID { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(50)]
        public string QuocTich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }

    public partial class KhachHang
    {
        public static List<KhachHang> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.KhachHangs.ToList();
        }
        public static KhachHang GetKhachHang(int khachHangId)
        {
            QLKSModel context = new QLKSModel();
            return context.KhachHangs.Where(p => p.KhachHangID == khachHangId).FirstOrDefault();

        }
        public KhachHang InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            KhachHang kh = context.KhachHangs.Add(this);
            context.SaveChanges();
            return kh;
        }
    }
}
