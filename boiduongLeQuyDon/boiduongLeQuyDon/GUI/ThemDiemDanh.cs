using System;
using DevExpress.XtraSplashScreen;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraEditors;

namespace boiduongLeQuyDon.GUI
{
    public partial class ThemDiemDanh : SplashScreen
    {
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSHocVien hv = new BUSHocVien();
        public ThemDiemDanh()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
     //       foreach (var item in lkPhep.Properties.Items.GetCheckedValues())
        //    {
                // MessageBox.Show(item.ToString());
                try
                {
                    bus.insertp(lkPhep.EditValue.ToString(), dtNgay.EditValue.ToString(), lkLop.EditValue.ToString(), txtGhichu.Text);
                  //  load();

                }
                catch
                {
            //        XtraMessageBox.Show("Có lỗi xảy ra");
                }
           // }
       //     foreach (var item in lkKhong.Properties.Items.GetCheckedValues())
       //     {
                // MessageBox.Show(item.ToString());
                try
                {
                    bus.insertk(lkKhong.EditValue.ToString(), dtNgay.EditValue.ToString(), lkLop.EditValue.ToString(), txtGhichu.Text);
                    //  load();

                }
                catch
                {
           //s         XtraMessageBox.Show("Có lỗi xảy ra");
                }
         //   }
        }

        private void ThemDiemDanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdlqdDataSet1.getKhoaHoc' table. You can move, or remove it, as needed.
            this.getKhoaHocTableAdapter.Fill(this.bdlqdDataSet1.getKhoaHoc);
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
        }

        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void lkLop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lkPhep.Properties.DataSource = hv.getdiemdanh(lkLop.EditValue.ToString()).Tables[0];
                lkPhep.Properties.DisplayMember = "Họ tên";
                lkPhep.Properties.ValueMember = "ID";
                lkKhong.Properties.DataSource = hv.getdiemdanh(lkLop.EditValue.ToString()).Tables[0];
                lkKhong.Properties.DisplayMember = "Họ tên";
                lkKhong.Properties.ValueMember = "ID";
                ckTre.Properties.DataSource = hv.getdiemdanh(lkLop.EditValue.ToString()).Tables[0];
                ckTre.Properties.DisplayMember = "Họ tên";
                ckTre.Properties.ValueMember = "ID";
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           // foreach (var item in ckTre.Properties.Items.GetCheckedValues())
         //   {
                // MessageBox.Show(item.ToString());
                try
                {
                    bus.inserttre(ckTre.EditValue.ToString(), dtNgay.EditValue.ToString(),txtTre.Text, lkLop.EditValue.ToString(), txtGhichu.Text);
                    //  load();
                }
                catch
                {
                    XtraMessageBox.Show("Có lỗi xảy ra");
                }
          //  }
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}