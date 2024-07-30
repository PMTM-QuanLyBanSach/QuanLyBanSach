using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class PhanQuyenDAL
    {
        public PhanQuyenDAL()
        {

        }

        public enumLogin.LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'",
            PhanQuyenBLL.connectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return enumLogin.LoginResult.Invalid;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return enumLogin.LoginResult.Disabled;// Không hoạt động
            }
            return enumLogin.LoginResult.Success;// Đăng nhập thành công
        }

        public DataTable getDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source="
                + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }

        //public List<string> GetMaNhomNguoiDung(string pTDN)
        //{
        //    List<string> lst = new List<string>();

        //    QL_NguoiDungNhomNguoiDung_NhomTableAdapter da = new QL_NguoiDungNhomNguoiDung_NhomTableAdapter();

        //    Buoi05.dsNguoiDung.QL_NguoiDungNhomNguoiDung_NhomDataTable dt = da.GetData_Nhom(pTDN);

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        string maNhom = dt.Rows[i][0].ToString();
        //        lst.Add(maNhom);
        //    }

        //    return lst;
        //}

        //public DataTable GetMaManHinh(string pMaNhom)
        //{
        //    QL_PhanQuyen_PQTableAdapter da = new QL_PhanQuyen_PQTableAdapter();
        //    DataTable dt = da.GetData(pMaNhom);
        //    return dt;
        //}
    }
}
