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
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatVatTu
            // 
            this.btnCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatVatTu.Location = new System.Drawing.Point(60, 124);
            this.btnCapNhatVatTu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatVatTu.Name = "btnCapNhatVatTu";
            this.btnCapNhatVatTu.Size = new System.Drawing.Size(133, 73);
            this.btnCapNhatVatTu.TabIndex = 0;
            this.btnCapNhatVatTu.Text = "Cập nhật vật tư";
            this.btnCapNhatVatTu.UseVisualStyleBackColor = true;
            this.btnCapNhatVatTu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCapNhatDVPhong
            // 
            this.btnCapNhatDVPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDVPhong.Location = new System.Drawing.Point(60, 290);
            this.btnCapNhatDVPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatDVPhong.Name = "btnCapNhatDVPhong";
            this.btnCapNhatDVPhong.Size = new System.Drawing.Size(133, 73);
            this.btnCapNhatDVPhong.TabIndex = 1;
            this.btnCapNhatDVPhong.Text = "Cập nhật dịch vụ";
            this.btnCapNhatDVPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatDVPhong.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnCapNhatLoaiPhong
            // 
            this.btnCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiPhong.Location = new System.Drawing.Point(60, 485);
            this.btnCapNhatLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatLoaiPhong.Name = "btnCapNhatLoaiPhong";
            this.btnCapNhatLoaiPhong.Size = new System.Drawing.Size(133, 94);
            this.btnCapNhatLoaiPhong.TabIndex = 2;
            this.btnCapNhatLoaiPhong.Text = "Cập nhật loại phòng";
            this.btnCapNhatLoaiPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatLoaiPhong.Click += new System.EventHandler(this.ButtonCapNhapLoaiPhong_Click);
            // 
            // lblQuanLyPhong
            // 
            this.lblQuanLyPhong.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyPhong.Location = new System.Drawing.Point(713, 11);
            this.lblQuanLyPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuanLyPhong.Name = "lblQuanLyPhong";
            this.lblQuanLyPhong.Size = new System.Drawing.Size(291, 52);
            this.lblQuanLyPhong.TabIndex = 3;
            this.lblQuanLyPhong.Text = "Quản Lý Phòng";
            this.lblQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvQuanLyPhong
            // 
            this.dgvQuanLyPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhong.Location = new System.Drawing.Point(387, 124);
            this.dgvQuanLyPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQuanLyPhong.Name = "dgvQuanLyPhong";
            this.dgvQuanLyPhong.Size = new System.Drawing.Size(1099, 454);
            this.dgvQuanLyPhong.TabIndex = 4;
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 661);
            this.Controls.Add(this.dgvQuanLyPhong);
            this.Controls.Add(this.lblQuanLyPhong);
            this.Controls.Add(this.btnCapNhatLoaiPhong);
            this.Controls.Add(this.btnCapNhatDVPhong);
            this.Controls.Add(this.btnCapNhatVatTu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyPhong";
            this.Text = "QuanLyPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatVatTu;
        private System.Windows.Forms.Button btnCapNhatDVPhong;
        private System.Windows.Forms.Button btnCapNhatLoaiPhong;
        private System.Windows.Forms.Label lblQuanLyPhong;
        private System.Windows.Forms.DataGridView dgvQuanLyPhong;
    }
}