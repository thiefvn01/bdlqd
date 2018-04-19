namespace boiduongLeQuyDon.GUI
{
    partial class ThemDiemDanh
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgay = new DevExpress.XtraEditors.DateEdit();
            this.lkKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.bntAdd = new DevExpress.XtraEditors.SimpleButton();
            this.bntClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTre = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhichu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkPhep = new DevExpress.XtraEditors.LookUpEdit();
            this.lkKhong = new DevExpress.XtraEditors.LookUpEdit();
            this.ckTre = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLop = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckTre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Có phép";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(495, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Lớp";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(262, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Khóa";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(262, 102);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Không phép";
            // 
            // dtNgay
            // 
            this.dtNgay.EditValue = null;
            this.dtNgay.Location = new System.Drawing.Point(108, 26);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.Mask.EditMask = "";
            this.dtNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtNgay.Size = new System.Drawing.Size(100, 20);
            this.dtNgay.TabIndex = 0;
            // 
            // lkKhoa
            // 
            this.lkKhoa.Location = new System.Drawing.Point(359, 29);
            this.lkKhoa.Name = "lkKhoa";
            this.lkKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoa.Properties.DropDownRows = 15;
            this.lkKhoa.Properties.NullText = "";
            this.lkKhoa.Size = new System.Drawing.Size(100, 20);
            this.lkKhoa.TabIndex = 1;
            this.lkKhoa.EditValueChanged += new System.EventHandler(this.lkKhoa_EditValueChanged);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(262, 175);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 8;
            this.bntAdd.Text = "Vắng";
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(506, 175);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 23);
            this.bntClose.TabIndex = 10;
            this.bntClose.Text = "Đóng";
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(495, 106);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(16, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Trễ";
            // 
            // txtTre
            // 
            this.txtTre.Location = new System.Drawing.Point(695, 103);
            this.txtTre.Name = "txtTre";
            this.txtTre.Size = new System.Drawing.Size(32, 20);
            this.txtTre.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(384, 175);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Trễ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Location = new System.Drawing.Point(702, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 18);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "ĐÓNG";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(108, 143);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(100, 20);
            this.txtGhichu.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 146);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Ghi chú";
            // 
            // lkPhep
            // 
            this.lkPhep.Location = new System.Drawing.Point(108, 103);
            this.lkPhep.Name = "lkPhep";
            this.lkPhep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhep.Properties.DropDownRows = 20;
            this.lkPhep.Properties.NullText = "";
            this.lkPhep.Size = new System.Drawing.Size(100, 20);
            this.lkPhep.TabIndex = 3;
            // 
            // lkKhong
            // 
            this.lkKhong.Location = new System.Drawing.Point(359, 99);
            this.lkKhong.Name = "lkKhong";
            this.lkKhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhong.Properties.DropDownRows = 20;
            this.lkKhong.Properties.NullText = "";
            this.lkKhong.Size = new System.Drawing.Size(100, 20);
            this.lkKhong.TabIndex = 4;
            // 
            // ckTre
            // 
            this.ckTre.Location = new System.Drawing.Point(589, 103);
            this.ckTre.Name = "ckTre";
            this.ckTre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ckTre.Properties.DropDownRows = 20;
            this.ckTre.Properties.NullText = "";
            this.ckTre.Size = new System.Drawing.Size(100, 20);
            this.ckTre.TabIndex = 5;
            // 
            // lkLop
            // 
            this.lkLop.Location = new System.Drawing.Point(589, 32);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.DropDownRows = 15;
            this.lkLop.Properties.NullText = "";
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 2;
            this.lkLop.EditValueChanged += new System.EventHandler(this.lkLop_EditValueChanged);
            // 
            // ThemDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 239);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lkKhoa);
            this.Controls.Add(this.txtTre);
            this.Controls.Add(this.lkPhep);
            this.Controls.Add(this.lkKhong);
            this.Controls.Add(this.ckTre);
            this.Controls.Add(this.lkLop);
            this.Name = "ThemDiemDanh";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ThemDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckTre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dtNgay;
        private DevExpress.XtraEditors.LookUpEdit lkKhoa;
        private DevExpress.XtraEditors.SimpleButton bntAdd;
        private DevExpress.XtraEditors.SimpleButton bntClose;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTre;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtGhichu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lkPhep;
        private DevExpress.XtraEditors.LookUpEdit lkKhong;
        private DevExpress.XtraEditors.LookUpEdit ckTre;
        private DevExpress.XtraEditors.LookUpEdit lkLop;

    }
}
