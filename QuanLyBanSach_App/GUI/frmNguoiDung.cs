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
            Program.mainForm.TenDangNhap = frmLogin.tenND;
            Program.mainForm.Show();
            this.Dispose();
        }

        private void DgvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            txtTDN.Text = dgvNguoiDung.CurrentRow.Cells[0].Value.ToString();
            txtMK.Text = dgvNguoiDung.CurrentRow.Cells[1].Value.ToString();
            ckHD.Checked = (bool)dgvNguoiDung.CurrentRow.Cells[2].Value;
            cboNV.SelectedIndex = cboNV.FindString(dgvNguoiDung.CurrentRow.Cells[3].Value.ToString());
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.suaND(txtMK.Text, ckHD.Checked, txtTDN.Text);
            loadND();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.xoaND(txtTDN.Text);
            loadND();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (phanQuyenBLL.ktraKC(txtTDN.Text))
            {
                MessageBox.Show("Tên đăng nhập đã bị trùng vui lòng nhập lại");
                txtTDN.Focus();
            }
            else
            {
                phanQuyenBLL.themND(txtTDN.Text, txtMK.Text, ckHD.Checked, cboNV.SelectedValue.ToString().Trim());
                loadND();
            }
        }

        void loadND()
        {
            dgvNguoiDung.DataSource = phanQuyenBLL.getND();
        }
        
        void loadNV()
        {
            cboNV.DataSource = phanQuyenBLL.getNV();
            cboNV.ValueMember = "MaNV";
            cboNV.DisplayMember = "TenNV";
        }

        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            loadND();
            loadNV();
        }

        public static void processMain(Form f)
        {
            Program.mainForm = new frmMain();
            Program.mainForm.TenDangNhap = frmLogin.tenND;
            Program.mainForm.Show();
            f.Dispose();
        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {

        }

        private void frmNguoiDung_Load_1(object sender, EventArgs e)
        {

        }
    }
}
