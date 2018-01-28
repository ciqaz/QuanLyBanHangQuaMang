namespace QuanLyBanHangQuaMang
{
    partial class FrmDanhSachMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemLoai = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbThongTinHang = new System.Windows.Forms.RichTextBox();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.loaiSanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBanHangQuaMang1DataSet = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSet();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loaiSanPhamTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.LoaiSanPhamTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnTIm = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDSMH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLuu,
            this.btnHuy,
            this.btnTaiLai,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnNhapHang,
            this.btnThemLoai});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(669, 141);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 1;
            this.btnLuu.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._3;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 2;
            this.btnHuy.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._4;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải Lại";
            this.btnTaiLai.Id = 3;
            this.btnTaiLai.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Apps_Accessibility_icon;
            this.btnTaiLai.Name = "btnTaiLai";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 4;
            this.btnThem.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._21;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 5;
            this.btnSua.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Contacts_icon__1_;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 6;
            this.btnXoa.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Books_icon3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Caption = "Nhập ";
            this.btnNhapHang.Id = 7;
            this.btnNhapHang.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.DigitalColorMeter_icon;
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapHang_ItemClick);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Caption = "Thêm Loại Mặt Hàng";
            this.btnThemLoai.Id = 8;
            this.btnThemLoai.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Books_icon;
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemLoai_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThem, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThemLoai);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHuy);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lưu - Hủy - Load ";
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            // 
            // rtbThongTinHang
            // 
            this.rtbThongTinHang.Location = new System.Drawing.Point(100, 301);
            this.rtbThongTinHang.Name = "rtbThongTinHang";
            this.rtbThongTinHang.Size = new System.Drawing.Size(363, 110);
            this.rtbThongTinHang.TabIndex = 3;
            this.rtbThongTinHang.Text = "";
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.DataSource = this.loaiSanPhamBindingSource1;
            this.cbLoaiHang.DisplayMember = "TenLoaiSanPham";
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(100, 215);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiHang.TabIndex = 5;
            this.cbLoaiHang.ValueMember = "LoaiID";
            // 
            // loaiSanPhamBindingSource1
            // 
            this.loaiSanPhamBindingSource1.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource1.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // quanLiBanHangQuaMang1DataSet
            // 
            this.quanLiBanHangQuaMang1DataSet.DataSetName = "QuanLiBanHangQuaMang1DataSet";
            this.quanLiBanHangQuaMang1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(333, 167);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(121, 20);
            this.txtTenMatHang.TabIndex = 4;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(333, 215);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);
            this.txtDonGia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thông Tin ";
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Location = new System.Drawing.Point(100, 167);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(121, 20);
            this.txtMaMatHang.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(100, 261);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(121, 20);
            this.txtSL.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Lượng";
            // 
            // loaiSanPhamTableAdapter
            // 
            this.loaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslTenNhanVien
            // 
            this.tslTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tslTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tslTenNhanVien.Name = "tslTenNhanVien";
            this.tslTenNhanVien.Size = new System.Drawing.Size(40, 22);
            this.tslTenNhanVien.Text = "null";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 571);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(487, 209);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTIm
            // 
            this.btnTIm.Location = new System.Drawing.Point(487, 160);
            this.btnTIm.Name = "btnTIm";
            this.btnTIm.Size = new System.Drawing.Size(75, 23);
            this.btnTIm.TabIndex = 13;
            this.btnTIm.Text = "Tìm";
            this.btnTIm.Click += new System.EventHandler(this.btnTIm_Click);
            // 
            // dgvDSMH
            // 
            this.dgvDSMH.AllowUserToAddRows = false;
            this.dgvDSMH.AllowUserToDeleteRows = false;
            this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMH.Location = new System.Drawing.Point(12, 415);
            this.dgvDSMH.Name = "dgvDSMH";
            this.dgvDSMH.ReadOnly = true;
            this.dgvDSMH.Size = new System.Drawing.Size(645, 150);
            this.dgvDSMH.TabIndex = 14;
            this.dgvDSMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellClick);
            // 
            // FrmDanhSachMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 596);
            this.Controls.Add(this.dgvDSMH);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTIm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMaMatHang);
            this.Controls.Add(this.txtTenMatHang);
            this.Controls.Add(this.cbLoaiHang);
            this.Controls.Add(this.rtbThongTinHang);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmDanhSachMatHang";
            this.Text = "Danh Sách Mặt Hàng";
            this.Load += new System.EventHandler(this.FrmDanhSachMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet1;
        //private QuanLiBanHangQuaMang1DataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        //private QuanLiBanHangQuaMang1DataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.RichTextBox rtbThongTinHang;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
       // private QuanLiBanHangQuaMang1DataSetTableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private DevExpress.XtraBars.BarButtonItem btnNhapHang;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource1;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnThemLoai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnTIm;
        private System.Windows.Forms.DataGridView dgvDSMH;
    }
}