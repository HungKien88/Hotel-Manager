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
    public partial class frmChiTietPhieuPhong : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public frmChiTietPhieuPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnLuuCuaCTPP_Click(object sender, EventArgs e)
        {
            SetValueForText1 = txtChiTietTenBooking.Text;
            SetValueForText2 = txtChiTietTenKhach.Text;
            

            frmManHinhChinh frm2 = new frmManHinhChinh();
            frm2.Show();

        }
    }
}
