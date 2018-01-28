namespace QuanLyBanHangQuaMang
{
    partial class FrmDSLoaiGiamGia
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
            this.dgvLoaiGiamGia = new System.Windows.Forms.DataGridView();
            this.loaiGiamGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBanHangQuaMang1DataSet = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSet();
            this.loaiGiamGiaTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.LoaiGiamGiaTableAdapter();
            this.tableAdapterManager = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.TableAdapterManager();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiGiamGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.ribbonControl2.Size = new System.Drawing.Size(373, 141);
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
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
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
            // dgvLoaiGiamGia
            // 
            this.dgvLoaiGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiGiamGia.Location = new System.Drawing.Point(10, 262);
            this.dgvLoaiGiamGia.Name = "dgvLoaiGiamGia";
            this.dgvLoaiGiamGia.Size = new System.Drawing.Size(351, 173);
            this.dgvLoaiGiamGia.TabIndex = 2;
            this.dgvLoaiGiamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiGiamGia_CellClick);
            // 
            // loaiGiamGiaBindingSource
            // 
            this.loaiGiamGiaBindingSource.DataMember = "LoaiGiamGia";
            this.loaiGiamGiaBindingSource.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // quanLiBanHangQuaMang1DataSet
            // 
            this.quanLiBanHangQuaMang1DataSet.DataSetName = "QuanLiBanHangQuaMang1DataSet";
            this.quanLiBanHangQuaMang1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiGiamGiaTableAdapter
            // 
            this.loaiGiamGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CacLoaiPhiTableAdapter = null;
            this.tableAdapterManager.DonHangTableAdapter = null;
            this.tableAdapterManager.GiamGiaTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoHangTableAdapter = null;
            this.tableAdapterManager.LoaiGiamGiaTableAdapter = this.loaiGiamGiaTableAdapter;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.LoaiShipTableAdapter = null;
            this.tableAdapterManager.LoiNhuanTableAdapter = null;
            this.tableAdapterManager.MaTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
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
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(100, 183);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(126, 20);
            this.txtTen.TabIndex = 4;
            // 
            // txtGiam
            // 
            this.txtGiam.Location = new System.Drawing.Point(100, 212);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(126, 20);
            this.txtGiam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Giảm Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Giảm Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giảm";
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.Location = new System.Drawing.Point(100, 156);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(126, 20);
            this.txtMaGiamGia.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 433);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(373, 25);
            this.toolStrip1.TabIndex = 12;
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
            // FrmDSLoaiGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 458);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiam);
            this.Controls.Add(this.txtMaGiamGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dgvLoaiGiamGia);
            this.Controls.Add(this.ribbonControl2);
            this.Name = "FrmDSLoaiGiamGia";
            this.Text = "FrmDSLoaiGiamGia";
            this.Load += new System.EventHandler(this.FrmDSLoaiGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiGiamGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvLoaiGiamGia;
        private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        private System.Windows.Forms.BindingSource loaiGiamGiaBindingSource;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.LoaiGiamGiaTableAdapter loaiGiamGiaTableAdapter;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}