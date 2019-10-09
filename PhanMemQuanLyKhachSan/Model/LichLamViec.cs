namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichLamViec")]
    public partial class LichLamViec
    {
        public int LichLamViecID { get; set; }

        public int? NhanVienID { get; set; }

        [StringLength(10)]
        public string Ca { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
