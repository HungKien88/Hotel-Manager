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
    public partial class frmCapNhatLoaiPhong : Form
    {
        public frmCapNhatLoaiPhong()
        {
            InitializeComponent();
        }

        private void BtnTroVeCuaQLNV_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong qlp = new frmQuanLyPhong();
            qlp.Show();
            this.Hide();
        }

        private void btnHuyCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
