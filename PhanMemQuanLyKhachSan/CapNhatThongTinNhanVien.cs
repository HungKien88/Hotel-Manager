using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void BindGrid(List<NhanVien> listNhanVien)
        {
            dgvThongTinNhanVien.Rows.Clear();
            int id = 1;
            foreach (var item in listNhanVien)
            {
                int index = dgvThongTinNhanVien.Rows.Add();
                dgvThongTinNhanVien.Rows[index].Cells[0].Value = id++;
                dgvThongTinNhanVien.Rows[index].Cells[1].Value = item.NhanVienID;
                dgvThongTinNhanVien.Rows[index].Cells[2].Value = item.TenNV;
            }
        }
        private void BtnBackTTNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien mhc = new frmQuanLyNhanVien();
            mhc.Show();
            this.Hide();
        }
        private NhanVien GetNhanVien()
        {
            NhanVien k = new NhanVien();
            k.TenNV = txtTimKiemTTNV.Text;
            return k;
        }
        private void frmCapNhatThongTinNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvThongTinNhanVien);
                BindGrid(NhanVien.GetAll());
                string imageFolder = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Images");
                string fileDefaultImage = Path.Combine(imageFolder, "user.png");
                picThongTinNhanVien.Image = Image.FromFile(fileDefaultImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemTTNV_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien s = GetNhanVien();
                NhanVien db = NhanVien.GetNhanVien(s.NhanVienID);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                BindGrid(NhanVien.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaTTNV_Click(object sender, EventArgs e)
        {
            try
            {
                //không xóa được những thằng đang có liên kết đến bảng khác.
                //ví dụ k thể xóa những nv có id 1->3 vì bên lịch làm việc có 3 id nv từ 1->3
                int rowIndex = (int)dgvThongTinNhanVien.CurrentRow.Cells[1].Value;
                NhanVien.Delete(rowIndex);
                BindGrid(NhanVien.GetAll());
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công vì liên quan đến các dữ liệu khác!");
            }
        }

        private void btnLuuTTNV_Click(object sender, EventArgs e)
        {
            NhanVien s = GetNhanVien();
            s.NhanVienID = (int)dgvThongTinNhanVien.CurrentRow.Cells[1].Value;
            NhanVien db = NhanVien.GetNhanVien(s.NhanVienID);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(NhanVien.GetAll());
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThongTinNhanVien.Rows[e.RowIndex];
                int maNV = int.Parse(row.Cells[1].Value.ToString());
                NhanVien db = NhanVien.GetNhanVien(maNV);
                if (db != null)
                {
                    txtTimKiemTTNV.Text = db.TenNV.ToString();
                    string imageFolder = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Images");
                    string fileDefaultImage = Path.Combine(imageFolder, "user.png");
                    if (db.PathImage != null)
                    {
                        string filePath = Path.Combine(imageFolder, db.PathImage);
                        if (File.Exists(filePath))
                        {
                            picThongTinNhanVien.Image = Image.FromFile(filePath);
                        }
                        else
                        {
                            if (File.Exists(fileDefaultImage))
                                picThongTinNhanVien.Image = Image.FromFile(fileDefaultImage);
                        }
                        //  string pathFile =  
                    }
                    else
                    {
                        if (File.Exists(fileDefaultImage))
                            picThongTinNhanVien.Image = Image.FromFile(fileDefaultImage);
                    }
                }
            }
        }

        private void btnTimKiemTTNV_Click(object sender, EventArgs e)
        {
            List<NhanVien> listKQTK = NhanVien.GetAll();
            var listTimNhanVien = listKQTK.Where(p => (p is NhanVien) && (p as NhanVien).TenNV.ToLower().Contains(txtTimKiemTTNV.Text.ToLower())).ToList();
            if(listTimNhanVien.Count > 0)
            {
                BindGrid(listTimNhanVien);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào!");
            }        
        }

        private void btnHuyCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {
            BindGrid(NhanVien.GetAll());
        }
    }
}
