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
    public partial class frmDanhMucSach : Form
    {
        DanhMucSachBLL danhMucSachBLL = new DanhMucSachBLL();
        public frmDanhMucSach()
        {
            InitializeComponent();
            this.Load += FrmDanhMucSach_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLoc.Click += BtnLoc_Click;
            dgvDanhMuc.SelectionChanged += DgvDanhMuc_SelectionChanged;
            btnClear.Click += BtnClear_Click;
            btnMain.Click += BtnMain_Click;
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            frmNguoiDung.processMain(this);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMaDM.Clear();
            txtTenDM.Clear();
            txtMaDM.Focus();
            loadDT();
        }

        private void DgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            int n = dgvDanhMuc.SelectedRows.Count;
            if (n > 0)
            {
                txtMaDM.Text = dgvDanhMuc.CurrentRow.Cells[0].Value.ToString();
                txtTenDM.Text = dgvDanhMuc.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            if (txtMaDM.Text == string.Empty && txtTenDM.Text == string.Empty)
                MessageBox.Show("Để lọc vui lòng nhập mã danh mục hoặc tên danh mục");
            else
            {
                if (txtMaDM.Text != string.Empty)
                    dgvDanhMuc.DataSource = danhMucSachBLL.locMaDM(txtMaDM.Text);
                else if (txtTenDM.Text != string.Empty)
                    dgvDanhMuc.DataSource = danhMucSachBLL.locTenDM(txtTenDM.Text);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            danhMucSachBLL.xoaDL(txtMaDM.Text);
            loadDT();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            danhMucSachBLL.suaDL(txtTenDM.Text, txtMaDM.Text);
            loadDT();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            bool kq = danhMucSachBLL.ktraKC(txtMaDM.Text);
            if (!kq)
            {
                danhMucSachBLL.themDL(txtMaDM.Text, txtTenDM.Text);
                loadDT();
            }
            else
            {
                MessageBox.Show("Mã danh mục đã trùng vui lòng nhập lại");
                txtMaDM.Focus();
            }

        }

        void loadDT()
        {
            dgvDanhMuc.DataSource = danhMucSachBLL.loadDMS();
        }

        private void FrmDanhMucSach_Load(object sender, EventArgs e)
        {
            loadDT();
        }
    }
}
