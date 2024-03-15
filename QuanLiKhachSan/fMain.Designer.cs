using System;

namespace QuanLiKhachSan
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLPhong = new Guna.UI2.WinForms.Guna2Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnThongTinKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnDKKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.panelmove = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tNgayGio = new System.Windows.Forms.Timer(this.components);
            this.lbNgayGio = new System.Windows.Forms.Label();
            this.uC_Statistic1 = new QuanLiKhachSan.All_user_control.UC_Statistic();
            this.uC_Customer1 = new QuanLiKhachSan.All_user_control.UC_Customer();
            this.uC_CheckOut1 = new QuanLiKhachSan.All_user_control.UC_CheckOut();
            this.uC_Res1 = new QuanLiKhachSan.All_user_control.UC_Res();
            this.uC_AddRoom1 = new QuanLiKhachSan.All_user_control.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Statistic1);
            this.panel1.Controls.Add(this.uC_Customer1);
            this.panel1.Controls.Add(this.uC_CheckOut1);
            this.panel1.Controls.Add(this.uC_Res1);
            this.panel1.Controls.Add(this.uC_AddRoom1);
            this.panel1.Location = new System.Drawing.Point(24, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1884, 742);
            this.panel1.TabIndex = 1;
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.AnimatedGIF = true;
            this.btnQLPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnQLPhong.BorderRadius = 18;
            this.btnQLPhong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLPhong.Checked = true;
            this.btnQLPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLPhong.FillColor = System.Drawing.Color.ForestGreen;
            this.btnQLPhong.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLPhong.ForeColor = System.Drawing.Color.White;
            this.btnQLPhong.Location = new System.Drawing.Point(34, 12);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnQLPhong.Size = new System.Drawing.Size(258, 111);
            this.btnQLPhong.TabIndex = 0;
            this.btnQLPhong.Text = "Quản Lí Phòng";
            this.btnQLPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnThongTinKhachHang);
            this.pnMenu.Controls.Add(this.btnThongKe);
            this.pnMenu.Controls.Add(this.btnDKKH);
            this.pnMenu.Controls.Add(this.btnThanhToan);
            this.pnMenu.Controls.Add(this.btnQLPhong);
            this.pnMenu.Location = new System.Drawing.Point(44, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1832, 130);
            this.pnMenu.TabIndex = 2;
            // 
            // btnThongTinKhachHang
            // 
            this.btnThongTinKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinKhachHang.BorderRadius = 18;
            this.btnThongTinKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTinKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTinKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTinKhachHang.FillColor = System.Drawing.Color.ForestGreen;
            this.btnThongTinKhachHang.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongTinKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnThongTinKhachHang.Location = new System.Drawing.Point(1143, 12);
            this.btnThongTinKhachHang.Name = "btnThongTinKhachHang";
            this.btnThongTinKhachHang.Size = new System.Drawing.Size(258, 111);
            this.btnThongTinKhachHang.TabIndex = 4;
            this.btnThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            this.btnThongTinKhachHang.Click += new System.EventHandler(this.btnThongTinKhachHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderRadius = 18;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.ForestGreen;
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(1507, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(258, 111);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDKKH
            // 
            this.btnDKKH.BackColor = System.Drawing.Color.Transparent;
            this.btnDKKH.BorderRadius = 18;
            this.btnDKKH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDKKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDKKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDKKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDKKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDKKH.FillColor = System.Drawing.Color.ForestGreen;
            this.btnDKKH.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDKKH.ForeColor = System.Drawing.Color.White;
            this.btnDKKH.Location = new System.Drawing.Point(393, 12);
            this.btnDKKH.Name = "btnDKKH";
            this.btnDKKH.Size = new System.Drawing.Size(258, 111);
            this.btnDKKH.TabIndex = 2;
            this.btnDKKH.Text = "Đăng Kí Khách Hàng";
            this.btnDKKH.Click += new System.EventHandler(this.btnDKKH_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.BorderRadius = 18;
            this.btnThanhToan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.ForestGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(782, 12);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(258, 111);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panelmove
            // 
            this.panelmove.BackColor = System.Drawing.Color.Turquoise;
            this.panelmove.Location = new System.Drawing.Point(65, 148);
            this.panelmove.Name = "panelmove";
            this.panelmove.Size = new System.Drawing.Size(265, 7);
            this.panelmove.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 29;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 29;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // tNgayGio
            // 
            this.tNgayGio.Enabled = true;
            this.tNgayGio.Interval = 1000;
            this.tNgayGio.Tick += new System.EventHandler(this.tNgayGio_Tick);
            // 
            // lbNgayGio
            // 
            this.lbNgayGio.AutoSize = true;
            this.lbNgayGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGio.Location = new System.Drawing.Point(1535, 953);
            this.lbNgayGio.Name = "lbNgayGio";
            this.lbNgayGio.Size = new System.Drawing.Size(329, 32);
            this.lbNgayGio.TabIndex = 3;
            this.lbNgayGio.Text = "28/02/2024 9:09:25 CH";
            // 
            // uC_Statistic1
            // 
            this.uC_Statistic1.BackColor = System.Drawing.Color.White;
            this.uC_Statistic1.Location = new System.Drawing.Point(3, 3);
            this.uC_Statistic1.Name = "uC_Statistic1";
            this.uC_Statistic1.Size = new System.Drawing.Size(1882, 780);
            this.uC_Statistic1.TabIndex = 4;
            this.uC_Statistic1.Visible = false;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.White;
            this.uC_Customer1.Location = new System.Drawing.Point(3, 3);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1882, 780);
            this.uC_Customer1.TabIndex = 3;
            this.uC_Customer1.Visible = false;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.Location = new System.Drawing.Point(3, 3);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1882, 780);
            this.uC_CheckOut1.TabIndex = 2;
            this.uC_CheckOut1.Visible = false;
            this.uC_CheckOut1.Load += new System.EventHandler(this.uC_CheckOut1_Load);
            // 
            // uC_Res1
            // 
            this.uC_Res1.BackColor = System.Drawing.Color.White;
            this.uC_Res1.Location = new System.Drawing.Point(3, 3);
            this.uC_Res1.Name = "uC_Res1";
            this.uC_Res1.Size = new System.Drawing.Size(1882, 780);
            this.uC_Res1.TabIndex = 1;
            this.uC_Res1.Visible = false;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_AddRoom1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1884, 742);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // fMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.lbNgayGio);
            this.Controls.Add(this.panelmove);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnQLPhong;
        private System.Windows.Forms.Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Panel panelmove;
        private Guna.UI2.WinForms.Guna2Button btnDKKH;
        private Guna.UI2.WinForms.Guna2Button btnThongTinKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private All_user_control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_user_control.UC_Res uC_Res1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_user_control.UC_CheckOut uC_CheckOut1;
        private System.Windows.Forms.Timer tNgayGio;
        private System.Windows.Forms.Label lbNgayGio;
        private All_user_control.UC_Customer uC_Customer1;
        private All_user_control.UC_Statistic uC_Statistic1;
    }
}