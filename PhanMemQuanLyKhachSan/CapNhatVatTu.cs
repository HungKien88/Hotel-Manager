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
    public partial class frmCapNhatVatTu : Form
    {
        public frmCapNhatVatTu()
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
        private void BtnThoatCapNhatVatTu_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong qlp = new frmQuanLyPhong();
            qlp.Show();
            this.Hide();
        }

        private void BindGrid(List<VatTu> listVatTu)
        {
            dgvCapNhatVatTu.Rows.Clear();
            int id = 1;
            foreach (var item in listVatTu)
            {
                int index = dgvCapNhatVatTu.Rows.Add();
                dgvCapNhatVatTu.Rows[index].Cells[0].Value = id++;
                dgvCapNhatVatTu.Rows[index].Cells[1].Value = item.VatTuID;
                dgvCapNhatVatTu.Rows[index].Cells[2].Value = item.TenVT;
            }
        }
        private void frmCapNhatVatTu_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvCapNhatVatTu);
                BindGrid(VatTu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private VatTu GetVatTu()
        {
            VatTu k = new VatTu();          
            k.TenVT = txtCapNhatVatTu.Text;
            return k;
        }

        private void btnThemDichVuVT_Click(object sender, EventArgs e)
        {
            try
            {
                VatTu s = GetVatTu();
                VatTu db = VatTu.GetVatTu(s.VatTuID);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm vật tư thành công!");
                }
                BindGrid(VatTu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaDichVuVT_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = (int)dgvCapNhatVatTu.CurrentRow.Cells[1].Value;
                VatTu.Delete(rowIndex);
                BindGrid(VatTu.GetAll());
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
                DataGridViewRow row = this.dgvCapNhatVatTu.Rows[e.RowIndex];
                int maVT = int.Parse(row.Cells[1].Value.ToString());
                VatTu db = VatTu.GetVatTu(maVT);
                txtCapNhatVatTu.Text = db.TenVT.ToString();
            }
        }
        
        private void btnLuuCapNhatVatTu_Click(object sender, EventArgs e)
        {
            VatTu s = GetVatTu();
            s.VatTuID = (int)dgvCapNhatVatTu.CurrentRow.Cells[1].Value;
            VatTu db = VatTu.GetVatTu(s.VatTuID);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(VatTu.GetAll());
        }
    }
}
