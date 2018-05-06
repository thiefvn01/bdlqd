using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraEditors;

namespace boiduongLeQuyDon.GUI
{
    public partial class DKLop : SplashScreen
    {
        BUSHocVien hv = new BUSHocVien();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSLop lop = new BUSLop();
        public DKLop(string id)
        {
            InitializeComponent();
            this.id=id;
        }
        string id;
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        string change = "";
        private void DKLop_Load(object sender, EventArgs e)
        {
            if (id == "-1")
            {
                bntDK.Enabled = false;
            }
         //   gridView1.OptionsBehavior.ReadOnly = true;
        //    gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsBehavior.Editable = false;
       //     gridControl1.RefreshDataSource();
       //     gridControl1.DataSource = hv.getTKB().Tables[0];
      //      gridView1.PopulateColumns();
            gridControl2.RefreshDataSource();
            gridControl2.DataSource = lop.get().Tables[0];
            gridView2.PopulateColumns();
            dkTKB.Properties.DataSource = tkb.gettt().Tables[0];
            dkTKB.Properties.DisplayMember = "Tên TKB";
            dkTKB.Properties.ValueMember = "ID";
            
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
            //upLop.Properties.DataSource = ck.get(1).Tables[0];
            //upLop.Properties.DisplayMember = "Lớp";
            //upLop.Properties.ValueMember = "ID";
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // idHV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
        }

        private void bntDK_Click(object sender, EventArgs e)
        {
            foreach (var item in lkLop.Properties.Items.GetCheckedValues())
            {
           //     MessageBox.Show(item.ToString());
                //try
                //{
                    lop.insert(id, item.ToString(), txtadGC.Text,txtsbl.Text, dtngay.Text);
                    DataSet ds3 = new DataSet();
                    ds3 = lop.getlg();
                    lop.updatenew(ds3.Tables[0].Rows[0]["idLop"].ToString(), ds3.Tables[0].Rows[0]["idlop"].ToString(),"Đang học");
                    
              //  }
                //catch
                //{
                    
                //    XtraMessageBox.Show("Có lỗi xảy ra");
                //}
            }
            load();

        }

      

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(dkTKB.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

       

        private void bntXoa_Click(object sender, EventArgs e)
        {
          
        }
        private void load()
        {
      //      this.Dock = DockStyle.Fill;
       //     gridControl1.RefreshDataSource();
      //      gridControl1.DataSource = hv.getTKB().Tables[0];
      //      gridView1.PopulateColumns();
            gridControl2.RefreshDataSource();
            gridControl2.DataSource = lop.get().Tables[0];
            gridView2.PopulateColumns(); 
      //      gridView1.PopulateColumns();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void upLop_EditValueChanged(object sender, EventArgs e)
        {
            change = "1";
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}