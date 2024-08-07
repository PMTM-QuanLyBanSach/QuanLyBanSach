using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        KhachHangBLL khachhangbll = new KhachHangBLL();
        public frmKhachHang()
        {
            InitializeComponent();
            LoadDataKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void tbl_DSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadDataKhachHang()
        {
            tbl_DSKH.DataSource = khachhangbll.loadKH();
        }

        private void tbl_DSKH_SelectionChanged(object sender, EventArgs e)
        {
            int n = tbl_DSKH.SelectedRows.Count;
            if (n > 0)
            {
                txt_makhachhang.Text = tbl_DSKH.CurrentRow.Cells[0].Value.ToString().Trim();
                txt_tenkhachhang.Text = tbl_DSKH.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_diachi.Text = tbl_DSKH.CurrentRow.Cells[2].Value.ToString().Trim();
                txt_sdt.Text = tbl_DSKH.CurrentRow.Cells[3].Value.ToString().Trim();
                txt_email.Text = tbl_DSKH.CurrentRow.Cells[4].Value.ToString().Trim();
                txt_makhachhang.Enabled = true;
            }    
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Program.mainForm = new frmMain();
            Program.mainForm.TenDangNhap = frmLogin.tenND;
            Program.mainForm.Show();
            this.Dispose();
        }
           public void ClearForm()
        {
            txt_tenkhachhang.Text = String.Empty;
            txt_makhachhang.Text = String.Empty;
            txt_sdt.Text = String.Empty;
            txt_diachi.Text = String.Empty;
            txt_email.Text = String.Empty;
        }
        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            ClearForm();
            txt_makhachhang.Enabled = false;

        }

        private void btn_luukhachhang_Click(object sender, EventArgs e)
        {
            DataTable khachhangById = khachhangbll.getOneKhachHang(txt_makhachhang.Text);
            if (string.IsNullOrWhiteSpace(txt_makhachhang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tenkhachhang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Vui lòng nhập email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (khachhangById.Rows.Count > 0 && khachhangById.Rows[0][0] != null)
            {
                MessageBox.Show("Trùng mã khách hàng");
            }
            else
            {
                khachhangbll.themKH(txt_makhachhang.Text, txt_tenkhachhang.Text, txt_email.Text, txt_sdt.Text, txt_diachi.Text);
                MessageBox.Show("Thêm khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataKhachHang();
                ClearForm();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_suakhachhang_Click(object sender, EventArgs e)
        {
            int n = tbl_DSKH.SelectedRows.Count;
            if (n > 0)
            {
                if (string.IsNullOrWhiteSpace(txt_makhachhang.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_tenkhachhang.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_sdt.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_email.Text))
                {
                    MessageBox.Show("Vui lòng nhập email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                    khachhangbll.suaKH(txt_tenkhachhang.Text,  txt_diachi.Text, txt_sdt.Text, txt_email.Text, txt_makhachhang.Text);
                    MessageBox.Show("Sửa khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataKhachHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin của khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_xoakhachhang_Click(object sender, EventArgs e)
        {
            int n = tbl_DSKH.SelectedRows.Count;
            if (n > 0)
            {
                khachhangbll.xoaKH(txt_makhachhang.Text);
                MessageBox.Show("Xóa khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataKhachHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin của khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_luukhachhang_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_suakhachhang_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_xoakhachhang_Click_1(object sender, EventArgs e)
        {

        }
    }
}
