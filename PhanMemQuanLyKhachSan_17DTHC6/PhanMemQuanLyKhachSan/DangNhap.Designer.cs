namespace PhanMemQuanLyKhachSan
{
    partial class DangNhap
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
            this.lblDangnhap = new System.Windows.Forms.Label();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.pnlTendangnhap = new System.Windows.Forms.Panel();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.btnHienmatkhau = new System.Windows.Forms.Button();
            this.picMatkhau = new System.Windows.Forms.PictureBox();
            this.picTendangnhap = new System.Windows.Forms.PictureBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnQuenmatkhau = new System.Windows.Forms.Button();
            this.lblChuacotaikhoan = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.pnlMatkhau = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTendangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangnhap
            // 
            this.lblDangnhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDangnhap.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangnhap.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDangnhap.Location = new System.Drawing.Point(0, 0);
            this.lblDangnhap.Name = "lblDangnhap";
            this.lblDangnhap.Size = new System.Drawing.Size(487, 71);
            this.lblDangnhap.TabIndex = 0;
            this.lblDangnhap.Text = "Đăng nhập";
            this.lblDangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.BackColor = System.Drawing.SystemColors.Control;
            this.txtTendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTendangnhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendangnhap.ForeColor = System.Drawing.Color.Silver;
            this.txtTendangnhap.Location = new System.Drawing.Point(92, 124);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(375, 30);
            this.txtTendangnhap.TabIndex = 1;
            this.txtTendangnhap.Text = "Tên đăng nhập";
            this.txtTendangnhap.Enter += new System.EventHandler(this.txtTendangnhap_Enter);
            this.txtTendangnhap.Leave += new System.EventHandler(this.txtTendangnhap_Leave);
            // 
            // pnlTendangnhap
            // 
            this.pnlTendangnhap.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTendangnhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTendangnhap.Location = new System.Drawing.Point(92, 152);
            this.pnlTendangnhap.Name = "pnlTendangnhap";
            this.pnlTendangnhap.Size = new System.Drawing.Size(375, 2);
            this.pnlTendangnhap.TabIndex = 2;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackColor = System.Drawing.SystemColors.Control;
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.ForeColor = System.Drawing.Color.Silver;
            this.txtMatkhau.Location = new System.Drawing.Point(92, 192);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(335, 30);
            this.txtMatkhau.TabIndex = 4;
            this.txtMatkhau.Text = "Mật khẩu";
            this.txtMatkhau.Enter += new System.EventHandler(this.txtMatkhau_Enter);
            this.txtMatkhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // btnHienmatkhau
            // 
            this.btnHienmatkhau.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.iconShowpassword;
            this.btnHienmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienmatkhau.FlatAppearance.BorderSize = 0;
            this.btnHienmatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienmatkhau.Location = new System.Drawing.Point(433, 192);
            this.btnHienmatkhau.Name = "btnHienmatkhau";
            this.btnHienmatkhau.Size = new System.Drawing.Size(34, 30);
            this.btnHienmatkhau.TabIndex = 7;
            this.btnHienmatkhau.UseVisualStyleBackColor = true;
            this.btnHienmatkhau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseDown);
            this.btnHienmatkhau.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseUp);
            // 
            // picMatkhau
            // 
            this.picMatkhau.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconPassword;
            this.picMatkhau.Location = new System.Drawing.Point(30, 192);
            this.picMatkhau.Name = "picMatkhau";
            this.picMatkhau.Size = new System.Drawing.Size(40, 38);
            this.picMatkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatkhau.TabIndex = 6;
            this.picMatkhau.TabStop = false;
            // 
            // picTendangnhap
            // 
            this.picTendangnhap.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconUser;
            this.picTendangnhap.Location = new System.Drawing.Point(30, 124);
            this.picTendangnhap.Name = "picTendangnhap";
            this.picTendangnhap.Size = new System.Drawing.Size(40, 38);
            this.picTendangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTendangnhap.TabIndex = 3;
            this.picTendangnhap.TabStop = false;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangnhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(134, 335);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(222, 45);
            this.btnDangnhap.TabIndex = 8;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            // 
            // btnQuenmatkhau
            // 
            this.btnQuenmatkhau.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuenmatkhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenmatkhau.Location = new System.Drawing.Point(134, 386);
            this.btnQuenmatkhau.Name = "btnQuenmatkhau";
            this.btnQuenmatkhau.Size = new System.Drawing.Size(222, 45);
            this.btnQuenmatkhau.TabIndex = 9;
            this.btnQuenmatkhau.Text = "Quên mật khẩu";
            this.btnQuenmatkhau.UseVisualStyleBackColor = false;
            // 
            // lblChuacotaikhoan
            // 
            this.lblChuacotaikhoan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuacotaikhoan.Location = new System.Drawing.Point(134, 496);
            this.lblChuacotaikhoan.Name = "lblChuacotaikhoan";
            this.lblChuacotaikhoan.Size = new System.Drawing.Size(222, 33);
            this.lblChuacotaikhoan.TabIndex = 10;
            this.lblChuacotaikhoan.Text = "Chưa có tài khoản?";
            this.lblChuacotaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangky
            // 
            this.btnDangky.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangky.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.Location = new System.Drawing.Point(134, 532);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(222, 45);
            this.btnDangky.TabIndex = 11;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = false;
            // 
            // pnlMatkhau
            // 
            this.pnlMatkhau.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMatkhau.ForeColor = System.Drawing.Color.Peru;
            this.pnlMatkhau.Location = new System.Drawing.Point(92, 228);
            this.pnlMatkhau.Name = "pnlMatkhau";
            this.pnlMatkhau.Size = new System.Drawing.Size(375, 2);
            this.pnlMatkhau.TabIndex = 12;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 641);
            this.Controls.Add(this.pnlMatkhau);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.lblChuacotaikhoan);
            this.Controls.Add(this.btnQuenmatkhau);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.btnHienmatkhau);
            this.Controls.Add(this.picMatkhau);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.picTendangnhap);
            this.Controls.Add(this.pnlTendangnhap);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.lblDangnhap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.picMatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTendangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangnhap;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Panel pnlTendangnhap;
        private System.Windows.Forms.PictureBox picTendangnhap;
        private System.Windows.Forms.PictureBox picMatkhau;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Button btnHienmatkhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnQuenmatkhau;
        private System.Windows.Forms.Label lblChuacotaikhoan;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Panel pnlMatkhau;
    }
}

