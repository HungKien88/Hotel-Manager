namespace PhanMemQuanLyKhachSan
{
    partial class ManHinhQuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuanlykhachhang = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTrovecuaqlkh = new System.Windows.Forms.Button();
            this.lblNgayden = new System.Windows.Forms.Label();
            this.txtNgayden = new System.Windows.Forms.TextBox();
            this.txtNgaydi = new System.Windows.Forms.TextBox();
            this.lblNgaydi = new System.Windows.Forms.Label();
            this.dgvQuanlykkhachhang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanlykhachhang
            // 
            this.lblQuanlykhachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanlykhachhang.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanlykhachhang.Location = new System.Drawing.Point(0, 0);
            this.lblQuanlykhachhang.Name = "lblQuanlykhachhang";
            this.lblQuanlykhachhang.Size = new System.Drawing.Size(1362, 51);
            this.lblQuanlykhachhang.TabIndex = 0;
            this.lblQuanlykhachhang.Text = "Quản lý khách hàng";
            this.lblQuanlykhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(238, 75);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(869, 37);
            this.txtTimkiem.TabIndex = 2;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLoc;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(1201, 117);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(112, 37);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconTimKiem;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(1170, 74);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(160, 37);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // btnTrovecuaqlkh
            // 
            this.btnTrovecuaqlkh.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrovecuaqlkh.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTrovecuaqlkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrovecuaqlkh.Location = new System.Drawing.Point(27, 75);
            this.btnTrovecuaqlkh.Name = "btnTrovecuaqlkh";
            this.btnTrovecuaqlkh.Size = new System.Drawing.Size(129, 37);
            this.btnTrovecuaqlkh.TabIndex = 1;
            this.btnTrovecuaqlkh.Text = "Trở về";
            this.btnTrovecuaqlkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrovecuaqlkh.UseVisualStyleBackColor = true;
            this.btnTrovecuaqlkh.Click += new System.EventHandler(this.btnTrovecuaqlkh_Click);
            // 
            // lblNgayden
            // 
            this.lblNgayden.AutoSize = true;
            this.lblNgayden.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayden.Location = new System.Drawing.Point(245, 121);
            this.lblNgayden.Name = "lblNgayden";
            this.lblNgayden.Size = new System.Drawing.Size(120, 31);
            this.lblNgayden.TabIndex = 5;
            this.lblNgayden.Text = "Ngày đến:";
            // 
            // txtNgayden
            // 
            this.txtNgayden.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayden.Location = new System.Drawing.Point(371, 118);
            this.txtNgayden.Name = "txtNgayden";
            this.txtNgayden.Size = new System.Drawing.Size(139, 32);
            this.txtNgayden.TabIndex = 6;
            // 
            // txtNgaydi
            // 
            this.txtNgaydi.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaydi.Location = new System.Drawing.Point(968, 120);
            this.txtNgaydi.Name = "txtNgaydi";
            this.txtNgaydi.Size = new System.Drawing.Size(139, 32);
            this.txtNgaydi.TabIndex = 8;
            // 
            // lblNgaydi
            // 
            this.lblNgaydi.AutoSize = true;
            this.lblNgaydi.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaydi.Location = new System.Drawing.Point(851, 121);
            this.lblNgaydi.Name = "lblNgaydi";
            this.lblNgaydi.Size = new System.Drawing.Size(101, 31);
            this.lblNgaydi.TabIndex = 7;
            this.lblNgaydi.Text = "Ngày đi:";
            // 
            // dgvQuanlykkhachhang
            // 
            this.dgvQuanlykkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlykkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlykkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvQuanlykkhachhang.Location = new System.Drawing.Point(27, 223);
            this.dgvQuanlykkhachhang.Name = "dgvQuanlykkhachhang";
            this.dgvQuanlykkhachhang.RowHeadersVisible = false;
            this.dgvQuanlykkhachhang.RowTemplate.Height = 24;
            this.dgvQuanlykkhachhang.Size = new System.Drawing.Size(1303, 404);
            this.dgvQuanlykkhachhang.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quốc tịch";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số phòng ở";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày đến";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày đi";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giá phòng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Số đêm";
            this.Column8.Name = "Column8";
            // 
            // ManHinhQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 690);
            this.Controls.Add(this.dgvQuanlykkhachhang);
            this.Controls.Add(this.txtNgaydi);
            this.Controls.Add(this.lblNgaydi);
            this.Controls.Add(this.txtNgayden);
            this.Controls.Add(this.lblNgayden);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnTrovecuaqlkh);
            this.Controls.Add(this.lblQuanlykhachhang);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManHinhQuanLyKhachHang";
            this.Text = "Màn Hình Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanlykhachhang;
        private System.Windows.Forms.Button btnTrovecuaqlkh;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblNgayden;
        private System.Windows.Forms.TextBox txtNgayden;
        private System.Windows.Forms.TextBox txtNgaydi;
        private System.Windows.Forms.Label lblNgaydi;
        private System.Windows.Forms.DataGridView dgvQuanlykkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}