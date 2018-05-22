using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using boiduongLeQuyDon.BUS;
namespace boiduongLeQuyDon.GUI
{
    public partial class hocVien : DevExpress.XtraEditors.XtraUserControl
    {
        BUSHocVien bus = new BUSHocVien();
     //   BUSdmTruongHoc tr = new BUSdmTruongHoc();
        public hocVien()
        {
            InitializeComponent();
        }

        private void hocVien_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get("1").Tables[0];
       //     gridView1.PopulateColumns();
       ////     lkTruong.Properties.DataSource = tr.get().Tables[0];
        ////    lkTruong.Properties.DisplayMember = "Tên trường";
        //    lkTruong.Properties.ValueMember = "ID";
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
        }
        string ngaysinh;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtNgaySinh.Text.Trim() == "01/01/0001")
                    ngaysinh = "";
                else
                    ngaysinh = dtNgaySinh.Text.Trim();
                bus.insert(txtMaHV.Text.Trim(),txtHo.Text.Trim(), txtTen.Text.Trim(), ngaysinh, lkTruong.Text.Trim(), txtDienThoai.Text.Trim(), txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtTenCha.Text.Trim(), txtDTCha.Text.Trim(), txtNgheCha.Text.Trim(), txtCDCha.Text.Trim(), txtTenMe.Text.Trim(), txtDTMe.Text.Trim(), txtNgheMe.Text.Trim(), txtCDMe.Text.Trim(), txtNuoiDuong.Text.Trim(), txtDTPH.Text.Trim(), txtEmailPH.Text.Trim(), txtGhiChu.Text.Trim());
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

                if (dtNgaySinh.Text.Trim() == "01/01/0001")
                    ngaysinh = "";
                else
                    ngaysinh = dtNgaySinh.Text.Trim();
                bus.update(txtMaHV.Text.Trim(),txtHo.Text.Trim(), txtTen.Text.Trim(), ngaysinh, lkTruong.Text.Trim(), txtDienThoai.Text.Trim(), txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtTenCha.Text.Trim(), txtDTCha.Text.Trim(), txtNgheCha.Text.Trim(), txtCDCha.Text.Trim(), txtTenMe.Text.Trim(), txtDTMe.Text.Trim(), txtNgheMe.Text.Trim(), txtCDMe.Text.Trim(), txtNuoiDuong.Text.Trim(), txtDTPH.Text.Trim(), txtEmailPH.Text.Trim(), txtGhiChu.Text.Trim(), lblID.Text.Trim());
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
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                bus.delete(lblID.Text.Trim());
                load();
            }
            catch
            {
                XtraMessageBox.Show("Chọn một học viên để xóa");
            }
        }
        private void load()
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.getcurr().Tables[0];
          //  gridView1.PopulateColumns();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaHV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã HV").ToString();
            txtHo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Họ tên lót").ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên").ToString();
            dtNgaySinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ngày sinh").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Điện thoại").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ").ToString();
            lkTruong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Trường").ToString();
            txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "email").ToString();
            DataSet ds = new DataSet();
            ds = bus.get1(lblID.Text);
            txtTenCha.Text = ds.Tables[0].Rows[0]["hoTenCha"].ToString();
            txtDTCha.Text = ds.Tables[0].Rows[0]["dienThoaiCha"].ToString();
            txtNgheCha.Text = ds.Tables[0].Rows[0]["ngheNghiepCha"].ToString();
            txtCDCha.Text = ds.Tables[0].Rows[0]["chucVuCha"].ToString();
            txtTenMe.Text = ds.Tables[0].Rows[0]["hoTenMe"].ToString();
            txtNgheMe.Text = ds.Tables[0].Rows[0]["ngheNghiepMe"].ToString();
            txtCDMe.Text = ds.Tables[0].Rows[0]["chucVuMe"].ToString();
            txtDTMe.Text = ds.Tables[0].Rows[0]["dienThoaiMe"].ToString();
            txtNuoiDuong.Text = ds.Tables[0].Rows[0]["tenNguoiNuoiDuong"].ToString();
            txtEmailPH.Text = ds.Tables[0].Rows[0]["emailPhuHuynh"].ToString();
            txtDTPH.Text = ds.Tables[0].Rows[0]["dienThoaiNguoiNuoiDuong"].ToString();
         //   txtHo.TabStop = true;
          //  txtHo. = true;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            nguyenVong nv = new nguyenVong(lblID.Text.Trim());
            nv.Show();
        }

        private void lblNV_Click(object sender, EventArgs e)
        {
            nguyenVong nv = new nguyenVong(lblID.Text.Trim());
            nv.Show();
        }

        private void lblLop_Click(object sender, EventArgs e)
        {
            try
            {
                DKLop dk = new DKLop(lblID.Text.Trim());
                dk.Show();
            }
            catch
            {
                DKLop dk = new DKLop("-1");
                dk.Show();
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == false)
            {
                this.Dock = DockStyle.Fill;
                gridControl1.RefreshDataSource();
                gridControl1.DataSource = bus.get("1").Tables[0];
            //    gridView1.PopulateColumns();
            }
            else {

                this.Dock = DockStyle.Fill;
                gridControl1.RefreshDataSource();
                gridControl1.DataSource = bus.getcurr().Tables[0];
            //    gridView1.PopulateColumns();
            }

        }

        private void dtNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            if (dtNgaySinh.Text.Trim() == "01/01/0001")
                dtNgaySinh.Text = "";
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            exportHV exp = new exportHV();
            exp.Show();
        }
    }
}
