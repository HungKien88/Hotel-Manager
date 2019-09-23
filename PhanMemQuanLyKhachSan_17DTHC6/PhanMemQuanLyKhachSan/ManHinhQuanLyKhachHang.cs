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
    public partial class ManHinhQuanLyKhachHang : Form
    {
        public ManHinhQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnTrovecuaqlkh_Click(object sender, EventArgs e)
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
    }
}
