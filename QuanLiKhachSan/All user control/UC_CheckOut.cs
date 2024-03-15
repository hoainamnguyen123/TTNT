using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.All_user_control
{
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        public void UC_CheckOut_Load(object sender, EventArgs e)
        {
            string query = "select customer.cid ,customer.cname ,customer.idcccd, customer.mobile,customer.gender,customer.dob,customer.address,customer.checkin,Room.roomNo,Room.price from customer,Room where customer.roomid = Room.roomid and chekout = 'NO'";
            DataSet ds = fn.GetData(query);
            dgwDSKhach.DataSource = ds.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpNgayTraPhong.Value = DateTime.Now;
        }
        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "select customer.cid,customer.cname ,customer.idcccd, customer.mobile,customer.gender,customer.dob,customer.address,customer.checkin,Room.roomNo,Room.price from customer,Room where customer.roomid = Room.roomid and chekout = 'NO' and mobile like '%"+ tbTimKiem.Text +"%'";
            DataSet ds = fn.GetData(query);
            dgwDSKhach.DataSource = ds.Tables[0];
        }
        int id;
        string tenKhach;
        string ngayThue;
        string tienPhong;
        string sdt;
        private void dgwDSKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int i = dgwDSKhach.CurrentRow.Index;
                id = int.Parse(dgwDSKhach.Rows[i].Cells[0].Value.ToString());
                tbTenKH.Text = dgwDSKhach.Rows[i].Cells[1].Value.ToString();
                tbSoPhong.Text = dgwDSKhach.Rows[i].Cells[8].Value.ToString();
                tenKhach = dgwDSKhach.Rows[i].Cells[1].Value.ToString();
                ngayThue = dgwDSKhach.Rows[i].Cells[7].Value.ToString();
                tienPhong = dgwDSKhach.Rows[i].Cells[9].Value.ToString();
                sdt = dgwDSKhach.Rows[i].Cells[3].Value.ToString();
        }
        DialogResult dia;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if(tbTenKH.Text != "")
            {
                DateTime startDate = DateTime.Parse(ngayThue);
                DateTime endDate = dtpNgayTraPhong.Value.Date;

                TimeSpan difference = endDate - startDate;
                double days = difference.TotalDays;

                // Làm tròn lên số ngày chênh lệch thành kiểu int
                int roundedDays = (int)Math.Ceiling(days);
                //tinh tien
                int payment = (roundedDays + 1) * int.Parse(tienPhong);
                dia = MessageBox.Show("Bạn có chắc chắn muốn thanh toán không ?"+
                    "\n" + "Hóa Đơn :" +
                    "\n    Tên :" + tbTenKH.Text + 
                    "\n    SĐT : " + sdt +
                    "\n    Ngày thuê phòng : " + ngayThue +
                    "\n    Ngày trả phòng : " + dtpNgayTraPhong.Value.ToString() +
                    "\n    Đơn giá phòng :" + tienPhong + " VNĐ/Ngày" +
                    "\n    Tổng tiền phải trả :" + payment +" VNĐ "+
                    "\n Cảm ơn quý khách đã chọn khách sạn xanh của chúng tôi :))"
                      
                    , "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(dia == DialogResult.OK)
                {
                    string query = "update customer set chekout = 'YES',checkout = '" + dtpNgayTraPhong.Text + "',payment = '"+payment+"'  where cid = " + id + " update Room set booked =N'CHƯA ĐẶT' where roomNo = '" + tbSoPhong.Text+"'";
                    fn.setData(query, "thanh toán thành công");
                    UC_CheckOut_Load(this, null);
                }
            }
        }
        private void pcbreload_Click(object sender, EventArgs e)
        {
            UC_CheckOut_Load(this, null);
        }

        private void dgwDSKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
