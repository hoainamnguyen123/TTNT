namespace QuanLiKhachSan.All_user_control
{
    partial class UC_CheckOut
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
            this.lbThanhToan = new System.Windows.Forms.Label();
            this.tbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.tbSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.tbTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgayTraPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgwDSKhach = new System.Windows.Forms.DataGridView();
            this.lbDSKhach = new System.Windows.Forms.Label();
            this.pcbreload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbreload)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbThanhToan.Location = new System.Drawing.Point(755, 29);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(233, 58);
            this.lbThanhToan.TabIndex = 0;
            this.lbThanhToan.Text = "Thanh Toán";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimKiem.DefaultText = "";
            this.tbTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimKiem.Location = new System.Drawing.Point(648, 148);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.PasswordChar = '\0';
            this.tbTimKiem.PlaceholderText = "Nhập số điện thoại";
            this.tbTimKiem.SelectedText = "";
            this.tbTimKiem.Size = new System.Drawing.Size(458, 48);
            this.tbTimKiem.TabIndex = 1;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimKiem.Location = new System.Drawing.Point(644, 121);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(103, 24);
            this.lbTimKiem.TabIndex = 8;
            this.lbTimKiem.Text = "Tìm Kiếm :";
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoPhong.Location = new System.Drawing.Point(596, 628);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(109, 24);
            this.lbSoPhong.TabIndex = 10;
            this.lbSoPhong.Text = "Số Phòng : ";
            // 
            // tbSoPhong
            // 
            this.tbSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSoPhong.DefaultText = "";
            this.tbSoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSoPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSoPhong.Location = new System.Drawing.Point(587, 655);
            this.tbSoPhong.Name = "tbSoPhong";
            this.tbSoPhong.PasswordChar = '\0';
            this.tbSoPhong.PlaceholderText = "";
            this.tbSoPhong.ReadOnly = true;
            this.tbSoPhong.SelectedText = "";
            this.tbSoPhong.Size = new System.Drawing.Size(458, 48);
            this.tbSoPhong.TabIndex = 9;
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenKH.Location = new System.Drawing.Point(104, 628);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(169, 24);
            this.lbTenKH.TabIndex = 12;
            this.lbTenKH.Text = "Tên Khách Hàng : ";
            // 
            // tbTenKH
            // 
            this.tbTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenKH.DefaultText = "";
            this.tbTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenKH.Location = new System.Drawing.Point(97, 655);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.PasswordChar = '\0';
            this.tbTenKH.PlaceholderText = "\r\n";
            this.tbTenKH.ReadOnly = true;
            this.tbTenKH.SelectedText = "";
            this.tbTenKH.Size = new System.Drawing.Size(458, 48);
            this.tbTenKH.TabIndex = 11;
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Checked = true;
            this.dtpNgayTraPhong.Enabled = false;
            this.dtpNgayTraPhong.FillColor = System.Drawing.Color.White;
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(1074, 657);
            this.dtpNgayTraPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTraPhong.MinDate = new System.DateTime(2024, 2, 16, 0, 0, 0, 0);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(192, 46);
            this.dtpNgayTraPhong.TabIndex = 23;
            this.dtpNgayTraPhong.Value = new System.DateTime(2024, 2, 19, 0, 0, 0, 0);
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(1070, 628);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(171, 24);
            this.lbNgayTraPhong.TabIndex = 22;
            this.lbNgayTraPhong.Text = "Ngày Trả Phòng  : ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 18;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(1400, 641);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(294, 62);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgwDSKhach
            // 
            this.dgwDSKhach.AllowUserToAddRows = false;
            this.dgwDSKhach.AllowUserToDeleteRows = false;
            this.dgwDSKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDSKhach.BackgroundColor = System.Drawing.Color.White;
            this.dgwDSKhach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwDSKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDSKhach.ColumnHeadersVisible = false;
            this.dgwDSKhach.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwDSKhach.Location = new System.Drawing.Point(84, 233);
            this.dgwDSKhach.Name = "dgwDSKhach";
            this.dgwDSKhach.ReadOnly = true;
            this.dgwDSKhach.RowHeadersWidth = 62;
            this.dgwDSKhach.RowTemplate.Height = 28;
            this.dgwDSKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDSKhach.Size = new System.Drawing.Size(1755, 308);
            this.dgwDSKhach.TabIndex = 26;
            this.dgwDSKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDSKhach_CellClick);
            this.dgwDSKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDSKhach_CellContentClick);
            // 
            // lbDSKhach
            // 
            this.lbDSKhach.AutoSize = true;
            this.lbDSKhach.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDSKhach.Location = new System.Drawing.Point(102, 196);
            this.lbDSKhach.Name = "lbDSKhach";
            this.lbDSKhach.Size = new System.Drawing.Size(247, 34);
            this.lbDSKhach.TabIndex = 28;
            this.lbDSKhach.Text = "Danh Sách Khách Hàng : ";
            // 
            // pcbreload
            // 
            this.pcbreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbreload.Image = global::QuanLiKhachSan.Properties.Resources.View_refresh_Gion_svg;
            this.pcbreload.Location = new System.Drawing.Point(41, 24);
            this.pcbreload.Name = "pcbreload";
            this.pcbreload.Size = new System.Drawing.Size(51, 46);
            this.pcbreload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbreload.TabIndex = 29;
            this.pcbreload.TabStop = false;
            this.pcbreload.Click += new System.EventHandler(this.pcbreload_Click);
            // 
            // UC_CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcbreload);
            this.Controls.Add(this.lbDSKhach);
            this.Controls.Add(this.dgwDSKhach);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtpNgayTraPhong);
            this.Controls.Add(this.lbNgayTraPhong);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.lbSoPhong);
            this.Controls.Add(this.tbSoPhong);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.lbThanhToan);
            this.Name = "UC_CheckOut";
            this.Size = new System.Drawing.Size(1882, 780);
            this.Load += new System.EventHandler(this.UC_CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbreload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbThanhToan;
        private Guna.UI2.WinForms.Guna2TextBox tbTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Label lbTenKH;
        private Guna.UI2.WinForms.Guna2TextBox tbTenKH;
        private System.Windows.Forms.Label lbSoPhong;
        private Guna.UI2.WinForms.Guna2TextBox tbSoPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDSKhach;
        private System.Windows.Forms.DataGridView dgwDSKhach;
        private System.Windows.Forms.PictureBox pcbreload;
    }
}
