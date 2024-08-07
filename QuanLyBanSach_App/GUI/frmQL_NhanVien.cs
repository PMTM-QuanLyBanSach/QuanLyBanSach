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
    public partial class frmQL_NhanVien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public frmQL_NhanVien()
        {
            InitializeComponent();
            LoadDataNhanVien();
        }
        public void LoadDataNhanVien()
        {
            dgv_listNV.DataSource = nhanVienBLL.loadNV();
        }
        private void frmQL_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dgv_listNV_SelectionChanged(object sender, EventArgs e)
        {
            int n = dgv_listNV.SelectedRows.Count;
            if (n > 0)
            {
                txt_manv.Text = dgv_listNV.CurrentRow.Cells[0].Value.ToString().Trim();
                txt_tennv.Text = dgv_listNV.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_diachi.Text = dgv_listNV.CurrentRow.Cells[2].Value.ToString().Trim();
                txt_sdt.Text = dgv_listNV.CurrentRow.Cells[3].Value.ToString().Trim();
                txt_email.Text = dgv_listNV.CurrentRow.Cells[4].Value.ToString().Trim();
                txt_chucvu.Text = dgv_listNV.CurrentRow.Cells[4].Value.ToString().Trim();
            }
        }

        public void resetFrom()
        {
            txt_manv.Text = String.Empty;
            txt_tennv.Text = String.Empty;
            txt_diachi.Text = String.Empty;
            txt_sdt.Text = String.Empty;
            txt_email.Text = String.Empty;
            txt_chucvu.Text = String.Empty;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            resetFrom();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DataTable khachhangById = nhanVienBLL.getOneNhanVien(txt_manv.Text);
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tennv.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Trùng mã nhân viên");
            }
            else
            {
                nhanVienBLL.themNV(txt_manv.Text, txt_tennv.Text, txt_email.Text, txt_sdt.Text, txt_diachi.Text,txt_chucvu.Text);
                MessageBox.Show("Thêm nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
                resetFrom();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int n = dgv_listNV.SelectedRows.Count;
            if (n > 0)
            {
                if (string.IsNullOrWhiteSpace(txt_manv.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_tennv.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                nhanVienBLL.suaNV(txt_tennv.Text, txt_diachi.Text, txt_sdt.Text, txt_email.Text, txt_manv.Text,txt_chucvu.Text);
                MessageBox.Show("Sửa nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin của nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int n = dgv_listNV.SelectedRows.Count;
            if (n > 0)
            {
                nhanVienBLL.xoaNV(txt_manv.Text);
                MessageBox.Show("Xóa nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin của nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
