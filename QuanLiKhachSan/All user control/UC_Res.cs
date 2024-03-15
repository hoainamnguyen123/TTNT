using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace QuanLiKhachSan.All_user_control
{
    public partial class UC_Res : UserControl
    {
        function fn = new function();
        string query;
        public UC_Res()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {

            // Lấy dữ liệu từ truy vấn SQL
            SqlDataReader sdr = fn.getForCombo(query);
            // Duyệt qua từng bản ghi trong kết quả
            while (sdr.Read())
            {
                // Lặp qua từng cột trong bản ghi
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    // Thêm giá trị của cột vào ComboBox
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            // Đóng kết nối với database
            sdr.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKieuPhong.SelectedIndex = -1;
            cbSoPhong.Items.Clear();

        }

        private void cbKieuPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lọc dữ liệu băng phương thức setComboBox ở class function
            cbSoPhong.Items.Clear();
            query = "select roomNo from Room where bed = N'" + cbKieuPhong.Text + "' and roomType = N'" + cbLoaiPhong.Text + "' and booked = N'CHƯA ĐẶT'";
            setComboBox(query, cbSoPhong);
        }
        int rid;
        private void cbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lọc dữ liệu băng phương thức setComboBox ở class function
            query = "select price, roomid from Room where roomNo = '" + cbSoPhong.Text + "'";
            DataSet ds = fn.GetData(query);
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
            //tự động tính giá tiền
            tbGiaTien.Text = ds.Tables[0].Rows[0][0].ToString() + " VNĐ / Ngày";
        }

        private void btnDangKiKH_Click(object sender, EventArgs e)
        {
            //checknull
            if(tbHTKH.Text != "" &&  tbCCCD.Text != "" && tbPhone.Text != "" && tbDiaChi.Text != "" && cbGioiTinh.Text != ""
                && cbKieuPhong.Text != "" && cbLoaiPhong.Text != "" && cbSoPhong.Text != "")
            {
                //thêm vào csdl bằng phương thức setData
                query = "insert into customer (cname,idcccd,mobile,gender,dob,address,checkin,roomid) values (N'"+tbHTKH.Text+"','"+tbCCCD.Text+"','"+tbPhone.Text+"',N'"+cbGioiTinh.Text+"',N'"+dtpNgaySinh.Text+"',N'"+tbDiaChi.Text+"','"+dtpNgayThue.Text+"',"+rid+") update Room set booked = N'ĐÃ ĐẶT' where roomNo = '"+cbSoPhong.Text+"'";
                fn.setData(query, "Đăng kí thành công!");
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui Lòng nhập đủ thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        //Xóa tất cả dữ liệu ở các ô
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            tbCCCD.Clear();
            tbPhone.Clear();
            tbDiaChi.Clear();
            tbHTKH.Clear();
            cbGioiTinh.SelectedIndex = -1;
            cbKieuPhong.SelectedIndex = -1;
            cbLoaiPhong.SelectedIndex = -1;
            cbSoPhong.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            tbGiaTien.Clear();
        }

        private void tbHTKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpNgayThue.Value = DateTime.Now;
        }

        private void UC_Res_Load(object sender, EventArgs e)
        {

        }
    }
}
