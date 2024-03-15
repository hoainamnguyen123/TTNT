using QuanLiKhachSan.All_user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            panelmove.Visible = true;
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
       
            uC_AddRoom1.Visible = true;
            uC_Res1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Statistic1.Visible = false;
            panelmove.Left = btnQLPhong.Left + 25;
        }
        private void btnDKKH_Click(object sender, EventArgs e)
        {
            uC_Res1.Visible = true;
            uC_Statistic1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_Customer1.Visible = false;
            panelmove.Left = btnDKKH.Left + 32;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            uC_CheckOut1_Load(sender, e);
            uC_Statistic1.Visible = false;
            uC_Res1.Visible = false;
            uC_Customer1.Visible = false;
            uC_CheckOut1.Visible = true;

            panelmove.Left = btnThanhToan.Left + 27;
            
        }

        private void uC_CheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void tNgayGio_Tick(object sender, EventArgs e)
        {
            lbNgayGio.Text = DateTime.Now.ToString();
        }

        private void btnThongTinKhachHang_Click(object sender, EventArgs e)
        {
            uC_Statistic1.Visible = false;
            uC_CheckOut1.Visible=false;
            uC_Customer1.Visible=true;
            uC_Res1.Visible = false;
            panelmove.Left = btnThongTinKhachHang.Left + 27;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            uC_Customer1.Visible = false;
            uC_Statistic1.Visible = true;
            uC_Res1.Visible = false;
            uC_CheckOut1.Visible=false;
            panelmove.Left = btnThongKe.Left + 27;
        }
    }
}
