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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

            
        }

        private void txtTendangnhap_Enter(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "Tên đăng nhập")
            {
                txtTendangnhap.Text = "";
                txtTendangnhap.ForeColor = Color.Black;
            }
        }

        private void txtTendangnhap_Leave(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "")
            {
                txtTendangnhap.Text = "Tên đăng nhập";
                txtTendangnhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "Mật khẩu")
            {
                txtMatkhau.UseSystemPasswordChar = true;
                txtMatkhau.Text = "";
                txtMatkhau.ForeColor = Color.Black;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            
            if (txtMatkhau.Text == "")
            {
                txtMatkhau.UseSystemPasswordChar = false;
                txtMatkhau.Text = "Mật khẩu";
                txtMatkhau.ForeColor = Color.Silver;
            }
        }

        private void btnHienmatkhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = false;
        }

        private void btnHienmatkhau_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = true;
        }
    }
}
