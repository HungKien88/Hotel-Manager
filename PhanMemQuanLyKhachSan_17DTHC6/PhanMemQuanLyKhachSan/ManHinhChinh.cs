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

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong fmqlp = new frmQuanLyPhong();
            fmqlp.FormClosed += new FormClosedEventHandler(fmqlp_FormClosed);
            fmqlp.Show();
            this.Hide();
        }

        private void fmqlp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien fmqlnv = new frmQuanLyNhanVien();
            fmqlnv.FormClosed += new FormClosedEventHandler(fmqlnv_FormClosed);
            fmqlnv.Show();
            this.Hide();
        }

        private void fmqlnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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

       /* private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/
    }
}
