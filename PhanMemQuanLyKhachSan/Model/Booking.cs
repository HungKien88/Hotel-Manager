namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Booking")]
    public partial class Booking
    {
        public int BookingID { get; set; }

        [StringLength(50)]
        public string TenBooking { get; set; }
    }
    public partial class Booking
    {
        public static List<Booking> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.Bookings.ToList();
        }
        public static Booking GetBooking(int bookingid)
        {
            QLKSModel context = new QLKSModel();
            return context.Bookings.Where(p => p.BookingID == bookingid).FirstOrDefault();
        }
    }
}
