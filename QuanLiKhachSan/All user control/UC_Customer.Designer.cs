namespace QuanLiKhachSan.All_user_control
{
    partial class UC_Customer
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
            this.lbDSKhachhang = new System.Windows.Forms.Label();
            this.dgwDSKhachHang = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcccdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chekoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKhachSanDataSet = new QuanLiKhachSan.QLKhachSanDataSet();
            this.lbThongTinKhach = new System.Windows.Forms.Label();
            this.pcbreload = new System.Windows.Forms.PictureBox();
            this.cbfill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.customerTableAdapter = new QuanLiKhachSan.QLKhachSanDataSetTableAdapters.customerTableAdapter();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbreload)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbDSKhachhang
            // 
            this.lbDSKhachhang.AutoSize = true;
            this.lbDSKhachhang.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDSKhachhang.Location = new System.Drawing.Point(96, 176);
            this.lbDSKhachhang.Name = "lbDSKhachhang";
            this.lbDSKhachhang.Size = new System.Drawing.Size(309, 34);
            this.lbDSKhachhang.TabIndex = 34;
            this.lbDSKhachhang.Text = "Danh Sách Tất Cả Khách Hàng : ";
            // 
            // dgwDSKhachHang
            // 
            this.dgwDSKhachHang.AllowUserToAddRows = false;
            this.dgwDSKhachHang.AllowUserToDeleteRows = false;
            this.dgwDSKhachHang.AutoGenerateColumns = false;
            this.dgwDSKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDSKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgwDSKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.idcccdDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.chekoutDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn});
            this.dgwDSKhachHang.DataSource = this.customerBindingSource;
            this.dgwDSKhachHang.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwDSKhachHang.Location = new System.Drawing.Point(64, 226);
            this.dgwDSKhachHang.Name = "dgwDSKhachHang";
            this.dgwDSKhachHang.ReadOnly = true;
            this.dgwDSKhachHang.RowHeadersWidth = 62;
            this.dgwDSKhachHang.RowTemplate.Height = 28;
            this.dgwDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDSKhachHang.Size = new System.Drawing.Size(1755, 383);
            this.dgwDSKhachHang.TabIndex = 33;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "cid";
            this.cidDataGridViewTextBoxColumn.HeaderText = "Mã Khách";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcccdDataGridViewTextBoxColumn
            // 
            this.idcccdDataGridViewTextBoxColumn.DataPropertyName = "idcccd";
            this.idcccdDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.idcccdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcccdDataGridViewTextBoxColumn.Name = "idcccdDataGridViewTextBoxColumn";
            this.idcccdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "Ngày Thuê Phòng";
            this.checkinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            this.checkinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "Ngày Trả Phòng";
            this.checkoutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            this.checkoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chekoutDataGridViewTextBoxColumn
            // 
            this.chekoutDataGridViewTextBoxColumn.DataPropertyName = "chekout";
            this.chekoutDataGridViewTextBoxColumn.HeaderText = "Đã Trả Phòng";
            this.chekoutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chekoutDataGridViewTextBoxColumn.Name = "chekoutDataGridViewTextBoxColumn";
            this.chekoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "roomid";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "Phòng đã thuê";
            this.roomidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.qLKhachSanDataSet;
            // 
            // qLKhachSanDataSet
            // 
            this.qLKhachSanDataSet.DataSetName = "QLKhachSanDataSet";
            this.qLKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbThongTinKhach
            // 
            this.lbThongTinKhach.AutoSize = true;
            this.lbThongTinKhach.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbThongTinKhach.Location = new System.Drawing.Point(704, 17);
            this.lbThongTinKhach.Name = "lbThongTinKhach";
            this.lbThongTinKhach.Size = new System.Drawing.Size(434, 58);
            this.lbThongTinKhach.TabIndex = 30;
            this.lbThongTinKhach.Text = "Thông Tin Khách Hàng";
            // 
            // pcbreload
            // 
            this.pcbreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbreload.Image = global::QuanLiKhachSan.Properties.Resources.View_refresh_Gion_svg;
            this.pcbreload.Location = new System.Drawing.Point(21, 17);
            this.pcbreload.Name = "pcbreload";
            this.pcbreload.Size = new System.Drawing.Size(51, 46);
            this.pcbreload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbreload.TabIndex = 35;
            this.pcbreload.TabStop = false;
            this.pcbreload.Click += new System.EventHandler(this.pcbreload_Click);
            // 
            // cbfill
            // 
            this.cbfill.BackColor = System.Drawing.Color.Transparent;
            this.cbfill.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbfill.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.cbfill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbfill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbfill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbfill.ItemHeight = 30;
            this.cbfill.Items.AddRange(new object[] {
            "Tất cả",
            "Đã trả phòng",
            "Chưa trả phòng"});
            this.cbfill.Location = new System.Drawing.Point(714, 87);
            this.cbfill.Name = "cbfill";
            this.cbfill.Size = new System.Drawing.Size(403, 36);
            this.cbfill.StartIndex = 0;
            this.cbfill.TabIndex = 36;
            this.cbfill.SelectedIndexChanged += new System.EventHandler(this.cbfill_SelectedIndexChanged);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.BorderRadius = 18;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(837, 632);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(194, 61);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbfill);
            this.Controls.Add(this.pcbreload);
            this.Controls.Add(this.lbDSKhachhang);
            this.Controls.Add(this.dgwDSKhachHang);
            this.Controls.Add(this.lbThongTinKhach);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1882, 780);
            this.Load += new System.EventHandler(this.UC_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbreload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbDSKhachhang;
        private System.Windows.Forms.DataGridView dgwDSKhachHang;
        private System.Windows.Forms.Label lbThongTinKhach;
        private System.Windows.Forms.PictureBox pcbreload;
        private Guna.UI2.WinForms.Guna2ComboBox cbfill;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QLKhachSanDataSet qLKhachSanDataSet;
        private QLKhachSanDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcccdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chekoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}
