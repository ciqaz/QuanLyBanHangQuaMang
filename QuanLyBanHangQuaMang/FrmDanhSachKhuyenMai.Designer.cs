namespace QuanLyBanHangQuaMang
{
    partial class FrmDanhSachKhuyenMai
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
            this.dgvDSGG = new System.Windows.Forms.DataGridView();
            this.quanLiBanHangQuaMang1DataSet = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSet();
            this.giamGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giamGiaTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.GiamGiaTableAdapter();
            this.tableAdapterManager = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.TableAdapterManager();
            this.loaiGiamGiaTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.LoaiGiamGiaTableAdapter();
            this.matHangTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.MatHangTableAdapter();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemMaGiam = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSMGG = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cbMaHang = new System.Windows.Forms.ComboBox();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMaGiam = new System.Windows.Forms.ComboBox();
            this.loaiGiamGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deBD = new DevExpress.XtraEditors.DateEdit();
            this.deKT = new DevExpress.XtraEditors.DateEdit();
            this.ceConHieuLuc = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.giamGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.giamGiaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiGiamGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceConHieuLuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSGG
            // 
            this.dgvDSGG.AllowUserToAddRows = false;
            this.dgvDSGG.AllowUserToDeleteRows = false;
            this.dgvDSGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGG.Location = new System.Drawing.Point(12, 262);
            this.dgvDSGG.Name = "dgvDSGG";
            this.dgvDSGG.ReadOnly = true;
            this.dgvDSGG.Size = new System.Drawing.Size(745, 168);
            this.dgvDSGG.TabIndex = 1;
            this.dgvDSGG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGG_CellClick);
            // 
            // quanLiBanHangQuaMang1DataSet
            // 
            this.quanLiBanHangQuaMang1DataSet.DataSetName = "QuanLiBanHangQuaMang1DataSet";
            this.quanLiBanHangQuaMang1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giamGiaBindingSource
            // 
            this.giamGiaBindingSource.DataMember = "GiamGia";
            this.giamGiaBindingSource.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // giamGiaTableAdapter
            // 
            this.giamGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CacLoaiPhiTableAdapter = null;
            this.tableAdapterManager.DonHangTableAdapter = null;
            this.tableAdapterManager.GiamGiaTableAdapter = this.giamGiaTableAdapter;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoHangTableAdapter = null;
            this.tableAdapterManager.LoaiGiamGiaTableAdapter = this.loaiGiamGiaTableAdapter;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.LoaiShipTableAdapter = null;
            this.tableAdapterManager.LoiNhuanTableAdapter = null;
            this.tableAdapterManager.MaTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = this.matHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhapHangTableAdapter = null;
            this.tableAdapterManager.PhanQuyenTableAdapter = null;
            this.tableAdapterManager.PhiQuangCaoTableAdapter = null;
            this.tableAdapterManager.PhiShipSPTableAdapter = null;
            this.tableAdapterManager.PhiTheoThangTableAdapter = null;
            this.tableAdapterManager.TangQuaTableAdapter = null;
            this.tableAdapterManager.TinhTrangDonTableAdapter = null;
            this.tableAdapterManager.TongGiamGiaTableAdapter = null;
            this.tableAdapterManager.TongTienNgayTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loaiGiamGiaTableAdapter
            // 
            this.loaiGiamGiaTableAdapter.ClearBeforeFill = true;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.barButtonItem1,
            this.btnThemMaGiam,
            this.btnDSMGG});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 13;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl2.Size = new System.Drawing.Size(781, 141);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._4;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._3;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._21;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
            this.btnLuu.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._12;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Apps_Accessibility_icon1;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemMaGiam
            // 
            this.btnThemMaGiam.Caption = "barButtonItem2";
            this.btnThemMaGiam.Id = 11;
            this.btnThemMaGiam.Name = "btnThemMaGiam";
            // 
            // btnDSMGG
            // 
            this.btnDSMGG.Caption = "Danh Sách Loại Giảm Giá";
            this.btnDSMGG.Id = 12;
            this.btnDSMGG.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Apps_Ubuntu_Tweak_icon1;
            this.btnDSMGG.Name = "btnDSMGG";
            this.btnDSMGG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSMGG_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Thao Tác";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnHuy);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSMGG);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // cbMaHang
            // 
            this.cbMaHang.DataSource = this.matHangBindingSource;
            this.cbMaHang.DisplayMember = "TenHang";
            this.cbMaHang.FormattingEnabled = true;
            this.cbMaHang.Location = new System.Drawing.Point(104, 174);
            this.cbMaHang.Name = "cbMaHang";
            this.cbMaHang.Size = new System.Drawing.Size(121, 21);
            this.cbMaHang.TabIndex = 4;
            this.cbMaHang.ValueMember = "MaHang";
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // cbMaGiam
            // 
            this.cbMaGiam.DataSource = this.loaiGiamGiaBindingSource;
            this.cbMaGiam.DisplayMember = "TenGiamGia";
            this.cbMaGiam.FormattingEnabled = true;
            this.cbMaGiam.Location = new System.Drawing.Point(391, 175);
            this.cbMaGiam.Name = "cbMaGiam";
            this.cbMaGiam.Size = new System.Drawing.Size(121, 21);
            this.cbMaGiam.TabIndex = 4;
            this.cbMaGiam.ValueMember = "MaGiamGia";
            // 
            // loaiGiamGiaBindingSource
            // 
            this.loaiGiamGiaBindingSource.DataMember = "LoaiGiamGia";
            this.loaiGiamGiaBindingSource.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Đợt Giảm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Hàng";
            // 
            // deBD
            // 
            this.deBD.EditValue = null;
            this.deBD.Location = new System.Drawing.Point(104, 218);
            this.deBD.MenuManager = this.ribbonControl2;
            this.deBD.Name = "deBD";
            this.deBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBD.Size = new System.Drawing.Size(121, 20);
            this.deBD.TabIndex = 6;
            // 
            // deKT
            // 
            this.deKT.EditValue = null;
            this.deKT.Location = new System.Drawing.Point(391, 215);
            this.deKT.Name = "deKT";
            this.deKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deKT.Size = new System.Drawing.Size(121, 20);
            this.deKT.TabIndex = 6;
            // 
            // ceConHieuLuc
            // 
            this.ceConHieuLuc.Location = new System.Drawing.Point(539, 215);
            this.ceConHieuLuc.MenuManager = this.ribbonControl2;
            this.ceConHieuLuc.Name = "ceConHieuLuc";
            this.ceConHieuLuc.Properties.Caption = "Còn Hiệu Lực";
            this.ceConHieuLuc.Size = new System.Drawing.Size(85, 19);
            this.ceConHieuLuc.TabIndex = 7;
            this.ceConHieuLuc.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Kết Thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Bắt Đầu";
            // 
            // giamGiaBindingSource1
            // 
            this.giamGiaBindingSource1.DataMember = "GiamGia";
            this.giamGiaBindingSource1.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // giamGiaBindingSource2
            // 
            this.giamGiaBindingSource2.DataMember = "GiamGia";
            this.giamGiaBindingSource2.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 434);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
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
            // FrmDanhSachKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 459);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ceConHieuLuc);
            this.Controls.Add(this.deKT);
            this.Controls.Add(this.deBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaGiam);
            this.Controls.Add(this.cbMaHang);
            this.Controls.Add(this.ribbonControl2);
            this.Controls.Add(this.dgvDSGG);
            this.Name = "FrmDanhSachKhuyenMai";
            this.Text = "Danh Sách Khuyến Mại";
            this.Load += new System.EventHandler(this.FrmDanhSachKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiGiamGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceConHieuLuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDSGG;
        private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        private System.Windows.Forms.BindingSource giamGiaBindingSource;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.GiamGiaTableAdapter giamGiaTableAdapter;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThemMaGiam;
        private DevExpress.XtraBars.BarButtonItem btnDSMGG;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.ComboBox cbMaHang;
        private System.Windows.Forms.ComboBox cbMaGiam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit deBD;
        private DevExpress.XtraEditors.DateEdit deKT;
        private DevExpress.XtraEditors.CheckEdit ceConHieuLuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.BindingSource giamGiaBindingSource2;
        private System.Windows.Forms.BindingSource giamGiaBindingSource1;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.LoaiGiamGiaTableAdapter loaiGiamGiaTableAdapter;
        private System.Windows.Forms.BindingSource loaiGiamGiaBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}