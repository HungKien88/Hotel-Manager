using PhanMemQuanLyKhachSan.Model;
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
        public frmChiTietPhieuPhong()
        {
            InitializeComponent();
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmManHinhChinh fmmhc = new frmManHinhChinh();       
            fmmhc.Show();
            this.Hide();
        }
        private void BindGrid(List<ChiTietHoaDon> listVatTu)
        {
            dgvChiTietDichVu.Rows.Clear();
            int id = 1;
            foreach (var item in listVatTu)
            {
                int index = dgvChiTietDichVu.Rows.Add();
                dgvChiTietDichVu.Rows[index].Cells[0].Value = id++;
                dgvChiTietDichVu.Rows[index].Cells[1].Value = item.DichVuID;
                dgvChiTietDichVu.Rows[index].Cells[2].Value = item.GiaDV;
            }
        }
        private void fmmhc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLuuCuaCTPP_Click(object sender, EventArgs e)
        {               
            frmManHinhChinh frm2 = new frmManHinhChinh();
            frm2.Show();
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietPhieuPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
