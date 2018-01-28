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
    public partial class FrmTangQua1 : Form
    {
        int tam = -1;

        BALayer.TangQua tq = null;
        BALayer.DonHang dh = null;
        MatHang1 mh = null;
        DataTable dt = null;
        public FrmTangQua1()
        {
            dh = new BALayer.DonHang();
            mh = new MatHang1();
            tq = new BALayer.TangQua();
            InitializeComponent();
        }
        public int MaDonHang { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        private void FrmTangQua1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
               
                dt = new DataTable();
                dt= dh.LayDonHang();
                cbMaDon.DataSource = dt;
                cbMaDon.DisplayMember = "MaDonHang";
                cbMaDon.ValueMember = "MaDonHang";

                 DataTable dt1 = new DataTable();
                dt1 =mh.LayQua();
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "TenHang";
                comboBox1.ValueMember = "MaHang";

                 DataTable dt2 = new DataTable();
                dt2 = mh.LayMatHang();
             
                cbMaQua.DataSource = dt2;
                cbMaQua.DisplayMember = "TenHang";
                cbMaQua.ValueMember = "MaHang";
                if(MaDonHang !=0)
                {
                    dgvTQ.DataSource = tq.LayTangQuaTheoMa(Int32.Parse(MaDonHang.ToString()), MaHang.ToString());
                    cbMaDon.SelectedValue = MaDonHang;
                    cbMaQua.SelectedValue = MaHang;
                    int SLQua = SoLuong / 2;
                    txtSL.Text = SLQua.ToString();
                }
                else
                {
                    dgvTQ.DataSource = tq.LayTangQua();
                }
                //dgvTQ.DataSource = mh.LayMatHang();
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                tam = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtSL.ResetText();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string err = "";
                bool f = false;
                DialogResult traloi;

                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    int r = dgvTQ.CurrentCell.RowIndex;
                    f = tq.XoaTangQua(ref err, Int32.Parse(cbMaDon.SelectedValue.ToString()),
                        cbMaQua.SelectedValue.ToString());
                    if (f)
                    {
                        MessageBox.Show("Ðã Xóa xong!");

                    }
                    else
                    {
                        MessageBox.Show(" Chua Xóa Được !\n\r" + "Lỗi:" + err);

                    }

                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn đối tượng!!");
            }

            LoadData();
            tam = 1;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            if (tam == 1 && txtSL.Text != "")
            {
                f = tq.ThemTangQua(ref err, Int32.Parse(cbMaDon.SelectedValue.ToString()),
                    cbMaQua.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), Int32.Parse(txtSL.Text.ToString()));
                if (f)
                {
                    MessageBox.Show("Ðã thêm xong!");
                    tam = -1;
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }

            }
            if (tam == 0)
            {
                f = tq.SuaTangQua(ref err, Int32.Parse(cbMaDon.SelectedValue.ToString()),
                   cbMaQua.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), Int32.Parse(txtSL.Text.ToString()));
                if (f)
                {
                    MessageBox.Show("Ðã sửa xong!");
                    tam = -1;
                }
                else
                {
                    MessageBox.Show(" Chua sửa được !\n\r" + "Lỗi:" + err);
                }

            }
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void dgvTQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTQ.CurrentCell.RowIndex;
            cbMaDon.SelectedValue = dgvTQ.Rows[r].Cells[1].Value;
            cbMaQua.SelectedValue = dgvTQ.Rows[r].Cells[2].Value;
            comboBox1.SelectedValue = dgvTQ.Rows[r].Cells[3].Value;
            txtSL.Text = dgvTQ.Rows[r].Cells[4].Value.ToString();
        }

        private void cbMaQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            HangTrongDon hd = new HangTrongDon();
            txtKho.Text = hd.LaySLKho(cbMaQua.SelectedValue.ToString()).ToString();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
