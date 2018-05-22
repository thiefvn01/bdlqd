using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraEditors;

namespace boiduongLeQuyDon.GUI
{
    public partial class nguyenVong : SplashScreen
    {
        BUSNguyenVongHocVien bus=new BUSNguyenVongHocVien();
    //    BUSdmTruongHoc tr =new BUSdmTruongHoc();
        public nguyenVong(string id)
        {
            InitializeComponent();
            this.id = id;
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

        private void nguyenVong_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get(id).Tables[0];
         //   gridView1.PopulateColumns();
            //lkTruong.Properties.DataSource = tr.get().Tables[0];
            //lkTruong.Properties.DisplayMember = "Tên trường";
            //lkTruong.Properties.ValueMember = "ID";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bus.insert(id,lkTruong.Text,txtGhiChu.Text,txtMon.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                bus.update(lkTruong.Text,txtGhiChu.Text,txtMon.Text, lblID.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                bus.delete(lblID.Text);
                load();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lkTruong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Trường").ToString();
            txtMon.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Môn chuyên").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
        }
        private void load()
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get(id).Tables[0];
       //     gridView1.PopulateColumns();
            //  txtNgayKetThuc.Text = Convert.ToDateTime(txtNgayKetThuc.Text).ToShortDateString();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}