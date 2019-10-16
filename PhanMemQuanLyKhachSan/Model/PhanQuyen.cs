namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }

    public partial class PhanQuyen
    {
        public List<PhanQuyen> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.PhanQuyens.ToList();
        }
    }
}
