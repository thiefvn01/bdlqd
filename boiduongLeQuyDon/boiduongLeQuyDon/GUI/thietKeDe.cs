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
        double tong = 0;
        bdlqdDataSet1TableAdapters.getDe1TableAdapter getde1 = new bdlqdDataSet1TableAdapters.getDe1TableAdapter();
        bdlqdDataSet1TableAdapters.getKiemTraTableAdapter getkiemtra = new bdlqdDataSet1TableAdapters.getKiemTraTableAdapter();
        bdlqdDataSet1TableAdapters.getKiemTra1TableAdapter getkiemtra1 = new bdlqdDataSet1TableAdapters.getKiemTra1TableAdapter();
        bdlqdDataSet1TableAdapters.getDe4TableAdapter getde4 = new bdlqdDataSet1TableAdapters.getDe4TableAdapter();
        bdlqdDataSet1TableAdapters.getDe5TableAdapter getde5 = new bdlqdDataSet1TableAdapters.getDe5TableAdapter();
        bdlqdDataSet1TableAdapters.getDe7TableAdapter getde7 = new bdlqdDataSet1TableAdapters.getDe7TableAdapter();
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        //   coSoBoiDuongDataSetTableAdapters.deTableAdapter da = new coSoBoiDuongDataSetTableAdapters.deTableAdapter();
        //   coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter ka = new coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
        private void thietKeDe_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl1.DataSource = getde1.GetData();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            lkde.Properties.DataSource = getkiemtra.GetData();
            lkde.Properties.DisplayMember = "Mã đề";
            lkde.Properties.ValueMember = "ID";
            this.dt = getkiemtra.GetData();
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
                    this.count = Convert.ToInt32(getde4.GetData(Convert.ToInt32(lkde.EditValue.ToString())).Rows[0]["dem"].ToString());
                    queries.InsertDe(txtCau.Text, Convert.ToInt32(lkde.EditValue.ToString()), Convert.ToDouble(txttd.Text), txtCauLon.Text, txtNhomCau.Text);
                   
                  //  MessageBox.Show(count.ToString());
                 //   tong = 0;
                    queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), "  Tổng");
                    if (txtNhomCau.Text == "Đại số")
                    {
                        // dai += Convert.ToDouble(txttd.Text);
                         queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Đại");
                    }
                    else if (txtNhomCau.Text == "Hình học")
                    {
                         queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Hình");
                    }
                    else if (txtNhomCau.Text == "Tự luận")
                    {
                         queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TL");
                    }
                    else if (txtNhomCau.Text == "Trắc nghiệm")
                    {
                         queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TN");
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
                queries.InsertDe(txtCau.Text, Convert.ToInt32(lkde.EditValue.ToString()), Convert.ToDouble(txttd.Text), txtCauLon.Text, txtNhomCau.Text);
          //      gridControl1.DataSource = da.GetData();
                 queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), "  Tổng");
                if (txtNhomCau.Text == "Đại số")
                {
                   // dai += Convert.ToDouble(txttd.Text);
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Đại");
                }
                else if (txtNhomCau.Text == "Hình học")
                {
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " Hình");
                }
                else if (txtNhomCau.Text == "Tự luận")
                {
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TL");
                }
                else if (txtNhomCau.Text == "Trắc nghiệm")
                {
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TN");
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
            gridControl1.DataSource = getde1.GetData();
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            try
            {
                 queries.UpdateDe1(txtCau.Text, Convert.ToDouble(txttd.Text), txtCauLon.Text, txtNhomCau.Text, Convert.ToInt32(lblID.Text));

               
                if (txtNhomCau.Text == "Đại số")
                {
                    // dai += Convert.ToDouble(txttd.Text);
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam),deid, " Đại");
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, "  Tổng");
               //      queries.UpdateDe2(0, Convert.ToDouble(txttd.Text), deid, " Tổng");
                    //       queries.UpdateDe2(tong, Convert.ToDouble(txttd.Text), deid, " Tổng");
                }
                else if (txtNhomCau.Text == "Hình học")
                {
                     queries.UpdateDe2( Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, " Hình");
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, "  Tổng");
                }
                else if (txtNhomCau.Text == "Tự luận")
                {
                     queries.UpdateDe2( Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, " TL");
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, "  Tổng");
                }
                else if (txtNhomCau.Text == "Trắc nghiệm")
                {
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, " TN");
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, "  Tổng");
                   
                }
                else
                {
                    if (txtCau.Text == "  Tổng" || txtCau.Text == " TN" || txtCau.Text == " TL" || txtCau.Text == " Đại" || txtCau.Text == " Hình")
                    {
                    }
                    else
                     queries.UpdateDe2(Convert.ToDouble(txttd.Text), Convert.ToDouble(diemtam), deid, "  Tổng");
                }
                gridControl1.DataSource = getde1.GetData();
            }
            catch
            {
            }
        }
        double diemtam = 0;
        private void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    queries.deleteDe(Convert.ToInt32(lblID.Text));
                    if (txtNhomCau.Text == "Đại số")
                    {
                        // dai += Convert.ToDouble(txttd.Text);
                         queries.UpdateDe2(0, Convert.ToDouble(txttd.Text), deid, " Đại");
                         queries.UpdateDe2(0, Convert.ToDouble(txttd.Text), deid, " Tổng");
                  //       queries.UpdateDe2(tong, Convert.ToDouble(txttd.Text), deid, " Tổng");
                    }
                    else if (txtNhomCau.Text == "Hình học")
                    {
                         queries.UpdateDe2(0, Convert.ToDouble(txttd.Text), deid, " Hình");
                    }
                    else if (txtNhomCau.Text == "Tự luận")
                    {
                         queries.UpdateDe2(0, Convert.ToDouble(txttd.Text), deid, " TL");
                    }
                    else if (txtNhomCau.Text == "Trắc nghiệm")
                    {
                         queries.UpdateDe2(0, Convert.ToDouble(txttd.Text), deid, " TN");
                    }
                    gridControl1.DataSource = getde1.GetData();
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
            tong = Convert.ToDouble(getde5.GetData(Convert.ToInt32(lblID.Text)).Rows[0]["diemtoida"].ToString());
            deid = Convert.ToInt32(getde7.GetData(Convert.ToInt32(lblID.Text)).Rows[0]["deid"].ToString());
            diemtam = Convert.ToDouble(txttd.Text);
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
                    queries.InsertDe("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                else if (dang == "Đề hỗn hợp  Trắc nghiệm/Tự luận")
                {
                    queries.InsertDe("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    queries.InsertDe(" TL", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    queries.InsertDe(" TN", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
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
                    queries.InsertDe("C.0" + from.ToString(), de, Convert.ToDouble(txtmax.Text), "", "Trắc nghiệm");
                else
                    queries.InsertDe("C." + from.ToString(), de, Convert.ToDouble(txtmax.Text), "", "Trắc nghiệm");
                 queries.UpdateDe2(Convert.ToDouble(txtmax.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), " TN");
                 queries.UpdateDe2(Convert.ToDouble(txtmax.Text), 0, Convert.ToInt32(lkde.EditValue.ToString()), "  Tổng");
            }
            gridControl1.DataSource = getde1.GetData();
        }
        void themhead()
        {
             try
            {
                if (dang == "Đề toán")
                {
                    queries.InsertDe("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()),0,"","");
                    queries.InsertDe(" Đại", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    queries.InsertDe(" Hình", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                }
                else if (dang == "Đề cơ bản")
                    queries.InsertDe("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                else if (dang == "Đề hỗn hợp  Trắc nghiệm/Tự luận")
                {
                    queries.InsertDe("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    queries.InsertDe(" TL", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                    queries.InsertDe(" TN", Convert.ToInt32(lkde.EditValue.ToString()), 0, "", "");
                }
                    /* */
                else if (dang == "Đề 1 câu")
                    queries.InsertDe("  Tổng", Convert.ToInt32(lkde.EditValue.ToString()), 10, "", "");
                gridControl1.DataSource = getde1.GetData();
            }
            catch
            {
            }
        }

        private void lkde_EditValueChanged(object sender, EventArgs e)
        {
            this.dang = getkiemtra1.GetData(Convert.ToInt32(lkde.EditValue.ToString())).Rows[0]["dang"].ToString();
            this.count = Convert.ToInt32(getde4.GetData(Convert.ToInt32(lkde.EditValue.ToString())).Rows[0]["dem"].ToString());
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
