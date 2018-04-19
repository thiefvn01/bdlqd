namespace boiduongLeQuyDon.GUI
{
    partial class diemDanh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bntThem = new DevExpress.XtraEditors.SimpleButton();
            this.lkKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLop = new DevExpress.XtraEditors.LookUpEdit();
            this.bntXoa = new DevExpress.XtraEditors.SimpleButton();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.dtngay = new DevExpress.XtraEditors.DateEdit();
            this.bntRf = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhichu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.bntExport = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 32);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(920, 302);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(619, 3);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 3;
            this.bntThem.Text = "Điểm danh";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // lkKhoa
            // 
            this.lkKhoa.Location = new System.Drawing.Point(233, 6);
            this.lkKhoa.Name = "lkKhoa";
            this.lkKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoa.Properties.NullText = "";
            this.lkKhoa.Size = new System.Drawing.Size(100, 20);
            this.lkKhoa.TabIndex = 1;
            this.lkKhoa.EditValueChanged += new System.EventHandler(this.lkKhoa_EditValueChanged);
            // 
            // lkLop
            // 
            this.lkLop.Location = new System.Drawing.Point(357, 6);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.NullText = "";
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 2;
            this.lkLop.EditValueChanged += new System.EventHandler(this.lkLop_EditValueChanged);
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(527, 385);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 4;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(210, 385);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "labelControl1";
            this.lblID.Visible = false;
            // 
            // dtngay
            // 
            this.dtngay.EditValue = null;
            this.dtngay.Location = new System.Drawing.Point(490, 6);
            this.dtngay.Name = "dtngay";
            this.dtngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Size = new System.Drawing.Size(100, 20);
            this.dtngay.TabIndex = 6;
            this.dtngay.EditValueChanged += new System.EventHandler(this.dtngay_EditValueChanged);
            // 
            // bntRf
            // 
            this.bntRf.Location = new System.Drawing.Point(700, 3);
            this.bntRf.Name = "bntRf";
            this.bntRf.Size = new System.Drawing.Size(75, 23);
            this.bntRf.TabIndex = 7;
            this.bntRf.Text = "Refresh";
            this.bntRf.Click += new System.EventHandler(this.bntRf_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(484, 345);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(100, 20);
            this.txtGhichu.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(210, 348);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Ghi chú";
            this.labelControl1.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(422, 385);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Sửa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // bntExport
            // 
            this.bntExport.Location = new System.Drawing.Point(781, 3);
            this.bntExport.Name = "bntExport";
            this.bntExport.Size = new System.Drawing.Size(75, 23);
            this.bntExport.TabIndex = 11;
            this.bntExport.Text = "Xuất Excel";
            this.bntExport.Click += new System.EventHandler(this.bntExport_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(12, 3);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 12;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(422, 348);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Ghi chú";
            // 
            // diemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.bntExport);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.bntRf);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lkKhoa);
            this.Controls.Add(this.lkLop);
            this.Name = "diemDanh";
            this.Size = new System.Drawing.Size(935, 494);
            this.Load += new System.EventHandler(this.diemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton bntThem;
        private DevExpress.XtraEditors.LookUpEdit lkKhoa;
        private DevExpress.XtraEditors.LookUpEdit lkLop;
        private DevExpress.XtraEditors.SimpleButton bntXoa;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.DateEdit dtngay;
        private DevExpress.XtraEditors.SimpleButton bntRf;
        private DevExpress.XtraEditors.TextEdit txtGhichu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton bntExport;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}
