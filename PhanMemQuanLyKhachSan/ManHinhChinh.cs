using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }
          
        public void SetBookingRoom()
        {
            var listHD = HoaDon.GetAll();
            var hd1 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 1);
            if (hd1 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd1.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd1.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking1.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach1.Text = hd1.KhachHang.TenKH;
                    lblNoiDungSoKhach1.Text = hd1.SoKhach + "";
                    lblNoiDungQuocTich1.Text = hd1.KhachHang.QuocTich;
                    lblNoiDungNgayDen1.Text = dt.AddDays(0 - hd1.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi1.Text = hd1.NgayHD;
                    //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
                }
            }

            var hd2 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 2);
            if (hd2 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd2.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd2.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking2.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach2.Text = hd2.KhachHang.TenKH;
                    lblNoiDungSoKhach2.Text = hd2.SoKhach + "";
                    lblNoiDungQuocTich2.Text = hd2.KhachHang.QuocTich;
                    lblNoiDungNgayDen2.Text = dt.AddDays(0 - hd2.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi2.Text = hd2.NgayHD;
                }
            }

            var hd3 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 3);
            if (hd3 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd3.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd3.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking3.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach3.Text = hd3.KhachHang.TenKH;
                    lblNoiDungSoKhach3.Text = hd3.SoKhach + "";
                    lblNoiDungQuocTich3.Text = hd3.KhachHang.QuocTich;
                    lblNoiDungNgayDen3.Text = dt.AddDays(0 - hd3.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi3.Text = hd3.NgayHD;
                }
            }

            var hd4 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 4);
            if (hd4 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd4.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd4.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking4.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach4.Text = hd4.KhachHang.TenKH;
                    lblNoiDungSoKhach4.Text = hd4.SoKhach + "";
                    lblNoiDungQuocTich4.Text = hd4.KhachHang.QuocTich;
                    lblNoiDungNgayDen4.Text = dt.AddDays(0 - hd4.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi4.Text = hd4.NgayHD;
                }
            }

            var hd5 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 5);
            if (hd5 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd5.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd5.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking5.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach5.Text = hd5.KhachHang.TenKH;
                    lblNoiDungSoKhach5.Text = hd5.SoKhach + "";
                    lblNoiDungQuocTich5.Text = hd5.KhachHang.QuocTich;
                    lblNoiDungNgayDen5.Text = dt.AddDays(0 - hd5.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi5.Text = hd5.NgayHD;
                }
            }

            var hd6 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 6);
            if (hd6 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd6.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd6.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking6.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach6.Text = hd6.KhachHang.TenKH;
                    lblNoiDungSoKhach6.Text = hd6.SoKhach + "";
                    lblNoiDungQuocTich6.Text = hd6.KhachHang.QuocTich;
                    lblNoiDungNgayDen6.Text = dt.AddDays(0 - hd6.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi6.Text = hd6.NgayHD;
                }
            }

            var hd7 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 7);
            if (hd7 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd7.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd7.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking7.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach7.Text = hd7.KhachHang.TenKH;
                    lblNoiDungSoKhach7.Text = hd7.SoKhach + "";
                    lblNoiDungQuocTich7.Text = hd7.KhachHang.QuocTich;
                    lblNoiDungNgayDen7.Text = dt.AddDays(0 - hd7.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi7.Text = hd7.NgayHD;
                }
            }

            var hd8 = listHD.LastOrDefault(p => p.PhongID != null && p.PhongID == 8);
            if (hd8 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            {
                DateTime dt = DateTime.ParseExact(hd8.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Date >= DateTime.Now)
                {
                    Booking findBook = Booking.GetBooking(hd8.BookingID.Value);
                    if (findBook != null)
                    {
                        lblNoiDungTenBooking8.Text = findBook.TenBooking;
                    }
                    lblNoiDungTenKhach8.Text = hd8.KhachHang.TenKH;
                    lblNoiDungSoKhach8.Text = hd8.SoKhach + "";
                    lblNoiDungQuocTich8.Text = hd8.KhachHang.QuocTich;
                    lblNoiDungNgayDen8.Text = dt.AddDays(0 - hd8.SoDem.Value).ToString("dd/MM/yyyy");
                    lblNoiDungNgayDi8.Text = hd8.NgayHD;
                }
            }
        }

        private void btnChitiet1_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong(this);
            fmmhctpp.Show();
        
        }
        private void fmmhctpp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang fmqlkh = new frmQuanLyKhachHang();
            fmqlkh.Show();
            this.Hide();
        }

        private void fmqlkh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void LblKhachSan_Click(object sender, EventArgs e)
        {

        }

        private void FrmManHinhChinh_Load(object sender, EventArgs e)
        {
            SetBookingRoom();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.Show();
         
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLienHe frmLienHe = new frmLienHe();
            frmLienHe.Show();
            this.Hide();
        }

        private void cậpNhậtVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatVatTu frmCapNhatVatTu = new frmCapNhatVatTu();
            frmCapNhatVatTu.Show();
            this.Hide();
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatDichVu frmCapNhatDichVu = new frmCapNhatDichVu();
            frmCapNhatDichVu.Show();
            this.Hide();
        }

        private void cậpNhậtLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatLoaiPhong frmCapNhatLoaiPhong = new frmCapNhatLoaiPhong();
            frmCapNhatLoaiPhong.Show();
            this.Hide();
        }

        private void cậpNhậtThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frmNhanVien = new frmQuanLyNhanVien();
            frmNhanVien.Show();
            this.Hide();
        }


        private void cậpNhậtLịchLàmViệcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatLichLamViec frmcnllv = new frmCapNhatLichLamViec();
            frmcnllv.Show();
            this.Hide();
        }
        private void lblTien1_Click(object sender, EventArgs e)
        {

        }

        private void lblSoPhong1_Click(object sender, EventArgs e)
        {

        }

        private void pnlPhong1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong qlp = new frmQuanLyPhong();
            qlp.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien qlnv = new frmQuanLyNhanVien();
            qlnv.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut1_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking1.Text = ".........................................";
            lblNoiDungTenKhach1.Text = ".........................................";
            lblNoiDungSoKhach1.Text = ".........................................";
            lblNoiDungQuocTich1.Text = ".........................................";
            lblNoiDungNgayDen1.Text = ".........................................";
            lblNoiDungNgayDi1.Text = ".........................................";
            //lblNoiDungTien1.Text = ".........................................";
            lblPhong1.BackColor = Color.Gray;
        }

        private void btnCheckOut2_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking2.Text = ".........................................";
            lblNoiDungTenKhach2.Text = ".........................................";
            lblNoiDungSoKhach2.Text = ".........................................";
            lblNoiDungQuocTich2.Text = ".........................................";
            lblNoiDungNgayDen2.Text = ".........................................";
            lblNoiDungNgayDi2.Text = ".........................................";
            //lblNoiDungTien2.Text = ".........................................";
            lblPhong2.BackColor = Color.Gray;
        }

        private void btnCheckOut3_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking3.Text = ".........................................";
            lblNoiDungTenKhach3.Text = ".........................................";
            lblNoiDungSoKhach3.Text = ".........................................";
            lblNoiDungQuocTich3.Text = ".........................................";
            lblNoiDungNgayDen3.Text = ".........................................";
            lblNoiDungNgayDi3.Text = ".........................................";
            //lblNoiDungTien3.Text = ".........................................";
            lblPhong3.BackColor = Color.Gray;
        }

        private void btnCheckOut4_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking4.Text = ".........................................";
            lblNoiDungTenKhach4.Text = ".........................................";
            lblNoiDungSoKhach4.Text = ".........................................";
            lblNoiDungQuocTich4.Text = ".........................................";
            lblNoiDungNgayDen4.Text = ".........................................";
            lblNoiDungNgayDi4.Text = ".........................................";
            //lblNoiDungTien4.Text = ".........................................";
            lblPhong4.BackColor = Color.Gray;
        }

        private void btnCheckOut5_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking5.Text = ".........................................";
            lblNoiDungTenKhach5.Text = ".........................................";
            lblNoiDungSoKhach5.Text = ".........................................";
            lblNoiDungQuocTich5.Text = ".........................................";
            lblNoiDungNgayDen5.Text = ".........................................";
            lblNoiDungNgayDi5.Text = ".........................................";
            //lblNoiDungTien5.Text = ".........................................";
            lblPhong5.BackColor = Color.Gray;
        }
        private void btnCheckOut6_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking6.Text = ".........................................";
            lblNoiDungTenKhach6.Text = ".........................................";
            lblNoiDungSoKhach6.Text = ".........................................";
            lblNoiDungQuocTich6.Text = ".........................................";
            lblNoiDungNgayDen6.Text = ".........................................";
            lblNoiDungNgayDi6.Text = ".........................................";
            //lblNoiDungTien6.Text = ".........................................";
            lblPhong6.BackColor = Color.Gray;
        }
        private void btnCheckOut7_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking7.Text = ".........................................";
            lblNoiDungTenKhach7.Text = ".........................................";
            lblNoiDungSoKhach7.Text = ".........................................";
            lblNoiDungQuocTich7.Text = ".........................................";
            lblNoiDungNgayDen7.Text = ".........................................";
            lblNoiDungNgayDi7.Text = ".........................................";
            //lblNoiDungTien7.Text = ".........................................";
            lblPhong7.BackColor = Color.Gray;
        }
        private void btnCheckOut8_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking8.Text = ".........................................";
            lblNoiDungTenKhach8.Text = ".........................................";
            lblNoiDungSoKhach8.Text = ".........................................";
            lblNoiDungQuocTich8.Text = ".........................................";
            lblNoiDungNgayDen8.Text = ".........................................";
            lblNoiDungNgayDi8.Text = ".........................................";
            //lblNoiDungTien8.Text = ".........................................";
            lblPhong8.BackColor = Color.Gray;
        }

        private void cmbPhong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong1.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong1.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong1.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong1.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong2.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong2.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong2.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong2.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong2.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong3.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong3.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong3.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong3.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong3.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong4.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong4.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong4.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong4.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong4.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong5.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong5.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong5.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong5.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong5.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong6.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong6.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong6.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong6.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong6.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong7.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong7.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong7.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong7.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong7.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong8.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong8.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong8.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong8.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong8.BackColor = Color.Gray;
                    break;
            }
        }

        private void lblSoKhach3_Click(object sender, EventArgs e)
        {

        }
    }
}
