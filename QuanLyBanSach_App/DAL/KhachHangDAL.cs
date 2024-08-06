using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dsQLBSTableAdapters;


namespace DAL
{
    public class KhachHangDAL
    {
        public KhachHangDAL()
        {

        }

        KhachHangTableAdapter da = new KhachHangTableAdapter();

        public DataTable loadDataKH()
        {
            return da.GetData();
        }

        public void themKhachHang(string maKH, string tenKH, string diaChi, string sdt, string email)
        {
            da.InsertT_KH(maKH,tenKH,diaChi,sdt,email);
        }

        public void suaKhachHang(string tenKH, string diaChi, string sdt, string email, string maKH)
        {
            da.UpdateT_KH(tenKH, diaChi, sdt, email, maKH) ;
        }

        public void xoaKhachHang(string maKh)
        {
            da.DeleteT_KH(maKh);
        }

    }

}
