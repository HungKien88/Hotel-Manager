namespace PhanMemQuanLyKhachSan
{
    partial class ManHinhQuanLyNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapnhatlichlvnv = new System.Windows.Forms.Button();
            this.btnGiaocanv = new System.Windows.Forms.Button();
            this.btnCapnhatthongtinnv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cdrQlnv = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQlnv = new System.Windows.Forms.DataGridView();
            this.btnXemlainv = new System.Windows.Forms.Button();
            this.btnTrovecuaqlnv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlnv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCapnhatlichlvnv);
            this.panel1.Controls.Add(this.btnGiaocanv);
            this.panel1.Controls.Add(this.btnCapnhatthongtinnv);
            this.panel1.Location = new System.Drawing.Point(24, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 181);
            this.panel1.TabIndex = 0;
            // 
            // btnCapnhatlichlvnv
            // 
            this.btnCapnhatlichlvnv.Location = new System.Drawing.Point(6, 72);
            this.btnCapnhatlichlvnv.Name = "btnCapnhatlichlvnv";
            this.btnCapnhatlichlvnv.Size = new System.Drawing.Size(256, 46);
            this.btnCapnhatlichlvnv.TabIndex = 2;
            this.btnCapnhatlichlvnv.Text = "Cập nhật lịch làm việc";
            this.btnCapnhatlichlvnv.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // cdrQlnv
            // 
            this.cdrQlnv.Location = new System.Drawing.Point(24, 276);
            this.cdrQlnv.Name = "cdrQlnv";
            this.cdrQlnv.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQlnv);
            this.panel2.Location = new System.Drawing.Point(334, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 452);
            this.panel2.TabIndex = 3;
            // 
            // dgvQlnv
            // 
            this.dgvQlnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlnv.Location = new System.Drawing.Point(3, 72);
            this.dgvQlnv.Name = "dgvQlnv";
            this.dgvQlnv.RowTemplate.Height = 24;
            this.dgvQlnv.Size = new System.Drawing.Size(821, 380);
            this.dgvQlnv.TabIndex = 0;
            // 
            // btnXemlainv
            // 
            this.btnXemlainv.Location = new System.Drawing.Point(59, 505);
            this.btnXemlainv.Name = "btnXemlainv";
            this.btnXemlainv.Size = new System.Drawing.Size(190, 30);
            this.btnXemlainv.TabIndex = 2;
            this.btnXemlainv.Text = "Xem lại";
            this.btnXemlainv.UseVisualStyleBackColor = true;
            // 
            // btnTrovecuaqlnv
            // 
            this.btnTrovecuaqlnv.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTrovecuaqlnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrovecuaqlnv.Location = new System.Drawing.Point(12, 12);
            this.btnTrovecuaqlnv.Name = "btnTrovecuaqlnv";
            this.btnTrovecuaqlnv.Size = new System.Drawing.Size(101, 26);
            this.btnTrovecuaqlnv.TabIndex = 4;
            this.btnTrovecuaqlnv.Text = "Trở về";
            this.btnTrovecuaqlnv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrovecuaqlnv.UseVisualStyleBackColor = true;
            this.btnTrovecuaqlnv.Click += new System.EventHandler(this.btnTrovecuaqlnv_Click);
            // 
            // ManHinhQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btnTrovecuaqlnv);
            this.Controls.Add(this.btnXemlainv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cdrQlnv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManHinhQuanLyNhanVien";
            this.Text = "ManHinhQuanLyNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGiaocanv;
        private System.Windows.Forms.Button btnCapnhatthongtinnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar cdrQlnv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQlnv;
        private System.Windows.Forms.Button btnXemlainv;
        private System.Windows.Forms.Button btnCapnhatlichlvnv;
        private System.Windows.Forms.Button btnTrovecuaqlnv;
    }
}