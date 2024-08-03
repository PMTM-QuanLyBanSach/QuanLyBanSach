using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public frmLogin()
        {
            InitializeComponent();
            btnDN.Click += btnDN_Click;
            btnHuy.Click += btnHuy_Click;
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void btnDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + labUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPass.Text))
            {
                MessageBox.Show("Không được bỏ trống" + labPass.Text.ToLower());
                this.txtPass.Focus();
                return;
            }

            int kq = phanQuyenBLL.Check_Config(); //hàm Check_Config()
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }

        public void ProcessLogin()
        {
            enumLogin.LoginResult result;
            result = phanQuyenBLL.Check_User(txtUsername.Text, txtPass.Text);
            //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == enumLogin.LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + labUsername.Text + " Hoặc " + labPass.Text);
                return;
            }
            // Account had been disabled
            else if (result == enumLogin.LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frmMain();
            }
            this.Visible = false;
            Program.mainForm.TenDangNhap = txtUsername.Text;
            Program.mainForm.Show();
        }

        public void ProcessConfig()
        {
            Program.configForm = new frmConfig();
            this.Visible = false;
            Program.configForm.Show();
        }
    }
}
