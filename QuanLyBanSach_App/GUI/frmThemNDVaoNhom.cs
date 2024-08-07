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
    public partial class frmThemNDVaoNhom : Form
    {
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public frmThemNDVaoNhom()
        {
            InitializeComponent();
            this.Load += FrmThemNDVaoNhom_Load;
            cboNND.DropDown += CboNND_DropDown;
            cboNND.SelectedIndexChanged += CboNND_SelectedIndexChanged;
            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;
            btnMain.Click += BtnMain_Click;
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            frmNguoiDung.processMain(this);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNND.SelectedRows.Count > 0)
            {
                string maNhom = cboNND.SelectedValue.ToString();
                string tenDN = dgvNND.CurrentRow.Cells[1].Value.ToString();

                phanQuyenBLL.xoaNDKhoiNhom(tenDN, maNhom);
                loadNND();
            }
            else
                MessageBox.Show("Vui lòng chọn vào người dùng cần xóa");
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (dgvND.SelectedRows.Count > 0)
            {
                string maNhom = cboNND.SelectedValue.ToString();
                string tenDN = dgvND.CurrentRow.Cells[0].Value.ToString();

                if (phanQuyenBLL.ktraKCNND_DK(tenDN, maNhom))
                {
                    MessageBox.Show("Người dùng đã ở trong nhóm này");
                    return;
                }
                else
                {
                    phanQuyenBLL.themNDVaoNhom(tenDN, maNhom, string.Empty);
                    loadNND();
                }
            }
            else
                MessageBox.Show("Vui lòng chọn vào người dùng cần thêm");
        }

        private void CboNND_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNND();
        }

        void loadNND()
        {
            dgvNND.DataSource = phanQuyenBLL.getNND_DK(cboNND.SelectedValue.ToString());
        }

        private void FrmThemNDVaoNhom_Load(object sender, EventArgs e)
        {
            dgvND.DataSource = phanQuyenBLL.getND();
        }

        private void CboNND_DropDown(object sender, EventArgs e)
        {
            cboNND.DataSource = phanQuyenBLL.getNND();
            cboNND.ValueMember = "MaNhom";
            cboNND.DisplayMember = "TenNhom";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmThemNDVaoNhom_Load_1(object sender, EventArgs e)
        {

        }
    }
}
