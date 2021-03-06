﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using boiduongLeQuyDon.BUS;
using System.Data;

namespace boiduongLeQuyDon.GUI
{
    public partial class giaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        int bo, me, anh, chi, kinhnghiem1, kinhnghiem2 =0;
        BUSgiaoVien bus = new BUSgiaoVien();
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        bdlqdDataSet1TableAdapters.getNhanVien1TableAdapter nhanvien = new bdlqdDataSet1TableAdapters.getNhanVien1TableAdapter();
        bdlqdDataSet1TableAdapters.getNhanVien11TableAdapter nhanvientatca = new bdlqdDataSet1TableAdapters.getNhanVien11TableAdapter();
        bdlqdDataSet1TableAdapters.getNhanVienMoiNhapTableAdapter nvmoi = new bdlqdDataSet1TableAdapters.getNhanVienMoiNhapTableAdapter();
        bdlqdDataSet1TableAdapters.getquanhennhanvienTableAdapter quanhe = new bdlqdDataSet1TableAdapters.getquanhennhanvienTableAdapter();
        bdlqdDataSet1TableAdapters.getkinhnghiemnhanvienTableAdapter kinhnghiem = new bdlqdDataSet1TableAdapters.getkinhnghiemnhanvienTableAdapter();
        bdlqdDataSet1TableAdapters.getNhanVien2TableAdapter nv2 = new bdlqdDataSet1TableAdapters.getNhanVien2TableAdapter();
        public giaoVien()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            lblKN1.Text = "0";
            lblKN2.Text = "0";
        }

        private void giaoVien_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //gridControl1.RefreshDataSource();
            //gridControl1.DataSource = bus.get().Tables[0];  
            //gridView1.PopulateColumns();
            //gridView1.OptionsBehavior.Editable = false;
            //gridView1.OptionsBehavior.ReadOnly = true;
            load();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            queries.insertnhanvien(txtHoLot.Text, txtTen.Text, txtThuongTru.Text, txtTamTru.Text,txtDienThoai.Text, txtEmail.Text, txtUname.Text, txtPasswd.Text, txtGhiChu.Text, lkChucDanh.Text, ckGioiTinh.Text, txtCMND.Text, Convert.ToDateTime(dtNgayCap.EditValue.ToString().Substring(0, 10)), txtNoiCap.Text, txtChuyenNganh.Text, Convert.ToInt32(txtNamThu.Text), txtTruong.Text, txtKhoa.Text, txtBietDen.Text);
            int id = Convert.ToInt32(nvmoi.GetData().Rows[0][0].ToString());
            if (txtBo.Text!="")
                queries.insertquanhenhanvien(id, txtBo.Text, Convert.ToInt32(txtTuoiBo.Text), txtNgheBo.Text, txtDcBo.Text,  "Bố");
            if(txtMe.Text!="")
                queries.insertquanhenhanvien(id, txtMe.Text, Convert.ToInt32(txtTuoiMe.Text), txtNgheMe.Text, txtDCMe.Text, "Mẹ");
            if (txtAnh.Text!="")
                queries.insertquanhenhanvien(id, txtAnh.Text, Convert.ToInt32(txtTuoiAnh.Text), txtNNAnh.Text, "", "Anh");
            if (txtChi.Text!="")
                queries.insertquanhenhanvien(id, txtChi.Text, Convert.ToInt32(txtTuoiChi.Text), txtNNChi.Text, "", "Chị");
            if (txtMon1.Text != "")
                queries.insertkinhnghiemnhanvien(id, txtMon1.Text, txtLop1.Text, txtTruong1.Text, Convert.ToInt32(txtNam1.Text));
            if (txtMon2.Text != "")
                queries.insertkinhnghiemnhanvien(id, txtMon2.Text, txtLop2.Text, txtTruong2.Text, Convert.ToInt32(txtNam2.Text));
            //try
            //{
            //    bus.insert(txtHoLot.Text, txtTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, lkChucDanh.EditValue.ToString(), txtUname.Text, txtPasswd.Text, ckGioiTinh.EditValue.ToString(), txtMucLuong.Text, txtGhiChu.Text);
            //    load();
            //}
            //catch
            //{
            //    XtraMessageBox.Show("Có lỗi xảy ra");
            //}
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {

            if (ckNghi.CheckState == CheckState.Checked)
                queries.updateNhanVien(txtHoLot.Text, txtTen.Text, txtThuongTru.Text, txtTamTru.Text, txtDienThoai.Text, txtEmail.Text, txtUname.Text, txtPasswd.Text, txtGhiChu.Text, lkChucDanh.Text, ckGioiTinh.Text, txtCMND.Text, Convert.ToDateTime(dtNgayCap.EditValue.ToString().Substring(0, 10)), txtNoiCap.Text, txtChuyenNganh.Text, Convert.ToInt32(txtNamThu.Text), txtTruong.Text, txtKhoa.Text, txtBietDen.Text, true, Convert.ToInt32(lblID.Text));
            else
                queries.updateNhanVien(txtHoLot.Text, txtTen.Text, txtThuongTru.Text, txtTamTru.Text, txtDienThoai.Text, txtEmail.Text, txtUname.Text, txtPasswd.Text, txtGhiChu.Text, lkChucDanh.Text, ckGioiTinh.Text, txtCMND.Text, Convert.ToDateTime(dtNgayCap.EditValue.ToString().Substring(0,10)), txtNoiCap.Text, txtChuyenNganh.Text, Convert.ToInt32(txtNamThu.Text), txtTruong.Text, txtKhoa.Text, txtBietDen.Text, false, Convert.ToInt32(lblID.Text));
            if (txtBo.Text != "" && bo == 1)

                queries.updatequanhenhanvien(txtBo.Text, Convert.ToInt32(txtTuoiBo.Text), txtNgheBo.Text, txtDcBo.Text, "Bố", Convert.ToInt32(lblID.Text));
            else if (bo == 0 && txtBo.Text != "")
                try
                {
                    queries.insertquanhenhanvien(Convert.ToInt32(lblID.Text), txtBo.Text, Convert.ToInt32(txtTuoiBo.Text), txtNgheBo.Text, txtDcBo.Text, "Bố");
                }
                catch { }

            if (txtMe.Text != "" && me == 1)

                queries.updatequanhenhanvien(txtMe.Text, Convert.ToInt32(txtTuoiMe.Text), txtNgheMe.Text, txtDCMe.Text, "Mẹ", Convert.ToInt32(lblID.Text));
            else if (me == 0 && txtMe.Text != "")
                try
                {
                    queries.insertquanhenhanvien(Convert.ToInt32(lblID.Text), txtMe.Text, Convert.ToInt32(txtTuoiMe.Text), txtNgheMe.Text, txtDCMe.Text, "Mẹ");
                }
                catch { }

            if (txtAnh.Text != "" && anh == 1)

                queries.updatequanhenhanvien(txtAnh.Text, Convert.ToInt32(txtTuoiAnh.Text), txtNNAnh.Text, "", "Anh", Convert.ToInt32(lblID.Text));
            else if (anh == 0 && txtAnh.Text != "")
                try
                {
                    queries.insertquanhenhanvien(Convert.ToInt32(lblID.Text), txtAnh.Text, Convert.ToInt32(txtTuoiAnh.Text), txtNNAnh.Text, "", "Anh");
                }
                catch { }

            if (txtChi.Text != "" && chi == 1)

                queries.updatequanhenhanvien(txtChi.Text, Convert.ToInt32(txtTuoiChi.Text), txtNNChi.Text, "", "Chị", Convert.ToInt32(lblID.Text));
            else if (chi == 0 && txtChi.Text != "")
                try
                {
                    queries.insertquanhenhanvien(Convert.ToInt32(lblID.Text), txtChi.Text, Convert.ToInt32(txtTuoiChi.Text), txtNNChi.Text, "", "Chị");
                }
                catch { }

            if (txtMon1.Text != "" && kinhnghiem1==1)
                
                    queries.updatekinhnghiemnhanvien(txtMon1.Text, txtLop1.Text, txtTruong1.Text, Convert.ToInt32(txtNam1.Text), Convert.ToInt32(lblKN1.Text));
              else if(kinhnghiem1==0)
                    queries.insertkinhnghiemnhanvien(Convert.ToInt32(lblID.Text), txtMon1.Text, txtLop1.Text, txtTruong1.Text, Convert.ToInt32(txtNam1.Text));
               
            if (txtMon2.Text != "" && kinhnghiem2==1)
               
                    queries.updatekinhnghiemnhanvien(txtMon2.Text, txtLop2.Text, txtTruong2.Text, Convert.ToInt32(txtNam2.Text), Convert.ToInt32(lblKN2.Text));
             
              else if(kinhnghiem2==0)
                    queries.insertkinhnghiemnhanvien(Convert.ToInt32(lblID.Text), txtMon2.Text, txtLop2.Text, txtTruong2.Text, Convert.ToInt32(txtNam2.Text));
                
            lblKN1.Text = "0";
            lblKN2.Text = "0";
            lblID.Text = "0";
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            
           // queries.deleteNhanVien(Convert.ToInt32(lblID.Text));
            //try
            //{
            //    bus.delete(lblID.Text);
            //    load();
            //}
            //catch
            //{
            //    XtraMessageBox.Show("Chọn một dòng để xóa"); 
            //}
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //txtHoLot.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Họ tên lót").ToString();
            //txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên").ToString();
            //txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ").ToString();
            //txtDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số điện thoại").ToString();
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            int nid = Convert.ToInt32(lblID.Text);
            DataTable dtNhanVien = nv2.GetData(nid);
            DataTable dtQuanHeCha = quanhe.GetData(nid, "Bố");
            DataTable dtQuanHeMe = quanhe.GetData(nid, "Mẹ");
            DataTable dtQuanHeAnh = quanhe.GetData(nid, "Anh");
            DataTable dtQuanHeChi = quanhe.GetData(nid, "Chị");
            if (dtQuanHeAnh.Rows.Count > 0)
            {
                txtAnh.Text = dtQuanHeAnh.Rows[0][0].ToString();
                txtTuoiAnh.Text = dtQuanHeAnh.Rows[0][1].ToString();
                txtNNAnh.Text = dtQuanHeAnh.Rows[0][2].ToString();
            }
            else
                txtAnh.Text = txtTuoiAnh.Text = txtNNAnh.Text = "";
            if (dtQuanHeChi.Rows.Count > 0)
            {
                txtChi.Text = dtQuanHeChi.Rows[0][0].ToString();
                txtTuoiChi.Text = dtQuanHeChi.Rows[0][1].ToString();
                txtNNChi.Text = dtQuanHeChi.Rows[0][2].ToString();
            }
            else
                txtChi.Text = txtTuoiChi.Text = txtNNChi.Text = "";
            if (dtQuanHeCha.Rows.Count > 0)
            {
                txtBo.Text = dtQuanHeCha.Rows[0][0].ToString();
                txtTuoiBo.Text = dtQuanHeCha.Rows[0][1].ToString();
                txtNgheBo.Text = dtQuanHeCha.Rows[0][2].ToString();
                txtDcBo.Text = dtQuanHeCha.Rows[0][3].ToString();
            }
            else
                txtBo.Text = txtTuoiBo.Text = txtNgheBo.Text = txtDcBo.Text = "";
            if (dtQuanHeMe.Rows.Count > 0)
            {
                txtMe.Text = dtQuanHeMe.Rows[0][0].ToString();
                txtTuoiMe.Text = dtQuanHeMe.Rows[0][1].ToString();
                txtNgheMe.Text = dtQuanHeMe.Rows[0][2].ToString();
                txtDCMe.Text = dtQuanHeMe.Rows[0][3].ToString();
            }
            else
                txtMe.Text = txtTuoiMe.Text = txtNgheMe.Text = txtDCMe.Text = "";
            DataTable dtKinhnghiem = kinhnghiem.GetData(nid);
            txtTen.Text = dtNhanVien.Rows[0][2].ToString();
            txtHoLot.Text = dtNhanVien.Rows[0][1].ToString();
            txtDienThoai.Text = dtNhanVien.Rows[0][5].ToString();
            //txtDiaChi.Text = "";
            ckGioiTinh.Text = dtNhanVien.Rows[0][12].ToString();
            txtEmail.Text = dtNhanVien.Rows[0][6].ToString();
            txtCMND.Text = dtNhanVien.Rows[0][17].ToString();
            dtNgayCap.EditValue = dtNhanVien.Rows[0][18].ToString();
            txtNoiCap.Text = dtNhanVien.Rows[0][19].ToString();
            txtTruong.Text = dtNhanVien.Rows[0][22].ToString();
            txtNamThu.Text = dtNhanVien.Rows[0][21].ToString();
            txtKhoa.Text = dtNhanVien.Rows[0][23].ToString();
            txtChuyenNganh.Text = dtNhanVien.Rows[0][20].ToString();
            txtBietDen.Text = dtNhanVien.Rows[0][24].ToString();
            txtThuongTru.Text = dtNhanVien.Rows[0][3].ToString();
            txtTamTru.Text = dtNhanVien.Rows[0][4].ToString();
            lkChucDanh.Text = dtNhanVien.Rows[0][11].ToString();
            txtGhiChu.Text = dtNhanVien.Rows[0][10].ToString();
            try
            {
                if (Convert.ToBoolean(dtNhanVien.Rows[0][25].ToString()))
                    ckNghi.CheckState = CheckState.Checked;
                else
                    ckNghi.CheckState = CheckState.Unchecked;
            }
            catch
            { ckNghi.CheckState = CheckState.Unchecked; }
            //bắt đầu kinh nghiệm
            string tam = "";
            try
            {
                tam=dtKinhnghiem.Rows[0][3].ToString();
                kinhnghiem1 = 1;
                lblKN1.Text = tam;
            }
            catch
            {
                kinhnghiem1 = 0;
                tam = "";
            }
            if (tam != "")
            {
                txtMon1.Text = dtKinhnghiem.Rows[0][0].ToString();
                txtTruong1.Text = dtKinhnghiem.Rows[0][2].ToString();
                txtLop1.Text = dtKinhnghiem.Rows[0][1].ToString();
                txtNam1.Text = dtKinhnghiem.Rows[0][3].ToString();
            }
            else
            {
                txtMon1.Text = "";
                txtTruong1.Text = "";
                txtLop1.Text = "";
                txtNam1.Text = "";
            }
            try
            {
                tam = dtKinhnghiem.Rows[1][3].ToString();
                kinhnghiem2 = 1;
                lblKN2.Text = tam;
            }
            catch
            {
                kinhnghiem2 = 0;
                tam = "";
            }
            if (tam != "")
            {
                txtMon2.Text = dtKinhnghiem.Rows[1][0].ToString();
                txtTruong2.Text = dtKinhnghiem.Rows[1][2].ToString();
                txtLop2.Text = dtKinhnghiem.Rows[1][1].ToString();
                txtNam2.Text = dtKinhnghiem.Rows[1][3].ToString();
            }
            else
            {
                txtMon2.Text = "";
                txtTruong2.Text = "";
                txtLop2.Text = "";
                txtNam2.Text = "";
            }
            //dtQuanHeCha
            //try
            //{
            //    tam = dtQuanHeCha.Rows[0][0].ToString();
            //    bo = 1;
            //}
            //catch
            //{
            //    bo = 0;
            //    tam = "";
            //}
            //if (tam != "")
            //{
            //    //bắt đầu quan hệ
            //    txtBo.Text = dtQuanHeCha.Rows[0][0].ToString();
            //    txtDcBo.Text = dtQuanHeCha.Rows[0][3].ToString();
            //    txtNgheBo.Text = dtQuanHeCha.Rows[0][2].ToString();
            //    txtTuoiBo.Text = dtQuanHeCha.Rows[0][1].ToString();
            //}
            //else
            //{
            //    txtBo.Text = "";
            //    txtDcBo.Text = "";
            //    txtNgheBo.Text = "";
            //    txtTuoiBo.Text = "";
            //}
            //try
            //{
            //    tam = dtQuanHeMe.Rows[0][0].ToString();
            //    me = 1;
            //}
            //catch
            //{
            //    me = 0;
            //    tam = "";
            //}
            //if (tam != "")
            //{
            //    txtMe.Text = dtQuanHeMe.Rows[0][0].ToString();
            //    txtDCMe.Text = dtQuanHeMe.Rows[0][3].ToString();
            //    txtNgheMe.Text = dtQuanHeMe.Rows[0][2].ToString();
            //    txtTuoiMe.Text = dtQuanHeMe.Rows[0][1].ToString();
            //}
            //else
            //{
            //    txtMe.Text = "";
            //    txtDCMe.Text = "";
            //    txtNgheMe.Text = "";
            //    txtTuoiMe.Text = "";
            //}
            //try
            //{
            //    tam = dtQuanHeAnh.Rows[0][0].ToString();
            //    anh = 1;
            //}
            //catch
            //{
            //    anh = 0;
            //    tam = "";
            //}
            //if (tam != "")
            //{
            //    txtAnh.Text = dtQuanHeAnh.Rows[0][2].ToString(); ;
            //    txtTuoiAnh.Text = dtQuanHeAnh.Rows[0][3].ToString(); ;
            //    txtNNAnh.Text = dtQuanHeAnh.Rows[0][4].ToString(); ;
            //}
            //else
            //{
            //    txtAnh.Text = "";
            //    txtTuoiAnh.Text = "";
            //    txtNNAnh.Text ="" ;
            //}
            //try
            //{
            //    tam = dtQuanHeChi.Rows[0][0].ToString();
            //    chi = 1;
            //}
            //catch
            //{
            //    chi = 0;
            //    tam = "";
            //}
            //if (tam != "")
            //{
            //    txtChi.Text = dtQuanHeChi.Rows[0][2].ToString();
            //    txtTuoiChi.Text = dtQuanHeChi.Rows[0][3].ToString();
            //    txtNNChi.Text = dtQuanHeChi.Rows[0][4].ToString();
            //}
            //else
            //{
            //    txtChi.Text = "";
            //    txtTuoiChi.Text = "";
            //    txtNNChi.Text = "";
            //}
            ////bắt đầu kinh nghiệm
            //try
            //{
            //    tam = dtKinhnghiem.Rows[0][0].ToString();
            //    lblKN1.Text = tam;
            //}
            //catch
            //{

            //}
            //if (tam != "")
            //{
            //    txtMon1.Text = dtKinhnghiem.Rows[0][2].ToString();
            //    txtTruong1.Text = dtKinhnghiem.Rows[0][4].ToString();
            //    txtNam1.Text = dtKinhnghiem.Rows[0][5].ToString();
            //    txtLop1.Text = dtKinhnghiem.Rows[0][3].ToString();
            //}
            //try
            //{
            //    tam = dtKinhnghiem.Rows[1][0].ToString();
            //    lblKN2.Text = tam;
            //}
            //catch
            //{

            //}
            //if (tam != "")
            //{
            //    txtMon2.Text = dtKinhnghiem.Rows[1][2].ToString();
            //    txtTruong2.Text = dtKinhnghiem.Rows[1][4].ToString();
            //    txtLop2.Text = dtKinhnghiem.Rows[1][5].ToString();
            //    txtNam2.Text = dtKinhnghiem.Rows[1][3].ToString();
            //}
            ////bắt đầu unam
            txtUname.Text = dtNhanVien.Rows[0][7].ToString();
            txtPasswd.Text = dtNhanVien.Rows[0][8].ToString();

            //txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
            //txtUname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "userName").ToString();
            ////txtPasswd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "passWord").ToString();
            //txtThuongTru.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mức lương").ToString();
            //lkChucDanh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Vị trí").ToString();
            //txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            //ckGioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Giới tính").ToString();
        }
        private void load()
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = nhanvien.GetData();
       //     gridView1.PopulateColumns();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl31_Click(object sender, EventArgs e)
        {

        }

        private void txtDCMe_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtTuoiMe_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTuoiBo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl20_Click(object sender, EventArgs e)
        {

        }

        private void labelControl37_Click(object sender, EventArgs e)
        {

        }

        private void labelControl38_Click(object sender, EventArgs e)
        {

        }
    }
}
