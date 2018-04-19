namespace boiduongLeQuyDon.GUI
{
    partial class dotKiemTra
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHeso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bntThem = new DevExpress.XtraEditors.SimpleButton();
            this.bntEdit = new DevExpress.XtraEditors.SimpleButton();
            this.bntDelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.dtngay = new DevExpress.XtraEditors.DateEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dbdang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.lkLop = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Location = new System.Drawing.Point(138, 367);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày";
            // 
            // txtDe
            // 
            this.txtDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDe.Location = new System.Drawing.Point(186, 414);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 20);
            this.txtDe.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Location = new System.Drawing.Point(138, 421);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mã đề";
            // 
            // txtHeso
            // 
            this.txtHeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHeso.Location = new System.Drawing.Point(364, 414);
            this.txtHeso.Name = "txtHeso";
            this.txtHeso.Size = new System.Drawing.Size(100, 20);
            this.txtHeso.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Location = new System.Drawing.Point(306, 417);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Hệ số";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(13, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(869, 336);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // bntThem
            // 
            this.bntThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntThem.Location = new System.Drawing.Point(268, 478);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 7;
            this.bntThem.Text = "Thêm";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntEdit.Location = new System.Drawing.Point(405, 478);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(75, 23);
            this.bntEdit.TabIndex = 8;
            this.bntEdit.Text = "Sửa";
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntDelete.Location = new System.Drawing.Point(547, 478);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 9;
            this.bntDelete.Text = "Xóa";
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Location = new System.Drawing.Point(306, 359);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Khóa";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl5.Location = new System.Drawing.Point(493, 367);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(17, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Lớp";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // lkKhoa
            // 
            this.lkKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkKhoa.Location = new System.Drawing.Point(361, 359);
            this.lkKhoa.Name = "lkKhoa";
            this.lkKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoa.Properties.DropDownRows = 15;
            this.lkKhoa.Properties.NullText = "";
            this.lkKhoa.Size = new System.Drawing.Size(100, 20);
            this.lkKhoa.TabIndex = 2;
            this.lkKhoa.EditValueChanged += new System.EventHandler(this.lkKhoa_EditValueChanged);
            // 
            // dtngay
            // 
            this.dtngay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtngay.EditValue = null;
            this.dtngay.Location = new System.Drawing.Point(186, 360);
            this.dtngay.Name = "dtngay";
            this.dtngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Properties.Mask.EditMask = "";
            this.dtngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtngay.Size = new System.Drawing.Size(100, 20);
            this.dtngay.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(136, 478);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 13);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "Hệ số";
            this.lblID.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl8.Location = new System.Drawing.Point(673, 366);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 34;
            this.labelControl8.Text = "Loại đề";
            // 
            // dbdang
            // 
            this.dbdang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dbdang.Location = new System.Drawing.Point(729, 363);
            this.dbdang.Name = "dbdang";
            this.dbdang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dbdang.Properties.Items.AddRange(new object[] {
            "Đề toán",
            "Đề cơ bản",
            "Đề 1 câu",
            "Đề hỗn hợp  Trắc nghiệm/Tự luận"});
            this.dbdang.Size = new System.Drawing.Size(100, 20);
            this.dbdang.TabIndex = 4;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(33, 342);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 36;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // lkLop
            // 
            this.lkLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkLop.Location = new System.Drawing.Point(547, 360);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.NullText = "";
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 3;
            this.lkLop.EditValueChanged += new System.EventHandler(this.lkLop_EditValueChanged);
            // 
            // dotKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lkKhoa);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntEdit);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtHeso);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.dbdang);
            this.Controls.Add(this.lkLop);
            this.Name = "dotKiemTra";
            this.Size = new System.Drawing.Size(885, 533);
            this.Load += new System.EventHandler(this.dotKiemTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHeso;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton bntThem;
        private DevExpress.XtraEditors.SimpleButton bntEdit;
        private DevExpress.XtraEditors.SimpleButton bntDelete;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lkKhoa;
        private DevExpress.XtraEditors.DateEdit dtngay;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit dbdang;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LookUpEdit lkLop;
    }
}
