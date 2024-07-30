using GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL phanQuyenDAL = new PhanQuyenDAL();
        public PhanQuyenBLL()
        {

        }

        public static string connectionString = frmConfig.connectionString;

        public enumLogin.LoginResult Check_User(string pUser, string pPass)
        {
            return phanQuyenDAL.Check_User(pUser, pPass);
        }

        public int Check_Config()
        {
            if (connectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(connectionString);
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
    }
}
