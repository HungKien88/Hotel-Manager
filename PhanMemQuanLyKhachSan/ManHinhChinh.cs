using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnChitiet1_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.Show();
            this.Hide();
        }
        private void fmmhctpp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnChitiet2_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet3_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet4_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet5_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet7_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();          
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet8_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.Show();
            this.Hide();
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

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.Show();
            this.Hide();
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
            lblNoDungSoKhach1.Text = ".........................................";
            lblNoiDungQuocTich1.Text = ".........................................";
            lblNoiDungNgayDen1.Text = ".........................................";
            lblNoiDungTien1.Text = ".........................................";
            lblPhong1.BackColor = Color.Gray;
        }

        private void btnCheckOut2_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking2.Text = ".........................................";
            lblNoiDungTenKhach2.Text = ".........................................";
            lblNoDungSoKhach2.Text = ".........................................";
            lblNoiDungQuocTich2.Text = ".........................................";
            lblNoiDungNgayDen2.Text = ".........................................";
            lblNoiDungTien2.Text = ".........................................";
            lblPhong2.BackColor = Color.Gray;
        }

        private void btnCheckOut3_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking3.Text = ".........................................";
            lblNoiDungTenKhach3.Text = ".........................................";
            lblNoDungSoKhach3.Text = ".........................................";
            lblNoiDungQuocTich3.Text = ".........................................";
            lblNoiDungNgayDen3.Text = ".........................................";
            lblNoiDungTien3.Text = ".........................................";
            lblPhong3.BackColor = Color.Gray;
        }

        private void btnCheckOut4_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking4.Text = ".........................................";
            lblNoiDungTenKhach4.Text = ".........................................";
            lblNoDungSoKhach4.Text = ".........................................";
            lblNoiDungQuocTich4.Text = ".........................................";
            lblNoiDungNgayDen4.Text = ".........................................";
            lblNoiDungTien4.Text = ".........................................";
            lblPhong4.BackColor = Color.Gray;
        }

        private void btnCheckOut5_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking5.Text = ".........................................";
            lblNoiDungTenKhach5.Text = ".........................................";
            lblNoDungSoKhach5.Text = ".........................................";
            lblNoiDungQuocTich5.Text = ".........................................";
            lblNoiDungNgayDen5.Text = ".........................................";
            lblNoiDungTien5.Text = ".........................................";
            lblPhong5.BackColor = Color.Gray;
        }
        private void btnCheckOut6_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking6.Text = ".........................................";
            lblNoiDungTenKhach6.Text = ".........................................";
            lblNoDungSoKhach6.Text = ".........................................";
            lblNoiDungQuocTich6.Text = ".........................................";
            lblNoiDungNgayDen6.Text = ".........................................";
            lblNoiDungTien6.Text = ".........................................";
            lblPhong6.BackColor = Color.Gray;
        }
        private void btnCheckOut7_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking7.Text = ".........................................";
            lblNoiDungTenKhach7.Text = ".........................................";
            lblNoDungSoKhach7.Text = ".........................................";
            lblNoiDungQuocTich7.Text = ".........................................";
            lblNoiDungNgayDen7.Text = ".........................................";
            lblNoiDungTien7.Text = ".........................................";
            lblPhong7.BackColor = Color.Gray;
        }
        private void btnCheckOut8_Click(object sender, EventArgs e)
        {
            lblNoiDungTenBooking8.Text = ".........................................";
            lblNoiDungTenKhach8.Text = ".........................................";
            lblNoDungSoKhach8.Text = ".........................................";
            lblNoiDungQuocTich8.Text = ".........................................";
            lblNoiDungNgayDen8.Text = ".........................................";
            lblNoiDungTien8.Text = ".........................................";
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
    }
}
