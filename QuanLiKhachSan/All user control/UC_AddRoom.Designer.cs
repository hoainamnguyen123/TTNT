namespace QuanLiKhachSan.All_user_control
{
    partial class UC_AddRoom
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
            this.lbQLPhong = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new QuanLiKhachSan.Database1DataSet();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.tbSoPhong = new System.Windows.Forms.TextBox();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.tbGiaTien = new System.Windows.Forms.TextBox();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbKieuPhong = new System.Windows.Forms.ComboBox();
            this.lbKieuPhong = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.roomTableAdapter = new QuanLiKhachSan.Database1DataSetTableAdapters.RoomTableAdapter();
            this.lbDSPhong = new System.Windows.Forms.Label();
            this.lbThemPhong = new System.Windows.Forms.Label();
            this.cbfill = new System.Windows.Forms.ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cbfill3 = new System.Windows.Forms.ComboBox();
            this.cbfill2 = new System.Windows.Forms.ComboBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLPhong
            // 
            this.lbQLPhong.AutoSize = true;
            this.lbQLPhong.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLPhong.Location = new System.Drawing.Point(699, 24);
            this.lbQLPhong.Name = "lbQLPhong";
            this.lbQLPhong.Size = new System.Drawing.Size(293, 58);
            this.lbQLPhong.TabIndex = 0;
            this.lbQLPhong.Text = "Quản Lí Phòng";
            this.lbQLPhong.Click += new System.EventHandler(this.lbThemPhong_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomid,
            this.roomNoDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.bedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.bookedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(64, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 495);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roomid
            // 
            this.roomid.DataPropertyName = "roomid";
            this.roomid.HeaderText = "Mã Phòng";
            this.roomid.MinimumWidth = 8;
            this.roomid.Name = "roomid";
            this.roomid.ReadOnly = true;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "roomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "Số Phòng";
            this.roomNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "roomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Loại Phòng";
            this.roomTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedDataGridViewTextBoxColumn
            // 
            this.bedDataGridViewTextBoxColumn.DataPropertyName = "bed";
            this.bedDataGridViewTextBoxColumn.HeaderText = "Kiểu Phòng";
            this.bedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bedDataGridViewTextBoxColumn.Name = "bedDataGridViewTextBoxColumn";
            this.bedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá Tiền";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookedDataGridViewTextBoxColumn
            // 
            this.bookedDataGridViewTextBoxColumn.DataPropertyName = "booked";
            this.bookedDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.bookedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookedDataGridViewTextBoxColumn.Name = "bookedDataGridViewTextBoxColumn";
            this.bookedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoPhong.Location = new System.Drawing.Point(951, 166);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(102, 34);
            this.lbSoPhong.TabIndex = 2;
            this.lbSoPhong.Text = "Số Phòng";
            // 
            // tbSoPhong
            // 
            this.tbSoPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoPhong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbSoPhong.Location = new System.Drawing.Point(951, 203);
            this.tbSoPhong.Name = "tbSoPhong";
            this.tbSoPhong.Size = new System.Drawing.Size(600, 44);
            this.tbSoPhong.TabIndex = 3;
            this.tbSoPhong.TextChanged += new System.EventHandler(this.tbSoPhong_TextChanged);
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(951, 250);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(117, 34);
            this.lbLoaiPhong.TabIndex = 6;
            this.lbLoaiPhong.Text = "Loại Phòng";
            // 
            // tbGiaTien
            // 
            this.tbGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaTien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbGiaTien.Location = new System.Drawing.Point(951, 488);
            this.tbGiaTien.Name = "tbGiaTien";
            this.tbGiaTien.Size = new System.Drawing.Size(600, 44);
            this.tbGiaTien.TabIndex = 8;
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaTien.Location = new System.Drawing.Point(951, 451);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(86, 34);
            this.lbGiaTien.TabIndex = 7;
            this.lbGiaTien.Text = "Giá tiền";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.BackColor = System.Drawing.Color.White;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Thường",
            "VIP"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(951, 298);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(600, 45);
            this.cbLoaiPhong.Sorted = true;
            this.cbLoaiPhong.TabIndex = 9;
            // 
            // cbKieuPhong
            // 
            this.cbKieuPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKieuPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKieuPhong.FormattingEnabled = true;
            this.cbKieuPhong.Items.AddRange(new object[] {
            "Đơn",
            "Đôi",
            "Gia Đình"});
            this.cbKieuPhong.Location = new System.Drawing.Point(951, 394);
            this.cbKieuPhong.Name = "cbKieuPhong";
            this.cbKieuPhong.Size = new System.Drawing.Size(600, 45);
            this.cbKieuPhong.TabIndex = 11;
            // 
            // lbKieuPhong
            // 
            this.lbKieuPhong.AutoSize = true;
            this.lbKieuPhong.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKieuPhong.Location = new System.Drawing.Point(951, 357);
            this.lbKieuPhong.Name = "lbKieuPhong";
            this.lbKieuPhong.Size = new System.Drawing.Size(119, 34);
            this.lbKieuPhong.TabIndex = 10;
            this.lbKieuPhong.Text = "Kiểu Phòng";
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 18;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(963, 568);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(193, 63);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // lbDSPhong
            // 
            this.lbDSPhong.AutoSize = true;
            this.lbDSPhong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDSPhong.Location = new System.Drawing.Point(59, 83);
            this.lbDSPhong.Name = "lbDSPhong";
            this.lbDSPhong.Size = new System.Drawing.Size(269, 29);
            this.lbDSPhong.TabIndex = 13;
            this.lbDSPhong.Text = "Danh sách phòng đã có :";
            // 
            // lbThemPhong
            // 
            this.lbThemPhong.AutoSize = true;
            this.lbThemPhong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThemPhong.Location = new System.Drawing.Point(923, 105);
            this.lbThemPhong.Name = "lbThemPhong";
            this.lbThemPhong.Size = new System.Drawing.Size(206, 29);
            this.lbThemPhong.TabIndex = 14;
            this.lbThemPhong.Text = "Thêm Phòng Mới : ";
            // 
            // cbfill
            // 
            this.cbfill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfill.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbfill.FormattingEnabled = true;
            this.cbfill.Items.AddRange(new object[] {
            "TẤT CẢ",
            "CHƯA ĐẶT",
            "ĐÃ ĐẶT"});
            this.cbfill.Location = new System.Drawing.Point(638, 121);
            this.cbfill.Name = "cbfill";
            this.cbfill.Size = new System.Drawing.Size(138, 27);
            this.cbfill.TabIndex = 15;
            this.cbfill.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 18;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1162, 568);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(193, 63);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(1535, 148);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(43, 43);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "X";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 18;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1361, 568);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(193, 63);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbfill3
            // 
            this.cbfill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfill3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbfill3.FormattingEnabled = true;
            this.cbfill3.Items.AddRange(new object[] {
            "TẤT CẢ",
            "ĐƠN",
            "ĐÔI",
            "GIA ĐÌNH"});
            this.cbfill3.Location = new System.Drawing.Point(350, 121);
            this.cbfill3.Name = "cbfill3";
            this.cbfill3.Size = new System.Drawing.Size(138, 27);
            this.cbfill3.TabIndex = 21;
            // 
            // cbfill2
            // 
            this.cbfill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfill2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbfill2.FormattingEnabled = true;
            this.cbfill2.Items.AddRange(new object[] {
            "TẤT CẢ",
            "VIP",
            "THƯỜNG"});
            this.cbfill2.Location = new System.Drawing.Point(494, 121);
            this.cbfill2.Name = "cbfill2";
            this.cbfill2.Size = new System.Drawing.Size(138, 27);
            this.cbfill2.TabIndex = 22;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::QuanLiKhachSan.Properties.Resources.OOjs_UI_icon_search_ltr_svg;
            this.pbSearch.Location = new System.Drawing.Point(791, 121);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(33, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 23;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::QuanLiKhachSan.Properties.Resources.View_refresh_Gion_svg;
            this.pictureBox1.Location = new System.Drawing.Point(41, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.cbfill2);
            this.Controls.Add(this.cbfill3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbfill);
            this.Controls.Add(this.lbThemPhong);
            this.Controls.Add(this.lbDSPhong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbKieuPhong);
            this.Controls.Add(this.lbKieuPhong);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.tbGiaTien);
            this.Controls.Add(this.lbGiaTien);
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.tbSoPhong);
            this.Controls.Add(this.lbSoPhong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbQLPhong);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(1882, 780);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.TextBox tbSoPhong;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.TextBox tbGiaTien;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbKieuPhong;
        private System.Windows.Forms.Label lbKieuPhong;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Label lbDSPhong;
        private System.Windows.Forms.Label lbThemPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbfill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.ComboBox cbfill2;
        private System.Windows.Forms.ComboBox cbfill3;
        private System.Windows.Forms.PictureBox pbSearch;
    }
}
