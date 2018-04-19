using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace boiduongLeQuyDon.GUI
{
    public partial class ThemTKB : SplashScreen
    {
        BUSThoiKhoaBieu bus = new BUSThoiKhoaBieu();
        public ThemTKB()
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

        private void ThemTKB_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
            gridView1.PopulateColumns();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                bus.insert(txtTen.Text, txtLop.Text, txtNamHoc.Text, dtKhaiGiang.Text,dtKetthuc.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtKetthuc.Text == "")
                {
                    bus.update(txtTen.Text, txtLop.Text, txtNamHoc.Text, dtKhaiGiang.Text, lblID.Text);
                    load();
                }
                else
                {
                    bus.update(txtTen.Text, txtLop.Text, txtNamHoc.Text, dtKhaiGiang.Text, dtKetthuc.Text, lblID.Text);
                    load();
                }
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên TKB").ToString();
            txtLop.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Lớp").ToString();
            txtNamHoc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Năm học").ToString();
           // txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            dtKhaiGiang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Khai giảng").ToString();
        }
        private void load()
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
            gridView1.PopulateColumns();
            //  txtNgayKetThuc.Text = Convert.ToDateTime(txtNgayKetThuc.Text).ToShortDateString();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntIn_Click(object sender, EventArgs e)
        {
            GUI.Report.TKB tkb = new Report.TKB(Convert.ToInt32(lblID.Text),txtTen.Text,txtNamHoc.Text, Convert.ToDateTime(dtKhaiGiang.Text),txtGhiChu.Text,txtgc2.Text,txtgc3.Text,txtgc4.Text,dtNgay.Text);
            tkb.ShowPreview();
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }
    }
}