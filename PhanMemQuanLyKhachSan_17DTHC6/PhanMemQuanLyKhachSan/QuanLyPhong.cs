using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmQuanLyPhong : Form
    {
        public frmQuanLyPhong()
        {
            InitializeComponent();
        }

        private void ButtonCapNhapLoaiPhong_Click(object sender, EventArgs e)
        {
            frmCapNhatLoaiPhong fmb = new frmCapNhatLoaiPhong();
            fmb.FormClosed += new FormClosedEventHandler(fmb_FormClosed);
            fmb.Show();
            this.Hide();
        }
        private void fmb_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmCapNhatDichVu fmdv = new frmCapNhatDichVu();
            fmdv.FormClosed += new FormClosedEventHandler(fmdv_FormClosed);
            fmdv.Show();
            this.Hide();
        }
        private void fmdv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmCapNhatVatTu fmvt = new frmCapNhatVatTu();
            fmvt.FormClosed += new FormClosedEventHandler(fmdv_FormClosed);
            fmvt.Show();
            this.Hide();
        }
        private void fmvt_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
