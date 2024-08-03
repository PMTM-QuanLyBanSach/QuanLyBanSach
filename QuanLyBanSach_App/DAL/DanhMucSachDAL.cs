using DAL.dsQLBSTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhMucSachDAL
    {
        public DanhMucSachDAL()
        {

        }

        DanhMucSachTableAdapter da = new DanhMucSachTableAdapter();
        public DataTable loadDMS()
        {
            return da.GetData();
        }

        public bool ktraKC(string maDM)
        {
            int? n = da.ktraKC(maDM);

            if (n > 0)
                return true;// trùng

            return false;
        }

        public void themDL(string maDM, string tenDM)
        {
            da.Insert(maDM, tenDM);
        }

        public void suaDL(string tenDM, string maDM)
        {
            da.UpdateT(tenDM, maDM);
        }

        public void xoaDL(string maDM)
        {
            da.DeleteT(maDM);
        }

        public DataTable locMaDM(string maDM)
        {
            return da.GetDataBy_MaDM(maDM);
        }

        public DataTable locTenDM(string tenDM)
        {
            return da.GetDataBy_TenDM(tenDM);
        }
    }
}
