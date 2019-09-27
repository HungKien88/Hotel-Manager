namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyKhachHang
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
            this.lblQuanLyKhachHang = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTroVeCuaQLKH = new System.Windows.Forms.Button();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.txtNgayDi = new System.Windows.Forms.TextBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dgvQuanLyKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLyKhachHang
            // 
            this.lblQuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyKhachHang.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyKhachHang.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyKhachHang.Name = "lblQuanLyKhachHang";
            this.lblQuanLyKhachHang.Size = new System.Drawing.Size(1362, 51);
            this.lblQuanLyKhachHang.TabIndex = 0;
            this.lblQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.lblQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(238, 75);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(869, 31);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLoc;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(1121, 113);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(83, 37);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconTimKiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1121, 69);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnTroVeCuaQLKH
            // 
            this.btnTroVeCuaQLKH.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLKH.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLKH.Location = new System.Drawing.Point(27, 75);
            this.btnTroVeCuaQLKH.Name = "btnTroVeCuaQLKH";
            this.btnTroVeCuaQLKH.Size = new System.Drawing.Size(129, 37);
            this.btnTroVeCuaQLKH.TabIndex = 1;
            this.btnTroVeCuaQLKH.Text = "Trở về";
            this.btnTroVeCuaQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLKH.UseVisualStyleBackColor = true;
            this.btnTroVeCuaQLKH.Click += new System.EventHandler(this.btnTrovecuaqlkh_Click);
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.Location = new System.Drawing.Point(245, 121);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(92, 24);
            this.lblNgayDen.TabIndex = 5;
            this.lblNgayDen.Text = "Ngày đến:";
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDen.Location = new System.Drawing.Point(371, 118);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(139, 27);
            this.txtNgayDen.TabIndex = 6;
            // 
            // txtNgayDi
            // 
            this.txtNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDi.Location = new System.Drawing.Point(968, 120);
            this.txtNgayDi.Name = "txtNgayDi";
            this.txtNgayDi.Size = new System.Drawing.Size(139, 27);
            this.txtNgayDi.TabIndex = 8;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(851, 121);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(78, 24);
            this.lblNgayDi.TabIndex = 7;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // dgvQuanLyKhachHang
            // 
            this.dgvQuanLyKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvQuanLyKhachHang.Location = new System.Drawing.Point(27, 223);
            this.dgvQuanLyKhachHang.Name = "dgvQuanLyKhachHang";
            this.dgvQuanLyKhachHang.RowHeadersVisible = false;
            this.dgvQuanLyKhachHang.RowTemplate.Height = 24;
            this.dgvQuanLyKhachHang.Size = new System.Drawing.Size(1303, 404);
            this.dgvQuanLyKhachHang.TabIndex = 9;
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
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 690);
            this.Controls.Add(this.dgvQuanLyKhachHang);
            this.Controls.Add(this.txtNgayDi);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.lblNgayDen);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTroVeCuaQLKH);
            this.Controls.Add(this.lblQuanLyKhachHang);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyKhachHang";
            this.Text = "Màn Hình Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyKhachHang;
        private System.Windows.Forms.Button btnTroVeCuaQLKH;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.TextBox txtNgayDi;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DataGridView dgvQuanLyKhachHang;
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