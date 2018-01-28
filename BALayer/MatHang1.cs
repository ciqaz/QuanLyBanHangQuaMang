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
    public class MatHang1
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
        public DataTable LayMatHang()
        {
            var dh = from p in dbs.MatHangs
                     join d in dbs.KhoHangs on p.MaHang equals d.MaHang where p.LoaiID!="Q"
                     select new {p, d.SoLuong};
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

        public DataTable LayLoaiMatHang()
        {
            var dh = from p in dbs.LoaiSanPhams
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
        public DataTable LayTatCa()
        {
            var dh = from p in dbs.MatHangs
                     join d in dbs.KhoHangs on p.MaHang equals d.MaHang
                     select new { p, d.SoLuong };
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
        
        public DataTable LayNhapHang()
        {
            var dh = from p in dbs.NhapHangs
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
        public DataTable LayQua()
        {
            var dh = from p in dbs.MatHangs
                     join d in dbs.KhoHangs on p.MaHang equals d.MaHang
                     where p.LoaiID == "Q"
                     select new {p.MaHang,p.TenHang,d.SoLuong,p.DonGia };
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
        public bool ThemMatHang(ref string err, string MaMatHang, string LoaiMatHang,string TenMatHang, Decimal GiaMatHang,string ThongTinMatHang)
        {
            bool f = false;
            MatHang m = new MatHang();
            m.MaHang = MaMatHang;
            m.LoaiID = LoaiMatHang;
            m.TenHang = TenMatHang;
            m.DonGia = GiaMatHang;
            m.ThongTinHang = ThongTinMatHang;
            try
            {
                dbs.MatHangs.InsertOnSubmit(m);
                dbs.SubmitChanges();
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool ThemLoaiMatHang(ref string err, string Ma, string TenLoai)
        {
            bool f = false;
            LoaiSanPham m = new LoaiSanPham();
            m.LoaiID = Ma;
            m.TenLoaiSanPham = TenLoai;
            try
            {
                dbs.LoaiSanPhams.InsertOnSubmit(m);
                dbs.SubmitChanges();
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool XoaMatHang(ref string err, string MaMatHang)
        {
            bool f = false;
            MatHang hs = dbs.MatHangs.Single(p => p.MaHang == MaMatHang);
            try
            {
                if (hs != null)
                {
                    dbs.MatHangs.DeleteOnSubmit(hs);
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
        public bool XoaLoaiMatHang(ref string err, string Ma)
        {
            bool f = false;
            LoaiSanPham hs = dbs.LoaiSanPhams.Single(p => p.LoaiID == Ma);
            try
            {
                if (hs != null)
                {
                    dbs.LoaiSanPhams.DeleteOnSubmit(hs);
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
        public bool SuaMatHang(ref string err, string MaMatHang, string LoaiMatHang, string TenMatHang, Decimal GiaMatHang, string ThongTinMatHang)
        {
            bool f = false;
            MatHang d = dbs.MatHangs.Single(p => p.MaHang == MaMatHang);
            try
            {
                if (d != null)
                {
                    d.LoaiID = LoaiMatHang;
                    d.TenHang = TenMatHang;
                    d.DonGia = GiaMatHang;
                    d.ThongTinHang = ThongTinMatHang;
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
        public bool SuaLoaiMatHang(ref string err, string Ma,string Ma1, string Ten)
        {
            bool f = false;
            LoaiSanPham d = dbs.LoaiSanPhams.Single(p => p.LoaiID == Ma1);
            try
            {
                if (d != null)
                {
                    d.LoaiID = Ma;
                    d.TenLoaiSanPham = Ten;
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
        public bool ThemNhapHang(ref string err,string MaHang,int SL,string NguoiNhap,decimal DonGia)
        {


            bool f = false;
            try
            {
                dbs.SP_ThemNhapHang(MaHang, SL, NguoiNhap, DonGia);
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool SuaNhapHang(ref string err,int MaNhapHang, string MaHang, int SL, string NguoiNhap, decimal DonGia)
        {


            bool f = false;
            NhapHang d = dbs.NhapHangs.Single(p => p.MaNhapHang== MaNhapHang);
            try
            {
                if (d != null)
                {
                    d.MaHang = MaHang;
                    d.SoLuong = SL;
                    d.NguoiNhap = NguoiNhap;
                    d.DonGia = DonGia;
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
        public bool XoaNhapHang(ref string err, int MaNhapHang)
        {
            bool f = false;
            NhapHang hs = dbs.NhapHangs.Single(p => p.MaNhapHang == MaNhapHang);
            try
            {
                if (hs != null)
                {
                    dbs.NhapHangs.DeleteOnSubmit(hs);
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
    }
}
