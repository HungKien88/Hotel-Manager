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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
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
        private void BindGrid(List<KhachHang> listKhachHang)
        {
            dgvQuanLyKhachHang.Rows.Clear();

            foreach (var item in listKhachHang)
            {
                int index = dgvQuanLyKhachHang.Rows.Add();
                dgvQuanLyKhachHang.Rows[index].Cells[0].Value = item.KhachHangID;
                dgvQuanLyKhachHang.Rows[index].Cells[1].Value = item.TenKH;
                dgvQuanLyKhachHang.Rows[index].Cells[2].Value = item.QuocTich;
            }
        }

        private void btnTrovecuaqlkh_Click(object sender, EventArgs e)
        {
            frmManHinhChinh fmmhc = new frmManHinhChinh();
            fmmhc.Show();
            this.Hide();
        }

        private void fmmhc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvQuanLyKhachHang);
                BindGrid(KhachHang.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblQuanLyKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<KhachHang> listkh = new List<KhachHang>();
            List<HoaDon> listHD = HoaDon.GetAll();
            DateTime tungay = DateTime.Parse(dtpTuNgay.Text);
            DateTime denngay = DateTime.Parse(dtpTuNgay.Text);
            foreach (var item in listHD)
            {
                DateTime dt = DateTime.Parse(item.NgayHD);
                if(dt >= tungay && dt <= denngay)
                {
                    KhachHang kh = new KhachHang();
                    kh.KhachHangID = ((int)item.KhachHangID);
                    kh.TenKH = (item.KhachHang.TenKH);
                    kh.TenKH = (item.KhachHang.QuocTich);
                    listkh.Add(kh);
                }
            }
            BindGrid(listkh);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<KhachHang> listKQTK = KhachHang.GetAll();
            var listKhacHang = listKQTK.Where(p => (p is KhachHang) && (p as KhachHang).TenKH.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            if (listKhacHang.Count > 0)
            {
                BindGrid(listKhacHang);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào!");
            }
        }

        private void btnHuyCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {
            BindGrid(KhachHang.GetAll());
        }
    }
}
