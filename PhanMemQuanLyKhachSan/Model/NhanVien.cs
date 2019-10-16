namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            LichLamViecs = new HashSet<LichLamViec>();
        }

        public int NhanVienID { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(200)]
        public string PathImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichLamViec> LichLamViecs { get; set; }
    }

    public partial class NhanVien
    {
        public static List<NhanVien> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.NhanViens.ToList();
        }
        public static NhanVien GetNhanVien(int idNhanVien)
        {
            QLKSModel context = new QLKSModel();
            return context.NhanViens.Where(p => p.NhanVienID == idNhanVien).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.NhanViens.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLKSModel context = new QLKSModel();
            NhanVien db = context.NhanViens.Where(p => p.NhanVienID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.NhanViens.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
