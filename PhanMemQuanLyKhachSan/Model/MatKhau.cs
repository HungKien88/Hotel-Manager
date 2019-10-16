namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("MatKhau")]
    public partial class MatKhau
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }
    public partial class MatKhau
    {
        public List<MatKhau> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.MatKhaus.ToList();
        }
    }
}
