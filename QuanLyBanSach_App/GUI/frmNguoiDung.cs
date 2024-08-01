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
    public partial class frmNguoiDung : Form
    {
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public frmNguoiDung()
        {
            InitializeComponent();
            this.Load += FrmNguoiDung_Load;
            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;
            btnSua.Click += BtnSua_Click;
            btnMain.Click += BtnMain_Click;
            dgvNguoiDung.SelectionChanged += DgvNguoiDung_SelectionChanged;
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            Program.mainForm = new frmMain();
            Program.mainForm.Show();
            this.Dispose();
        }

        private void DgvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            txtTDN.Text = dgvNguoiDung.CurrentRow.Cells[0].Value.ToString();
            txtMK.Text = dgvNguoiDung.CurrentRow.Cells[1].Value.ToString();
            ckHD.Checked = (bool)dgvNguoiDung.CurrentRow.Cells[2].Value;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.suaND(txtTDN.Text, txtMK.Text, ckHD.Checked);
            loadND();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.xoaND(txtTDN.Text);
            loadND();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (phanQuyenBLL.ktraKC(txtTDN.Text) == true)
                MessageBox.Show("Tên đăng nhập đã tồn tại vui lòng đổi tên khác");
            else
            {
                phanQuyenBLL.themND(txtTDN.Text, txtMK.Text, ckHD.Checked);
                loadND();
            }
        }

        void loadND()
        {
            dgvNguoiDung.DataSource = phanQuyenBLL.getND();
        }

        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            loadND();
        }
    }
}
