using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraReports.UI;

namespace boiduongLeQuyDon.GUI
{
    public partial class QuanLyPhuDao : DevExpress.XtraEditors.XtraUserControl
    {
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        bdlqdDataSet1TableAdapters.getPhuDao1TableAdapter phudao = new bdlqdDataSet1TableAdapters.getPhuDao1TableAdapter();
        bdlqdDataSet1TableAdapters.getPhuDao_AllTableAdapter phudaoall = new bdlqdDataSet1TableAdapters.getPhuDao_AllTableAdapter();
        bdlqdDataSet1TableAdapters.getHocVien5TableAdapter gethocvientheolop = new bdlqdDataSet1TableAdapters.getHocVien5TableAdapter();
        bdlqdDataSet1TableAdapters.getTroGiangTableAdapter trogiang = new bdlqdDataSet1TableAdapters.getTroGiangTableAdapter();
        public QuanLyPhuDao()
        {
            InitializeComponent();
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            queries.insertPhuDao(Convert.ToInt32(lkHocVien.EditValue), Convert.ToInt32(lkLop.EditValue), txtLyDo.Text, txtThoiLuong.Text, txtThoiGian.Text, txtNoiDung.Text, Convert.ToInt32(lkTroGiang.EditValue), txtYKien.Text, txtKetQua.Text, txtNhanXet.Text, Convert.ToInt32(txtThuPhi.Text));
            load();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            queries.updatePhuDao(Convert.ToInt32(lkHocVien.EditValue), Convert.ToInt32(lkLop.EditValue), txtLyDo.Text, txtThoiLuong.Text, txtThoiGian.Text, txtNoiDung.Text, Convert.ToInt32(lkTroGiang.EditValue), txtYKien.Text, txtKetQua.Text, txtNhanXet.Text, Convert.ToInt32(txtThuPhi.Text), Convert.ToInt32(lblID.Text));
            lblID.Text = "a";
            load();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            queries.deletePhuDao(Convert.ToInt32(lblID.Text));
            load();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DeXuatPhuDao phieuphudao = new DeXuatPhuDao(lkHocVien.Text, lkLop.Text, txtLyDo.Text, txtThoiLuong.Text, txtNoiDung.Text, lkTroGiang.Text, txtYKien.Text, txtKetQua.Text, txtNhanXet.Text, Convert.ToInt32(txtThuPhi.Text));
            phieuphudao.ShowPreview();
        }
        BUSChiTietTKB ck = new BUSChiTietTKB();
        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void lkLop_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = gethocvientheolop.GetData(Convert.ToInt32(lkLop.EditValue));
            lkLop.Properties.DisplayMember = "Họ tên";
            lkLop.Properties.ValueMember = "ID";
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtKetQua.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kết quả").ToString();
            txtLyDo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Lý do").ToString();
            txtNhanXet.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nhận xét").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nội dung").ToString();
            txtThoiGian.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thời gian").ToString();
            txtThoiLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thời lượng").ToString();
            txtThuPhi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số tiền").ToString();
            txtYKien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ý kiến").ToString();
            lkTroGiang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Trợ giảng").ToString();
            lkTroGiang.EditValue = trogiang.GetData(Convert.ToInt32(lblID.Text));
        }
        void load()
        {
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = phudao.GetData();
            gridView1.PopulateColumns();
        }
    }
}
