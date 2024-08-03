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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
            this.Load += FrmSach_Load;
            btnMain.Click += BtnMain_Click;
            dgvSach.SelectionChanged += DgvSach_SelectionChanged;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnClear.Click += BtnClear_Click;
            btnLoc.Click += BtnLoc_Click;
        }

        SachBLL sachBLL = new SachBLL();

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            string maSH = txtMaSH.Text;
            string tenSH = txtTenSH.Text;
            string maTG = cboTG.SelectedValue.ToString();
            string maDM = cboDM.SelectedValue.ToString();

            if (maSH == string.Empty && tenSH == string.Empty && maTG == string.Empty && maDM == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã sách hoặc tên sách hoặc chọn tác giả hoặc chọn danh mục sách để bắt đầu lọc.");
                txtMaSH.Focus();
            }
            else
            {
                if (maSH != string.Empty || tenSH != string.Empty || maTG != string.Empty || maDM != string.Empty)
                {
                    dgvSach.DataSource = sachBLL.locSH(maSH, maTG, maDM, tenSH);
                }
                else
                {
                    string x = cboTon.SelectedText;
                    if (x.CompareTo("Dưới 50") == 0)
                        dgvSach.DataSource = sachBLL.locSLT("0");
                    else
                        dgvSach.DataSource = sachBLL.locSLT("1");
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMaSH.Clear();
            txtTenSH.Clear();
            txtSLK.Clear();
            cboTG.SelectedItem = 0;
            cboDM.SelectedItem = 0;
            txtGB.Clear();

            txtMaSH.Focus();
            loadDT();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            sachBLL.xoaDL(txtMaSH.Text);
            loadDT();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string maSH = txtMaSH.Text;
            string tenSH = txtTenSH.Text;
            int slKho = int.Parse(txtSLK.Text);
            string maTG = cboTG.SelectedValue.ToString();
            string maDM = cboDM.SelectedValue.ToString();
            decimal giaBan = decimal.Parse(txtGB.Text);
            sachBLL.suaDL(maTG, maDM, giaBan, slKho, tenSH, maSH);
            loadDT();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            bool kq = sachBLL.ktraKC(txtMaSH.Text);
            if (!kq)
            {
                string maSH = txtMaSH.Text;
                string tenSH = txtTenSH.Text;
                int slKho = int.Parse(txtSLK.Text);
                string maTG = cboTG.SelectedValue.ToString();
                string maDM = cboDM.SelectedValue.ToString();
                decimal giaBan = decimal.Parse(txtGB.Text);

                sachBLL.themDL(maSH, maTG, maDM, giaBan, slKho, tenSH);
                loadDT();
            }
            else
            {
                MessageBox.Show("Mã tác giả đã trùng vui lòng nhập lại");
                txtMaSH.Focus();
            }
        }

        private void DgvSach_SelectionChanged(object sender, EventArgs e)
        {
            int n = dgvSach.SelectedRows.Count;
            if (n > 0)
            {
                txtMaSH.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
                txtTenSH.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
                txtSLK.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
                txtGB.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
                cboTG.SelectedValue = dgvSach.CurrentRow.Cells[1].Value.ToString();
                cboDM.SelectedValue = dgvSach.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            frmNguoiDung.processMain(this);
        }

        void loadDT()
        {
            dgvSach.DataSource = sachBLL.loadSH();

            cboDM.DataSource = sachBLL.loadDM();
            cboDM.ValueMember = "MaDanhMuc";
            cboDM.DisplayMember = "TenDanhMuc";

            cboTG.DataSource = sachBLL.loadTG();
            cboTG.ValueMember = "MaTG";
            cboTG.DisplayMember = "TenTG";
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            loadDT();
            cboTon.Items.Add("Dưới 50");
            cboTon.Items.Add("Trên 50");
        }
    }
}
