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
    public partial class frmCapNhatDichVu : Form
    {
        public frmCapNhatDichVu()
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
        private void Button1_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong mqv = new frmQuanLyPhong();
            mqv.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
  
        }
        private void BindGrid(List<DichVu> listDichVu)
        {
            dgvCapNhatDichVu.Rows.Clear();
            int id = 1;
            foreach (var item in listDichVu)
            {
                int index = dgvCapNhatDichVu.Rows.Add();
                dgvCapNhatDichVu.Rows[index].Cells[0].Value = id++;
                dgvCapNhatDichVu.Rows[index].Cells[1].Value = item.DichVuID;
                dgvCapNhatDichVu.Rows[index].Cells[2].Value = item.TenDV;
                dgvCapNhatDichVu.Rows[index].Cells[3].Value = item.GiaDV;
            }
        }
        private void frmCapNhatDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvCapNhatDichVu);
                BindGrid(DichVu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DichVu GetDichVu()
        {
            DichVu k = new DichVu();
            k.TenDV = txtCapNhatDichVu.Text;
            k.GiaDV = int.Parse(txtGia.Text);
            return k;
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu s = GetDichVu();
                DichVu db = DichVu.GetDichVu(s.DichVuID);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
                BindGrid(DichVu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = (int)dgvCapNhatDichVu.CurrentRow.Cells[1].Value;
                DichVu.Delete(rowIndex);
                BindGrid(DichVu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCapNhatDichVu.Rows[e.RowIndex];
                int maDV = int.Parse(row.Cells[1].Value.ToString());
                DichVu db = DichVu.GetDichVu(maDV);
                txtCapNhatDichVu.Text = db.TenDV.ToString();
                txtGia.Text = db.GiaDV.ToString();
            }
        }

        private void btnLuuCapNhatDichVu_Click(object sender, EventArgs e)
        {
            DichVu s = GetDichVu();
            s.DichVuID = (int)dgvCapNhatDichVu.CurrentRow.Cells[1].Value;
            DichVu db = DichVu.GetDichVu(s.DichVuID);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(DichVu.GetAll());
        }
    }
}
