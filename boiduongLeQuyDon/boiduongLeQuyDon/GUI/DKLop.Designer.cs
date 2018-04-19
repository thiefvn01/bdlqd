namespace boiduongLeQuyDon.GUI
{
    partial class DKLop
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtsbl = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtadGC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.idHV = new DevExpress.XtraEditors.LabelControl();
            this.idLop = new DevExpress.XtraEditors.LabelControl();
            this.bntDK = new DevExpress.XtraEditors.SimpleButton();
            this.dkTKB = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLop = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.dtngay = new DevExpress.XtraEditors.DateEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.lblLC = new DevExpress.XtraEditors.LabelControl();
            this.lblHV = new DevExpress.XtraEditors.LabelControl();
            this.lblLopGoc = new DevExpress.XtraEditors.LabelControl();
            this.txtusbl = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txtupGC = new DevExpress.XtraEditors.TextEdit();
            this.bntXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bntUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.upTKB = new DevExpress.XtraEditors.LookUpEdit();
            this.upLop = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsbl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadGC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkTKB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusbl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupGC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTKB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(991, 507);
            this.groupControl2.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(987, 484);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.FindFilterColumns = "Họ tên lót";
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Thời khóa biểu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Lớp";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtsbl);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.txtadGC);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.idHV);
            this.groupControl3.Controls.Add(this.idLop);
            this.groupControl3.Controls.Add(this.bntDK);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.dkTKB);
            this.groupControl3.Controls.Add(this.lkLop);
            this.groupControl3.Controls.Add(this.dtngay);
            this.groupControl3.Location = new System.Drawing.Point(12, 526);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(384, 167);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Đăng ký";
            // 
            // txtsbl
            // 
            this.txtsbl.Location = new System.Drawing.Point(260, 56);
            this.txtsbl.Name = "txtsbl";
            this.txtsbl.Size = new System.Drawing.Size(100, 20);
            this.txtsbl.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số biên lai";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(239, 125);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Đóng";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtadGC
            // 
            this.txtadGC.Location = new System.Drawing.Point(260, 28);
            this.txtadGC.Name = "txtadGC";
            this.txtadGC.Size = new System.Drawing.Size(100, 20);
            this.txtadGC.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(210, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ghi chú";
            // 
            // idHV
            // 
            this.idHV.Location = new System.Drawing.Point(5, 149);
            this.idHV.Name = "idHV";
            this.idHV.Size = new System.Drawing.Size(24, 13);
            this.idHV.TabIndex = 8;
            this.idHV.Text = "hana";
            this.idHV.Visible = false;
            // 
            // idLop
            // 
            this.idLop.Location = new System.Drawing.Point(5, 114);
            this.idLop.Name = "idLop";
            this.idLop.Size = new System.Drawing.Size(24, 13);
            this.idLop.TabIndex = 9;
            this.idLop.Text = "hana";
            this.idLop.Visible = false;
            // 
            // bntDK
            // 
            this.bntDK.Location = new System.Drawing.Point(141, 125);
            this.bntDK.Name = "bntDK";
            this.bntDK.Size = new System.Drawing.Size(75, 23);
            this.bntDK.TabIndex = 5;
            this.bntDK.Text = "Đăng ký";
            this.bntDK.Click += new System.EventHandler(this.bntDK_Click);
            // 
            // dkTKB
            // 
            this.dkTKB.Location = new System.Drawing.Point(90, 32);
            this.dkTKB.Name = "dkTKB";
            this.dkTKB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dkTKB.Properties.DropDownRows = 15;
            this.dkTKB.Properties.NullText = "";
            this.dkTKB.Size = new System.Drawing.Size(100, 20);
            this.dkTKB.TabIndex = 2;
            this.dkTKB.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // lkLop
            // 
            this.lkLop.Location = new System.Drawing.Point(90, 58);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.AllowMultiSelect = true;
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.DropDownRows = 15;
            this.lkLop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 3;
            // 
            // dtngay
            // 
            this.dtngay.EditValue = null;
            this.dtngay.Location = new System.Drawing.Point(90, 84);
            this.dtngay.Name = "dtngay";
            this.dtngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Properties.Mask.EditMask = "";
            this.dtngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtngay.Size = new System.Drawing.Size(100, 20);
            this.dtngay.TabIndex = 3;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.checkEdit1);
            this.groupControl4.Controls.Add(this.lblLC);
            this.groupControl4.Controls.Add(this.lblHV);
            this.groupControl4.Controls.Add(this.lblLopGoc);
            this.groupControl4.Controls.Add(this.txtusbl);
            this.groupControl4.Controls.Add(this.lblID);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.txtupGC);
            this.groupControl4.Controls.Add(this.bntXoa);
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Controls.Add(this.bntUpdate);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.upTKB);
            this.groupControl4.Controls.Add(this.upLop);
            this.groupControl4.Location = new System.Drawing.Point(407, 526);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(596, 167);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Cập nhật";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(469, 24);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 18;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // lblLC
            // 
            this.lblLC.Location = new System.Drawing.Point(427, 97);
            this.lblLC.Name = "lblLC";
            this.lblLC.Size = new System.Drawing.Size(24, 13);
            this.lblLC.TabIndex = 17;
            this.lblLC.Text = "hana";
            this.lblLC.Visible = false;
            // 
            // lblHV
            // 
            this.lblHV.Location = new System.Drawing.Point(427, 123);
            this.lblHV.Name = "lblHV";
            this.lblHV.Size = new System.Drawing.Size(18, 13);
            this.lblHV.TabIndex = 16;
            this.lblHV.Text = "hân";
            this.lblHV.Visible = false;
            // 
            // lblLopGoc
            // 
            this.lblLopGoc.Location = new System.Drawing.Point(427, 68);
            this.lblLopGoc.Name = "lblLopGoc";
            this.lblLopGoc.Size = new System.Drawing.Size(24, 13);
            this.lblLopGoc.TabIndex = 15;
            this.lblLopGoc.Text = "hana";
            this.lblLopGoc.Visible = false;
            // 
            // txtusbl
            // 
            this.txtusbl.Location = new System.Drawing.Point(272, 75);
            this.txtusbl.Name = "txtusbl";
            this.txtusbl.Size = new System.Drawing.Size(100, 20);
            this.txtusbl.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(352, 114);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "hana";
            this.lblID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số biên lai";
            // 
            // txtupGC
            // 
            this.txtupGC.Location = new System.Drawing.Point(272, 34);
            this.txtupGC.Name = "txtupGC";
            this.txtupGC.Size = new System.Drawing.Size(100, 20);
            this.txtupGC.TabIndex = 9;
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(203, 123);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 11;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(203, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Ghi chú";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(91, 123);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntUpdate.TabIndex = 10;
            this.bntUpdate.Text = "Cập nhật";
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Thời khóa biểu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Lớp";
            // 
            // upTKB
            // 
            this.upTKB.Location = new System.Drawing.Point(91, 34);
            this.upTKB.Name = "upTKB";
            this.upTKB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.upTKB.Properties.DropDownRows = 15;
            this.upTKB.Properties.NullText = "";
            this.upTKB.Size = new System.Drawing.Size(100, 20);
            this.upTKB.TabIndex = 7;
            this.upTKB.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // upLop
            // 
            this.upLop.Location = new System.Drawing.Point(91, 77);
            this.upLop.Name = "upLop";
            this.upLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.upLop.Properties.DropDownRows = 15;
            this.upLop.Properties.NullText = "";
            this.upLop.Size = new System.Drawing.Size(100, 20);
            this.upLop.TabIndex = 8;
            this.upLop.EditValueChanged += new System.EventHandler(this.upLop_EditValueChanged);
            // 
            // DKLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 715);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "DKLop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DKLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsbl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadGC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkTKB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusbl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupGC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTKB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLop.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton bntDK;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton bntXoa;
        private DevExpress.XtraEditors.SimpleButton bntUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl idHV;
        private DevExpress.XtraEditors.LabelControl idLop;
        private DevExpress.XtraEditors.LookUpEdit dkTKB;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lkLop;
        private DevExpress.XtraEditors.LookUpEdit upTKB;
        private DevExpress.XtraEditors.LookUpEdit upLop;
        private DevExpress.XtraEditors.TextEdit txtadGC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtupGC;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtsbl;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtusbl;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl lblLC;
        private DevExpress.XtraEditors.LabelControl lblHV;
        private DevExpress.XtraEditors.LabelControl lblLopGoc;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtngay;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;

    }
}
