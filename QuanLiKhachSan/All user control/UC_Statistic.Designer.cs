namespace QuanLiKhachSan.All_user_control
{
    partial class UC_Statistic
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
            this.lbThongKe = new System.Windows.Forms.Label();
            this.cbThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.dgwDSK = new System.Windows.Forms.DataGridView();
            this.lbSoKhach = new System.Windows.Forms.Label();
            this.lbPhongmax = new System.Windows.Forms.Label();
            this.lbNgayMax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbThongke = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bntThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.lbDSK = new System.Windows.Forms.Label();
            this.qLKhachSanDataSet = new QuanLiKhachSan.QLKhachSanDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new QuanLiKhachSan.QLKhachSanDataSetTableAdapters.customerTableAdapter();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSK)).BeginInit();
            this.gbThongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbThongKe
            // 
            this.lbThongKe.AutoSize = true;
            this.lbThongKe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbThongKe.Location = new System.Drawing.Point(851, 21);
            this.lbThongKe.Name = "lbThongKe";
            this.lbThongKe.Size = new System.Drawing.Size(195, 58);
            this.lbThongKe.TabIndex = 1;
            this.lbThongKe.Text = "Thống Kê";
            // 
            // cbThang
            // 
            this.cbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbThang.ItemHeight = 30;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(725, 114);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(295, 36);
            this.cbThang.TabIndex = 2;
            // 
            // cbNam
            // 
            this.cbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNam.ItemHeight = 30;
            this.cbNam.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cbNam.Location = new System.Drawing.Point(725, 172);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(295, 36);
            this.cbNam.StartIndex = 3;
            this.cbNam.TabIndex = 3;
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNam.Location = new System.Drawing.Point(631, 172);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(57, 24);
            this.lbNam.TabIndex = 4;
            this.lbNam.Text = "Năm:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThang.Location = new System.Drawing.Point(631, 126);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(69, 24);
            this.lbThang.TabIndex = 5;
            this.lbThang.Text = "Tháng:";
            // 
            // dgwDSK
            // 
            this.dgwDSK.AllowUserToAddRows = false;
            this.dgwDSK.AllowUserToDeleteRows = false;
            this.dgwDSK.AutoGenerateColumns = false;
            this.dgwDSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDSK.BackgroundColor = System.Drawing.Color.White;
            this.dgwDSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDSK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn});
            this.dgwDSK.DataSource = this.customerBindingSource;
            this.dgwDSK.Location = new System.Drawing.Point(28, 351);
            this.dgwDSK.Name = "dgwDSK";
            this.dgwDSK.RowHeadersWidth = 62;
            this.dgwDSK.RowTemplate.Height = 28;
            this.dgwDSK.Size = new System.Drawing.Size(933, 373);
            this.dgwDSK.TabIndex = 6;
            // 
            // lbSoKhach
            // 
            this.lbSoKhach.AutoSize = true;
            this.lbSoKhach.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoKhach.Location = new System.Drawing.Point(10, 48);
            this.lbSoKhach.Name = "lbSoKhach";
            this.lbSoKhach.Size = new System.Drawing.Size(151, 24);
            this.lbSoKhach.TabIndex = 7;
            this.lbSoKhach.Text = "Tổng Số Khách :";
            this.lbSoKhach.Click += new System.EventHandler(this.lbSoKhach_Click);
            // 
            // lbPhongmax
            // 
            this.lbPhongmax.AutoSize = true;
            this.lbPhongmax.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhongmax.Location = new System.Drawing.Point(6, 136);
            this.lbPhongmax.Name = "lbPhongmax";
            this.lbPhongmax.Size = new System.Drawing.Size(287, 24);
            this.lbPhongmax.TabIndex = 8;
            this.lbPhongmax.Text = "Phòng có lượt thuê nhiều nhất :";
            // 
            // lbNgayMax
            // 
            this.lbNgayMax.AutoSize = true;
            this.lbNgayMax.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayMax.Location = new System.Drawing.Point(10, 240);
            this.lbNgayMax.Name = "lbNgayMax";
            this.lbNgayMax.Size = new System.Drawing.Size(277, 24);
            this.lbNgayMax.TabIndex = 9;
            this.lbNgayMax.Text = "Ngày có lượt thuê nhiều nhất :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng Doanh Thu :";
            // 
            // gbThongke
            // 
            this.gbThongke.Controls.Add(this.lbSoKhach);
            this.gbThongke.Controls.Add(this.label4);
            this.gbThongke.Controls.Add(this.lbPhongmax);
            this.gbThongke.Controls.Add(this.lbNgayMax);
            this.gbThongke.Location = new System.Drawing.Point(1041, 303);
            this.gbThongke.Name = "gbThongke";
            this.gbThongke.Size = new System.Drawing.Size(801, 421);
            this.gbThongke.TabIndex = 11;
            this.gbThongke.TabStop = false;
            this.gbThongke.Text = "Báo Cáo:";
            // 
            // bntThongKe
            // 
            this.bntThongKe.BorderRadius = 13;
            this.bntThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntThongKe.ForeColor = System.Drawing.Color.White;
            this.bntThongKe.Location = new System.Drawing.Point(1065, 141);
            this.bntThongKe.Name = "bntThongKe";
            this.bntThongKe.Size = new System.Drawing.Size(180, 45);
            this.bntThongKe.TabIndex = 12;
            this.bntThongKe.Text = "Xem Thống Kê";
            this.bntThongKe.Click += new System.EventHandler(this.bntThongKe_Click);
            // 
            // lbDSK
            // 
            this.lbDSK.AutoSize = true;
            this.lbDSK.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDSK.Location = new System.Drawing.Point(36, 314);
            this.lbDSK.Name = "lbDSK";
            this.lbDSK.Size = new System.Drawing.Size(176, 24);
            this.lbDSK.TabIndex = 11;
            this.lbDSK.Text = "Danh Sách Khách :";
            // 
            // qLKhachSanDataSet
            // 
            this.qLKhachSanDataSet.DataSetName = "QLKhachSanDataSet";
            this.qLKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.qLKhachSanDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "Ngày Thuê Phòng";
            this.checkinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // UC_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDSK);
            this.Controls.Add(this.bntThongKe);
            this.Controls.Add(this.gbThongke);
            this.Controls.Add(this.dgwDSK);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lbThongKe);
            this.Name = "UC_Statistic";
            this.Size = new System.Drawing.Size(1882, 780);
            this.Load += new System.EventHandler(this.UC_Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSK)).EndInit();
            this.gbThongke.ResumeLayout(false);
            this.gbThongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cbNam;
        private Guna.UI2.WinForms.Guna2ComboBox cbThang;
        private System.Windows.Forms.Label lbThongKe;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNgayMax;
        private System.Windows.Forms.Label lbPhongmax;
        private System.Windows.Forms.Label lbSoKhach;
        private System.Windows.Forms.DataGridView dgwDSK;
        private System.Windows.Forms.GroupBox gbThongke;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button bntThongKe;
        private System.Windows.Forms.Label lbDSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QLKhachSanDataSet qLKhachSanDataSet;
        private QLKhachSanDataSetTableAdapters.customerTableAdapter customerTableAdapter;
    }
}
