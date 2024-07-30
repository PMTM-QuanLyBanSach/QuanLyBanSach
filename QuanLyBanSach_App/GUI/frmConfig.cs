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

namespace GUI
{
    public partial class frmConfig : Form
    {
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public frmConfig()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            cboDB.DropDown += cboDB_DropDown;
        }

        public static string connectionString = Properties.Settings.Default.connectionString;

        void cboDB_DropDown(object sender, EventArgs e)
        {
            cboDB.DataSource = phanQuyenBLL.getDBName(txtServerName.Text, txtUsername.Text, txtPass.Text);
            cboDB.DisplayMember = "Name";
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Không được bỏ trống " + labUN.Text.ToLower());
                txtUsername.Focus();
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Không được bỏ trống " + labPass.Text.ToLower());
                txtUsername.Focus();
            }
            else
            {
                saveConfig();
                processLogin();
            }
        }

        public void processLogin()
        {
            Program.loginForm = new frmLogin();
            this.Visible = false;
            Program.loginForm.Show();
        }

        void saveConfig()
        {
            Properties.Settings.Default.connectionString = 
                phanQuyenBLL.saveConfig(txtServerName.Text, txtUsername.Text, txtPass.Text, cboDB.SelectedValue.ToString());
            Properties.Settings.Default.Save();
        }
    }
}
