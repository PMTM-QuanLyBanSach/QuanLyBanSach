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

        public void themKH(string makh,string tenkh, string email,string sdt, string diachi)
        {
            khachhangDAL.themKhachHang(makh, tenkh, diachi, sdt, email);
        }

        public void suaKH(string makh, string tenkh, string email, string sdt, string diachi)
        {
            khachhangDAL.suaKhachHang(makh, tenkh, diachi, sdt, email);
        }
        public void xoaKH(string makh)
        {
            khachhangDAL.xoaKhachHang(makh);
        }
    }

}
