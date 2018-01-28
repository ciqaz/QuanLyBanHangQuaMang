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
    public partial class FrmLoiNhuan : Form
    {
        DoanhThu dt = null;
        public FrmLoiNhuan()
        {
            dt = new DoanhThu();
            InitializeComponent();
        }

        private void FrmLoiNhuan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.LayHetLoiNhuan();
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
    private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string b = txtThang.Text + "-1" + "-" + txtNam.Text;
                dataGridView1.DataSource = dt.Tim2(DateTime.Parse(b));
                txtThu.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString())).ToString();
                txtChi.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString())).ToString();
                txtTongTien.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString())).ToString();
            }
            catch { MessageBox.Show("Chưa có lợi nhuận trong tháng này!!"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtThu.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[r].Cells[2].Value.ToString())).ToString();
            txtChi.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[r].Cells[3].Value.ToString())).ToString();
            txtTongTien.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[r].Cells[4].Value.ToString())).ToString();
            txtThang.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtNam.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.LayHetLoiNhuan();
        }

        private void btnQLDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDSPhi f = new FrmDSPhi();
            this.Close();
            f.ShowDialog();
        }

        private void btnDSDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDonHang f = new FrmDanhSachDonHang();
            this.Close();
            f.ShowDialog();
        }
    }
}
