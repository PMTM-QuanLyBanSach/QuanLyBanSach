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
    public partial class frmTacGia : Form
    {
        TacGiaBLL tacGiaBLL = new TacGiaBLL();
        public frmTacGia()
        {
            InitializeComponent();
            this.Load += FrmTacGia_Load;
            dgvTacGia.SelectionChanged += DgvTacGia_SelectionChanged;
            btnMain.Click += BtnMain_Click;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLoc.Click += BtnLoc_Click;
            btnClear.Click += BtnClear_Click;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtMaTG.Focus();
            loadDT();
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == string.Empty && txtTenTG.Text == string.Empty)
                MessageBox.Show("Để lọc vui lòng nhập mã tác giả hoặc tên tác giả");
            else
            {
                if (txtMaTG.Text != string.Empty)
                    dgvTacGia.DataSource = tacGiaBLL.locMaDM(txtMaTG.Text);
                else if (txtTenTG.Text != string.Empty)
                    dgvTacGia.DataSource = tacGiaBLL.locTenDM(txtTenTG.Text);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            tacGiaBLL.xoaDL(txtMaTG.Text);
            loadDT();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            tacGiaBLL.suaDL(txtTenTG.Text, txtMaTG.Text);
            loadDT();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            bool kq = tacGiaBLL.ktraKC(txtMaTG.Text);
            if (!kq)
            {
                tacGiaBLL.themDL(txtMaTG.Text, txtTenTG.Text);
                loadDT();
            }
            else
            {
                MessageBox.Show("Mã tác giả đã trùng vui lòng nhập lại");
                txtMaTG.Focus();
            }
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            frmNguoiDung.processMain(this);
        }

        private void DgvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            int n = dgvTacGia.SelectedRows.Count;
            if (n > 0)
            {
                txtMaTG.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
                txtTenTG.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
            }
        }

        void loadDT()
        {
            dgvTacGia.DataSource = tacGiaBLL.loadTG();
        }

        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            loadDT();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
