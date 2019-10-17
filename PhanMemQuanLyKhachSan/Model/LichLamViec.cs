namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("LichLamViec")]
    public partial class LichLamViec
    {
        public int LichLamViecID { get; set; }

        public int? NhanVienID { get; set; }

        [StringLength(10)]
        public string Ca { get; set; }

        [StringLength(50)]
        public string Ngay { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
    public partial class LichLamViec
    {
        public static List<LichLamViec> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.LichLamViecs.ToList();
        }
        public static LichLamViec GetLichLamViec(int lichLamViecId)
        {
            QLKSModel context = new QLKSModel();
            return context.LichLamViecs.Where(p => p.LichLamViecID == lichLamViecId).FirstOrDefault();
        }
        //?ang x? lý
        public static List<LichLamViec> GetLichLamViecHienTai(string ngayHienTai)
        {
            QLKSModel context = new QLKSModel();
            return context.LichLamViecs.Where(p => p.Ngay == ngayHienTai).ToList();
        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.LichLamViecs.AddOrUpdate(this);
            context.SaveChanges();
        }
        public static void Delete(int id)
        {
            QLKSModel context = new QLKSModel();
            LichLamViec db = context.LichLamViecs.Where(p => p.LichLamViecID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.LichLamViecs.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
