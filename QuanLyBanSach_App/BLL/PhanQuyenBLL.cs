using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL phanQuyenDAL = new PhanQuyenDAL();
        PhanQuyenDTO phanQuyenDTO = new PhanQuyenDTO();
        public PhanQuyenBLL()
        {

        }

        #region Login và Config
        public enumLogin.LoginResult Check_User(string pUser, string pPass)
        {
            return phanQuyenDAL.Check_User(pUser, pPass);
        }

        public int Check_Config()
        {
            if (PhanQuyenDTO.connectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(PhanQuyenDTO.connectionString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }

        public string saveConfig(string pServer, string pUser, string pPass, string pDBName)
        {
            return "Data Source= " + pServer
                + ";Initial Catalog=" + pDBName + ";User ID=" + pUser + "; pwd = " + pPass;
        }

        public DataTable getDBName(string pServer, string pUser, string pPass)
        {
            return phanQuyenDAL.getDBName(pServer, pUser, pPass);
        }
        #endregion

        #region Quản lý người dùng
        public DataTable getND()
        {
            return phanQuyenDAL.getND();
        }

        public bool ktraKC(string tenDN)
        {
            return phanQuyenDAL.ktraKC(tenDN);
        }

        public void themND(string tenDN, string matKhau, bool hoatDong)
        {
            phanQuyenDAL.themND(tenDN, matKhau, hoatDong);
        }

        public void suaND(string matKhau, bool hoatDong, string tenDN)
        {
            phanQuyenDAL.suaND(matKhau, hoatDong, tenDN);
        }

        public void xoaND(string tenDN)
        {
            phanQuyenDAL.xoaND(tenDN);
        }
        #endregion

        #region Quản lý nhóm người dùng
        public DataTable getNND()
        {
            return phanQuyenDAL.getNND();
        }

        public bool ktrKC_NND(string maNhom)
        {
            return phanQuyenDAL.ktrKC_NND(maNhom);
        }

        public void themNND(string maNhom, string tenNhom, string ghiChu)
        {
            phanQuyenDAL.themNND(maNhom, tenNhom, ghiChu);
        }

        public void suaNND(string tenNhom, string ghiChu, string maNhom)
        {
            phanQuyenDAL.suaNND(tenNhom, ghiChu, maNhom);
        }

        public void xoaNND(string maNhom)
        {
            phanQuyenDAL.xoaNND(maNhom);
        }
        #endregion

        #region Quản lý màn hình
        public DataTable loadMH()
        {
            return phanQuyenDAL.loadMH();
        }

        public bool ktraKC_MH(string maMH)
        {
            return phanQuyenDAL.ktraKC_MH(maMH);
        }

        public void themMH(string maMH, string tenMH)
        {
            phanQuyenDAL.themMH(maMH, tenMH);
        }

        public void suaMH(string tenMH, string maMH)
        {
            phanQuyenDAL.suaMH(tenMH, maMH);
        }

        public void xoaMH(string maMH)
        {
            phanQuyenDAL.xoaMH(maMH);
        }
        #endregion

        #region Quản lý thêm người dùng vào nhóm
        public DataTable getNND_DK(string maNhom)
        {
            return phanQuyenDAL.getNND_DK(maNhom);
        }

        public bool ktraKCNND_DK(string tenDN, string maNhom)
        {
            return phanQuyenDAL.ktraKCNND_DK(tenDN, maNhom);
        }

        public void themNDVaoNhom(string tenDN, string maNhom, string ghiChu)
        {
            phanQuyenDAL.themNDVaoNhom(tenDN, maNhom, ghiChu);
        }

        public void xoaNDKhoiNhom(string tenDN, string maNhom)
        {
            phanQuyenDAL.xoaNDKhoiNhom(tenDN, maNhom);
        }
        #endregion

        public DataTable getManHinhTheoNhom(string maNhom)
        {
            return phanQuyenDAL.getManHinhTheoNhom(maNhom);
        }

        public bool ktraKC_PQ(string maNhom, string maMH)
        {
            return phanQuyenDAL.ktraKC_PQ(maNhom, maMH);
        }

        public void themQuyen(string MaNhomNguoiDung, string maMH, bool coQuyen)
        {
            phanQuyenDAL.themQuyen(MaNhomNguoiDung, maMH, coQuyen);
        }

        public void suaMH(bool coQuyen, string maNhom, string maMH)
        {
            phanQuyenDAL.suaQuyen(coQuyen, maNhom, maMH);
        }

        public List<string> GetMaNhomNguoiDung(string pTDN)
        {
            return phanQuyenDAL.GetMaNhomNguoiDung(pTDN);
        }
    }
}
