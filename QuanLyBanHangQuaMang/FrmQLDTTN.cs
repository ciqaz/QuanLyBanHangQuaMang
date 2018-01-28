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
    public partial class FrmQLDTTN : Form
    {
        DoanhThu dt = null;
        public FrmQLDTTN()
        {
            dt = new DoanhThu();
            InitializeComponent();
        }

        private void FrmQLDTTN_Load(object sender, EventArgs e)
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
        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTTN.DataSource = dt.Tim(DateTime.Parse(deNgay.Text.ToString()));

                string a = dgvTTN.Rows[0].Cells[1].Value.ToString() + "-" + dgvTTN.Rows[0].Cells[0].Value.ToString() + "-" + dgvTTN.Rows[0].Cells[2].Value.ToString();
                txtSL.Text = dt.LaySLDonTrongNgay(DateTime.Parse(a.ToString())).ToString();
                txtTT.Text = Decimal.Truncate(Decimal.Parse(dgvTTN.Rows[0].Cells[3].Value.ToString())).ToString();
            }
            catch { MessageBox.Show("Chưa có doanh thu trong ngày này!!"); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvTTN.DataSource = dt.Layhet();
            txtSL.ResetText();
            txtTT.ResetText();
            deNgay.Text = DateTime.Now.ToString();
        }

        private void dgvTTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTTN.CurrentCell.RowIndex;
            string a = dgvTTN.Rows[r].Cells[1].Value.ToString() + "-" + dgvTTN.Rows[r].Cells[0].Value.ToString() + "-" + dgvTTN.Rows[r].Cells[2].Value.ToString();
            txtSL.Text = dt.LaySLDonTrongNgay(DateTime.Parse(a.ToString())).ToString();
            txtTT.Text = Decimal.Truncate(Decimal.Parse(dgvTTN.Rows[r].Cells[3].Value.ToString())).ToString();
            deNgay.Text = a.ToString();
        }
        private void btnQLDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDonHang f = new FrmDanhSachDonHang();
            f.ShowDialog();
            this.Close();


        }

        private void btnDenTTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTinhTrangDon t = new FrmTinhTrangDon();
            t.ShowDialog();
            this.Close();
        }
    }
}
