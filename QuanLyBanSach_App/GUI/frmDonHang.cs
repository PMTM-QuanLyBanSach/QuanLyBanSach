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
                donHangBLL.themDH(maDH, maKH, ngayDat, tongTien);
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
            int n = dgvDH.SelectedRows.Count;
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

        private void FrmDonHang_Load(object sender, EventArgs e)
        {
            txtTongTien.Enabled = false;
            txtDH2.Enabled = false;
            txtGiaBan.Enabled = false;

            loadDH();
            loadKH();
            loadSH();
            loadCTDH("");
        }

        private void btnMain_Click(object sender, EventArgs e)
        {

        }

        private void frmDonHang_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
