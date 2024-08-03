using DAL.dsQLBSTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TacGiaDAL
    {
        public TacGiaDAL()
        {

        }

        TacGiaTableAdapter da = new TacGiaTableAdapter();
        public DataTable loadTG()
        {
            return da.GetData();
        }

        public bool ktraKC(string maTG)
        {
            int? n = da.ktraKC(maTG);

            if (n > 0)
                return true;// trùng

            return false;
        }

        public void themDL(string maTG, string tenTG)
        {
            da.Insert(maTG, tenTG);
        }

        public void suaDL(string tenTG, string maTG)
        {
            da.UpdateT(tenTG, maTG);
        }

        public void xoaDL(string maTG)
        {
            da.DeleteT(maTG);
        }

        public DataTable locMaDM(string maTG)
        {
            return da.GetDataBy_MaTG(maTG);
        }

        public DataTable locTenDM(string tenTG)
        {
            return da.GetDataBy_TenTG(tenTG);
        }
    }
}
