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
    public partial class FrmTongGiamGia : Form
    {
        KhuyenMai km = null;
        public FrmTongGiamGia()
        {
            km=new KhuyenMai();
            InitializeComponent();
        }
        public int MaDonHang { get; set; }
        public string MaHang { get; set; }
       

        private void FrmTongGiamGia_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            if (MaDonHang.ToString() != "0")
                dataGridView2.DataSource = km.LayTongGiamGiaTheoMa(MaDonHang, MaHang);
            else
                dataGridView2.DataSource = km.LayTongGiamGia();
            LayTenNhanVien();
            DayLenToolStrips();
        }
        string TenNhanVien;
        ThongTinNhanVien tt = new ThongTinNhanVien();
        public void LayTenNhanVien()
        {
            string err = "";
            TenNhanVien = tt.LayTenNhanVien(ref err, Class1.username);
        }
        public void DayLenToolStrips()
        {

            if (Class1.mGroup.ToString() == "QUANLY")
                tslTenNhanVien.Text = "QUẢN LÝ: " + TenNhanVien;
            if (Class1.mGroup.ToString() == "NHANVIENBANHANG")
            {
                tslTenNhanVien.Text = "NHÂN VIÊN BÁN HÀNG: " + TenNhanVien;

            }

            if (Class1.mGroup.ToString() == "NHANVIENNHAPKHO")
            {
                tslTenNhanVien.Text = "NHÂN VIÊN NHẬP KHO: " + TenNhanVien;

            }
        }
        private void btnDenGiamGia_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachKhuyenMai f = new FrmDanhSachKhuyenMai();
            f.ShowDialog();
            LoadData();
        }
    }
}
