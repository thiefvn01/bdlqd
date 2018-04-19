namespace boiduongLeQuyDon.GUI
{
    partial class soDauBai
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLop = new DevExpress.XtraEditors.LookUpEdit();
            this.dtNgay = new DevExpress.XtraEditors.DateEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.bntIN = new DevExpress.XtraEditors.SimpleButton();
            this.lblLop = new DevExpress.XtraEditors.LabelControl();
            this.bntBia = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtca3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtca2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtca1 = new DevExpress.XtraEditors.TextEdit();
            this.txtca4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Khóa";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(275, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Lớp";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(561, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ngày";
            // 
            // lkKhoa
            // 
            this.lkKhoa.Location = new System.Drawing.Point(110, 34);
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
            this.lkLop.Location = new System.Drawing.Point(399, 34);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.NullText = "";
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 2;
            this.lkLop.EditValueChanged += new System.EventHandler(this.lkLop_EditValueChanged);
            // 
            // dtNgay
            // 
            this.dtNgay.EditValue = null;
            this.dtNgay.Location = new System.Drawing.Point(649, 30);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.Mask.EditMask = "";
            this.dtNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtNgay.Size = new System.Drawing.Size(100, 20);
            this.dtNgay.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(22, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "Khóa";
            this.lblID.Visible = false;
            // 
            // bntIN
            // 
            this.bntIN.Location = new System.Drawing.Point(234, 283);
            this.bntIN.Name = "bntIN";
            this.bntIN.Size = new System.Drawing.Size(75, 23);
            this.bntIN.TabIndex = 12;
            this.bntIN.Text = "In sổ đầu bài";
            this.bntIN.Click += new System.EventHandler(this.bntIN_Click);
            // 
            // lblLop
            // 
            this.lblLop.Location = new System.Drawing.Point(275, 17);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(24, 13);
            this.lblLop.TabIndex = 18;
            this.lblLop.Text = "Khóa";
            this.lblLop.Visible = false;
            // 
            // bntBia
            // 
            this.bntBia.Location = new System.Drawing.Point(399, 283);
            this.bntBia.Name = "bntBia";
            this.bntBia.Size = new System.Drawing.Size(75, 23);
            this.bntBia.TabIndex = 13;
            this.bntBia.Text = "In bìa sổ";
            this.bntBia.Click += new System.EventHandler(this.bntBia_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(561, 84);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Ca ngày 3";
            // 
            // txtca3
            // 
            this.txtca3.Location = new System.Drawing.Point(649, 81);
            this.txtca3.Name = "txtca3";
            this.txtca3.Size = new System.Drawing.Size(100, 20);
            this.txtca3.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(275, 88);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Ca ngày 2";
            // 
            // txtca2
            // 
            this.txtca2.Location = new System.Drawing.Point(399, 81);
            this.txtca2.Name = "txtca2";
            this.txtca2.Size = new System.Drawing.Size(100, 20);
            this.txtca2.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(22, 84);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Ca ngày 1";
            // 
            // txtca1
            // 
            this.txtca1.Location = new System.Drawing.Point(110, 81);
            this.txtca1.Name = "txtca1";
            this.txtca1.Size = new System.Drawing.Size(100, 20);
            this.txtca1.TabIndex = 8;
            // 
            // txtca4
            // 
            this.txtca4.Location = new System.Drawing.Point(855, 81);
            this.txtca4.Name = "txtca4";
            this.txtca4.Size = new System.Drawing.Size(100, 20);
            this.txtca4.TabIndex = 11;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(767, 84);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(49, 13);
            this.labelControl14.TabIndex = 24;
            this.labelControl14.Text = "Ca ngày 4";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(81, 9);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 25;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // soDauBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtca4);
            this.Controls.Add(this.txtca3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtca2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtca1);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.bntBia);
            this.Controls.Add(this.bntIN);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lkKhoa);
            this.Controls.Add(this.lkLop);
            this.Controls.Add(this.dtNgay);
            this.Name = "soDauBai";
            this.Size = new System.Drawing.Size(981, 408);
            this.Load += new System.EventHandler(this.soDauBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtca4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkKhoa;
        private DevExpress.XtraEditors.LookUpEdit lkLop;
        private DevExpress.XtraEditors.DateEdit dtNgay;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.SimpleButton bntIN;
        private DevExpress.XtraEditors.LabelControl lblLop;
        private DevExpress.XtraEditors.SimpleButton bntBia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtca3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtca2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtca1;
        private DevExpress.XtraEditors.TextEdit txtca4;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
