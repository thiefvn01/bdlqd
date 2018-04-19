namespace boiduongLeQuyDon.GUI
{
    partial class KiemTap
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
            this.coSoBoiDuongDataSet1 = new boiduongLeQuyDon.coSoBoiDuongDataSet();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgay = new DevExpress.XtraEditors.DateEdit();
            this.lkKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLop = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.txtGhichu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lkPhep = new DevExpress.XtraEditors.LookUpEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.coSoBoiDuongDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // coSoBoiDuongDataSet1
            // 
            this.coSoBoiDuongDataSet1.DataSetName = "coSoBoiDuongDataSet";
            this.coSoBoiDuongDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton3.Location = new System.Drawing.Point(481, 480);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "Sửa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Location = new System.Drawing.Point(600, 480);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Xóa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Location = new System.Drawing.Point(380, 480);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(944, 341);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Location = new System.Drawing.Point(368, 372);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Khóa";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Location = new System.Drawing.Point(601, 375);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Lớp";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Location = new System.Drawing.Point(132, 368);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Ngày";
            // 
            // dtNgay
            // 
            this.dtNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtNgay.EditValue = null;
            this.dtNgay.Location = new System.Drawing.Point(214, 365);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.Mask.EditMask = "";
            this.dtNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtNgay.Size = new System.Drawing.Size(100, 20);
            this.dtNgay.TabIndex = 23;
            // 
            // lkKhoa
            // 
            this.lkKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkKhoa.Location = new System.Drawing.Point(465, 368);
            this.lkKhoa.Name = "lkKhoa";
            this.lkKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoa.Properties.DropDownRows = 15;
            this.lkKhoa.Properties.NullText = "";
            this.lkKhoa.Size = new System.Drawing.Size(100, 20);
            this.lkKhoa.TabIndex = 24;
            this.lkKhoa.EditValueChanged += new System.EventHandler(this.lkKhoa_EditValueChanged);
            // 
            // lkLop
            // 
            this.lkLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkLop.Location = new System.Drawing.Point(695, 371);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.DropDownRows = 15;
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 25;
            this.lkLop.EditValueChanged += new System.EventHandler(this.lkLop_EditValueChanged);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGhichu.Location = new System.Drawing.Point(465, 419);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(100, 20);
            this.txtGhichu.TabIndex = 30;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Location = new System.Drawing.Point(132, 426);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Học viên";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl5.Location = new System.Drawing.Point(368, 426);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Chấm tập";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblID.Location = new System.Drawing.Point(629, 422);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "hana";
            this.lblID.Visible = false;
            // 
            // lkPhep
            // 
            this.lkPhep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkPhep.Location = new System.Drawing.Point(214, 419);
            this.lkPhep.Name = "lkPhep";
            this.lkPhep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhep.Properties.DropDownRows = 15;
            this.lkPhep.Properties.NullText = "";
            this.lkPhep.Size = new System.Drawing.Size(100, 20);
            this.lkPhep.TabIndex = 29;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(14, 362);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 34;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // KiemTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lkKhoa);
            this.Controls.Add(this.lkLop);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lkPhep);
            this.Name = "KiemTap";
            this.Size = new System.Drawing.Size(950, 515);
            this.Load += new System.EventHandler(this.KiemTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coSoBoiDuongDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private coSoBoiDuongDataSet coSoBoiDuongDataSet1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtNgay;
        private DevExpress.XtraEditors.LookUpEdit lkKhoa;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lkLop;
        private DevExpress.XtraEditors.TextEdit txtGhichu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LookUpEdit lkPhep;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
