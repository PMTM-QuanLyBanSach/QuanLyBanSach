using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dsQLBSTableAdapters;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class PhanQuyenDAL
    {
        PhanQuyenDTO phanQuyenDTO = new PhanQuyenDTO();
        public PhanQuyenDAL()
        {

        }

        #region Login và Config
        public enumLogin.LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'",
            PhanQuyenDTO.connectionString);
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
        #endregion

        #region Quản lý người dùng
        QL_NguoiDungTableAdapter da = new QL_NguoiDungTableAdapter();

        public DataTable getND()
        {   
            return da.GetData();
        }

        public DataTable getNV()
        {
            NhanVienTableAdapter daNV = new NhanVienTableAdapter();
            return daNV.GetData();
        }

        public bool ktraKC(string tenDN)
        {
            QL_NguoiDungTableAdapter da = new QL_NguoiDungTableAdapter();
            int? n = da.ktraKC(tenDN);
            if (n > 0)
                return true; // Có trùng

            return false;
        }

        public void themND(string tenDN, string matKhau, bool hoatDong, string maNV)
        {
            da.InsertT(tenDN, matKhau, hoatDong, maNV);
        }

        public void suaND(string matKhau, bool hoatDong, string tenDN)
        {
            da.UpdateT(matKhau, hoatDong, tenDN);
        }

        public void xoaND(string tenDN)
        {
            da.DeleteT(tenDN);
        }
        #endregion

        #region Quản lý nhóm người dùng
        QL_NhomNguoiDungTableAdapter daNND = new QL_NhomNguoiDungTableAdapter();

        public DataTable getNND()
        {
            return daNND.GetData();
        }

        public bool ktrKC_NND(string maNhom)
        {
            int? n = daNND.ktrKC_NND(maNhom);
            
            if (n > 0)
                return true; // trùng

            return false;
        }

        public void themNND(string maNhom, string tenNhom, string ghiChu)
        {
            daNND.Insert(maNhom, tenNhom, ghiChu);
        }

        public void suaNND(string tenNhom, string ghiChu, string maNhom)
        {
            daNND.UpdateT_NND(tenNhom, ghiChu, maNhom);
        }

        public void xoaNND(string maNhom)
        {
            daNND.DeleteT_NND(maNhom);
        }
        #endregion

        #region Quản lý màn hình
        DM_ManHinhTableAdapter daMH = new DM_ManHinhTableAdapter();

        public DataTable loadMH()
        {
            return daMH.GetData();
        }

        public bool ktraKC_MH(string maMH)
        {
            int? n = daMH.ktraKC_MH(maMH);

            if (n > 0)
                return true; // trùng

            return false;
        }

        public void themMH(string maMH, string tenMH)
        {
            daMH.Insert(maMH, tenMH);
        }

        public void suaMH(string tenMH, string maMH)
        {
            daMH.UpdateT_MH(tenMH, maMH);
        }

        public void xoaMH(string maMH)
        {
            daMH.DeleteT_MH(maMH);
        }
        #endregion

        #region Quản lý thêm người dùng vào nhóm
        QL_NguoiDungNhomNguoiDung_DKTableAdapter daNND_DK = new QL_NguoiDungNhomNguoiDung_DKTableAdapter();

        public DataTable getNND_DK(string maNhom)
        {
            return daNND_DK.GetData_DK(maNhom);
        }

        public bool ktraKCNND_DK(string tenDN, string maNhom)
        {
            int? n = daNND_DK.ktraKCNND_DK(tenDN, maNhom);

            if (n > 0)
                return true;// có trùng

            return false;
        }

        public void themNDVaoNhom(string tenDN, string maNhom, string ghiChu)
        {
            daNND_DK.Insert(tenDN, maNhom, ghiChu);
        }

        public void xoaNDKhoiNhom(string tenDN, string maNhom)
        {
            daNND_DK.DeleteT_NND_DK(tenDN, maNhom);
        }
        #endregion

        #region Phân quyền
        QL_PhanQuyen_PQTableAdapter daPQ = new QL_PhanQuyen_PQTableAdapter();

        public DataTable getManHinhTheoNhom(string maNhom)
        {
            return daPQ.GetData_DK(maNhom);
        }

        public bool ktraKC_PQ(string maNhom, string maMH)
        {
            int? n = daPQ.ktrKC_PQ(maNhom, maMH);

            if (n > 0)
                return true; // trùng

            return false;
        }

        public void themQuyen(string MaNhomNguoiDung, string maMH, bool coQuyen)
        {
            daPQ.InsertT_PQ(MaNhomNguoiDung, maMH, coQuyen);
        }

        public void suaQuyen(bool coQuyen,string maNhom, string maMH)
        {
            daPQ.UpdateT_PQ(coQuyen, maNhom, maMH);
        }

        public List<string> GetMaNhomNguoiDung(string pTDN)
        {
            List<string> lst = new List<string>();

            dsQLBS.QL_NguoiDungNhomNguoiDung_DKDataTable dt = daNND_DK.GetData_Nhom(pTDN);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maNhom = dt.Rows[i][0].ToString();
                lst.Add(maNhom);
            }

            return lst;
        }
        #endregion
    }
}
