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
    public partial class FrmDanhSachKhuyenMai : Form
    {
        KhuyenMai km = null;
        int tam =2;
        public FrmDanhSachKhuyenMai()
        {
            km = new KhuyenMai();
            InitializeComponent();
        }

        private void FrmDanhSachKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            DataTable dt = new DataTable();
            cbMaGiam.DataSource = km.LayLoaiGiamGia();
            cbMaGiam.DisplayMember = "TenGiamGia";
            cbMaGiam.ValueMember = "MaLoaiGiamGia";
            dt = new DataTable();
            MatHang1 mh = new MatHang1();
            cbMaHang.DataSource = mh.LayMatHang();
            cbMaHang.DisplayMember = "TenHang";
            cbMaHang.ValueMember = "MaHang";
            dgvDSGG.DataSource = km.LayDSGG();
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
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSGG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSGG.CurrentCell.RowIndex;
            cbMaHang.SelectedValue = dgvDSGG.Rows[r].Cells[2].Value.ToString();
            deBD.Text = dgvDSGG.Rows[r].Cells[3].Value.ToString();
            deKT.Text = dgvDSGG.Rows[r].Cells[4].Value.ToString(); 
            cbMaGiam.SelectedValue = dgvDSGG.Rows[r].Cells[1].Value.ToString();
            ceConHieuLuc.Checked= Boolean.Parse(dgvDSGG.Rows[r].Cells[5].Value.ToString());
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            btnThem.Enabled = false;
            btnSua.Enabled = false; btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                bool f = false;
                string err = "";
                tam = 2;

                DialogResult traloi;

                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    int r = dgvDSGG.CurrentCell.RowIndex;
                    f = km.XoaGiamGia(ref err, Int32.Parse(dgvDSGG.Rows[r].Cells[0].Value.ToString()));
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
            catch { MessageBox.Show("Chưa chọn đối tượng cần xóa!!!"); }
            LoadData();
        }

    

    private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            //if (Int32.Parse(txtSoLuong.Text.ToString()) >= 50 && cbGiamGia.Checked == false && cbTangQua.Checked == false)
            //{
            //    MessageBox.Show("Bạn chưa chọn cách khuyến mãi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else

            if (tam == 1 )
            {
                f = km.ThemGiamGia(ref err, cbMaHang.SelectedValue.ToString(), Int32.Parse(cbMaGiam.SelectedValue.ToString()),DateTime.Parse(deBD.Text),DateTime.Parse(deKT.Text));
                   
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                    tam = -1;
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }
            }
            if (tam == 0)
            {
                int r = dgvDSGG.CurrentCell.RowIndex;
                f = km.SuaGiamGia(ref err, Int32.Parse(dgvDSGG.Rows[r].Cells[0].Value.ToString()), cbMaHang.SelectedValue.ToString(), Int32.Parse(cbMaGiam.SelectedValue.ToString()), DateTime.Parse(deBD.Text), DateTime.Parse(deKT.Text),ceConHieuLuc.Checked);
                if (f)
                {
                    MessageBox.Show("Đã sửa xong!");
                    tam = -1;
                }
                else
                {
                    MessageBox.Show(" Chưa sửa được !\n\r" + "Lỗi:" + err);
                }
            }
            LoadData();
        }

        private void btnDSMGG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDSLoaiGiamGia f = new FrmDSLoaiGiamGia();
            f.ShowDialog();
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

    }
}
