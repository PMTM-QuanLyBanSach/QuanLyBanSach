using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TacGiaBLL
    {
        public TacGiaBLL()
        { 

        }

        TacGiaDAL tacGiaDAL = new TacGiaDAL();
     
        public DataTable loadTG()
        {
            return tacGiaDAL.loadTG();
        }

        public bool ktraKC(string maDM)
        {
            return tacGiaDAL.ktraKC(maDM);
        }

        public void themDL(string maDM, string tenDM)
        {
            tacGiaDAL.themDL(maDM, tenDM);
        }

        public void suaDL(string tenDM, string maDM)
        {
            tacGiaDAL.suaDL(tenDM, maDM);
        }

        public void xoaDL(string maDM)
        {
            tacGiaDAL.xoaDL(maDM);
        }

        public DataTable locMaDM(string maDM)
        {
            return tacGiaDAL.locMaDM(maDM);
        }

        public DataTable locTenDM(string tenDM)
        {
            return tacGiaDAL.locTenDM(tenDM);
        }
    }
}
