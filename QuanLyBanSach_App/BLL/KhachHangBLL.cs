using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class KhachHangBLL
    {
        public KhachHangBLL()
        {

        }
        KhachHangDAL khachhangDAL = new KhachHangDAL();


        public DataTable loadKH()
        {
            return khachhangDAL.loadDataKH();
        }

        public DataTable getOneKhachHang(string makh)
        {
            return khachhangDAL.getOne(makh);
        }

        public void themKH(string makh, string tenkh, string email, string sdt, string diachi)
        {
            khachhangDAL.themKhachHang(makh, tenkh, diachi, sdt, email);
        }

        public void suaKH(string tenKH, string diaChi, string sdt, string email, string maKH)
        {
            khachhangDAL.suaKhachHang(tenKH, diaChi, sdt, email, maKH);
        }
        public void xoaKH(string makh)
        {
            khachhangDAL.xoaKhachHang(makh);
        }
    }

}
