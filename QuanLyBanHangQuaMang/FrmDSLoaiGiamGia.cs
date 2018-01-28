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
    public partial class FrmDSLoaiGiamGia : Form
    {
        KhuyenMai km = null;
        int tam=2;
        public FrmDSLoaiGiamGia()
        {
            km = new KhuyenMai();
            InitializeComponent();
        }

        private void FrmDSLoaiGiamGia_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }
        public void LoadData()
        {
            dgvLoaiGiamGia.DataSource = km.LayLoaiGiamGia();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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
        }

        private void dgvLoaiGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiGiamGia.CurrentCell.RowIndex;
            txtMaGiamGia.Text= dgvLoaiGiamGia.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dgvLoaiGiamGia.Rows[r].Cells[1].Value.ToString();
            txtGiam.Text = dgvLoaiGiamGia.Rows[r].Cells[2].Value.ToString();
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
            try {
                string err = "";
                bool f = false;
                DialogResult traloi;

                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    int r = dgvLoaiGiamGia.CurrentCell.RowIndex;

                    f = km.XoaLoaiGiamGia(ref err, Int32.Parse(dgvLoaiGiamGia.Rows[r].Cells[0].Value.ToString()));
                    if (f)
                    {
                        MessageBox.Show("Đã Xóa xong!");

                    }
                    else
                    {
                        MessageBox.Show(" Chưa Xóa được !\n\r" + "Lỗi:" + err);

                    }

                }
            }
            catch { MessageBox.Show("Chưa chọn đối tượng!!"); }
            LoadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string err = "";
            bool f = false;
            int r = dgvLoaiGiamGia.CurrentCell.RowIndex;
            if (txtMaGiamGia.Text != "" && txtGiam.Text != null && txtTen.Text!=null && tam == 1)
            {
                f = km.ThemLoaiGiamGia(ref err, Int32.Parse(txtMaGiamGia.Text.ToString()), txtTen.Text.ToString(), float.Parse(txtGiam.Text.ToString()));
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }

            }
            if (txtMaGiamGia.Text != "" && txtGiam.Text != null && txtTen.Text != null && tam == 0)
            {

                f = km.SuaLoaiGiamGia(ref err, Int32.Parse(txtMaGiamGia.Text.ToString()), txtTen.Text.ToString(), float.Parse(txtGiam.Text.ToString()));
                if (f)
                {
                    MessageBox.Show("Đã sửa xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa sửa được !\n\r" + "Lỗi:" + err);
                }
            }
            tam = 2;
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}
