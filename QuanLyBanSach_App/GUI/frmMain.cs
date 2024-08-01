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

        private void nhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.nhomNguoiDungForm = new frmNhomNguoiDung();
            Program.nhomNguoiDungForm.Show();
            this.Dispose();
        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.manHinhForm = new frmManHinh();
            Program.manHinhForm.Show();
            this.Dispose();
        }
    }
}
