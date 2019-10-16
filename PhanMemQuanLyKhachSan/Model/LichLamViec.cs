namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
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
        public static List<LichLamViec> GetLichLamViecHienTai(string ngayHienTai)
        {
            QLKSModel context = new QLKSModel();
            return context.LichLamViecs.Where(p => p.Ngay == ngayHienTai).ToList();
        }
    }
}
