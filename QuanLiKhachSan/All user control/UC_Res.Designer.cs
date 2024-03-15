using System;

namespace QuanLiKhachSan.All_user_control
{
    partial class UC_Res
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbDKKH = new System.Windows.Forms.Label();
            this.lbHoTenKH = new System.Windows.Forms.Label();
            this.tbHTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.cbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.tbDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.cbSoPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbKieuPhong = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayThue = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbKieuPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDangKiKH = new Guna.UI2.WinForms.Guna2Button();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tbGiaTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.tcapNhatNgay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbDKKH
            // 
            this.lbDKKH.AutoSize = true;
            this.lbDKKH.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbDKKH.Location = new System.Drawing.Point(650, 27);
            this.lbDKKH.Name = "lbDKKH";
            this.lbDKKH.Size = new System.Drawing.Size(402, 58);
            this.lbDKKH.TabIndex = 0;
            this.lbDKKH.Text = "Đăng Kí Khách Hàng";
            // 
            // lbHoTenKH
            // 
            this.lbHoTenKH.AutoSize = true;
            this.lbHoTenKH.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTenKH.Location = new System.Drawing.Point(140, 140);
            this.lbHoTenKH.Name = "lbHoTenKH";
            this.lbHoTenKH.Size = new System.Drawing.Size(86, 24);
            this.lbHoTenKH.TabIndex = 1;
            this.lbHoTenKH.Text = "Họ Tên : ";
            // 
            // tbHTKH
            // 
            this.tbHTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHTKH.DefaultText = "";
            this.tbHTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHTKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbHTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHTKH.Location = new System.Drawing.Point(127, 178);
            this.tbHTKH.Name = "tbHTKH";
            this.tbHTKH.PasswordChar = '\0';
            this.tbHTKH.PlaceholderText = "Nhập Họ Tên";
            this.tbHTKH.SelectedText = "";
            this.tbHTKH.Size = new System.Drawing.Size(431, 46);
            this.tbHTKH.TabIndex = 2;
            this.tbHTKH.TextChanged += new System.EventHandler(this.tbHTKH_TextChanged);
            // 
            // tbCCCD
            // 
            this.tbCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCCCD.DefaultText = "";
            this.tbCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCCCD.Location = new System.Drawing.Point(699, 304);
            this.tbCCCD.Name = "tbCCCD";
            this.tbCCCD.PasswordChar = '\0';
            this.tbCCCD.PlaceholderText = "Nhập số CCCD";
            this.tbCCCD.SelectedText = "";
            this.tbCCCD.Size = new System.Drawing.Size(431, 46);
            this.tbCCCD.TabIndex = 4;
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCCCD.Location = new System.Drawing.Point(712, 264);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(69, 24);
            this.lbCCCD.TabIndex = 3;
            this.lbCCCD.Text = "CCCD :";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGioiTinh.ItemHeight = 30;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(127, 436);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(431, 36);
            this.cbGioiTinh.TabIndex = 5;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGioiTinh.Location = new System.Drawing.Point(140, 399);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(96, 24);
            this.lbGioiTinh.TabIndex = 6;
            this.lbGioiTinh.Text = "Giới Tính :";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgaySinh.Location = new System.Drawing.Point(140, 264);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(115, 24);
            this.lbNgaySinh.TabIndex = 9;
            this.lbNgaySinh.Text = "Ngày Sinh : ";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiaChi.DefaultText = "";
            this.tbDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiaChi.Location = new System.Drawing.Point(699, 178);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.PasswordChar = '\0';
            this.tbDiaChi.PlaceholderText = "Nhập Địa Chỉ";
            this.tbDiaChi.SelectedText = "";
            this.tbDiaChi.Size = new System.Drawing.Size(431, 46);
            this.tbDiaChi.TabIndex = 8;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(712, 140);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(88, 24);
            this.lbDiaChi.TabIndex = 7;
            this.lbDiaChi.Text = "Địa Chỉ : ";
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoPhong.Location = new System.Drawing.Point(1265, 399);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(104, 24);
            this.lbSoPhong.TabIndex = 18;
            this.lbSoPhong.Text = "Số Phòng :";
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbSoPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSoPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSoPhong.ItemHeight = 30;
            this.cbSoPhong.Location = new System.Drawing.Point(1255, 436);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(431, 36);
            this.cbSoPhong.TabIndex = 17;
            this.cbSoPhong.SelectedIndexChanged += new System.EventHandler(this.cbSoPhong_SelectedIndexChanged);
            // 
            // lbKieuPhong
            // 
            this.lbKieuPhong.AutoSize = true;
            this.lbKieuPhong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKieuPhong.Location = new System.Drawing.Point(1265, 264);
            this.lbKieuPhong.Name = "lbKieuPhong";
            this.lbKieuPhong.Size = new System.Drawing.Size(121, 24);
            this.lbKieuPhong.TabIndex = 15;
            this.lbKieuPhong.Text = "Kiểu Phòng :";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(1265, 140);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(124, 24);
            this.lbLoaiPhong.TabIndex = 13;
            this.lbLoaiPhong.Text = "Loại Phòng : ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.AllowDrop = true;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(127, 304);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShowUpDown = true;
            this.dtpNgaySinh.Size = new System.Drawing.Size(431, 46);
            this.dtpNgaySinh.TabIndex = 19;
            this.dtpNgaySinh.Value = new System.DateTime(2024, 2, 16, 17, 53, 22, 428);
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Checked = true;
            this.dtpNgayThue.Enabled = false;
            this.dtpNgayThue.FillColor = System.Drawing.Color.White;
            this.dtpNgayThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(699, 426);
            this.dtpNgayThue.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayThue.MinDate = new System.DateTime(2024, 2, 16, 0, 0, 0, 0);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(431, 46);
            this.dtpNgayThue.TabIndex = 21;
            this.dtpNgayThue.Value = new System.DateTime(2024, 2, 16, 17, 53, 22, 459);
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.AutoSize = true;
            this.lbNgayDK.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayDK.Location = new System.Drawing.Point(712, 388);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(185, 24);
            this.lbNgayDK.TabIndex = 20;
            this.lbNgayDK.Text = "Ngày Thuê Phòng  : ";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiPhong.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.cbLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiPhong.ItemHeight = 30;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "VIP",
            "Thường"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(1255, 178);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(431, 36);
            this.cbLoaiPhong.TabIndex = 22;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // cbKieuPhong
            // 
            this.cbKieuPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbKieuPhong.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.cbKieuPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKieuPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKieuPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKieuPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKieuPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKieuPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbKieuPhong.ItemHeight = 30;
            this.cbKieuPhong.Items.AddRange(new object[] {
            "Đơn",
            "Đôi",
            "Gia Đình"});
            this.cbKieuPhong.Location = new System.Drawing.Point(1255, 304);
            this.cbKieuPhong.Name = "cbKieuPhong";
            this.cbKieuPhong.Size = new System.Drawing.Size(431, 36);
            this.cbKieuPhong.TabIndex = 23;
            this.cbKieuPhong.SelectedIndexChanged += new System.EventHandler(this.cbKieuPhong_SelectedIndexChanged);
            // 
            // btnDangKiKH
            // 
            this.btnDangKiKH.BorderRadius = 18;
            this.btnDangKiKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKiKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKiKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKiKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKiKH.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKiKH.ForeColor = System.Drawing.Color.White;
            this.btnDangKiKH.Location = new System.Drawing.Point(909, 656);
            this.btnDangKiKH.Name = "btnDangKiKH";
            this.btnDangKiKH.Size = new System.Drawing.Size(294, 62);
            this.btnDangKiKH.TabIndex = 24;
            this.btnDangKiKH.Text = "Đăng Kí";
            this.btnDangKiKH.Click += new System.EventHandler(this.btnDangKiKH_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(127, 565);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.PlaceholderText = "Nhập số điện thoại";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(431, 46);
            this.tbPhone.TabIndex = 26;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhone.Location = new System.Drawing.Point(140, 528);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(147, 24);
            this.lbPhone.TabIndex = 25;
            this.lbPhone.Text = "Số Điện Thoại : ";
            // 
            // btnClear
            // 
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderRadius = 17;
            this.btnClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnClear.DefaultAutoSize = true;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(794, 672);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 37);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbGiaTien
            // 
            this.tbGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGiaTien.DefaultText = "";
            this.tbGiaTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbGiaTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbGiaTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGiaTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGiaTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGiaTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGiaTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGiaTien.Location = new System.Drawing.Point(1255, 565);
            this.tbGiaTien.Name = "tbGiaTien";
            this.tbGiaTien.PasswordChar = '\0';
            this.tbGiaTien.PlaceholderText = "";
            this.tbGiaTien.ReadOnly = true;
            this.tbGiaTien.SelectedText = "";
            this.tbGiaTien.Size = new System.Drawing.Size(439, 36);
            this.tbGiaTien.TabIndex = 29;
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaTien.Location = new System.Drawing.Point(1265, 528);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(91, 24);
            this.lbGiaTien.TabIndex = 30;
            this.lbGiaTien.Text = "Giá Tiền :";
            // 
            // tcapNhatNgay
            // 
            this.tcapNhatNgay.Enabled = true;
            this.tcapNhatNgay.Interval = 1000;
            this.tcapNhatNgay.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbGiaTien);
            this.Controls.Add(this.tbGiaTien);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.btnDangKiKH);
            this.Controls.Add(this.cbKieuPhong);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.lbNgayDK);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lbSoPhong);
            this.Controls.Add(this.cbSoPhong);
            this.Controls.Add(this.lbKieuPhong);
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.tbCCCD);
            this.Controls.Add(this.lbCCCD);
            this.Controls.Add(this.tbHTKH);
            this.Controls.Add(this.lbHoTenKH);
            this.Controls.Add(this.lbDKKH);
            this.Name = "UC_Res";
            this.Size = new System.Drawing.Size(1882, 780);
            this.Load += new System.EventHandler(this.UC_Res_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbDKKH;
        private System.Windows.Forms.Label lbHoTenKH;
        private Guna.UI2.WinForms.Guna2TextBox tbCCCD;
        private System.Windows.Forms.Label lbCCCD;
        private Guna.UI2.WinForms.Guna2TextBox tbHTKH;
        private System.Windows.Forms.Label lbGioiTinh;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioiTinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbSoPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoPhong;
        private System.Windows.Forms.Label lbKieuPhong;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbNgaySinh;
        private Guna.UI2.WinForms.Guna2TextBox tbDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label lbNgayDK;
        private Guna.UI2.WinForms.Guna2ComboBox cbKieuPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiPhong;
        private Guna.UI2.WinForms.Guna2Button btnDangKiKH;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox tbGiaTien;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.Timer tcapNhatNgay;
    }
}
