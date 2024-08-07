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
    public partial class frmDonHang : Form
    {
        DonHangBLL donHangBLL = new DonHangBLL();
        public frmDonHang()
        {
            InitializeComponent();
            this.Load += FrmDonHang_Load;
            dgvDH.SelectionChanged += DgvDH_SelectionChanged;
            dgvCTDH.SelectionChanged += DgvCTDH_SelectionChanged;
            btnThemDH.Click += BtnThemDH_Click;
            cboSach.SelectedIndexChanged += CboSach_SelectedIndexChanged;
            btnThemCT.Click += BtnThemCT_Click;
            btnSuaDH.Click += BtnSuaDH_Click;
            btnReload.Click += BtnReload_Click;
            btnSuaCT.Click += BtnSuaCT_Click;
            btnXoaCT.Click += BtnXoaCT_Click;
            cboNV.Enabled = false;
            btnMain.Click += BtnMain_Click;
            btnThemKH.Click += BtnThemKH_Click;
        }

        private void BtnThemKH_Click(object sender, EventArgs e)
        {
            Program.khachHangForm = new frmKhachHang();
            Program.khachHangForm.ShowDialog();
            loadKH();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            frmNguoiDung.processMain(this);
        }

        private void BtnXoaCT_Click(object sender, EventArgs e)
        {
            string maDH = txtDH2.Text;
            string maSH = cboSach.SelectedValue.ToString();
            donHangBLL.xoaCT(maDH, maSH);
            loadDH();
            loadCTDH(maDH);
        }

        private void BtnSuaCT_Click(object sender, EventArgs e)
        {
            string maDH = txtDH2.Text;
            string maSH = cboSach.SelectedValue.ToString();
            int soLuong = int.Parse(txtSoLuong.Text.Trim());

            donHangBLL.suaCT(soLuong, maDH, maSH);
            loadDH();
            loadCTDH(maDH);
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control child in c.Controls)
                    {
                        if (child is TextBox)
                        {
                            ((TextBox)child).Clear();
                        }
                        else if (child is DateTimePicker)
                        {
                            ((DateTimePicker)child).Value = DateTime.Today;
                        }
                    }
                }
            }
            loadDH();
            loadCTDH("");
            loadKH();
            loadSH();
            loadNV_TDN(Program.mainForm.TenDangNhap);
        }

        private void BtnSuaDH_Click(object sender, EventArgs e)
        {
            string maKH = cboKH.SelectedValue.ToString().Trim();
            string maDH = txtDH.Text;
            string ngayDat = dtND.Value.ToString("yyyy-MM-dd");
            donHangBLL.suaDH(maKH, ngayDat, maDH);
            loadDH();
        }

        private void BtnThemCT_Click(object sender, EventArgs e)
        {
            string sl = txtSoLuong.Text.Trim();
            if (sl == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                txtSoLuong.Focus();
                return;
            }
            else
            {
                string maDH = txtDH2.Text;
                string maSH = cboSach.SelectedValue.ToString();
                int soLuong = int.Parse(sl);
                decimal giaBan = decimal.Parse(txtGiaBan.Text);
                if (donHangBLL.ktraKC_CT(maDH, maSH))
                {
                    MessageBox.Show("Sách này đã có trong đơn hàng nên sẽ tăng thêm số lượng của sách vừa thêm");
                    soLuong = int.Parse(dgvCTDH.CurrentRow.Cells[1].Value.ToString());
                    donHangBLL.suaCT(soLuong + int.Parse(sl), maDH, maSH);
                }

                else
                    donHangBLL.themCT(maDH, maSH, soLuong, giaBan);
                loadCTDH(maDH);
                loadDH();
            }
        }

        private void CboSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSH = cboSach.SelectedValue.ToString();
            if (maSH != string.Empty)
            {
                DataTable dt = donHangBLL.layGiaBan(maSH);
                if (dt.Rows.Count > 0)
                    txtGiaBan.Text = dt.Rows[0]["GiaBan"].ToString();
            }
        }

        private void BtnThemDH_Click(object sender, EventArgs e)
        {
            string maDH = txtDH.Text;

            bool kq = donHangBLL.ktraKC_DH(txtDH.Text);
            if (kq)
            {
                MessageBox.Show("Mã đơn hàng đã có vui lòng nhập lại");
                txtDH.Focus();
                return;
            }
            else
            {
                string maKH = cboKH.SelectedValue.ToString().Trim();
                decimal tongTien = 0;
                string ngayDat = dtND.Value.ToString("yyyy-MM-dd");

                string maNV = "";
                DataTable nv = donHangBLL.layMaNV(Program.mainForm.TenDangNhap);
                if (nv.Rows.Count > 0)
                    maNV = nv.Rows[0]["MaNV"].ToString();

                donHangBLL.themDH(maDH, maKH, ngayDat, tongTien, maNV);

                loadDH();
            }
        }

        DateTime chuyenStr(string str)
        {
            string dateTimeString = str;

            // Chuyển đổi chuỗi thành DateTime
            DateTime dateTimeValue;
            if (DateTime.TryParse(dateTimeString, out dateTimeValue))
            {
                // Gán giá trị DateTime cho DateTimePicker
                return dateTimeValue;
            }
            else
            {
                // Xử lý trường hợp chuỗi không phải là DateTime hợp lệ
                return DateTime.MinValue;
            }
        }

        private void DgvCTDH_SelectionChanged(object sender, EventArgs e)
        {
            int n = dgvCTDH.SelectedRows.Count;
            if (n > 0)
            {
                txtSoLuong.Text = dgvCTDH.CurrentRow.Cells[1].Value.ToString().Trim();
                txtGiaBan.Text = dgvCTDH.CurrentRow.Cells[2].Value.ToString().Trim();
                cboSach.SelectedIndex = cboSach.FindString(dgvCTDH.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void DgvDH_SelectionChanged(object sender, EventArgs e)
        {
            int n = dgvDH.SelectedRows.Count;
            if (n > 0)
            {
                txtDH.Text = dgvDH.CurrentRow.Cells[0].Value.ToString().Trim();
                txtDH2.Text = dgvDH.CurrentRow.Cells[0].Value.ToString().Trim();
                cboKH.SelectedIndex = cboKH.FindString(dgvDH.CurrentRow.Cells[3].Value.ToString());
                txtTongTien.Text = dgvDH.CurrentRow.Cells[2].Value.ToString();
                dtND.Value = chuyenStr(dgvDH.CurrentRow.Cells[1].Value.ToString());
                cboNV.SelectedIndex = cboNV.FindString(dgvDH.CurrentRow.Cells[4].Value.ToString().Trim());
                loadCTDH(txtDH.Text);
            }
        }

        void loadDH()
        {
            dgvDH.DataSource = donHangBLL.loadDH();
        }

        void loadKH()
        {
            cboKH.DataSource = donHangBLL.loadKH();
            cboKH.ValueMember = "MaKH";
            cboKH.DisplayMember = "TenKH";
        }

        void loadSH()
        {
            cboSach.DataSource = donHangBLL.loadSH();
            cboSach.ValueMember = "MaSach";
            cboSach.DisplayMember = "TenSach";
        }

        void loadCTDH(string maDH)
        {
            dgvCTDH.DataSource = donHangBLL.loadCTDH(maDH);
        }

        void loadNV_TDN(string TDN)
        {
            cboNV.DataSource = donHangBLL.layMaNV(TDN);
            cboNV.ValueMember = "MaNV";
            cboNV.DisplayMember = "TenNV";
        }

        void loadNV()
        {
            cboNV.DataSource = donHangBLL.loadNV();
            cboNV.ValueMember = "MaNV";
            cboNV.DisplayMember = "TenNV";
        }

        private void FrmDonHang_Load(object sender, EventArgs e)
        {
            txtTongTien.Enabled = false;
            txtDH2.Enabled = false;
            txtGiaBan.Enabled = false;

            loadDH();
            loadKH();
            loadSH();
            loadCTDH("");
            loadNV();
        }

        private void dgvDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {

        }

        private void frmDonHang_Load_1(object sender, EventArgs e)
        {

        }
    }
}
