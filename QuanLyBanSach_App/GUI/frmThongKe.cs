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
    public partial class frmThongKe : Form
    {
        DonHangBLL donhangbll = new DonHangBLL();
        public frmThongKe()
        {
            InitializeComponent();
            LoadCombobox_Thang();
        }


        public void LoadCombobox_Thang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbo_thang.Items.Add("Tháng - " + i.ToString());
            }

            cbo_thang.SelectedIndex = 0;
            LoadDonHangTheoThang(1);
        }

        public void LoadDonHangTheoThang(int thang)
        {
            var dataTable = donhangbll.LayDonHangTheoThang(thang);
            dgv_donhang.DataSource = dataTable;

            decimal tongTien = TinhTongTien(dataTable);
            lbl_tongtien.Text = $"{tongTien:N0} VND";
        }

        private decimal TinhTongTien(DataTable dataTable)
        {
            decimal tongTien = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                // tổng tiền mà là null tcho nó thanh 0
                if (row["TongTien"] != DBNull.Value)
                {
                    tongTien += Convert.ToDecimal(row["TongTien"]);
                }
            }
            return tongTien;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }

        private void cbo_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = cbo_thang.SelectedItem.ToString();
            string[] parts = selectedText.Split(' ');
            int thang = int.Parse(parts[parts.Length - 1]);

            LoadDonHangTheoThang(thang);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Program.mainForm = new frmMain();
            Program.mainForm.TenDangNhap = frmLogin.tenND;
            Program.mainForm.Show();
            this.Dispose();
        }
    }
}
