﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DonHangBLL
    {
        public DonHangBLL()
        {

        }

        DonHangDAL donHangDAL = new DonHangDAL();

        #region Load dữ liệu
        public DataTable loadDH()
        {
            return donHangDAL.loadDH();
        }

        public DataTable loadKH()
        {
            return donHangDAL.loadKH();
        }

        public DataTable loadSH()
        {
            return donHangDAL.loadSH();
        }

        public DataTable loadCTDH(string maDH)
        {
            return donHangDAL.loadCTDH(maDH);
        }

        public DataTable loadNV()
        {
            return donHangDAL.loadNV();
        }
        #endregion

        #region Kiểm tra khóa chính
        public bool ktraKC_DH(string maDH)
        {
            return donHangDAL.ktraKC_DH(maDH);
        }

        public bool ktraKC_CT(string maDH, string maSH)
        {
            return donHangDAL.ktraKC_CT(maDH, maSH);
        }
        #endregion

        #region Thêm dữ liệu
        public void themDH(string maDH, string maKH, string ngayDat, decimal tongTien, string maNV)
        {
            donHangDAL.themDH(maDH, maKH, ngayDat, tongTien, maNV);
        }

        public DataTable layGiaBan(string maSH)
        {
            return donHangDAL.layGiaBan(maSH);
        }

        public void themCT(string maDH, string maSH, int soLuong, decimal giaBan)
        {
            donHangDAL.themCT(maDH, maSH, soLuong, giaBan);
        }

        public DataTable layMaNV(string tenDN)
        {
            return donHangDAL.layMaNV(tenDN);
        }
        #endregion

        #region Sửa dữ liệu
        public void suaDH(string maKH, string ngayDat, string maDH)
        {
            donHangDAL.suaDH(maKH, ngayDat, maDH);
        }

        public void suaCT(int soLuong, string maDH, string maSH)
        {
            donHangDAL.suaCT(soLuong, maDH, maSH);
        }
        #endregion

        #region Xóa dữ liệu
        public void xoaCT(string maDH, string maSH)
        {
            donHangDAL.xoaCT(maDH, maSH);
        }
        #endregion



        public DataTable LayDonHangTheoThang(int thang)
        {
            return donHangDAL.LayDonHangTheoThang(thang);
        }
    }
}
