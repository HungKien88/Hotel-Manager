namespace PhanMemQuanLyKhachSan
{
    partial class frmDangNhap
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
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnQuenMatKhau = new System.Windows.Forms.Button();
            this.lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.picMatKhau = new System.Windows.Forms.PictureBox();
            this.picTenDangNhap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDangNhap.Location = new System.Drawing.Point(0, 0);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(487, 71);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Silver;
            this.txtTenDangNhap.Location = new System.Drawing.Point(92, 124);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(375, 30);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTendangnhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTendangnhap_Leave);
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTenDangNhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTenDangNhap.Location = new System.Drawing.Point(92, 152);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(375, 2);
            this.pnlTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.Location = new System.Drawing.Point(92, 192);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(335, 30);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatkhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(134, 335);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(222, 45);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuenMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMatKhau.Location = new System.Drawing.Point(134, 386);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(222, 45);
            this.btnQuenMatKhau.TabIndex = 9;
            this.btnQuenMatKhau.Text = "Quên mật khẩu";
            this.btnQuenMatKhau.UseVisualStyleBackColor = false;
            // 
            // lblChuaCoTaiKhoan
            // 
            this.lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuaCoTaiKhoan.Location = new System.Drawing.Point(134, 496);
            this.lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            this.lblChuaCoTaiKhoan.Size = new System.Drawing.Size(222, 33);
            this.lblChuaCoTaiKhoan.TabIndex = 10;
            this.lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            this.lblChuaCoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangKy.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(134, 532);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(222, 45);
            this.btnDangKy.TabIndex = 11;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMatKhau.ForeColor = System.Drawing.Color.Peru;
            this.pnlMatKhau.Location = new System.Drawing.Point(92, 228);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(375, 2);
            this.pnlMatKhau.TabIndex = 12;
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.iconShow;
            this.btnHienMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienMatKhau.FlatAppearance.BorderSize = 0;
            this.btnHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienMatKhau.Location = new System.Drawing.Point(433, 206);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(34, 21);
            this.btnHienMatKhau.TabIndex = 7;
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            this.btnHienMatKhau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseDown);
            this.btnHienMatKhau.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseUp);
            // 
            // picMatKhau
            // 
            this.picMatKhau.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconPassword;
            this.picMatKhau.Location = new System.Drawing.Point(30, 192);
            this.picMatKhau.Name = "picMatKhau";
            this.picMatKhau.Size = new System.Drawing.Size(40, 38);
            this.picMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatKhau.TabIndex = 6;
            this.picMatKhau.TabStop = false;
            // 
            // picTenDangNhap
            // 
            this.picTenDangNhap.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconUser;
            this.picTenDangNhap.Location = new System.Drawing.Point(30, 124);
            this.picTenDangNhap.Name = "picTenDangNhap";
            this.picTenDangNhap.Size = new System.Drawing.Size(40, 38);
            this.picTenDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenDangNhap.TabIndex = 3;
            this.picTenDangNhap.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 641);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblChuaCoTaiKhoan);
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnHienMatKhau);
            this.Controls.Add(this.picMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.picTenDangNhap);
            this.Controls.Add(this.pnlTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.PictureBox picTenDangNhap;
        private System.Windows.Forms.PictureBox picMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnQuenMatKhau;
        private System.Windows.Forms.Label lblChuaCoTaiKhoan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Panel pnlMatKhau;
    }
}

