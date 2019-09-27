namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyPhong
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
            this.btnCapNhatVatTu = new System.Windows.Forms.Button();
            this.btnCapNhatDVPhong = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.lblQuanLyPhong = new System.Windows.Forms.Label();
            this.dgvQuanLyPhong = new System.Windows.Forms.DataGridView();
            this.btnTroVeCuaCTPP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatVatTu
            // 
            this.btnCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatVatTu.Location = new System.Drawing.Point(45, 101);
            this.btnCapNhatVatTu.Name = "btnCapNhatVatTu";
            this.btnCapNhatVatTu.Size = new System.Drawing.Size(100, 59);
            this.btnCapNhatVatTu.TabIndex = 0;
            this.btnCapNhatVatTu.Text = "Cập nhật vật tư";
            this.btnCapNhatVatTu.UseVisualStyleBackColor = true;
            this.btnCapNhatVatTu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCapNhatDVPhong
            // 
            this.btnCapNhatDVPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDVPhong.Location = new System.Drawing.Point(45, 236);
            this.btnCapNhatDVPhong.Name = "btnCapNhatDVPhong";
            this.btnCapNhatDVPhong.Size = new System.Drawing.Size(100, 59);
            this.btnCapNhatDVPhong.TabIndex = 1;
            this.btnCapNhatDVPhong.Text = "Cập nhật dịch vụ";
            this.btnCapNhatDVPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatDVPhong.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnCapNhatLoaiPhong
            // 
            this.btnCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiPhong.Location = new System.Drawing.Point(45, 394);
            this.btnCapNhatLoaiPhong.Name = "btnCapNhatLoaiPhong";
            this.btnCapNhatLoaiPhong.Size = new System.Drawing.Size(100, 76);
            this.btnCapNhatLoaiPhong.TabIndex = 2;
            this.btnCapNhatLoaiPhong.Text = "Cập nhật loại phòng";
            this.btnCapNhatLoaiPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatLoaiPhong.Click += new System.EventHandler(this.ButtonCapNhapLoaiPhong_Click);
            // 
            // lblQuanLyPhong
            // 
            this.lblQuanLyPhong.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyPhong.Location = new System.Drawing.Point(535, 9);
            this.lblQuanLyPhong.Name = "lblQuanLyPhong";
            this.lblQuanLyPhong.Size = new System.Drawing.Size(218, 42);
            this.lblQuanLyPhong.TabIndex = 3;
            this.lblQuanLyPhong.Text = "Quản Lý Phòng";
            this.lblQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvQuanLyPhong
            // 
            this.dgvQuanLyPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhong.Location = new System.Drawing.Point(290, 101);
            this.dgvQuanLyPhong.Name = "dgvQuanLyPhong";
            this.dgvQuanLyPhong.Size = new System.Drawing.Size(824, 369);
            this.dgvQuanLyPhong.TabIndex = 4;
            // 
            // btnTroVeCuaCTPP
            // 
            this.btnTroVeCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCTPP.Location = new System.Drawing.Point(12, 9);
            this.btnTroVeCuaCTPP.Name = "btnTroVeCuaCTPP";
            this.btnTroVeCuaCTPP.Size = new System.Drawing.Size(87, 36);
            this.btnTroVeCuaCTPP.TabIndex = 5;
            this.btnTroVeCuaCTPP.Text = "Trở về";
            this.btnTroVeCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCTPP.UseVisualStyleBackColor = true;
            this.btnTroVeCuaCTPP.Click += new System.EventHandler(this.BtnTroVeCuaCTPP_Click);
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 537);
            this.Controls.Add(this.btnTroVeCuaCTPP);
            this.Controls.Add(this.dgvQuanLyPhong);
            this.Controls.Add(this.lblQuanLyPhong);
            this.Controls.Add(this.btnCapNhatLoaiPhong);
            this.Controls.Add(this.btnCapNhatDVPhong);
            this.Controls.Add(this.btnCapNhatVatTu);
            this.Name = "frmQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatVatTu;
        private System.Windows.Forms.Button btnCapNhatDVPhong;
        private System.Windows.Forms.Button btnCapNhatLoaiPhong;
        private System.Windows.Forms.Label lblQuanLyPhong;
        private System.Windows.Forms.DataGridView dgvQuanLyPhong;
        private System.Windows.Forms.Button btnTroVeCuaCTPP;
    }
}