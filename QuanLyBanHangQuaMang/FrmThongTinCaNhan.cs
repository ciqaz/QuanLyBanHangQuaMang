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
using System.IO;
using DALayer;

namespace QuanLyBanHangQuaMang
{
    public partial class FrmThongTinCaNhan : Form
    {
        int tam = 2;
        MemoryStream ms;
        byte[] arrImage;
        ThongTinNhanVien tt = null;
        public FrmThongTinCaNhan()
        {
            tt = new ThongTinNhanVien();
            InitializeComponent();
        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiBanHangQuaMang1DataSet.NhanVien' table. You can move, or remove it, as needed.
            
            LoadData();
        }
        public void LoadData()
        {
            //this.chucVuTableAdapter.Fill(this.quanLiBanHangQuaMang1DataSet.ChucVu);
            try
            {
                dataGridView1.DataSource = tt.LayNhanVien(Class1.username);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
            txtTenNhanVien.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            this.pbHinh.Image = (System.Drawing.Image)
            dataGridView1.Rows[0].Cells[4].FormattedValue;
            btnLuu.Enabled = false;
            txtMaNhanVien.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            btnSua.Enabled = true;
            dataGridView1.Visible = false;
            btnLuu.Enabled = false;
            LayTenNhanVien();
            DayLenToolStrips();
        }
        string TenNhanVien;
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


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                pbHinh.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                pbHinh.Image.Save(ms, pbHinh.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string err = "";
            bool f = false;
            int r = dataGridView1.CurrentCell.RowIndex;
            if (txtTenNhanVien.Text != "" && txtSDT.Text != null && txtDiaChi.Text != null && tam == 1)
            {
                f = tt.SuaTTNV(ref err, Class1.username.ToString(), txtTenNhanVien.Text.ToString(), txtDiaChi.Text.ToString(), txtSDT.Text.ToString(), arrImage);
                // string TenNhanVien, string DiaChi, string SDT, byte[] Hinh, string MaChucVu) )
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }

            }

            tam = 2;
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}
