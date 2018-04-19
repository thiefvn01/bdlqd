using System;
using System.Data;
using System.Windows.Forms;

namespace boiduongLeQuyDon.GUI
{
    public partial class thietKeDe : DevExpress.XtraEditors.XtraUserControl
    {
        public thietKeDe()
        {
            InitializeComponent();
        }
        int count = 0;
        decimal tong = 0;
        coSoBoiDuongDataSetTableAdapters.deTableAdapter da = new coSoBoiDuongDataSetTableAdapters.deTableAdapter();
        coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter ka = new coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
        private void thietKeDe_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl1.DataSource = da.GetData();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            lkde.Properties.DataSource = ka.GetData();
            lkde.Properties.DisplayMember = "Mã đề";
            lkde.Properties.ValueMember = "ID";
            this.dt = ka.GetData();
          //  this.dang = dt.Rows[0]["dang"].ToString(); //them dạng đề vào database
          
            //I <3 vnn hân so much
        }
        DataTable dt = new DataTable();
        string dang;
      
        private void bntThem_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                try
                {
                    themhead();
                    this.count = Convert.ToInt32(da.getcount(Convert.ToInt32(lkde.EditValue.ToString())).Rows[0]["dem"].ToString());
                    da.InsertQuery(txtCau.Text, Convert.ToInt32(lkde.EditValue.ToString()), Convert.ToDecimal(txttd.Text), txtCauLon.Text, txtNhomCau.Text);
                   
                  //  MessageBox.Show(count.ToString());
                 //   tong = 0;
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), "  Tổng");
                    if (txtNhomCau.Text == "Đại số")
                    {
                        // dai += Convert.ToDecimal(txttd.Text);
                        da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Đại");
                    }
                    else if (txtNhomCau.Text == "Hình học")
                    {
                        da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Hình");
                    }
                    else if (txtNhomCau.Text == "Tự luận")
                    {
                        da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TL");
                    }
                    else if (txtNhomCau.Text == "Trắc nghiệm")
                    {
                        da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TN");
                    }
               //     gridControl1.DataSource = da.GetData();
                }
                catch
                {
                }
            }
            else
            try
            {
                da.InsertQuery(txtCau.Text, Convert.ToInt32(lkde.EditValue.ToString()), Convert.ToDecimal(txttd.Text), txtCauLon.Text, txtNhomCau.Text);
          //      gridControl1.DataSource = da.GetData();
                da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), "  Tổng");
                if (txtNhomCau.Text == "Đại số")
                {
                   // dai += Convert.ToDecimal(txttd.Text);
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Đại");
                }
                else if (txtNhomCau.Text == "Hình học")
                {
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Hình");
                }
                else if (txtNhomCau.Text == "Tự luận")
                {
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TL");
                }
                else if (txtNhomCau.Text == "Trắc nghiệm")
                {
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TN");
                }
            }
            catch
            {
            }
            if (txtCau.Text == "a")
                txtCau.Text = "b";
            else if (txtCau.Text == "b")
                txtCau.Text = "c";
            else if (txtCau.Text == "c")
                txtCau.Text = "d";
            else  if (txtCau.Text == "d")
                txtCau.Text = "a";
            gridControl1.DataSource = da.GetData();
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            try
            {
                da.UpdateQuery(txtCau.Text, Convert.ToDecimal(txttd.Text), txtCauLon.Text, txtNhomCau.Text, Convert.ToInt32(lblID.Text));

               
                if (txtNhomCau.Text == "Đại số")
                {
                    // dai += Convert.ToDecimal(txttd.Text);
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), diemtam,deid, " Đại");
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), diemtam, deid, "  Tổng");
               //     da.UpdateQuery1(0, Convert.ToDecimal(txttd.Text), deid, " Tổng");
                    //      da.UpdateQuery1(tong, Convert.ToDecimal(txttd.Text), deid, " Tổng");
                }
                else if (txtNhomCau.Text == "Hình học")
                {
                    da.UpdateQuery1( Convert.ToDecimal(txttd.Text),diemtam, deid, " Hình");
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), diemtam, deid, "  Tổng");
                }
                else if (txtNhomCau.Text == "Tự luận")
                {
                    da.UpdateQuery1( Convert.ToDecimal(txttd.Text),diemtam, deid, " TL");
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), diemtam, deid, "  Tổng");
                }
                else if (txtNhomCau.Text == "Trắc nghiệm")
                {
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), diemtam, deid, " TN");
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), diemtam, deid, "  Tổng");
                   
                }
                else
                {
                    if (txtCau.Text == "  Tổng" || txtCau.Text == " TN" || txtCau.Text == " TL" || txtCau.Text == " Đại" || txtCau.Text == " Hình")
                    {
                    }
                    else
                    da.UpdateQuery1(Convert.ToDecimal(txttd.Text), diemtam, deid, "  Tổng");
                }
                gridControl1.DataSource = da.GetData();
            }
            catch
            {
            }
        }
        decimal diemtam = 0;
        private void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    da.DeleteQuery(Convert.ToInt32(lblID.Text));
                    if (txtNhomCau.Text == "Đại số")
                    {
                        // dai += Convert.ToDecimal(txttd.Text);
                        da.UpdateQuery1(0, Convert.ToDecimal(txttd.Text), deid, " Đại");
                        da.UpdateQuery1(0, Convert.ToDecimal(txttd.Text), deid, " Tổng");
                  //      da.UpdateQuery1(tong, Convert.ToDecimal(txttd.Text), deid, " Tổng");
                    }
                    else if (txtNhomCau.Text == "Hình học")
                    {
                        da.UpdateQuery1(0, Convert.ToDecimal(txttd.Text), deid, " Hình");
                    }
                    else if (txtNhomCau.Text == "Tự luận")
                    {
                        da.UpdateQuery1(0, Convert.ToDecimal(txttd.Text), deid, " TL");
                    }
                    else if (txtNhomCau.Text == "Trắc nghiệm")
                    {
                        da.UpdateQuery1(0, Convert.ToDecimal(txttd.Text), deid, " TN");
                    }
                    gridControl1.DataSource = da.GetData();
                }
               
            }
            catch
            {
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtCau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Câu").ToString();
            txttd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Điểm tối đa").ToString();
            txtNhomCau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nhóm câu").ToString();
            txtCauLon.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Câu lớn").ToString();
            tong = Convert.ToDecimal(da.GetDataBy5(Convert.ToInt32(lblID.Text)).Rows[0]["diemtoida"].ToString());
            deid = Convert.ToInt32(da.GetDataBy7(Convert.ToInt32(lblID.Text)).Rows[0]["deid"].ToString());
            diemtam = Convert.ToDecimal(txttd.Text);
            //if (txtNhomCau.Text == "Đại số")
            //{
            //    dai = Convert.ToInt32(da.GetDataBy6(" Đại", Convert.ToInt32(lblID.Text)).Rows[0]["diemtoida"].ToString());
            //}
            //else if (txtNhomCau.Text == "Hình học")
            //{
            //    hinh = Convert.ToInt32(da.GetDataBy6(" Hình", Convert.ToInt32(lblID.Text)).Rows[0]["diemtoida"].ToString());  
            //}
            //else if (txtNhomCau.Text == "Tự luận")
            //{
            //    tuluan = Convert.ToInt32(da.GetDataBy6(" TL", Convert.ToInt32(lblID.Text)).Rows[0]["diemtoida"].ToString());  
            //}
            //else if (txtNhomCau.Text == "Trắc nghiệm")
            //{
            //    tracnghiem = Convert.ToInt32(da.GetDataBy6(" TN", Convert.ToInt32(lblID.Text)).Rows[0]["diemtoida"].ToString());  
            //}
        }
       int deid;
        private void bntKT_Click(object sender, EventArgs e)
        {
            if (count == 0)
            try
            {
                if (dang == "Đề cơ bản")
                    da.InsertQuery("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                else if (dang == "Đề hỗn hợp  Trắc nghiệm/Tự luận")
                {
                    da.InsertQuery("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    da.InsertQuery(" TL", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    da.InsertQuery(" TN", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                }
                /* */
               
            }
            catch
            {
            }
            int from = 1;
            int to = 0;
            int de= Convert.ToInt32(lkde.EditValue.ToString());
            from = Convert.ToInt32(txtfrom.Text);
            to = Convert.ToInt32(txtto.Text);
            for (; from <= to; from++)
            {
                if(from<10)
                    da.InsertQuery("C.0" + from.ToString(), de, Convert.ToDecimal(txtmax.Text), "", "Trắc nghiệm");
                else
                    da.InsertQuery("C." + from.ToString(), de, Convert.ToDecimal(txtmax.Text), "", "Trắc nghiệm");
                da.UpdateQuery1(Convert.ToDecimal(txtmax.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TN");
                da.UpdateQuery1(Convert.ToDecimal(txtmax.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), "  Tổng");
            }
            gridControl1.DataSource = da.GetData();
        }
        void themhead()
        {
             try
            {
                if (dang == "Đề toán")
                {
                    da.InsertQuery("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()),0,"","");
                    da.InsertQuery(" Đại", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    da.InsertQuery(" Hình", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                }
                else if (dang == "Đề cơ bản")
                    da.InsertQuery("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                else if (dang == "Đề hỗn hợp  Trắc nghiệm/Tự luận")
                {
                    da.InsertQuery("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    da.InsertQuery(" TL", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    da.InsertQuery(" TN", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                }
                    /* */
                else if (dang == "Đề 1 câu")
                    da.InsertQuery("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 10, "", "");
                gridControl1.DataSource = da.GetData();
            }
            catch
            {
            }
        }

        private void lkde_EditValueChanged(object sender, EventArgs e)
        {
            this.dang = ka.GetDataBy3(Convert.ToInt32(lkde.EditValue.ToString())).Rows[0]["dang"].ToString();
            this.count = Convert.ToInt32(da.getcount(Convert.ToInt32(lkde.EditValue.ToString())).Rows[0]["dem"].ToString());
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
