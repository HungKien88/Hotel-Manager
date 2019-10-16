namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("LoaiPhong")]
    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        public int LoaiPhongID { get; set; }

        [StringLength(15)]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
    public partial class LoaiPhong
    {
        public static List<LoaiPhong> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.LoaiPhongs.ToList();
        }
        public static LoaiPhong GetLoaiPhong(int idLoaiPhong)
        {
            QLKSModel context = new QLKSModel();
            return context.LoaiPhongs.Where(p => p.LoaiPhongID == idLoaiPhong).FirstOrDefault();
        }
    }
}
