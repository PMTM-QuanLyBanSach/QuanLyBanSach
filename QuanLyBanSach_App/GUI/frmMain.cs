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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<string> nhomND = phanQuyenBLL.GetMaNhomNguoiDung(_TenDangNhap);
            foreach (string item in nhomND)
            {
                DataTable dsQuyen = phanQuyenBLL.getManHinhTheoNhom(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items,
                    mh[0].ToString(), Convert.ToBoolean(mh[1].ToString()));
                }
            }
        }

        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {

            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu is ToolStripMenuItem &&
                ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems,
                    pScreenName, pEnable);
                    menu.Enabled =
                    CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }

        string _TenDangNhap;

        public string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }

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

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.phanQuyenForm = new frmPhanQuyen();
            Program.phanQuyenForm.Show();
            this.Dispose();
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.danhMucSachForm = new frmDanhMucSach();
            Program.danhMucSachForm.Show();
            this.Dispose();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.tacGiaForm = new frmTacGia();
            Program.tacGiaForm.Show();
            this.Dispose();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.loginForm = new frmLogin();
            Program.loginForm.Show();
            this.Dispose();
        }
    }
}
