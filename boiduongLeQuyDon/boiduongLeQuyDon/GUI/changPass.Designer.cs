namespace boiduongLeQuyDon.GUI
{
    partial class changPass
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pw1 = new DevExpress.XtraEditors.TextEdit();
            this.pw2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtpasscu = new DevExpress.XtraEditors.TextEdit();
            this.lblbao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pw1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pw2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasscu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mật khẩu mới";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhập lại mật khẩu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(177, 164);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Cập nhật";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Location = new System.Drawing.Point(375, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Đóng";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // pw1
            // 
            this.pw1.Location = new System.Drawing.Point(138, 74);
            this.pw1.Name = "pw1";
            this.pw1.Properties.UseSystemPasswordChar = true;
            this.pw1.Size = new System.Drawing.Size(173, 20);
            this.pw1.TabIndex = 1;
            // 
            // pw2
            // 
            this.pw2.Location = new System.Drawing.Point(138, 116);
            this.pw2.Name = "pw2";
            this.pw2.Properties.UseSystemPasswordChar = true;
            this.pw2.Size = new System.Drawing.Size(173, 20);
            this.pw2.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mật khẩu cũ";
            // 
            // txtpasscu
            // 
            this.txtpasscu.Location = new System.Drawing.Point(134, 38);
            this.txtpasscu.Name = "txtpasscu";
            this.txtpasscu.Properties.UseSystemPasswordChar = true;
            this.txtpasscu.Size = new System.Drawing.Size(173, 20);
            this.txtpasscu.TabIndex = 1;
            // 
            // lblbao
            // 
            this.lblbao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblbao.Location = new System.Drawing.Point(326, 41);
            this.lblbao.Name = "lblbao";
            this.lblbao.Size = new System.Drawing.Size(117, 13);
            this.lblbao.TabIndex = 0;
            this.lblbao.Text = "Mật khẩu cũ không đúng";
            this.lblbao.Visible = false;
            // 
            // changPass
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.pw2);
            this.Controls.Add(this.txtpasscu);
            this.Controls.Add(this.pw1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblbao);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Name = "changPass";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.changPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pw1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pw2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasscu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit pw1;
        private DevExpress.XtraEditors.TextEdit pw2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtpasscu;
        private DevExpress.XtraEditors.LabelControl lblbao;

    }
}
