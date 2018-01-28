using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DALayer;

namespace BALayer
{
    public class TangQua
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);

        public DataTable LayTangQuaTheoMa(int MaDonHang, String MaHang)
        {
            var tt = from p in dbs.F_LoadTangQuaTheoMa(MaDonHang,MaHang)
                     select p;
            if (tt != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(tt);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public DataTable LayTangQua()
        {
            var tt = from p in dbs.TangQuas
                     select p;
            if (tt != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(tt);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public bool ThemTangQua(ref string err, int MaDonHang, string MaHang, string MaQua,int SoLuong)
        {
            bool f = false;
            try
            {
                dbs.SP_ThemTangQua(MaDonHang, MaHang, MaQua, SoLuong);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool SuaTangQua(ref string err, int MaDonHang, string MaHang, string MaQua, int SoLuong)
        {
            bool f = false;
            try
            {
                dbs.SP_SuaTangQua(MaDonHang, MaHang, MaQua, SoLuong);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool XoaTangQua(ref string err, int MaDonHang, string MaHang)
        {
            bool f = false;
            try
            {
                dbs.SP_XoaTangQua(MaDonHang, MaHang );
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
    }
}
