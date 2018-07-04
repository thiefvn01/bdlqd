using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using boiduongLeQuyDon.BUS;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.GUI
{
    public partial class changPass : SplashScreen
    {
        BUSgiaoVien bus = new BUSgiaoVien();
        bdlqdDataSet1TableAdapters.QueriesTableAdapter qu = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
    //    coSoBoiDuongDataSetTableAdapters.nhanVienTableAdapter da = new coSoBoiDuongDataSetTableAdapters.nhanVienTableAdapter();
        public changPass(string uname)
        {
            InitializeComponent();
            this.uname = uname;
            SqlConnection scon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["boiduongLeQuyDon.Properties.Settings.bdlqdConnectionString1"].ConnectionString);
            
        }
        string uname;
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtpasscu.Text != bus.login(uname).Tables[0].Rows[0][0].ToString())
                lblbao.Visible = true;
            else  if (pw1.Text == pw2.Text)
            {
                if(bus.updatepass(pw1.Text, uname)==1)
                MessageBox.Show("Cập nhật thành công");
           
            else
            
                MessageBox.Show("Mật khẩu nhập lại chưa chính xác, vui lòng kiểm tra lại");
            }
        }

        private void changPass_Load(object sender, EventArgs e)
        {

        }
    }
}