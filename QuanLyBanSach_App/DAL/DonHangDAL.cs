using DAL.dsQLBSTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonHangDAL
    {
        public DonHangDAL()
        {

        }

        DonHangTableAdapter daDH = new DonHangTableAdapter();
        ChiTietDonHangTableAdapter daCT = new ChiTietDonHangTableAdapter();

        #region Load dữ liệu
        public DataTable loadDH()
        {
            return daDH.GetData();
        }

        public DataTable loadKH()
        {
            KhachHangTableAdapter daKH = new KhachHangTableAdapter();
            return daKH.GetData();
        }

        public DataTable loadSH()
        {
            SachTableAdapter daSH = new SachTableAdapter();
            return daSH.GetData();
        }

        public DataTable loadCTDH(string maDH)
        {
            return daCT.GetData(maDH);
        }
        #endregion

        #region Kiểm tra khóa chính
        public bool ktraKC_DH(string maDH)
        {
            int? n = daDH.ktraKC_DH(maDH);

            if (n > 0)
                return true; // có trùng

            return false;
        }

        public bool ktraKC_CT(string maDH, string maSH)
        {
            int? n = daCT.ktraKC_CTDH(maDH, maSH);

            if (n > 0)
                return true; // có trùng

            return false;
        }
        #endregion

        #region Thêm dữ liệu
        public void themDH(string maDH, string maKH, string ngayDat, decimal tongTien)
        {
            daDH.InsertT_DH(maDH, maKH, ngayDat, tongTien);
        }

        public DataTable layGiaBan(string maSH)
        {
            return daCT.GetDataBy_MaSH(maSH);
        }

        public void themCT(string maDH, string maSH, int soLuong, decimal giaBan)
        {
            daCT.InsertT_CTDH(maDH, maSH, soLuong, giaBan);
        }
        #endregion

        #region Sửa dữ liệu
        public void suaDH(string maKH, string ngayDat, string maDH)
        {
            daDH.UpdateT_DH(maKH, ngayDat, maDH);
        }

        public void suaCT(int soLuong, string maDH, string maSH)
        {
            daCT.UpdateT_CTDH(soLuong, maDH, maSH);
        }
        #endregion

        #region Xóa dữ liệu
        public void xoaCT(string maDH, string maSH)
        {
            daCT.DeleteT_CTDH(maDH, maSH);
        }
        #endregion
    }
}
