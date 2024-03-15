using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.All_user_control
{
    public partial class UC_Statistic : UserControl
    {
        function fn = new function();
        public UC_Statistic()
        {
            InitializeComponent();
        }

        private void bntThongKe_Click(object sender, EventArgs e)
        {
            //Truy vấn dữ liệu đổ lên dgv Ds khách trong tháng và năm
            string query = "SELECT cname,address,mobile,checkin,gender FROM customer where checkin LIKE '%/0"+cbThang.Text+"/%' and checkin LIKE '%"+cbNam.Text+"%'";
            DataSet ds = fn.GetData(query);
            dgwDSK.DataSource = ds.Tables[0];

            //Đếm số khách 
            lbSoKhach.Text = "Tổng Số Khách : " + dgwDSK.RowCount.ToString();
            //Truy vấn dữ liệu phòng được thuê nhiều nhất
            DataSet ds2 = fn.GetData("select Top(1) Room.roomNo,count(*) from customer,Room where Room.roomId = customer.roomId and checkin LIKE '%/0" + cbThang.Text + "/%' and checkin LIKE '%"+cbNam.Text+"%' group by roomNo order by count(*) DESC");
            //Truy vấn dữ liệu ngày có nhiều khách thuê nhất
            DataSet ds3 = fn.GetData("select checkin, count(*) from customer, Room where Room.roomId = customer.roomId and checkin LIKE '%/0"+cbThang.Text+ "/%' and checkin LIKE '%"+cbNam.Text+"%' group by checkin order by count(*) DESC");
            //Truy vấn dữ liệu tính tổng danh doanh thu
            DataSet ds4 = fn.GetData("select SUM(payment) from customer where checkin LIKE '%/0"+cbThang.Text+ "/%'and checkin LIKE '%"+cbNam.Text+"%'");
            try
            {
                //Kiểm tra dữ liệu trong bảng
                string PhongMax = ds2.Tables[0].Rows[0][0].ToString();
                string NgayMax = ds3.Tables[0].Rows[0][0].ToString();
                string DoanhThu = ds4.Tables[0].Rows[0][0].ToString();
                // Lấy giá trị của cột thứ nhất trên hàng thứ nhất
                lbPhongmax.Text = "Phòng có lượt thuê nhiều nhất : " + PhongMax;
                lbNgayMax.Text = "Ngày có lượt thuê nhiều nhất : " + NgayMax;
                lbDoanhThu.Text = "Tổng Doanh Thu : " + DoanhThu + " VNĐ";
                //Xử lí không có dữ liệu
            }catch(Exception ex)
            {
                MessageBox.Show("Chưa có dữ liệu để thống kê !","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

        }

        private void UC_Statistic_Load(object sender, EventArgs e)
        {
            
        }

        private void lbSoKhach_Click(object sender, EventArgs e)
        {

        }
    }
}
