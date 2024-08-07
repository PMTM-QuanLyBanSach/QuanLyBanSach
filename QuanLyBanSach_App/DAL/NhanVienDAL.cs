using DAL.dsQLBSTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        public NhanVienDAL()
        {

        }

        NhanVienTableAdapter da = new NhanVienTableAdapter();

        public DataTable loadDataNV()
        {
            return da.GetData();
        }

        public DataTable getOne(string maNV)
        {
            return da.GetNhanVienByMaNV(maNV);
        }

        public void themNhanVien(string maNV, string tenNV, string diaChi, string sdt, string email, string chucVu)
        {
            da.InsertT_NV(maNV, tenNV, diaChi, sdt, email,chucVu);
        }

        public void suaNhanVien(string maNV, string tenNV, string diaChi, string sdt, string email, string chucVu)
        {
            da.UpdateT_NV(maNV, tenNV, diaChi, sdt, email, chucVu);
        }

        public void xoaNhanVien(string maNV)
        {
            da.DeleteT_NV(maNV);
        }
    }
}
