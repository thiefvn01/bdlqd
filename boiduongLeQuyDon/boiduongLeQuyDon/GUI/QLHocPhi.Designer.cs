namespace boiduongLeQuyDon.GUI
{
    partial class QLHocPhi
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
            this.components = new System.ComponentModel.Container();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.getLopHienTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdlqdDataSet1 = new boiduongLeQuyDon.bdlqdDataSet1();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDlớp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHọcsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọtên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLớp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBiênlai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrạngthái = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichú = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọcphíphảiđóng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọcphíđãđóng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọcphícònlại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.getLop5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.cbTrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.lblLC = new DevExpress.XtraEditors.LabelControl();
            this.lblHV = new DevExpress.XtraEditors.LabelControl();
            this.lblLopGoc = new DevExpress.XtraEditors.LabelControl();
            this.txtusbl = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txtupGC = new DevExpress.XtraEditors.TextEdit();
            this.bntXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bntUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.upTKB = new DevExpress.XtraEditors.LookUpEdit();
            this.getKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.upLop = new DevExpress.XtraEditors.LookUpEdit();
            this.getKhoaHocTableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter();
            this.getLop5TableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getLop5TableAdapter();
            this.getLopHienTaiTableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getLopHienTaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLopHienTaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLop5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusbl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupGC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTKB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.getLopHienTaiBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(932, 248);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // getLopHienTaiBindingSource
            // 
            this.getLopHienTaiBindingSource.DataMember = "getLopHienTai";
            this.getLopHienTaiBindingSource.DataSource = this.bdlqdDataSet1;
            // 
            // bdlqdDataSet1
            // 
            this.bdlqdDataSet1.DataSetName = "bdlqdDataSet1";
            this.bdlqdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDlớp,
            this.colIDHọcsinh,
            this.colHọtên,
            this.colLớp,
            this.colBiênlai,
            this.colTrạngthái,
            this.colGhichú,
            this.colHọcphíphảiđóng,
            this.colHọcphíđãđóng,
            this.colHọcphícònlại});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsFind.FindFilterColumns = "Họ tên lót";
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            // 
            // colIDlớp
            // 
            this.colIDlớp.FieldName = "ID lớp";
            this.colIDlớp.Name = "colIDlớp";
            this.colIDlớp.Visible = true;
            this.colIDlớp.VisibleIndex = 0;
            this.colIDlớp.Width = 86;
            // 
            // colIDHọcsinh
            // 
            this.colIDHọcsinh.FieldName = "ID Học sinh";
            this.colIDHọcsinh.Name = "colIDHọcsinh";
            this.colIDHọcsinh.Visible = true;
            this.colIDHọcsinh.VisibleIndex = 1;
            this.colIDHọcsinh.Width = 86;
            // 
            // colHọtên
            // 
            this.colHọtên.FieldName = "Họ tên";
            this.colHọtên.Name = "colHọtên";
            this.colHọtên.Visible = true;
            this.colHọtên.VisibleIndex = 2;
            this.colHọtên.Width = 86;
            // 
            // colLớp
            // 
            this.colLớp.FieldName = "Lớp";
            this.colLớp.Name = "colLớp";
            this.colLớp.Visible = true;
            this.colLớp.VisibleIndex = 3;
            this.colLớp.Width = 86;
            // 
            // colBiênlai
            // 
            this.colBiênlai.FieldName = "Biên lai";
            this.colBiênlai.Name = "colBiênlai";
            this.colBiênlai.Visible = true;
            this.colBiênlai.VisibleIndex = 4;
            this.colBiênlai.Width = 86;
            // 
            // colTrạngthái
            // 
            this.colTrạngthái.FieldName = "Trạng thái";
            this.colTrạngthái.Name = "colTrạngthái";
            this.colTrạngthái.Visible = true;
            this.colTrạngthái.VisibleIndex = 5;
            this.colTrạngthái.Width = 86;
            // 
            // colGhichú
            // 
            this.colGhichú.FieldName = "Ghi chú";
            this.colGhichú.Name = "colGhichú";
            this.colGhichú.Visible = true;
            this.colGhichú.VisibleIndex = 6;
            this.colGhichú.Width = 86;
            // 
            // colHọcphíphảiđóng
            // 
            this.colHọcphíphảiđóng.FieldName = "Học phí phải đóng";
            this.colHọcphíphảiđóng.Name = "colHọcphíphảiđóng";
            this.colHọcphíphảiđóng.Visible = true;
            this.colHọcphíphảiđóng.VisibleIndex = 7;
            this.colHọcphíphảiđóng.Width = 86;
            // 
            // colHọcphíđãđóng
            // 
            this.colHọcphíđãđóng.FieldName = "Học phí đã đóng";
            this.colHọcphíđãđóng.Name = "colHọcphíđãđóng";
            this.colHọcphíđãđóng.Visible = true;
            this.colHọcphíđãđóng.VisibleIndex = 8;
            this.colHọcphíđãđóng.Width = 86;
            // 
            // colHọcphícònlại
            // 
            this.colHọcphícònlại.FieldName = "Học phí còn lại";
            this.colHọcphícònlại.Name = "colHọcphícònlại";
            this.colHọcphícònlại.Visible = true;
            this.colHọcphícònlại.VisibleIndex = 9;
            this.colHọcphícònlại.Width = 89;
            // 
            // getLop5BindingSource
            // 
            this.getLop5BindingSource.DataMember = "getLop5";
            this.getLop5BindingSource.DataSource = this.bdlqdDataSet1;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl4.AutoSize = true;
            this.groupControl4.Controls.Add(this.cbTrangThai);
            this.groupControl4.Controls.Add(this.checkEdit1);
            this.groupControl4.Controls.Add(this.lblLC);
            this.groupControl4.Controls.Add(this.lblHV);
            this.groupControl4.Controls.Add(this.lblLopGoc);
            this.groupControl4.Controls.Add(this.txtusbl);
            this.groupControl4.Controls.Add(this.lblID);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.textEdit2);
            this.groupControl4.Controls.Add(this.txtupGC);
            this.groupControl4.Controls.Add(this.bntXoa);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Controls.Add(this.bntUpdate);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.upTKB);
            this.groupControl4.Controls.Add(this.upLop);
            this.groupControl4.Location = new System.Drawing.Point(17, 255);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(915, 236);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Cập nhật";
 //           this.groupControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl4_Paint);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Location = new System.Drawing.Point(706, 78);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTrangThai.Properties.Items.AddRange(new object[] {
            "Bình thường",
            "Chuyển lớp",
            "Nghỉ học",
            "Nghỉ tất cả cả lớp"});
            this.cbTrangThai.Size = new System.Drawing.Size(100, 20);
            this.cbTrangThai.TabIndex = 19;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(5, 42);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 18;
            this.checkEdit1.CheckStateChanged += new System.EventHandler(this.checkEdit1_CheckStateChanged);
            // 
            // lblLC
            // 
            this.lblLC.Location = new System.Drawing.Point(39, 23);
            this.lblLC.Name = "lblLC";
            this.lblLC.Size = new System.Drawing.Size(24, 13);
            this.lblLC.TabIndex = 17;
            this.lblLC.Text = "hana";
            this.lblLC.Visible = false;
            // 
            // lblHV
            // 
            this.lblHV.Location = new System.Drawing.Point(69, 21);
            this.lblHV.Name = "lblHV";
            this.lblHV.Size = new System.Drawing.Size(18, 13);
            this.lblHV.TabIndex = 16;
            this.lblHV.Text = "hân";
            this.lblHV.Visible = false;
            // 
            // lblLopGoc
            // 
            this.lblLopGoc.Location = new System.Drawing.Point(93, 18);
            this.lblLopGoc.Name = "lblLopGoc";
            this.lblLopGoc.Size = new System.Drawing.Size(24, 13);
            this.lblLopGoc.TabIndex = 15;
            this.lblLopGoc.Text = "hana";
            this.lblLopGoc.Visible = false;
            // 
            // txtusbl
            // 
            this.txtusbl.Location = new System.Drawing.Point(415, 120);
            this.txtusbl.Name = "txtusbl";
            this.txtusbl.Size = new System.Drawing.Size(100, 20);
            this.txtusbl.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(9, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "hana";
            this.lblID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số biên lai";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(708, 120);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 9;
            // 
            // txtupGC
            // 
            this.txtupGC.Location = new System.Drawing.Point(415, 74);
            this.txtupGC.Name = "txtupGC";
            this.txtupGC.Size = new System.Drawing.Size(100, 20);
            this.txtupGC.TabIndex = 9;
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(415, 180);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 11;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(651, 127);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Số tiền";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(651, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Trạng thái";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(363, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Ghi chú";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(298, 180);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntUpdate.TabIndex = 10;
            this.bntUpdate.Text = "Cập nhật";
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Thời khóa biểu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Lớp";
            // 
            // upTKB
            // 
            this.upTKB.Location = new System.Drawing.Point(114, 74);
            this.upTKB.Name = "upTKB";
            this.upTKB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.upTKB.Properties.DataSource = this.getKhoaHocBindingSource;
            this.upTKB.Properties.DisplayMember = "TenTKB";
            this.upTKB.Properties.DropDownRows = 15;
            this.upTKB.Properties.NullText = "";
            this.upTKB.Properties.ValueMember = "id";
            this.upTKB.Size = new System.Drawing.Size(100, 20);
            this.upTKB.TabIndex = 7;
            this.upTKB.EditValueChanged += new System.EventHandler(this.upTKB_EditValueChanged);
            // 
            // getKhoaHocBindingSource
            // 
            this.getKhoaHocBindingSource.DataMember = "getKhoaHoc";
            this.getKhoaHocBindingSource.DataSource = this.bdlqdDataSet1;
            // 
            // upLop
            // 
            this.upLop.Location = new System.Drawing.Point(114, 120);
            this.upLop.Name = "upLop";
            this.upLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.upLop.Properties.DropDownRows = 15;
            this.upLop.Properties.NullText = "";
            this.upLop.Size = new System.Drawing.Size(100, 20);
            this.upLop.TabIndex = 8;
            this.upLop.EditValueChanged += new System.EventHandler(this.upLop_EditValueChanged);
            // 
            // getKhoaHocTableAdapter
            // 
            this.getKhoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // getLop5TableAdapter
            // 
            this.getLop5TableAdapter.ClearBeforeFill = true;
            // 
            // getLopHienTaiTableAdapter
            // 
            this.getLopHienTaiTableAdapter.ClearBeforeFill = true;
            // 
            // QLHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.gridControl2);
            this.Name = "QLHocPhi";
            this.Size = new System.Drawing.Size(935, 494);
            this.Load += new System.EventHandler(this.QLHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLopHienTaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLop5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusbl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupGC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTKB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbTrangThai;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl lblLC;
        private DevExpress.XtraEditors.LabelControl lblHV;
        private DevExpress.XtraEditors.LabelControl lblLopGoc;
        private DevExpress.XtraEditors.TextEdit txtusbl;
        private DevExpress.XtraEditors.LabelControl lblID;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtupGC;
        private DevExpress.XtraEditors.SimpleButton bntXoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton bntUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit upTKB;
        private DevExpress.XtraEditors.LookUpEdit upLop;
        private System.Windows.Forms.BindingSource getKhoaHocBindingSource;
        private bdlqdDataSet1 bdlqdDataSet1;
        private bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter getKhoaHocTableAdapter;
        private System.Windows.Forms.BindingSource getLop5BindingSource;
        private bdlqdDataSet1TableAdapters.getLop5TableAdapter getLop5TableAdapter;
        private System.Windows.Forms.BindingSource getLopHienTaiBindingSource;
        private bdlqdDataSet1TableAdapters.getLopHienTaiTableAdapter getLopHienTaiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDlớp;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHọcsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colHọtên;
        private DevExpress.XtraGrid.Columns.GridColumn colLớp;
        private DevExpress.XtraGrid.Columns.GridColumn colBiênlai;
        private DevExpress.XtraGrid.Columns.GridColumn colTrạngthái;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichú;
        private DevExpress.XtraGrid.Columns.GridColumn colHọcphíphảiđóng;
        private DevExpress.XtraGrid.Columns.GridColumn colHọcphíđãđóng;
        private DevExpress.XtraGrid.Columns.GridColumn colHọcphícònlại;
    }
}
