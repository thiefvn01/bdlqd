using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraReports.UI;

namespace boiduongLeQuyDon.GUI
{
    public partial class soDauBai : DevExpress.XtraEditors.XtraUserControl
    {
        BUSsoDauBai bus = new BUSsoDauBai();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        public soDauBai()
        {
            InitializeComponent();
        }

        private void soDauBai_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
          //  gridControl1.RefreshDataSource();
            //gridControl1.DataSource = bus.get().Tables[0];
            //gridView1.PopulateColumns();
            //lkTruong.Properties.DataSource = tr.get().Tables[0];
            //lkTruong.Properties.DisplayMember = "Tên trường";
            //lkTruong.Properties.ValueMember = "ID";
          ///  gridView1.OptionsBehavior.ReadOnly = true;
          //  gridView1.OptionsBehavior.Editable = false;
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
            dtNgay.EditValue = DateTime.Now;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           // lkKhoa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "").ToString();
            //lkLop.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "lid").ToString();
            //dtNgay.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ngày").ToString();
            //txtNoiDung.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nội dung").ToString();
            //txtBaiTap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Bài tập về nhà").ToString();
            //txtNhanXet.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nhận xét").ToString();
            //lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            //lblLop.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Lớp").ToString();
          //  lkTruong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên trường").ToString();
        }

        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void bntThem_Click(object sender, EventArgs e)
        {

            // try
            //{
                
            //    bus.insert(txtngay1.Text,txtngay2.Text,txtngay3.Text,dtNgay.EditValue.ToString(),lkLop.EditValue.ToString());
            //    load();
     
            //}
            //catch
            //{
            //    XtraMessageBox.Show("Có lỗi xảy ra");
            //}
        }

        private void bntSua_Click(object sender, EventArgs e)
        {

            // try
            //{
                
            //    bus.update(txtngay1.Text,txtngay2.Text,txtngay3.Text,dtNgay.EditValue.ToString(),lblID.Text);
            //    load();
     
            //}
            //catch
            //{
            //    XtraMessageBox.Show("Có lỗi xảy ra");
            //}
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
             try
            {
                
                bus.delete(lblID.Text);
                load();
     
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }
        private void load()
        {
            //this.Dock = DockStyle.Fill;
            //gridControl1.RefreshDataSource();
            //gridControl1.DataSource = bus.get().Tables[0];
            //gridView1.PopulateColumns();
        }

        private void bntIN_Click(object sender, EventArgs e)
        {
            //Report.sdbCover sdb = new Report.sdbCover(lblLop.Text);
            //sdb.ShowPreview();
            try
            {
                Report.SoDauBai sdb = new Report.SoDauBai(lkLop.EditValue.ToString(), lkLop.Text.ToString(),lkKhoa.EditValue.ToString(),dtNgay.Text,txtca1.Text,txtca2.Text,txtca3.Text,txtca4.Text);
                sdb.ShowPreviewDialog();
            }
            catch
            {
                XtraMessageBox.Show("Vui lòng chọn lớp");
            }

        }

        private void bntBia_Click(object sender, EventArgs e)
        {
            try
            {
                Report.sdbCover sdb = new Report.sdbCover(lkLop.EditValue.ToString(),lkKhoa.EditValue.ToString());
                sdb.ShowPreview();
            }
            catch
            {
                XtraMessageBox.Show("vui lòng chọn lớp");
            }
        }

        private void lkLop_EditValueChanged(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //gridControl1.RefreshDataSource();
            //gridControl1.DataSource = bus.get(lkLop.EditValue.ToString()).Tables[0];
            //gridView1.PopulateColumns();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                lkKhoa.Properties.DataSource = tkb.get(1).Tables[0];
            }
            else
            {
                lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            }
        }
        }

    }
