namespace QuanLyBanHangQuaMang
{
    partial class FrmTinhTrangDon
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
            this.Sửa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tinhTrangDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbDaNhan = new DevExpress.XtraEditors.CheckEdit();
            this.cbBiHuy = new DevExpress.XtraEditors.CheckEdit();
            this.cbChuaNhan = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaDonHang = new System.Windows.Forms.ComboBox();
            this.tinhTrangDonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBanHangQuaMang1DataSet = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSet();
            this.tinhTrangDonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tinhTrangDonTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.TinhTrangDonTableAdapter();
            this.dgvTinhTrangDon = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBiHuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuaNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangDonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangDonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangDon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.Sửa,
            this.btnLuu,
            this.btnXoa,
            this.btnHuy,
            this.barButtonItem1,
            this.btnSua});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(379, 141);
            // 
            // Sửa
            // 
            this.Sửa.Caption = "Đã Nhận";
            this.Sửa.Id = 1;
            this.Sửa.Name = "Sửa";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._3;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Chưa Chuyển";
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._2;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đã Hủy ";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 6;
            this.btnSua.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._4;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHuy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // tinhTrangDonBindingSource
            // 
            this.tinhTrangDonBindingSource.DataMember = "TinhTrangDon";
            // 
            // cbDaNhan
            // 
            this.cbDaNhan.Location = new System.Drawing.Point(15, 42);
            this.cbDaNhan.MenuManager = this.ribbonControl1;
            this.cbDaNhan.Name = "cbDaNhan";
            this.cbDaNhan.Properties.Caption = "Đã Nhận";
            this.cbDaNhan.Size = new System.Drawing.Size(75, 19);
            this.cbDaNhan.TabIndex = 3;
            this.cbDaNhan.CheckedChanged += new System.EventHandler(this.cbDaNhan_CheckedChanged);
            // 
            // cbBiHuy
            // 
            this.cbBiHuy.Location = new System.Drawing.Point(127, 42);
            this.cbBiHuy.Name = "cbBiHuy";
            this.cbBiHuy.Properties.Caption = "Bị Hủy";
            this.cbBiHuy.Size = new System.Drawing.Size(75, 19);
            this.cbBiHuy.TabIndex = 3;
            this.cbBiHuy.CheckedChanged += new System.EventHandler(this.cbBiHuy_CheckedChanged);
            // 
            // cbChuaNhan
            // 
            this.cbChuaNhan.Location = new System.Drawing.Point(250, 42);
            this.cbChuaNhan.Name = "cbChuaNhan";
            this.cbChuaNhan.Properties.Caption = "Chưa Nhận";
            this.cbChuaNhan.Size = new System.Drawing.Size(75, 19);
            this.cbChuaNhan.TabIndex = 3;
            this.cbChuaNhan.CheckedChanged += new System.EventHandler(this.cbChuaNhan_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbDaNhan);
            this.groupControl1.Controls.Add(this.cbChuaNhan);
            this.groupControl1.Controls.Add(this.cbBiHuy);
            this.groupControl1.Location = new System.Drawing.Point(12, 216);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(353, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Tình Trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // cbMaDonHang
            // 
            this.cbMaDonHang.FormattingEnabled = true;
            this.cbMaDonHang.Location = new System.Drawing.Point(120, 166);
            this.cbMaDonHang.Name = "cbMaDonHang";
            this.cbMaDonHang.Size = new System.Drawing.Size(121, 21);
            this.cbMaDonHang.TabIndex = 5;
            this.cbMaDonHang.ValueMember = "MaDonHang";
            this.cbMaDonHang.SelectedIndexChanged += new System.EventHandler(this.cbMaDonHang_SelectedIndexChanged);
            // 
            // tinhTrangDonBindingSource2
            // 
            this.tinhTrangDonBindingSource2.DataMember = "TinhTrangDon";
            this.tinhTrangDonBindingSource2.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // quanLiBanHangQuaMang1DataSet
            // 
            this.quanLiBanHangQuaMang1DataSet.DataSetName = "QuanLiBanHangQuaMang1DataSet";
            this.quanLiBanHangQuaMang1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tinhTrangDonBindingSource1
            // 
            this.tinhTrangDonBindingSource1.DataMember = "TinhTrangDon";
            // 
            // tinhTrangDonTableAdapter
            // 
            this.tinhTrangDonTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTinhTrangDon
            // 
            this.dgvTinhTrangDon.AllowUserToAddRows = false;
            this.dgvTinhTrangDon.AllowUserToDeleteRows = false;
            this.dgvTinhTrangDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrangDon.Location = new System.Drawing.Point(12, 322);
            this.dgvTinhTrangDon.Name = "dgvTinhTrangDon";
            this.dgvTinhTrangDon.ReadOnly = true;
            this.dgvTinhTrangDon.Size = new System.Drawing.Size(353, 172);
            this.dgvTinhTrangDon.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 497);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 11;
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
            // FrmTinhTrangDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 522);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvTinhTrangDon);
            this.Controls.Add(this.cbMaDonHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmTinhTrangDon";
            this.Text = "FrmTinhTrangDon";
            this.Load += new System.EventHandler(this.FrmTinhTrangDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBiHuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuaNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangDonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangDonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangDon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        //private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        private System.Windows.Forms.BindingSource tinhTrangDonBindingSource;
        //private QuanLiBanHangQuaMang1DataSetTableAdapters.TinhTrangDonTableAdapter tinhTrangDonTableAdapter;
        private DevExpress.XtraBars.BarButtonItem Sửa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn maDonHangDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn daThanhToanDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ngayXacNhanDataGridViewTextBoxColumn;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraEditors.CheckEdit cbDaNhan;
        private DevExpress.XtraEditors.CheckEdit cbBiHuy;
        private DevExpress.XtraEditors.CheckEdit cbChuaNhan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaDonHang;
        private System.Windows.Forms.BindingSource tinhTrangDonBindingSource1;
        private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        private System.Windows.Forms.BindingSource tinhTrangDonBindingSource2;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.TinhTrangDonTableAdapter tinhTrangDonTableAdapter;
        private System.Windows.Forms.DataGridView dgvTinhTrangDon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}