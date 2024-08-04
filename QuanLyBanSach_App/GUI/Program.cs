using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static frmMain mainForm;
        public static frmLogin loginForm;
        public static frmConfig configForm;
        public static frmNguoiDung nguoiDungForm;
        public static frmNhomNguoiDung nhomNguoiDungForm;
        public static frmManHinh manHinhForm;
        public static frmThemNDVaoNhom themNDVaoNhomForm;
        public static frmPhanQuyen phanQuyenForm;
        public static frmDanhMucSach danhMucSachForm;
        public static frmTacGia tacGiaForm;
        public static frmSach sachForm;
        public static frmDonHang donHangForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
