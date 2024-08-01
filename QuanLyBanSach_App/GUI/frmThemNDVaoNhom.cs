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
        }

        private void FrmThemNDVaoNhom_Load(object sender, EventArgs e)
        {
            qL_NguoiDungDataGridView.DataSource = phanQuyenBLL.getND();
        }
    }
}
