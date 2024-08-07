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
    public partial class frmManHinh : Form
    {
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public frmManHinh()
        {
            InitializeComponent();
            this.Load += FrmManHinh_Load;
            dgvManHinh.SelectionChanged += DgvManHinh_SelectionChanged;
            btnMain.Click += BtnMain_Click;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.xoaMH(txtMMH.Text);
            loadMH();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            phanQuyenBLL.suaMH(txtTMH.Text, txtMMH.Text);
            loadMH();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (phanQuyenBLL.ktraKC_MH(txtMMH.Text))
            {
                MessageBox.Show("Tên đăng nhập đã bị trùng vui lòng nhập lại");
                txtMMH.Focus();
            }
            else
            {
                phanQuyenBLL.themMH(txtMMH.Text, txtTMH.Text);
                phanQuyenBLL.themQuyen("admin", txtMMH.Text, false);
                phanQuyenBLL.themQuyen("emp", txtMMH.Text, false);
                loadMH();
            }
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            frmNguoiDung.processMain(this);
        }

        private void DgvManHinh_SelectionChanged(object sender, EventArgs e)
        {
            int n = dgvManHinh.SelectedRows.Count;
            if(n > 0)
            {
                txtMMH.Text = dgvManHinh.CurrentRow.Cells[0].Value.ToString();
                txtTMH.Text = dgvManHinh.CurrentRow.Cells[1].Value.ToString();
            }
        }
        
        void loadMH()
        {
            dgvManHinh.DataSource = phanQuyenBLL.loadMH();
        }

        private void FrmManHinh_Load(object sender, EventArgs e)
        {
            loadMH();
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {

        }

        private void frmManHinh_Load_1(object sender, EventArgs e)
        {

        }
    }
}
