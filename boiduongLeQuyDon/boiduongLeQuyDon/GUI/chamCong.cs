using System;
using System.Data;
using System.Windows.Forms;
namespace boiduongLeQuyDon.GUI
{
    public partial class chamCong : DevExpress.XtraEditors.XtraUserControl
    {
        public chamCong()
        {
            InitializeComponent();
        //    gridControl1.DataSource = cc.GetData();
        //    lkgv.Properties.DataSource = nv.GetDataBy();
        //    lkNV.Properties.DataSource = nv.GetDataBy();
        //  //  lkgv.Properties.ValueMember = "id";
        // //   lkgv.Properties.DisplayMember = "Tên";
        }
        //DateTime fro = Convert.ToDateTime("01/01/1990");
        //DateTime to1=Convert.ToDateTime("01/01/2020");
     //   coSoBoiDuongDataSetTableAdapters.chamcongTableAdapter cc = new coSoBoiDuongDataSetTableAdapters.chamcongTableAdapter();
   //     coSoBoiDuongDataSetTableAdapters.nhanVienTableAdapter nv = new coSoBoiDuongDataSetTableAdapters.nhanVienTableAdapter();
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
         //   lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
         //   txtday.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Dạy").ToString();       
         //   dtngay.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ngày").ToString();      
         //// txtchambai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Trợ giảng").ToString();     
         //   txtghichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();

        }

        private void bntadd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    cc.InsertQuery(Convert.ToInt32(lkgv.EditValue.ToString()),Convert.ToDateTime(dtngay.Text), txtghichu.Text,Convert.ToDecimal(txtday.EditValue.ToString()));
            //    gridControl1.DataSource = cc.GetData();
            //}
            //catch
            //{
            //}
        }

        private void bntedit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    cc.UpdateQuery(Convert.ToDateTime(dtngay.Text), txtghichu.Text, Convert.ToDecimal(txtday.EditValue.ToString()),Convert.ToInt32(lblID.Text));
            //    gridControl1.DataSource = cc.GetData();
            //}
            //catch
            //{
            //}
        }

        private void bntdel_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //    cc.DeleteQuery(Convert.ToInt32(lblID.Text));
            //    gridControl1.DataSource = cc.GetData();
            //}
            //catch
            //{
            //}
        }

        private void chamCong_Load(object sender, EventArgs e)
        {
            //     lkgv.Properties.DataSource = nv.GetDataBy();
            // //    lkgv.Properties.ValueMember = "id";
            ////    lkgv.Properties.DisplayMember = "Tên";
            //     gridView1.OptionsBehavior.ReadOnly = true;
            //     gridView1.OptionsBehavior.Editable = false;
            // }
        }
        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void dtFrom_EditValueChanged(object sender, EventArgs e)
        {
       //     this.fro = Convert.ToDateTime(dtFrom.Text);
       //     try
       //     {
       //         gridControl1.DataSource = cc.GetDataBy3(Convert.ToInt32(lkNV.EditValue.ToString()), this.fro, this.to1);
       //     }
       //     catch
       //     {
       //         try
       //         {
       //             gridControl1.DataSource = cc.GetDataBy5(this.fro, this.to1);
       //         }
       //         catch { }
       //     } try
       //     {
       //         dt = cc.GetDataBy4(Convert.ToInt32(lkNV.EditValue.ToString()), this.fro, this.to1);
       //     //    lblBu.Text = "Bù: " + dt.Rows[0]["Bù"].ToString();
       //  //      lblChamBai.Text = "Chấm bài: " + dt.Rows[0]["Chấm bài"].ToString();
       //   //      lblCoiThi.Text = "Coi thi: " + dt.Rows[0]["Coi thi"].ToString();
       //         lblDay.Text = "Dạy: " + dt.Rows[0]["Dạy"].ToString();
       //  //       lblPhuDao.Text = "Phụ đạo: " + dt.Rows[0]["Phụ đạo"].ToString();
       ////         lblTroGiang.Text = "Trợ giảng: " + dt.Rows[0]["Trợ giảng"].ToString();
       ////         lblTruc.Text = "Trực: " + dt.Rows[0]["Trực"].ToString();
       //     }
       //     catch
       //     {
       //     }
        }

        private void dtTo_EditValueChanged(object sender, EventArgs e)
        {
       //     try
       //     {
       //         this.to1 = Convert.ToDateTime(dtTo.Text);
       //         gridControl1.DataSource = cc.GetDataBy3(Convert.ToInt32(lkNV.EditValue.ToString()), this.fro, this.to1);
       //     }
       //     catch
       //     {
       //         try
       //         {
       //             gridControl1.DataSource = cc.GetDataBy5(this.fro, this.to1);
       //         }
       //         catch { }
       //     }
       //     try
       //     {
       //         dt = cc.GetDataBy4(Convert.ToInt32(lkNV.EditValue.ToString()), this.fro, this.to1);
       //    //     lblBu.Text = "Bù: " + dt.Rows[0]["Bù"].ToString();
       //   //      lblChamBai.Text = "Chấm bài: " + dt.Rows[0]["Chấm bài"].ToString();
       //   //      lblCoiThi.Text = "Coi thi: " + dt.Rows[0]["Coi thi"].ToString();
       //         lblDay.Text = "Dạy: " + dt.Rows[0]["Dạy"].ToString();
       //  //       lblPhuDao.Text = "Phụ đạo: " + dt.Rows[0]["Phụ đạo"].ToString();
       // //        lblTroGiang.Text = "Trợ giảng: " + dt.Rows[0]["Trợ giảng"].ToString();
       ////         lblTruc.Text = "Trực: " + dt.Rows[0]["Trực"].ToString();
       //     }
       //     catch
       //     {
       //     }

        }

        private void lkNV_EditValueChanged(object sender, EventArgs e)
        {
   //         gridControl1.DataSource = cc.GetDataBy3(Convert.ToInt32(lkNV.EditValue.ToString()), fro, to1);
   //         dt = cc.GetDataBy4(Convert.ToInt32(lkNV.EditValue.ToString()), fro, to1);
   //     //    lblBu.Text = "Bù: " + dt.Rows[0]["Bù"].ToString();
   //    //     lblChamBai.Text = "Chấm bài: " + dt.Rows[0]["Chấm bài"].ToString();
   //   //      lblCoiThi.Text = "Coi thi: " + dt.Rows[0]["Coi thi"].ToString();
   //         lblDay.Text = "Dạy: " + dt.Rows[0]["Dạy"].ToString();
   //  //       lblPhuDao.Text = "Phụ đạo: " + dt.Rows[0]["Phụ đạo"].ToString();
   // //        lblTroGiang.Text = "Trợ giảng: " + dt.Rows[0]["Trợ giảng"].ToString();
   ////         lblTruc.Text = "Trực: " + dt.Rows[0]["Trực"].ToString();
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        string path;
        private void bntExport_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.FileName = "";
            //saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    path = saveFileDialog1.FileName;
            //}
            
            //gridControl1.ExportToXlsx(path);
      
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtghichu_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
