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
    public class HangTrongDon
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
        public DataTable LayHoaDon()
        {
            var dh = from p in dbs.HoaDons
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
        public DataTable LayMatHang()
        {
            var dh = from p in dbs.MatHangs where p.LoaiID!="Q"
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


        public DataTable LayHoaDonTheoMaDonHang(int MaDonHang)
        {
            var dh = from p in dbs.HoaDons where p.MaDonHang==MaDonHang
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
        public DataTable LayHoaDonTheoMaHang(string MaHang)
        {
            var dh = from p in dbs.HoaDons
                     where p.MaHang == MaHang
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
        public bool ThemHangTrongDon(ref string err, int MaDonHang, int SoLuong, string MaHang)
        {
            bool f = false;
            try
            {
                dbs.SP_ThemHoaDon(MaDonHang, MaHang, SoLuong);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public int LaySLKho(string MaHang)
        {
            return Int32.Parse(dbs.F_LaySLKho(MaHang).ToString());
        }
        public bool SuaHangTrongDon(ref string err,int MaDonHang, string MaHangCu, string MaHang, int SoLuong,bool TangQua,bool GiamGia)
        {
            bool f = false;
            try
            {
                dbs.SP_SuaHoaDon(MaDonHang,MaHangCu, MaHang, SoLuong,TangQua,GiamGia);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool CapNhatKhuyenMai(ref string err, int MaDonHang, string MaHang, bool TangQua, bool GiamGia)
        {
            bool f = false;
            try
            {
                dbs.SP_CapNhatKhuyenMai(MaDonHang,  MaHang, TangQua, GiamGia);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool XoaHangTrongDon(ref string err, int MaDonHang,string MaHang)
        {
            bool f = false;
            try
            {
                dbs.SP_XoaHoaDon(MaDonHang, MaHang);
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool XacNhanHangTrongDon(ref string err, int MaDonHang, string MaHang)
        {
            bool f = false;
            try
            {
                dbs.SP_XacNhanHoaDon(MaDonHang, MaHang);
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool BoXacNhanHangTrongDon(ref string err, int MaDonHang, string MaHang)
        {
            bool f = false;
            try
            {
                dbs.SP_BoXacNhanHoaDon(MaDonHang, MaHang);
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }

        public bool SuaHangTrongDon(ref string err, int v1, string v2, int v3, bool v4, bool v5)
        {
            throw new NotImplementedException();
        }
    }
}
