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
    public class PhanQuyen
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
      
        public int DoiMatKhau(string MaNV, string TenDangNhap,string MKMoi,string MKcu)
        {
            int f;
            dbs.SP_CapNhatTrangThaiTaiKhoan(TenDangNhap);
            f=dbs.DOIMK_LOGIN(MaNV, TenDangNhap, MKMoi, MKcu);
            return f;
        }
        
        public DataTable LayNV()
        {
            var dh = from p in dbs.PhanQuyens
                     join d in dbs.NhanViens on p.MaTK equals d.MaNhanVien
                     select new {d.MaNhanVien,d.TenNhanVien,d.DiaChi,d.SDT,p.TenDangNhap,p.MatKhau,p.Quyen};
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
       
        public bool ThemNV(ref string err,string MaNV,string TenNV,string DiaChi,string SDT,string TenDN,string MK,string quyen)
        {
            bool f = false;

            try
            {

                //dbs.SP_ThemNV(MaNV, TenNV, DiaChi, SDT);
                dbs.SP_TaoLogin_v2(MaNV, TenDN, MK, quyen, TenNV, DiaChi, SDT);
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
           /* if (f == true)
            {
                int a = dbs.TAO_LOGIN(TenDN, MK, MaNV, quyen);
                if (a == 0)
                    f = true;
                else f = false;
            }*/
            return f;
        }
        public bool XoaNV(ref string err, string  MaNV)
        {
            bool f = false; 
            try
            {        
                    if(dbs.XOA_LOGIN(MaNV)==0)      
                        f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }


    }
}
