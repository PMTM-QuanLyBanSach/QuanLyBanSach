using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class SachBLL
    {
        public SachBLL()
        {

        }

        SachDAL sachDAL = new SachDAL();

        public DataTable loadSH()
        {
            return sachDAL.loadSH();
        }

        public DataTable loadTG()
        {
            return sachDAL.loadTG();
        }

        public DataTable loadDM()
        {
            return sachDAL.loadDM();
        }

        public bool ktraKC(string maSH)
        {
            return sachDAL.ktraKC(maSH);
        }

        public bool ktraTenSH(string tenSH)
        {
            return sachDAL.ktraTenSH(tenSH);
        }

        public void themDL(string maSH, string maTG, string maDM, decimal giaBan, int slKho, string tenSH)
        {
            sachDAL.themDL(maSH, maTG, maDM, giaBan, slKho, tenSH);
        }

        public void suaDL(string maTG, string maDM, decimal giaBan, int slKho, string tenSH, string maSH)
        {
            sachDAL.suaDL(maTG, maDM, giaBan, slKho, tenSH, maSH);
        }

        public void xoaDL(string maSH)
        {
           sachDAL.xoaDL(maSH);
        }

        public DataTable locSH(string maSH, string maTG, string maDM)
        {
            return sachDAL.locSH(maSH, maTG, maDM);
        }

        public DataTable locTenSH(string tenSH)
        {
            return sachDAL.locTenSH(tenSH);
        }

        public DataTable locSLT(string SLT)
        {
            return sachDAL.locSLT(SLT);
        }
    }
}
