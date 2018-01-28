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
    public partial class FrmDanhSachHangTrongDon : Form
    {
        HangTrongDon hd = null;
        BALayer.DonHang dh = null; 
        DataTable dt = null;
        int tam = -1;
   
        bool f = false;
        string err = "";
        string a = "";
        
        public FrmDanhSachHangTrongDon()
        {
            hd = new HangTrongDon();
            dh = new BALayer.DonHang();
            
            InitializeComponent();
            dt = new DataTable();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gcKhuyenMai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbThemDonMoiTao_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FrmThemHangVaoDon_Load(object sender, EventArgs e)
        {
            LoadData();

            KH();
        }
        public void LoadData()
        {
            try
            {
                dt = hd.LayMatHang();
                cbMaHang.DataSource = dt;
                cbMaHang.DisplayMember = "TenHang";
                cbMaHang.ValueMember = "MaHang";
                dt = new DataTable();
                dt = dh.LayDonHang();
                cbMaDon.DataSource = dt;
                cbMaDon.DisplayMember = "MaDonHang";
                cbMaDon.ValueMember = "MaDonHang";
                if (MaDonHang.ToString() != "0")
                {
                    cbMaDon.SelectedValue = MaDonHang.ToString();
                    dgvDSHTD.DataSource = hd.LayHoaDonTheoMaDonHang(MaDonHang);
                }
                else
                {
                    dgvDSHTD.DataSource = hd.LayHoaDon();
                }
               
            }
            catch
            {
                MessageBox.Show("Chưa có mặt hàng nào. Vui lòng thêm mặt hàng!!!");
            }
            KH();
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
        public int MaDonHang { get; set; }

        private void txtMaDonHang_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnXacNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int r = dgvDSHTD.CurrentCell.RowIndex;
                if (dgvDSHTD.Rows[r].Cells[7].Value.ToString() == "0")
                {
                    DialogResult traloi;
                    traloi = MessageBox.Show("Có muốn xác nhận hàng này không?", "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (traloi == DialogResult.Yes)
                    {
                        f = hd.XacNhanHangTrongDon(ref err, Int32.Parse(dgvDSHTD.Rows[r].Cells[0].Value.ToString()), dgvDSHTD.Rows[r].Cells[1].Value.ToString());
                        if (f)
                        {
                            MessageBox.Show("Đã Xác Nhận Xong!");

                        }
                        else
                        {
                            MessageBox.Show(" Chưa Xác Nhận Được !\n\r" + "Lỗi:" + err);

                        }

                    }
                    
                }
                else
                {
                    {
                        string err = "";
                        bool f = hd.BoXacNhanHangTrongDon(ref err, Int32.Parse(dgvDSHTD.Rows[r].Cells[0].Value.ToString()), dgvDSHTD.Rows[r].Cells[1].Value.ToString());
                        if (f)
                        {
                            MessageBox.Show("Đã bỏ xác nhận!");
                        }
                        else
                        {
                            MessageBox.Show(" Chưa được !\n\r" + "Lỗi:" + err);
                        }
                        
                    }
                }
                LoadData();
            }
            catch
            {
                MessageBox.Show("Chưa chọn mặt hàng!!");
            }
            


        }
        public void VHH()
        {
            btnThem1.Enabled = false;
            btnSua.Enabled = false;
            btnXoa1.Enabled = false;
            btnLuu.Enabled = true;

        }
        public void KH()
        {
            btnThem1.Enabled = true;
            btnSua.Enabled = true;
            btnXoa1.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void dgvDSHTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int r = dgvDSHTD.CurrentCell.RowIndex;
            if (dgvDSHTD.Rows[r].Cells[0].Value.ToString() != null)
            {
                txtSoLuong.Text = dgvDSHTD.Rows[r].Cells[2].Value.ToString();
                txtTongTien.Text = dgvDSHTD.Rows[r].Cells[6].Value.ToString();
                cbMaHang.SelectedValue = dgvDSHTD.Rows[r].Cells[1].Value.ToString();
                cbGiamGia.Checked = Boolean.Parse(dgvDSHTD.Rows[r].Cells[4].Value.ToString());
                cbTangQua.Checked = Boolean.Parse(dgvDSHTD.Rows[r].Cells[3].Value.ToString());
                txtDonGia.Text = dgvDSHTD.Rows[r].Cells[5].Value.ToString();
                cbMaDon.SelectedValue = dgvDSHTD.Rows[r].Cells[0].Value.ToString();
               
            }
            if (dgvDSHTD.Rows[r].Cells[7].Value.ToString() == "1")
                btnXoa1.Enabled = false;
            else btnXoa1.Enabled = true;
        }



        private void btnXoa1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = -1;
            VHH();
            DialogResult traloi;

            traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
            {
                int r = dgvDSHTD.CurrentCell.RowIndex;
                f = hd.XoaHangTrongDon(ref err, Int32.Parse(dgvDSHTD.Rows[r].Cells[0].Value.ToString()), dgvDSHTD.Rows[r].Cells[1].Value.ToString());
                if (f)
                {
                    MessageBox.Show("Đã Xóa xong!");

                }
                else
                {
                    MessageBox.Show(" Chưa Xóa được !\n\r" + "Lỗi:" + err);

                }

            }
            LoadData();
        }



        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }


      

        private void btnThem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            VHH();
            cbMaDon.SelectedValue = MaDonHang.ToString();
            txtSoLuong.ResetText();
            txtDonGia.ResetText();
            txtTongTien.ResetText();
            cbGiamGia.Checked = false;
            cbTangQua.Checked = false;
            //gcKhuyenMai.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            VHH();
            gcKhuyenMai.Enabled = true;
            int r = dgvDSHTD.CurrentCell.RowIndex;
            a = dgvDSHTD.Rows[r].Cells[1].Value.ToString();
        }


        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            tam = -1;
        }




        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            

            if (tam == 1 && txtSoLuong.ToString() != "" && cbMaHang.SelectedValue.ToString() != "" && cbMaDon.SelectedValue.ToString() != "")
            {
                f = hd.ThemHangTrongDon(ref err, Int32.Parse(cbMaDon.SelectedValue.ToString()), Int32.Parse(txtSoLuong.Text.ToString()), cbMaHang.SelectedValue.ToString());
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                    tam = -1;
                    gcKhuyenMai.Enabled = false;
                    if (Int32.Parse(txtSoLuong.Text.ToString()) >= 50)
                    {
                        MessageBox.Show("Chọn cách khuyến mãi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gcKhuyenMai.Enabled = true;
                        tam = -2;
                    }

                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }
            }
            if (tam == 2)
            {
                bool a1 = false;
                bool a2 = false;
                if (cbTangQua.Checked==true && cbGiamGia.Checked==false)
                {
                    a1 = true;
                    a2 = false;
                }
                if (cbTangQua.Checked == false && cbGiamGia.Checked == true)
                {
                    a1 = false;
                    a2 = true;
                }
                if((cbTangQua.Checked == true && cbGiamGia.Checked == true) || (cbTangQua.Checked==false && cbGiamGia.Checked==false))
                {
                    MessageBox.Show("Không thể chọn cả hai hoặc bỏ chọn cả hai!!!");
                }
                else
                {
                    f = hd.CapNhatKhuyenMai(ref err, Int32.Parse(cbMaDon.SelectedValue.ToString())
                    , cbMaHang.SelectedValue.ToString(),  a1, a2);
                    if (f)
                    {
                        MessageBox.Show("Đã chọn cách khuyến mãi xong!");
                    }
                    else
                    {
                        MessageBox.Show(" Chưa chọn được !\n\r" + "Lỗi:" + err);
                    }
                    tam = -1;
                }
                
            }
            if (tam == 0)
            {
                bool a1 = false;
                bool a2 = false;
                if (cbTangQua.Checked == true && cbGiamGia.Checked == false)
                {
                    a1 = true;
                    a2 = false;
                }
                if (cbTangQua.Checked == false && cbGiamGia.Checked == true)
                {
                    a1 = false;
                    a2 = true;
                }
                if (cbTangQua.Checked == true && cbGiamGia.Checked == true)
                {
                    MessageBox.Show("Không thể chọn cả hai!!!");
                }
                else
                {   if (cbTangQua.Checked == true || cbGiamGia.Checked == true)
                    {
                        f = hd.SuaHangTrongDon(ref err, Int32.Parse(cbMaDon.SelectedValue.ToString()), a
                    , cbMaHang.SelectedValue.ToString(), Int32.Parse(txtSoLuong.Text.ToString()), a1, a2);
                        if (f)
                        {
                            MessageBox.Show("Đã sửa xong!");
                        }
                        else
                        {
                            MessageBox.Show(" Chưa sửa được !\n\r" + "Lỗi:" + err);
                        }
                        tam = -1;
                    }
                    
                }

            }
            if (tam!=-2)
                LoadData();
            else
            {
                btnThem1.Enabled = false;
                btnSua.Enabled = false;
                btnXoa1.Enabled = false;
                btnLuu.Enabled = true;
                tam = 2;
            }
        }

        private void gcKhuyenMai_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void cbTangQua_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnTangQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbTangQua.Checked == true)
            {
                FrmTangQua1 f = new FrmTangQua1();
                try
                {
                    f.MaDonHang = Int32.Parse(cbMaDon.SelectedValue.ToString());
                    f.MaHang = cbMaHang.SelectedValue.ToString();
                    f.SoLuong = Int32.Parse(txtSoLuong.Text.ToString());
                    f.ShowDialog();
                }
                catch (Exception err) { MessageBox.Show(err.Message+ "asdsadsad"); }
                
            }
            else
                MessageBox.Show("Chua chọn mục tặng quà");
            LoadData();
        }

        private void btnGiamGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbGiamGia.Checked == true)
            {
                FrmTongGiamGia f = new FrmTongGiamGia();
                try
                {
                    f.MaDonHang = Int32.Parse(cbMaDon.SelectedValue.ToString());
                    f.MaHang = cbMaHang.SelectedValue.ToString();
                    f.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Chưa chọn đơn hàng!!!");
                }
            }
            else MessageBox.Show("Chưa chọn mục giảm giá");
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKho.Text = hd.LaySLKho(cbMaHang.SelectedValue.ToString()).ToString();
        }
    }
}

