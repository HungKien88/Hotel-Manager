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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
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
        private void BindGrid(List<LichLamViec> listLichLamViec)
        {
            dgvLichLamViec.Rows.Clear();
            int id = 1;
            foreach (var item in listLichLamViec)
            {
                int index = dgvLichLamViec.Rows.Add();
                dgvLichLamViec.Rows[index].Cells[0].Value = id++;
                dgvLichLamViec.Rows[index].Cells[1].Value = item.NhanVien.TenNV;
                dgvLichLamViec.Rows[index].Cells[2].Value = item.Ca;
                dgvLichLamViec.Rows[index].Cells[3].Value = item.Ngay;
                dgvLichLamViec.Rows[index].Cells[4].Value = item.NhanVienID;
            }
        }
        private void fmmhgc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnTrovecuaqlnv_Click(object sender, EventArgs e)
        {
            frmManHinhChinh fmmhc = new frmManHinhChinh(); 
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
            cnttnv.Show();
            this.Hide();
        }
        private void xttnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void BtnCapnhatlichlvnv_Click(object sender, EventArgs e)
        {
            frmCapNhatLichLamViec llv = new frmCapNhatLichLamViec();
            llv.Show();
            this.Hide();
        }

        private void BtnXemLaiNV_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvLichLamViec);
                BindGrid(LichLamViec.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlQLNV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
