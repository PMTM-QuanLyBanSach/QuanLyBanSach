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
        }

        private void DgvNND_SelectionChanged(object sender, EventArgs e)
        {
            loadQ();
        }

        void loadQ()
        {
            int n = dgvNND.SelectedRows.Count;
            if(n > 0 )
            {
                string maNhom = dgvNND.CurrentRow.Cells[0].Value.ToString();
                if(maNhom == string.Empty)
                    maNhom = dgvNND.CurrentRow.Cells[0].Value.ToString();
                dgvPQ.DataSource = phanQuyenBLL.getManHinhTheoNhom(maNhom);
            }    
            
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            dgvNND.DataSource = phanQuyenBLL.getNND();
        }
    }
}
