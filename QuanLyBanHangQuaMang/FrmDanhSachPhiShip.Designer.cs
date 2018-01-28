namespace QuanLyBanHangQuaMang
{
    partial class FrmDanhSachPhiShip
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
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnluu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.phiShipSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.phiShipSPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phiShipSPBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaDonHang = new DevExpress.XtraEditors.TextEdit();
            this.dgvDSPS = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiShipSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiShipSPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiShipSPBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPS)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSua,
            this.btnluu,
            this.btnHuy});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(427, 141);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._31;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnluu
            // 
            this.btnluu.Caption = "Lưu";
            this.btnluu.Id = 2;
            this.btnluu.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._41;
            this.btnluu.Name = "btnluu";
            this.btnluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 3;
            this.btnHuy.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._21;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btnluu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHuy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // phiShipSPBindingSource
            // 
            this.phiShipSPBindingSource.DataMember = "PhiShipSP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(295, 159);
            this.txtDonGia.MenuManager = this.ribbonControl1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 5;
            // 
            // phiShipSPBindingSource1
            // 
            this.phiShipSPBindingSource1.DataMember = "PhiShipSP";
            // 
            // phiShipSPBindingSource2
            // 
            this.phiShipSPBindingSource2.DataMember = "PhiShipSP";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(100, 159);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaDonHang.TabIndex = 5;
            // 
            // dgvDSPS
            // 
            this.dgvDSPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPS.Location = new System.Drawing.Point(14, 203);
            this.dgvDSPS.Name = "dgvDSPS";
            this.dgvDSPS.Size = new System.Drawing.Size(381, 150);
            this.dgvDSPS.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 361);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(427, 25);
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
            // FrmDanhSachPhiShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 386);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDSPS);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmDanhSachPhiShip";
            this.Text = "FrmDanhSachPhiShip";
            this.Load += new System.EventHandler(this.FrmDanhSachPhiShip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiShipSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiShipSPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiShipSPBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPS)).EndInit();
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
        private System.Windows.Forms.BindingSource phiShipSPBindingSource;
        //private QuanLiBanHangQuaMang1DataSetTableAdapters.PhiShipSPTableAdapter phiShipSPTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn maDonHangDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tongTienShipDataGridViewTextBoxColumn;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnluu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private System.Windows.Forms.BindingSource phiShipSPBindingSource1;
        private System.Windows.Forms.BindingSource phiShipSPBindingSource2;
        private DevExpress.XtraEditors.TextEdit txtMaDonHang;
        private System.Windows.Forms.DataGridView dgvDSPS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}