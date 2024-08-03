using DAL.dsQLBSTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        public SachDAL()
        {

        }

        SachTableAdapter da = new SachTableAdapter();
        public DataTable loadSH()
        {
            return da.GetData();
        }

        public DataTable loadTG()
        {
            TacGiaTableAdapter daTG = new TacGiaTableAdapter();
            return daTG.GetData();
        }

        public DataTable loadDM()
        {
            DanhMucSachTableAdapter daDM = new DanhMucSachTableAdapter();
            return daDM.GetData();
        }

        public bool ktraKC(string maSH)
        {
            int? n = da.ktraKC(maSH);

            if (n > 0)
                return true;// trùng

            return false;
        }

        public void themDL(string maSH, string maTG, string maDM, decimal giaBan, int slKho, string tenSH)
        {
            da.Insert(maSH, maTG, maDM, giaBan, slKho, tenSH);
        }

        public void suaDL(string maTG, string maDM, decimal giaBan, int slKho, string tenSH, string maSH)
        {
            da.UpdateT(maTG, maDM, giaBan, slKho, tenSH, maSH);
        }

        public void xoaDL(string maSH)
        {
            da.DeleteT(maSH);
        }

        public DataTable locSH(string maSH, string maTG, string maDM, string tenSH)
        {
            return da.GetDataBy_DK(maSH, maTG, maDM, tenSH);
        }

        public DataTable locSLT(string SLT)
        {
            return da.GetDataBy_SLT(SLT);
        }
    }
}
