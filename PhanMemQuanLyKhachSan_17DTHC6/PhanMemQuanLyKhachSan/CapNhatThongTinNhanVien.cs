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
    public partial class frmCapNhatThongTinNhanVien : Form
    {
        public frmCapNhatThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void BtnBackTTNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien mhc = new frmQuanLyNhanVien();
            mhc.Show();
            this.Hide();
        }
    }
}
