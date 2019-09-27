namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyNhanVien
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
            this.pnlQuanLyNhanVien = new System.Windows.Forms.Panel();
            this.btnCapnhatlichlvnv = new System.Windows.Forms.Button();
            this.btnGiaocanv = new System.Windows.Forms.Button();
            this.btnCapnhatthongtinnv = new System.Windows.Forms.Button();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.cdrQLNV = new System.Windows.Forms.MonthCalendar();
            this.pnlQLNV = new System.Windows.Forms.Panel();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.btnXemLaiNV = new System.Windows.Forms.Button();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.pnlQuanLyNhanVien.SuspendLayout();
            this.pnlQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuanLyNhanVien
            // 
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapnhatlichlvnv);
            this.pnlQuanLyNhanVien.Controls.Add(this.btnGiaocanv);
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapnhatthongtinnv);
            this.pnlQuanLyNhanVien.Location = new System.Drawing.Point(24, 83);
            this.pnlQuanLyNhanVien.Name = "pnlQuanLyNhanVien";
            this.pnlQuanLyNhanVien.Size = new System.Drawing.Size(262, 181);
            this.pnlQuanLyNhanVien.TabIndex = 0;
            // 
            // btnCapnhatlichlvnv
            // 
            this.btnCapnhatlichlvnv.Location = new System.Drawing.Point(6, 72);
            this.btnCapnhatlichlvnv.Name = "btnCapnhatlichlvnv";
            this.btnCapnhatlichlvnv.Size = new System.Drawing.Size(256, 46);
            this.btnCapnhatlichlvnv.TabIndex = 2;
            this.btnCapnhatlichlvnv.Text = "Cập nhật lịch làm việc";
            this.btnCapnhatlichlvnv.UseVisualStyleBackColor = true;
            this.btnCapnhatlichlvnv.Click += new System.EventHandler(this.BtnCapnhatlichlvnv_Click);
            // 
            // btnGiaocanv
            // 
            this.btnGiaocanv.Location = new System.Drawing.Point(6, 132);
            this.btnGiaocanv.Name = "btnGiaocanv";
            this.btnGiaocanv.Size = new System.Drawing.Size(256, 46);
            this.btnGiaocanv.TabIndex = 1;
            this.btnGiaocanv.Text = "Giao ca";
            this.btnGiaocanv.UseVisualStyleBackColor = true;
            this.btnGiaocanv.Click += new System.EventHandler(this.btnGiaocanv_Click);
            // 
            // btnCapnhatthongtinnv
            // 
            this.btnCapnhatthongtinnv.Location = new System.Drawing.Point(3, 15);
            this.btnCapnhatthongtinnv.Name = "btnCapnhatthongtinnv";
            this.btnCapnhatthongtinnv.Size = new System.Drawing.Size(256, 46);
            this.btnCapnhatthongtinnv.TabIndex = 0;
            this.btnCapnhatthongtinnv.Text = "Cập nhật thông tin nhân viên";
            this.btnCapnhatthongtinnv.UseVisualStyleBackColor = true;
            this.btnCapnhatthongtinnv.Click += new System.EventHandler(this.btnCapnhatthongtinnv_Click);
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(441, 30);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(245, 29);
            this.lblQuanLyNhanVien.TabIndex = 1;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // cdrQLNV
            // 
            this.cdrQLNV.Location = new System.Drawing.Point(24, 276);
            this.cdrQLNV.Name = "cdrQLNV";
            this.cdrQLNV.TabIndex = 2;
            // 
            // pnlQLNV
            // 
            this.pnlQLNV.Controls.Add(this.dgvQLNV);
            this.pnlQLNV.Location = new System.Drawing.Point(334, 83);
            this.pnlQLNV.Name = "pnlQLNV";
            this.pnlQLNV.Size = new System.Drawing.Size(827, 452);
            this.pnlQLNV.TabIndex = 3;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(3, 72);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.Size = new System.Drawing.Size(821, 380);
            this.dgvQLNV.TabIndex = 0;
            // 
            // btnXemLaiNV
            // 
            this.btnXemLaiNV.Location = new System.Drawing.Point(59, 505);
            this.btnXemLaiNV.Name = "btnXemLaiNV";
            this.btnXemLaiNV.Size = new System.Drawing.Size(190, 30);
            this.btnXemLaiNV.TabIndex = 2;
            this.btnXemLaiNV.Text = "Xem lại";
            this.btnXemLaiNV.UseVisualStyleBackColor = true;
            this.btnXemLaiNV.Click += new System.EventHandler(this.BtnXemLaiNV_Click);
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(101, 26);
            this.btnTroVeCuaQLNV.TabIndex = 4;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = true;
            this.btnTroVeCuaQLNV.Click += new System.EventHandler(this.btnTrovecuaqlnv_Click);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.btnXemLaiNV);
            this.Controls.Add(this.pnlQLNV);
            this.Controls.Add(this.cdrQLNV);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Controls.Add(this.pnlQuanLyNhanVien);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyNhanVien";
            this.Text = "ManHinhQuanLyNhanVien";
            this.pnlQuanLyNhanVien.ResumeLayout(false);
            this.pnlQLNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyNhanVien;
        private System.Windows.Forms.Button btnGiaocanv;
        private System.Windows.Forms.Button btnCapnhatthongtinnv;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.MonthCalendar cdrQLNV;
        private System.Windows.Forms.Panel pnlQLNV;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.Button btnXemLaiNV;
        private System.Windows.Forms.Button btnCapnhatlichlvnv;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
    }
}