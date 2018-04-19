using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class giaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        BUSgiaoVien bus = new BUSgiaoVien();
        public giaoVien()
        {
            InitializeComponent();
        }

        private void giaoVien_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];  
            gridView1.PopulateColumns();
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            try
            {
                bus.insert(txtHoLot.Text, txtTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, lkChucDanh.EditValue.ToString(), txtUname.Text, txtPasswd.Text, ckGioiTinh.EditValue.ToString(), txtMucLuong.Text, txtGhiChu.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if(txtPasswd.Text!="")
            try
            {
                bus.updatepw(txtHoLot.Text,txtTen.Text,txtDiaChi.Text,txtDienThoai.Text,txtEmail.Text, lkChucDanh.EditValue.ToString(),txtUname.Text,txtPasswd.Text,ckGioiTinh.EditValue.ToString(),txtMucLuong.Text,txtGhiChu.Text,lblID.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
            else
                try
                {
                    bus.update(txtHoLot.Text, txtTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, lkChucDanh.EditValue.ToString(), ckGioiTinh.EditValue.ToString(), txtMucLuong.Text, txtGhiChu.Text, lblID.Text);
                    load();
                }
                catch
                {
                    XtraMessageBox.Show("Có lỗi xảy ra");
                }

        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bus.delete(lblID.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Chọn một dòng để xóa"); 
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtHoLot.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Họ tên lót").ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ").ToString();
            txtDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số điện thoại").ToString();
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
            txtUname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "userName").ToString();
            //txtPasswd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "passWord").ToString();
            txtMucLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mức lương").ToString();
            lkChucDanh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Vị trí").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            ckGioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Giới tính").ToString();
        }
        private void load()
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
            gridView1.PopulateColumns();
        }
    }
}
