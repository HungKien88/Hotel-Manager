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
        private void FillDichVuCombobox(List<DichVu> listDichVu)
        {
            this.cmbTenDichVu.DataSource = listDichVu;
            this.cmbTenDichVu.DisplayMember = "TenDV";
            this.cmbTenDichVu.ValueMember = "DichVuID";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmManHinhChinh fmmhc = new frmManHinhChinh();       
            fmmhc.Show();
            this.Hide();
        }
        private void BindGrid(List<ChiTietHoaDon> listDichVu)
        {
            dgvChiTietDichVu.Rows.Clear();
            int id = 1;
            foreach (var item in listDichVu)
            {
                int index = dgvChiTietDichVu.Rows.Add();
                dgvChiTietDichVu.Rows[index].Cells[0].Value = id++;
                dgvChiTietDichVu.Rows[index].Cells[1].Value = item.DichVuID;
                //dgvChiTietDichVu.Rows[index].Cells[2].Value = ;
                dgvChiTietDichVu.Rows[index].Cells[3].Value = item.GiaDV;
                dgvChiTietDichVu.Rows[index].Cells[4].Value = item.SoLuong;
                dgvChiTietDichVu.Rows[index].Cells[5].Value = item.ThanhTien;
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
            SetGridViewStyle(dgvChiTietDichVu);
            FillDichVuCombobox(DichVu.GetAll());
        }
        private void GetDichVu()
        {
            string ten = cmbTenDichVu.SelectedText.ToString();
        }

        private void btnThemCuaCTPP_Click(object sender, EventArgs e)
        {
            try
            {
                GetDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tendv = cmbTenDichVu.SelectedItem.ToString();
            List<DichVu> listKQTK = DichVu.GetAll();
            //var gia = listKQTK.Where(p)
        }

        private void btnXoaCuaCTPP_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvChiTietDichVu.SelectedRows)
            {
                dgvChiTietDichVu.Rows.RemoveAt(item.Index);
            }
        }
    }
}
