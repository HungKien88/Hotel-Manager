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
    public partial class ManHinhQuanLyNhanVien : Form
    {
        public ManHinhQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnGiaocanv_Click(object sender, EventArgs e)
        {
            ManHinhGiaoCa fmmhgc = new ManHinhGiaoCa();
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
            ManHinhChinh fmmhc = new ManHinhChinh();
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
            XemThongTinNhanVien xttnv = new XemThongTinNhanVien();
            xttnv.FormClosed += new FormClosedEventHandler(xttnv_FormClosed);
            xttnv.Show();
            this.Hide();
        }
        private void xttnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
