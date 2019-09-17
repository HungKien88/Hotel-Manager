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
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnChitiet1_Click(object sender, EventArgs e)
        {
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
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
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet3_Click(object sender, EventArgs e)
        {
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet4_Click(object sender, EventArgs e)
        {
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet5_Click(object sender, EventArgs e)
        {
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet7_Click(object sender, EventArgs e)
        {
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }

        private void btnChitiet8_Click(object sender, EventArgs e)
        {
            ManHinhChiTietPhieuPhong fmmhctpp = new ManHinhChiTietPhieuPhong();
            fmmhctpp.FormClosed += new FormClosedEventHandler(fmmhctpp_FormClosed);
            fmmhctpp.Show();
            this.Hide();
        }
    }
}
