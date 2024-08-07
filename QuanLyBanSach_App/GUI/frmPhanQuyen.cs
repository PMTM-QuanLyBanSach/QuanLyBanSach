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
    public partial class frmPhanQuyen : Form
    {
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public frmPhanQuyen()
        {
            InitializeComponent();
            this.Load += FrmPhanQuyen_Load;
            dgvNND.SelectionChanged += DgvNND_SelectionChanged;
            btnLuu.Click += BtnLuu_Click;
            btnMain.Click += BtnMain_Click;
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            frmNguoiDung.processMain(this);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string maNhomND = dgvNND.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < dgvPQ.Rows.Count; i++)
            {
                string maMH = dgvPQ.Rows[i].Cells[0].Value.ToString();
                bool coQuyen = (bool)(dgvPQ.Rows[i].Cells[1].Value);
                bool ktr = phanQuyenBLL.ktraKC_PQ(maNhomND, maMH);

                if (ktr)
                {
                    phanQuyenBLL.suaMH(coQuyen, maNhomND, maMH);
                }
                else
                {
                    phanQuyenBLL.themQuyen(maNhomND, maMH, coQuyen);
                }
            }
            loadQ(maNhomND);
        }

        private void DgvNND_SelectionChanged(object sender, EventArgs e)
        {
            string maNhom = dgvNND.CurrentRow.Cells[0].Value.ToString();
            loadQ(maNhom);
        }

        void loadQ(string maNhom)
        {
            int row = dgvNND.SelectedRows.Count;
            if (row > 0)
            {
                try
                {
                    dgvPQ.DataSource = phanQuyenBLL.getManHinhTheoNhom(maNhom);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            dgvNND.DataSource = phanQuyenBLL.getNND();
        }

        private void frmPhanQuyen_Load_1(object sender, EventArgs e)
        {

        }
    }
}
