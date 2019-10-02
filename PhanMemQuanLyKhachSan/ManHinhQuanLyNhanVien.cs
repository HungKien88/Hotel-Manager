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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnGiaocanv_Click(object sender, EventArgs e)
        {
            frmGiaoCa fmmhgc = new frmGiaoCa();
            fmmhgc.FormClosed += new FormClosedEventHandler(fmmhgc_FormClosed);
            fmmhgc.Show();
            this.Hide();
        }
        private void fmmhgc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnTrovecuaqlnv_Click(object sender, EventArgs e)
        {
            frmManHinhChinh fmmhc = new frmManHinhChinh();
            fmmhc.FormClosed += new FormClosedEventHandler(fmmhc_FormClosed);
            fmmhc.Show();
            this.Hide();
        }
        private void fmmhc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnCapnhatthongtinnv_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTinNhanVien cnttnv = new frmCapNhatThongTinNhanVien();
            cnttnv.FormClosed += new FormClosedEventHandler(xttnv_FormClosed);
            cnttnv.Show();
            this.Hide();
        }
        private void xttnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void BtnCapnhatlichlvnv_Click(object sender, EventArgs e)
        {

        }

        private void BtnXemLaiNV_Click(object sender, EventArgs e)
        {

        }
    }
}
