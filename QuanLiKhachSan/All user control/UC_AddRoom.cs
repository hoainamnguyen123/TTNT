﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.All_user_control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            string query = "select * from Room";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
            cbfill.SelectedIndex = 0;
            cbfill2.SelectedIndex = 0;
            cbfill3.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbLoaiPhong.Text != "" && cbKieuPhong.Text != "" && tbSoPhong.Text != "" && tbGiaTien.Text != "")
            {
                string LoaiPhong = cbLoaiPhong.Text;
                string KieuPhong = cbKieuPhong.Text;
                string SoPhong = tbSoPhong.Text;
                Int64 GiaTien = Int64.Parse(tbGiaTien.Text);
                query = "insert into Room(roomNo,roomType,bed,price) values ('" + SoPhong + "',N'" + LoaiPhong + "',N'" + KieuPhong + "','" + GiaTien + "')";
                fn.setData(query, "Đã thêm phòng");
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearAll()
        {
            tbGiaTien.Clear();
            tbSoPhong.Clear();
            cbKieuPhong.SelectedIndex = -1;
            cbLoaiPhong.SelectedIndex = -1;
        }

        private void lbThemPhong_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbSoPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbfill.SelectedIndex != 0)
            {
                string query = "select * from Room where booked = N'"+cbfill.Text+"'";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                UC_AddRoom_Load(this, null);
            }
               
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
            cbfill.SelectedIndex = 0;

        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           btnXoa.Enabled = true;
        }

        private bool isEditing = false;
        private void bntSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
              
                int i = dataGridView1.CurrentRow.Index;
                id = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                tbSoPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                tbGiaTien.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                cbKieuPhong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                cbLoaiPhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

                btnSua.Text = "Lưu";
                btnSua.FillColor = Color.Green;
                btnThem.Enabled = false;
                btnXoa.Enabled=false;
                isEditing = true;
                btnclear.Enabled = false;
            }
            else
            {
                string LoaiPhong = cbLoaiPhong.Text;
                string KieuPhong = cbKieuPhong.Text;
                string SoPhong = tbSoPhong.Text;
                Int64 GiaTien = Int64.Parse(tbGiaTien.Text);

                query = "UPDATE Room SET roomNo = '" + SoPhong + "' ,roomType = N'" + LoaiPhong + "', bed = N'" + KieuPhong + "', price = '" + GiaTien + "' where roomId = '" + id + "'";
                fn.setData(query, "Đã sửa phòng thành công");

                UC_AddRoom_Load(this, null);
                clearAll();

                btnSua.Text = "Sửa";
                btnSua.FillColor = Color.FromArgb(94, 148, 255);
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                isEditing = false;
                btnclear.Enabled = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbSoPhong.Clear();
            tbGiaTien.Clear();
            cbKieuPhong.SelectedIndex = -1;
            cbLoaiPhong.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            id = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu phòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    query = "DELETE FROM Room WHERE roomId = " + id;
                    fn.setData(query, "Đã xóa phòng");
                    UC_AddRoom_Load(this, null);

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể xóa phòng vì phòng đã được đặt ít nhất một lần \n Vui lòng chỉ xóa phòng chưa được đặt ","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    btnXoa.Enabled = false;
                }
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string query = "select * from Room WHERE 1=1 ";
            if(cbfill.SelectedIndex != 0)
            {
                query += "AND booked = N'" + cbfill.Text + "' ";
            }
            if(cbfill2.SelectedIndex != 0)
            {
                query+= "AND roomType = N'"+cbfill2.Text+"' ";
            }
            if(cbfill3.SelectedIndex != 0)
            {
                query += "AND bed = N'" + cbfill3.Text + "'";
            }
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}