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
using System.Data;

namespace QuanLiKhachSan
{
    public partial class fDangNhap : Form
    {
        function fn = new function();
        string query;
        public fDangNhap()
        {
            InitializeComponent();
        }
        
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            query = "select taikhoan,matkhau from nguoidung where taikhoan = '" + tbUserName.Text + "' and matkhau = '" + tbPassword.Text + "'";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                lbError.Visible = false;
                fMain f = new fMain();
                f.Show();
                this.Hide();
            }
            else {  lbError.Visible = true; }
            
            
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void checkbox_vmk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_vmk.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.PasswordChar = '\0';
            }
            else 
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
