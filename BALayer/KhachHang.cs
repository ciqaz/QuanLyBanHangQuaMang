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
    public class KhachHang
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
        public DataTable LayKhachHang()
        {
            var dh = from p in dbs.KhachHangs
                     select p;
            if (dh != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(dh);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
                return null;
        }
       
        public bool ThemKhachHang(ref string err,string TenKhachHang, string  SDT,string DiaChi)
        {
            bool f = false;
            try
            {
                dbs.SP_ThemKH( TenKhachHang, SDT, DiaChi);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool SuaKhachHang(ref string err,int MaKH , string TenKhachHang, string SDT, string DiaChi)
        {
            bool f = false;
            try
            {
                dbs.SP_SuaKH(MaKH, TenKhachHang, SDT, DiaChi);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool XoaKhachHang(ref string err, int MaKH)
        {
            bool f = false;
            try
            {
                dbs.SP_XoaKH(MaKH);
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
