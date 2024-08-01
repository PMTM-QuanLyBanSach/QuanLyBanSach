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
    public partial class frmNhomNguoiDung : Form
    {
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public frmNhomNguoiDung()
        {
            InitializeComponent();
            this.Load += FrmNhomNguoiDung_Load;
            dgvNhomNguoiDung.SelectionChanged += DgvNhomNguoiDung_SelectionChanged;
            btnMain.Click += BtnMain_Click;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.xoaNND(txtMaNhom.Text);
            loadNND();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.suaNND(txtTenNhom.Text, txtGhiChu.Text, txtMaNhom.Text);
            loadNND();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (phanQuyenBLL.ktrKC_NND(txtMaNhom.Text))
            {
                MessageBox.Show("Tên đăng nhập đã bị trùng vui lòng nhập lại");
                txtMaNhom.Focus();
            }
            else
            {
                phanQuyenBLL.themNND(txtMaNhom.Text, txtTenNhom.Text, txtGhiChu.Text);
                loadNND();
            }
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            Program.mainForm = new frmMain();
            Program.mainForm.Show();
            this.Dispose();
        }

        private void DgvNhomNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNhom.Text = dgvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            txtTenNhom.Text = dgvNhomNguoiDung.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dgvNhomNguoiDung.CurrentRow.Cells[2].Value.ToString();
        }

        void loadNND()
        {
            dgvNhomNguoiDung.DataSource = phanQuyenBLL.getNND();
        }

        private void FrmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            loadNND();
        }
    }
}
