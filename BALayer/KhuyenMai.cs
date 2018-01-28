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
    public class KhuyenMai
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
        public DataTable LayTongGiamGiaTheoMa(int MaDonHang,string MaHang )
        {
            var tt = from p in dbs.TongGiamGias where p.MaDonHang==MaDonHang &&p.MaHang==MaHang
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
        public DataTable LayTongGiamGia()
        {
            var tt = from p in dbs.TongGiamGias
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
        public DataTable LayDSGG()
        {
            var dh = from p in dbs.GiamGias
                     join d in dbs.LoaiGiamGias on p.MaLoaiGiamGia equals d.MaLoaiGiamGia
                     select new { p,d.Giam};
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

        public DataTable LayLoaiGiamGia ()
        {
            var tt = from p in dbs.LoaiGiamGias
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

        public bool SuaLoaiGiamGia(ref string err,int MaGiamGia,string TenGiamGia,float Giam)
        {
            bool f = false;
            LoaiGiamGia d = dbs.LoaiGiamGias.Single(p => p.MaLoaiGiamGia==MaGiamGia);
            try
            {
                if (d != null)
                {
                    d.TenGiamGia = TenGiamGia;
                    d.Giam = Giam;
                    dbs.SubmitChanges();
                    f = true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool XoaGiamGia(ref string err, int MaGiamGia)
        {
            bool f = false;
            GiamGia hs = dbs.GiamGias.Single(p => p.MaGiamGia == MaGiamGia);
            try
            {
                if (hs != null)
                {
                    dbs.GiamGias.DeleteOnSubmit(hs);
                    dbs.SubmitChanges();
                    f = true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool XoaLoaiGiamGia(ref string err, int MaGiamGia)
        {
            bool f = false;
            LoaiGiamGia hs = dbs.LoaiGiamGias.Single(p => p.MaLoaiGiamGia == MaGiamGia);
            try
            {
                if (hs != null)
                {
                    dbs.LoaiGiamGias.DeleteOnSubmit(hs);
                    dbs.SubmitChanges();
                    f = true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }







        public bool ThemGiamGia(ref string err,string MaHang ,int MaGiam ,DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            bool f = false;
            try
            {
                dbs.SP_ThemGiamGia(MaHang, MaGiam,NgayBatDau, NgayKetThuc);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool SuaGiamGia(ref string err, int MaGiamGia ,string MaHang ,int MaGiam,DateTime NgayBatDau , DateTime NgayKetThuc, bool ConHieuLuc)
        {
            bool f = false;
            try
            {
                dbs.SP_SuaGiamGia(MaGiamGia,MaHang, MaGiam, NgayBatDau, NgayKetThuc,ConHieuLuc);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }
        public bool ThemLoaiGiamGia(ref string err, int MaGiam,string Ten,float Giam)
        {
            bool f = false;
            LoaiGiamGia hs = new LoaiGiamGia();
            hs.MaLoaiGiamGia = MaGiam;
            hs.TenGiamGia = Ten;
            hs.Giam = Giam;
            try
            {
                dbs.LoaiGiamGias.InsertOnSubmit(hs);
                dbs.SubmitChanges();
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool XoaKhachHang(ref string err, string  MaNV)
        {
            bool f = false;
            try
            {
                dbs.XOA_LOGIN(MaNV);

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
