using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thêmNgườiDùngVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.themNDVaoNhomForm = new frmThemNDVaoNhom();
            Program.themNDVaoNhomForm.Show();
            this.Dispose();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.nguoiDungForm = new frmNguoiDung();
            Program.nguoiDungForm.Show();
            this.Dispose();
        }
    }
}
