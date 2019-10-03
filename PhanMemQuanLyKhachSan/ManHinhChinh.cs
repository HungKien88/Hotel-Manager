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
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
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
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet3_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet4_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet5_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet7_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet8_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        

        

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang fmqlkh = new frmQuanLyKhachHang();
            fmqlkh.FormClosed += new FormClosedEventHandler(fmqlkh_FormClosed);
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

        private void giaoCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoCa frmGiaoCa = new frmGiaoCa();
            frmGiaoCa.Show();
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
           lblNoiDungTenBooking1.Text = frmChiTietPhieuPhong.SetValueForText1;
            lblNoiDungTenKhach1.Text = frmChiTietPhieuPhong.SetValueForText2;
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong qlp = new frmQuanLyPhong();
            qlp.Show();
            this.Hide();
        }
    }
}
