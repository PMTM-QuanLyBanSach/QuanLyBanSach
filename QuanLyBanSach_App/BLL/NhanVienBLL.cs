using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class NhanVienBLL
    {
        public NhanVienBLL()
        {

        }
        NhanVienDAL nhanVienDAL = new NhanVienDAL();


        public DataTable loadNV()
        {
            return nhanVienDAL.loadDataNV();
        }

        public DataTable getOneNhanVien(string manv)
        {
            return nhanVienDAL.getOne(manv);
        }

        public void themNV(string manv, string tenNV, string email, string sdt, string diachi, string chucVu)
        {
            nhanVienDAL.themNhanVien(manv, tenNV, diachi, sdt, email, chucVu);
        }

        public void suaNV(string tenNV, string diaChi, string sdt, string email, string manv, string chucVu)
        {
            nhanVienDAL.suaNhanVien(tenNV, diaChi, sdt, email, manv, chucVu);
        }
        public void xoaNV(string manv)
        {
            nhanVienDAL.xoaNhanVien(manv);
        }
    }
}
