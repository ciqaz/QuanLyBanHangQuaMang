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
    public partial class FrmQLDTTT : Form
    {
        DoanhThu dt = null;
        public FrmQLDTTT()
        {
            dt = new DoanhThu();
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string b =txtThang.Text + "-1"+"-" + txtNam.Text;
                dgvTTN.DataSource = dt.Tim1(DateTime.Parse(b));
                string a = dgvTTN.Rows[0].Cells[1].Value.ToString() + "-" + dgvTTN.Rows[0].Cells[0].Value.ToString() + "-" + dgvTTN.Rows[0].Cells[2].Value.ToString();
                txtSL.Text = dt.LaySLDonTrongThang(DateTime.Parse(a.ToString())).ToString();
                txtTT.Text = Decimal.Truncate(Decimal.Parse(dgvTTN.Rows[0].Cells[3].Value.ToString())).ToString();
            }
            catch { MessageBox.Show("Chưa có doanh thu trong ngày này!!"); }
        }

        private void FrmQLDTTT_Load(object sender, EventArgs e)
        {
            dgvTTN.DataSource = dt.Layhet();
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
    private void dgvTTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTTN.CurrentCell.RowIndex;
            txtThang.Text = dgvTTN.Rows[r].Cells[1].Value.ToString();
            txtNam.Text = dgvTTN.Rows[r].Cells[2].Value.ToString();
            string a = dgvTTN.Rows[r].Cells[1].Value.ToString() + "-" + dgvTTN.Rows[r].Cells[0].Value.ToString() + "-" + dgvTTN.Rows[r].Cells[2].Value.ToString();
            txtSL.Text = dt.LaySLDonTrongThang(DateTime.Parse(a.ToString())).ToString();
            txtTT.Text = Decimal.Truncate(Decimal.Parse(dgvTTN.Rows[r].Cells[3].Value.ToString())).ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvTTN.DataSource = dt.Layhet();
        }

        private void btnQLDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDonHang f = new FrmDanhSachDonHang();
            f.ShowDialog();
            this.Close();
        }
    }
}
