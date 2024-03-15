using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.All_user_control
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        public UC_Customer()
        {
            InitializeComponent();
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {
            //tạo câu truy vấn đổ dữ liệu vào dgvDSkhachHang
            string query = "select * from customer";
            DataSet ds = fn.GetData(query);
            dgwDSKhachHang.DataSource = ds.Tables[0];
        }

        private void pcbreload_Click(object sender, EventArgs e)
        {
            UC_Customer_Load(this, null);
        }

        private void cbfill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfill.SelectedIndex == 0)
            {
                //Xử lí khi chọn tất cả
                string query = "select * from customer where 1 = 1";

                DataSet ds = fn.GetData(query);

                dgwDSKhachHang.DataSource = ds.Tables[0];
            }
            if (cbfill.SelectedIndex == 1)
            {
                //Xử lí khi chọn đã trả phòng
                string query = "select * from customer where chekout = 'YES'";

                DataSet ds = fn.GetData(query);

                dgwDSKhachHang.DataSource = ds.Tables[0];
            }

            if(cbfill.SelectedIndex == 2)
            {

                string query = "select * from customer where chekout = 'NO'";

                DataSet ds = fn.GetData(query);

                dgwDSKhachHang.DataSource = ds.Tables[0];
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgwDSKhachHang.CurrentRow.Index;
            int id = Int32.Parse(dgwDSKhachHang.Rows[i].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu Khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgwDSKhachHang.Rows[i].Cells[8].Value.ToString() != "")
                {
                    string query = "DELETE FROM customer WHERE cid = " + id;
                    fn.setData(query, "Xóa thành công rồi đại ca !");
                    UC_Customer_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn không thể xóa khách hàng chưa thanh toán !", "Ơ kìa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
