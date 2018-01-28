using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using DALayer;

namespace QuanLyBanHangQuaMang
{
    public partial class FrmDoiMatKhau : Form
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
        BALayer.PhanQuyen pq = null;
        public FrmDoiMatKhau()
        {
            pq = new BALayer.PhanQuyen();
            InitializeComponent();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMKmoi.ResetText();
            txtMKcu.ResetText();
            txtNhapLai.ResetText();
        }
        public int tam { get; set; }
        
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMKcu.Text!="" &&txtMKmoi.Text!="" &&txtNhapLai.Text!="")
            {
                if(txtMKcu.Text==Class1.password)
                {
                    if (txtMKmoi.Text == txtNhapLai.Text)
                    {
                        tam = pq.DoiMatKhau(Class1.username, Class1.mlogin, txtMKmoi.Text.ToString(), txtMKcu.Text.ToString());
                        if (tam == 0)
                        {
                            MessageBox.Show("Đổi Mật Khẩu Thành Công\n Mời Đăng Nhập Lại", "", MessageBoxButtons.OK);
                            //dbs.SP_CapNhatTrangThaiTaiKhoan(a1.Trim());
                            this.Close();
                        }
                        else
                            MessageBox.Show("Chưa Đổi Được", "Lỗi!!", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Nhập Lại Mật Khẩu Sai. Nhập Lại", "Lỗi!!", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Sai Mật Khẩu. Nhập Lại", "Lỗi!!", MessageBoxButtons.OK);
                }

               
            }

        }

        private void FrmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            tam = 1;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(tam.ToString());
            this.Close();

        }
    }
}
