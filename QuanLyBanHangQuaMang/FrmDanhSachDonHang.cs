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
    public partial class FrmDanhSachDonHang : Form
    {
       
        BALayer. DonHang dh = null;
        BALayer.KhachHang kh = null;
        ThongTinNhanVien tt = null;
        int tam;
        bool f = false;
        string err = "";
        string TenNhanVien;
        public FrmDanhSachDonHang()
        {
            InitializeComponent();
            tt=new ThongTinNhanVien();
            dh = new BALayer. DonHang();
            kh = new BALayer.KhachHang();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (txtDiaChi.Text != "" && deNgayChuyen.Text != "" && tam == 1)
            {
                f = dh.ThemDonHang(ref err, Int32.Parse(cbMaKH.SelectedValue.ToString()), DateTime.Parse(deNgayChuyen.Text), cbNoiThanh.Checked, txtDiaChi.Text,Class1.username.ToString());
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }

            }
            if (tam == 0)
            {
                
                int r = dgvDonHang1.CurrentCell.RowIndex;
                if (dgvDSDH1.Rows[0].Cells[4].Value.ToString().Trim() == Class1.username || Class1.mGroup == "QUANLY")
                {
                    f = dh.SuaDonHang(ref err, Int32.Parse(dgvDonHang1.Rows[r].Cells[0].Value.ToString()), Int32.Parse(cbMaKH.SelectedValue.ToString()), DateTime.Parse(deNgayChuyen.Text), cbNoiThanh.Checked, txtDiaChi.Text, Class1.username.ToString());
                    if (f)
                    {
                        MessageBox.Show("Đã sửa xong!");
                    }
                    else
                    {
                        MessageBox.Show(" Chưa sửa được !\n\r" + "Lỗi:" + err);
                    }
                }
                else { MessageBox.Show("Bạn không có quyền sửa đơn này!!!"); }
               
            }
            tam = 2;
            CapNhat();
            LoadData();
        }
        public void CapNhatTinhTrang()
        {

        }
        private void FrmThemDonHang_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            LoadData();
           
        }
       
        public void LoadData()
        {
            DataTable dt = new DataTable();
            
           
           
            dgvDonHang1.DataSource = dh.LayDonHang();
            dgvDSDH1.DataSource = dh.LayDonHang();
            txtDiaChi.ResetText();
            deNgayChuyen.ResetText();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemKhachHang.Enabled = true;

            btnThemPhiShip.Enabled = true;
            btnLuu.Enabled = false;
            tam = 2;
            //Do len combobox
            dt = tt.LayNhanVien1();
            
            dt = new DataTable();
            dt = kh.LayKhachHang();
            cbMaKH.DataSource = dt;
            cbMaKH.DisplayMember = "TenKhachHang";
            cbMaKH.ValueMember = "MaKH";
            //Hien ten nhan vien
            LayTenNhanVien();
            DayLenToolStrips();
        }
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

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            
        }

        private void btnThemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachKH f = new FrmDanhSachKH();
            f.ShowDialog();
            LoadData();
        }
        private void btnThemHangVaoDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int r = 0;
                r = dgvDonHang1.CurrentCell.RowIndex;
                FrmDanhSachHangTrongDon f = new FrmDanhSachHangTrongDon();
                f.MaDonHang = 0;
                f.MaDonHang = Int32.Parse(dgvDSDH1.Rows[r].Cells[0].Value.ToString());
                f.ShowDialog();
            }
            catch { MessageBox.Show("Chưa chọn đơn hàng!!!"); }
            

            LoadData();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            txtDiaChi.ResetText();
            deNgayChuyen.ResetText();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            
        }


        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            try
            {
                int r = dgvDonHang1.CurrentCell.RowIndex;

                if (dgvDSDH1.Rows[r].Cells[4].Value.ToString().Trim() == Class1.username || Class1.mGroup == "QUANLY")
                {
                    DialogResult traloi;

                    traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (traloi == DialogResult.Yes)
                    {
                        int r1 = dgvDonHang1.CurrentCell.RowIndex;
                        f = dh.XoaDonHang(ref err, Int32.Parse(dgvDonHang1.Rows[r1].Cells[0].Value.ToString()));
                        if (f)
                        {
                            MessageBox.Show("Đã Xóa xong!");
                            CapNhat();
                        }
                        else
                        {
                            MessageBox.Show(" Chưa xóa được: !\n\r" + "Lỗi:" + err);
                            LoadData();
                        }

                    }
                }
                else { MessageBox.Show("Bạn không có quyền xóa đơn này!!!"); LoadData(); }
                
            }
            catch { MessageBox.Show("Chưa chọn đối tượng!!!!"); LoadData(); }
        }

       

        private void btnXacNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int r = dgvDonHang1.CurrentCell.RowIndex;
                if (dgvDSDH1.Rows[r].Cells[4].Value.ToString().Trim() == Class1.username || Class1.mGroup == "QUANLY")
                {
                    if (dgvDSDH1.Rows[r].Cells[5].Value.ToString() == "0")
                    {
                        string err = "";
                        bool f = dh.XacNhanDonHang(ref err, Int32.Parse(dgvDonHang1.Rows[r].Cells[0].Value.ToString()));
                        if (f)
                        {
                            MessageBox.Show("Đã xác nhận xong!");
                            CapNhat();
                        }
                        else
                        {
                            MessageBox.Show(" Chưa được !\n\r" + "Lỗi:" + err);
                            LoadData();
                        }
                        
                    }
                    else { MessageBox.Show("Đơn đã được xác nhận!!!"); LoadData(); }       
                }
                else{ MessageBox.Show("Bạn không có quyền xác nhận đơn này!!!"); LoadData(); }
                
            }
            catch
            {
                MessageBox.Show("Chưa chọn đơn hàng. Vui lòng kiểm tra lại"); LoadData();
            }
            
                

                

           
           
        }
        
        private void btnDSKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachKH f = new FrmDanhSachKH();
            f.ShowDialog();
            LoadData();
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnChinhSuaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachHangTrongDon f = new FrmDanhSachHangTrongDon();
            try
            {
                int r = dgvDonHang1.CurrentCell.RowIndex;
                f.MaDonHang = Int32.Parse(dgvDonHang1.Rows[r].Cells[0].Value.ToString());

                f.ShowDialog();
                
            }
            catch
            {
                MessageBox.Show("Chưa chọn đơn hàng. Vui lòng kiểm tra lại");
            }
            CapNhat();

        }

        private void btnThemPhiShip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachPhiShip f1 = new FrmDanhSachPhiShip();
            try
            {
                int r = dgvDonHang1.CurrentCell.RowIndex;
                f1.MaDonHang = Int32.Parse(dgvDonHang1.Rows[r].Cells[0].Value.ToString());
                f1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Chưa chọn đơn hàng. Vui lòng kiểm tra lại");
            }
            CapNhat();
        }

        private void dgvDSDH1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSDH1.CurrentCell.RowIndex;
            
            cbMaKH.SelectedValue = dgvDonHang1.Rows[r].Cells[1].Value;
            txtDiaChi.Text = dgvDonHang1.Rows[r].Cells[3].Value.ToString();
            cbNoiThanh.Checked = Boolean.Parse(dgvDonHang1.Rows[r].Cells[4].Value.ToString());
           
            deNgayChuyen.Text = dgvDonHang1.Rows[r].Cells[5].Value.ToString();

            if (dgvDSDH1.Rows[r].Cells[4].Value.ToString().Trim() == Class1.username || Class1.mGroup == "QUANLY")
            {
                btnThemHangVaoDon.Enabled = true;
                if (cbNoiThanh.Checked == false)
                    btnThemPhiShip.Enabled = true;
                else
                    btnThemPhiShip.Enabled = false;
            }
            else
            {
                btnThemHangVaoDon.Enabled = false;
                if (cbNoiThanh.Checked == false)
                    btnThemPhiShip.Enabled = true;
                else
                    btnThemPhiShip.Enabled = false;
            }
            if (dgvDSDH1.Rows[r].Cells[5].Value.ToString() == "1")
                btnXacNhan.Enabled = false;
            else
                btnXacNhan.Enabled = true;
        }

        private void dgvDonHang1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDonHang1.CurrentCell.RowIndex;

            cbMaKH.SelectedValue = dgvDonHang1.Rows[r].Cells[1].Value;
            txtDiaChi.Text = dgvDonHang1.Rows[r].Cells[3].Value.ToString();
            cbNoiThanh.Checked = Boolean.Parse(dgvDonHang1.Rows[r].Cells[4].Value.ToString());
            deNgayChuyen.Text = dgvDonHang1.Rows[r].Cells[5].Value.ToString();
            dgvDSDH1.DataSource = dh.LayDonHangTheoMa(Int32.Parse(dgvDonHang1.Rows[r].Cells[0].Value.ToString()));
            if (dgvDSDH1.Rows[0].Cells[4].Value.ToString().Trim() == Class1.username || Class1.mGroup == "QUANLY")
            {
               
                btnThemHangVaoDon.Enabled = true;
                if (cbNoiThanh.Checked == false)
                    btnThemPhiShip.Enabled = true;
                else
                    btnThemPhiShip.Enabled = false;
            }
            if (dgvDSDH1.Rows[0].Cells[4].Value.ToString().Trim() != Class1.username && Class1.mGroup != "QUANLY")
            {
                btnThemHangVaoDon.Enabled = false;
                if (cbNoiThanh.Checked == false)
                    btnThemPhiShip.Enabled = true;
                else
                    btnThemPhiShip.Enabled = false;
            }
            if (dgvDSDH1.Rows[0].Cells[5].Value.ToString() == "1")
                btnXacNhan.Enabled = false;
            else
                btnXacNhan.Enabled = true;
        }
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (dbs.F_LayTinhTrangBang("DonHang") == true)
            //{
            //    LoadData();
            //    dbs.SP_CapNhatTinhTrangBang("DonHang");
            //    MessageBox.Show("Bảng DS Đơn Hàng Vừa Được Cập Nhật");
            //}
        }
        public void CapNhat()
        {
            try
            {

                //if (dbs.F_LayTinhTrangBang("DonHang") == false)
                //    dbs.SP_CapNhatTinhTrangBang("DonHang");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
