using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DanhMucSachBLL
    {
        DanhMucSachDAL danhMucSachDAL = new DanhMucSachDAL();
        public DanhMucSachBLL()
        {

        }

        public DataTable loadDMS()
        {
            return danhMucSachDAL.loadDMS();
        }

        public bool ktraKC(string maDM)
        {
            return danhMucSachDAL.ktraKC(maDM);
        }

        public void themDL(string maDM, string tenDM)
        {
            danhMucSachDAL.themDL(maDM, tenDM);
        }

        public void suaDL(string tenDM, string maDM)
        {
            danhMucSachDAL.suaDL(tenDM, maDM);
        }

        public void xoaDL(string maDM)
        {
            danhMucSachDAL.xoaDL(maDM);
        }

        public DataTable locMaDM(string maDM)
        {
            return danhMucSachDAL.locMaDM(maDM);
        }

        public DataTable locTenDM(string tenDM)
        {
            return danhMucSachDAL.locTenDM(tenDM);
        }
    }
}
