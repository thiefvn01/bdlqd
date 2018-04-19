namespace boiduongLeQuyDon.GUI
{
    partial class Login
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
            this.txtUname = new DevExpress.XtraEditors.TextEdit();
            this.txtPasswd = new DevExpress.XtraEditors.TextEdit();
            this.bntLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(144, 45);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(100, 20);
            this.txtUname.TabIndex = 0;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(146, 87);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Properties.UseSystemPasswordChar = true;
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 1;
            // 
            // bntLogin
            // 
            this.bntLogin.Location = new System.Drawing.Point(102, 128);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(75, 23);
            this.bntLogin.TabIndex = 2;
            this.bntLogin.Text = "Đăng nhập";
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(69, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(71, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(232, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 18);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "ĐÓNG";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.bntLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 171);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bntLogin);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUname);
            this.Name = "Login";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUname;
        private DevExpress.XtraEditors.TextEdit txtPasswd;
        private DevExpress.XtraEditors.SimpleButton bntLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;

    }
}
