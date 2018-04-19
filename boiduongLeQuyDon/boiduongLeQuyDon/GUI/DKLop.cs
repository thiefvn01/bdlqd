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
            upTKB.Properties.DataSource = tkb.gettt().Tables[0];
            upTKB.Properties.DisplayMember = "Tên TKB";
            upTKB.Properties.ValueMember = "ID";
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
                    lop.updatenew(ds3.Tables[0].Rows[0]["idLop"].ToString(), ds3.Tables[0].Rows[0]["idlop"].ToString());
                    
              //  }
                //catch
                //{
                    
                //    XtraMessageBox.Show("Có lỗi xảy ra");
                //}
            }
            load();

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            upLop.Properties.DataSource = ck.get(upTKB.EditValue.ToString()).Tables[0];
            upLop.Properties.DisplayMember = "Lớp";
            upLop.Properties.ValueMember = "ID";
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(dkTKB.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (change!="")
                try
                {
                    //   lop.update(upLop.EditValue.ToString(),txtupGC.Text,lblID.Text);
                    lop.insert(lblHV.Text, upLop.EditValue.ToString(), txtupGC.Text, txtusbl.Text, lblLC.Text, lblLopGoc.Text);
                    lop.updateold1(lblID.Text, "0");
                    lop.updateold("", "1");
                    load();

                }
                catch
                {
                    XtraMessageBox.Show("Có lỗi xảy ra");
                }
            else
            {
                try
                {
                    lop.update(txtusbl.Text, txtupGC.Text, lblID.Text);
                    
                }
                catch
                {
                }
                finally
                {
                    load();
                    change = "";
                }
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                lop.delete(lblID.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Chọn 1 dòng để xóa");
            }
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

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            change = "";
          //  upLop.EditValue = "-1";
          //  upTKB.EditValue = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "idLop").ToString();
         //   idLop.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Lớp").ToString();
            lblID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
            txtusbl.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SBL").ToString();
            DataSet ds1 = lop.getlg(lblID.Text);
            lblLC.Text = ds1.Tables[0].Rows[0]["idLop"].ToString();
            lblHV.Text = ds1.Tables[0].Rows[0]["idHocVien"].ToString();
            lblLopGoc.Text = ds1.Tables[0].Rows[0]["lopGoc"].ToString();
        }

        private void upLop_EditValueChanged(object sender, EventArgs e)
        {
            change = "1";
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                upTKB.Properties.DataSource = tkb.get(1).Tables[0];
                dkTKB.Properties.DataSource = tkb.get(1).Tables[0];
            }
            else
            {
                upTKB.Properties.DataSource = tkb.gettt().Tables[0];
                dkTKB.Properties.DataSource = tkb.gettt().Tables[0];
            }
        }
    }
}