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
    
    public class DonHang
    {
       QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
       
        public DataTable LayDonHang()
        {
           
            var dh = from p in dbs.DonHangs
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
        public DataTable LayDonHangTheoMa(int Ma)
        {

            var dh = from p in dbs.DonHangs where p.MaDonHang==Ma
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
        public DataTable LayDonHangTheoSDT(string Sdt)
        {
            
            var dh = from p in dbs.DonHangs
                     join d in dbs.KhachHangs on p.MaKH equals d.MaKH
                     where d.SDT == Sdt
                     orderby p.MaDonHang, p.MaKH
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
       
        public DataTable LayKhachHangTheoMa(int MaDonHang)
        {
            
            var dh = from p in dbs.DonHangs
                     join d in dbs.KhachHangs on p.MaKH equals d.MaKH
                     where p.MaDonHang == MaDonHang
                     orderby p.MaDonHang, p.MaKH
                     select d;
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
        public DataTable LayKHTheoSDT(string Sdt)
        {
            
            var dh = from p in dbs.DonHangs
                     join d in dbs.KhachHangs on p.MaKH equals d.MaKH
                     where d.SDT == Sdt
                     orderby p.MaDonHang, p.MaKH
                     select d;
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
        public bool ThemDonHang(ref string err, int MaKH, DateTime NgayChuyen, bool NoiThanh, string DiaChiGiao, string NhanVien)
        {
           
            bool f = false;
            try
            {
                dbs.SP_ThemDonHang(MaKH, NgayChuyen, NoiThanh, DiaChiGiao, NhanVien);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        
        public bool XoaDonHang(ref string err, int MaDonHang)
        {
            
            bool f = false;
            try
            {
                dbs.SP_XoaDonHang(MaDonHang);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool SuaDonHang(ref string err, int MaDonHang, int MaKH, DateTime NgayChuyen, bool NoiThanh, string DiaChiGiao, string NhanVien)
        {
            
            bool f = false;
            try
            {
                dbs.SP_SuaDonHang(MaDonHang, MaKH, NgayChuyen, NoiThanh, DiaChiGiao, NhanVien);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool XacNhanDonHang(ref string err, int MaDonHang)
        {
           
            bool f = false;
            try
            {
                dbs.SP_XacNhanDonHang(MaDonHang);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool BoXacNhanDonHang(ref string err, int MaDonHang)
        {
           
            bool f = false;
            try
            {
                dbs.SP_BoXacNhanDonHang(MaDonHang);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public DataTable F_LoadDonHang(int MaDonHang)
        {

           
            var a = from p in dbs.F_LoadDonHang(MaDonHang)
            select p;
            if (a != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(a);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else return null;
            
            

        }
        public DataTable F_LoadHoaDon(int MaDonHang)
        {

            
            var a = from p in dbs.F_LoadHoaDon(MaDonHang)
                    select p;
            if (a != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(a);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else return null;

        }
        public DataTable F_LoadTangQua(int MaDonHang)
        {

            
            var a = from p in dbs.F_LoadTangQua(MaDonHang)
                    select p;
            if (a != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(a);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else return null;

        }
        public DataTable F_LoadGiamGia(int MaDonHang)
        {
            

            var a = from p in dbs.F_LoadGiamGia(MaDonHang)
                    select p;
            if (a != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(a);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else return null;

        }
    }
}