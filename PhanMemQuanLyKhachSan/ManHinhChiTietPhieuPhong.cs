using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmChiTietPhieuPhong : Form
    {
        public frmManHinhChinh objManHinhChinh;
        public frmChiTietPhieuPhong()
        {
            InitializeComponent();
        }
        public frmChiTietPhieuPhong(frmManHinhChinh frm)
        {

            InitializeComponent();
            objManHinhChinh = frm;
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
        private void FillLoaiPhongCombobox(List<LoaiPhong> listLoaiPhong)
        {
            this.cmbLoaiPhong.DataSource = listLoaiPhong;
            this.cmbLoaiPhong.DisplayMember = "TenLoai";
            this.cmbLoaiPhong.ValueMember = "LoaiPhongID";
        }
        private void FillSoPhongCombobox(List<Phong> listSoPhong)
        {
            this.cmbSoPhong.DataSource = listSoPhong;
            this.cmbSoPhong.DisplayMember = "PhongID";
            this.cmbSoPhong.ValueMember = "PhongID";
        }
        private void FillTenBookingCombobox(List<Booking> listTenBooking)
        {
            this.cmbTenBooking.DataSource = listTenBooking;
            this.cmbTenBooking.DisplayMember = "TenBooking";
            this.cmbTenBooking.ValueMember = "BookingID";
        }
        private void FillComboboxNhanVien(ComboBox cmbName,List<NhanVien> listNhanVien)
        {
            this.cmbNhanVien.DataSource = listNhanVien;
            this.cmbNhanVien.DisplayMember = "TenNV";
            this.cmbNhanVien.ValueMember = "NhanVienID";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //bindgrid khi chương trình tắt đi mở lên vẫn còn dl
        private void BindGrid(List<ChiTietHoaDon> listDichVu)
        {
            dgvChiTietDichVu.Rows.Clear();
            foreach (var item in listDichVu)
            {
                int index = dgvChiTietDichVu.Rows.Add();
                dgvChiTietDichVu.Rows[index].Cells[0].Value = index++;
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
            try
            {

                //insert khách hàng trước mới có hóa đơn
                KhachHang kh = new KhachHang();
                kh.TenKH = txtChiTietTenKhach.Text;
                kh.QuocTich = txtChiTietQuocTich.Text;
                kh = kh.InsertUpdate();
               List<DichVu> listDV = GetListDichVu();

                //insert hoa don
                HoaDon hd = GetHoaDon();

                //insert  khách hàng trước khi insert hóa đơn
                hd.KhachHangID = kh.KhachHangID;
                hd.TongTien = listDV.Sum(p => p.ThanhTien) + int.Parse(txtChiTietGiaPhong.Text) * hd.SoDem.Value;

                int hoaDonID = hd.InsertUpdate();

                //có hóa đơn rồi insert chi tiet hoa don
                foreach(DichVu d in listDV)
                {
                    ChiTietHoaDon item = new ChiTietHoaDon();
                    item.DichVuID = d.DichVuID;
                    item.GiaDV = d.GiaDV;
                    item.HoaDonID = hoaDonID;

                    item.SoLuong = d.SoLuong;
                    item.ThanhTien = d.ThanhTien;
             
                    item.InsertUpdate();                  
                }
                //   GetDichVu();
                objManHinhChinh.SetBookingRoom();
                this.Close();
              //  frmManHinhChinh frm2 = new frmManHinhChinh();
              //  frm2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietPhieuPhong_Load(object sender, EventArgs e)
        {
            SetGridViewStyle(dgvChiTietDichVu);
            FillDichVuCombobox(DichVu.GetAll());
            FillLoaiPhongCombobox(LoaiPhong.GetAll());
            cmbLoaiPhong.SelectedIndex = 0;
            //FillSoPhongCombobox(Phong.GetAll().);
            FillTenBookingCombobox(Booking.GetAll());
            FillComboboxNhanVien(cmbNhanVien, NhanVien.GetAll());
            cmbSoPhong.SelectedIndex = 0;
            cmbNhanVien.SelectedIndex = 0;          
        }

        private HoaDon GetHoaDon()
        {
            HoaDon hd = new HoaDon();
            hd.TenLoai = cmbLoaiPhong.Text;
            hd.NhanVienID = int.Parse(cmbNhanVien.SelectedValue + "");
            hd.PhongID = int.Parse(cmbSoPhong.SelectedValue + "");
            hd.SoDem = int.Parse(txtChiTietSoDem.Text);
            hd.SoKhach = int.Parse(txtChiTietSoKhach.Text);
            hd.NgayHD = dtpNgayDi.Value.ToString("dd/MM/yyyy");

            if(cmbTenBooking.Text != "")
              hd.BookingID = int.Parse(cmbTenBooking.SelectedValue + "");
            return hd;
        }
        private List<DichVu> GetListDichVu()  //lay nguoc tu datagrid ra
        {
            //giá trị có thể là null nên cộng với null để k bị lỗi
            List<DichVu> list = new List<DichVu>();
            foreach (DataGridViewRow row in this.dgvChiTietDichVu.Rows)
            {
                DichVu dv = new DichVu();
                dv.DichVuID = int.Parse(row.Cells["id"].Value + "");
                dv.GiaDV = int.Parse(row.Cells[2].Value + "");
                dv.SoLuong = int.Parse(row.Cells[3].Value + "");
                dv.ThanhTien = int.Parse(row.Cells[4].Value + "");
                list.Add(dv);
            }

            return list;
        }

        private void btnThemCuaCTPP_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dv = DichVu.GetDichVu(int.Parse(cmbTenDichVu.SelectedValue.ToString()));
                if (txtSoLuong.Text == "")
                    throw new Exception("Vui long nhap so luong!");
                int index = dgvChiTietDichVu.Rows.Add();
                dgvChiTietDichVu.Rows[index].Cells[0].Value = (index + 1).ToString();
                dgvChiTietDichVu.Rows[index].Cells[1].Value = dv.TenDV;
                dgvChiTietDichVu.Rows[index].Cells[2].Value = dv.GiaDV + "";
                dgvChiTietDichVu.Rows[index].Cells[3].Value = txtSoLuong.Text + "";
                int thanhtien =  dv.GiaDV.Value * int.Parse(txtSoLuong.Text);
                dgvChiTietDichVu.Rows[index].Cells[4].Value = thanhtien.ToString();

                dgvChiTietDichVu.Rows[index].Cells["id"].Value = dv.DichVuID + "";
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
        }

        private void btnXoaCuaCTPP_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvChiTietDichVu.SelectedRows)
            {
                dgvChiTietDichVu.Rows.RemoveAt(item.Index);
            }
        }

        private void cbxLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
        private void txtChiTietGiaPhong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblThanhTien.Text = ( int.Parse(txtChiTietGiaPhong.Text) * int.Parse(txtChiTietSoDem.Text)).ToString();
            }
            catch 
            {
                lblThanhTien.Text = "";
            }
        }

        private void cmbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSoPhong.SelectedValue != null)
                {
                    Phong objPHong = Phong.GetPhong(int.Parse(cmbSoPhong.SelectedValue + ""));
                    if (objPHong != null)
                    {
                        txtChiTietGiaPhong.Text = objPHong.GiaPhong.ToString();
                    }
                }
            }
            catch { }
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLoaiPhong.SelectedValue != null)
                {
                    LoaiPhong temp =  (LoaiPhong)cmbLoaiPhong.SelectedItem;
                    var list = Phong.GetAll(temp.LoaiPhongID);
                    FillSoPhongCombobox(list);
                }
            }
            catch { }
        }
    }
}
