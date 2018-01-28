namespace QuanLyBanHangQuaMang
{
    partial class FrmTongGiamGia
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDenGiamGia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 148);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(377, 149);
            this.dataGridView2.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDenGiamGia});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(401, 141);
            // 
            // btnDenGiamGia
            // 
            this.btnDenGiamGia.Caption = "Đến DS Hàng Giảm Giá";
            this.btnDenGiamGia.Id = 1;
            this.btnDenGiamGia.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._4;
            this.btnDenGiamGia.Name = "btnDenGiamGia";
            this.btnDenGiamGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDenGiamGia_ItemClick_1);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDenGiamGia);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 305);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(401, 25);
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
            // FrmTongGiamGia
            // 
            this.ClientSize = new System.Drawing.Size(401, 330);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FrmTongGiamGia";
            this.Load += new System.EventHandler(this.FrmTongGiamGia_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dataGridView1;
        //private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        //private DevExpress.XtraBars.BarButtonItem btnDenGiamGia;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        //private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        //private System.Windows.Forms.BindingSource tongGiamGiaBindingSource;
        //private QuanLiBanHangQuaMang1DataSetTableAdapters.TongGiamGiaTableAdapter tongGiamGiaTableAdapter;
        //private QuanLiBanHangQuaMang1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        //private System.Windows.Forms.DataGridViewTextBoxColumn maDonHangDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tongGiamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDenGiamGia;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}