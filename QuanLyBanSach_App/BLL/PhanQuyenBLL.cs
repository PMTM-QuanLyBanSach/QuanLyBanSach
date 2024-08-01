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

        public void suaND(string tenDN, string matKhau, bool hoatDong)
        {
            phanQuyenDAL.suaND(tenDN, matKhau, hoatDong);
        }

        public void xoaND(string tenDN)
        {
            phanQuyenDAL.xoaND(tenDN);
        }

        public List<string> GetMaNhomNguoiDung(string pTDN)
        {
            return phanQuyenDAL.GetMaNhomNguoiDung(pTDN);
        }
    }
}
