using System;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraPrinting;
using System.Data.SqlClient;
namespace boiduongLeQuyDon.GUI.Report
{
    
    public partial class phieuBaoHocTap : DevExpress.XtraReports.UI.XtraReport
    {
      //  static string connstring = "Data Source=kurt;Initial Catalog=bdlqd;Integrated Security=True";
        SqlDataAdapter loptb = new SqlDataAdapter();
        BUSChiTietTKB bus = new BUSChiTietTKB();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        DateTime dtfrom, dtto;
        string hoten;
        
      //  coSoBoiDuongDataSetTableAdapters.hocVienTableAdapter hv = new coSoBoiDuongDataSetTableAdapters.hocVienTableAdapter();
        public phieuBaoHocTap(string hoten, string idhocvien, string idlop, string tenlop, string tengv, string nx2, string nx3, string nx4, string idtkb, DateTime dtfrom, DateTime dtto)
        {
            InitializeComponent();
            
            this.idhocvien = idhocvien;
            this.idlop = idlop;
            this.dtfrom = dtfrom;
            this.dtto = dtto;
            this.hoten = hoten;
            //xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = false;
            //xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            ////xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            ////xrPivotGrid1.OptionsView.ShowRowGrandTotalHeader = false;
            XDocument doc = XDocument.Load("config.xml");
            string tttt = doc.Element("sets").Elements("canbo").FirstOrDefault().Value.ToString();
            if(tttt.Length!=0)
            cb.Text = tttt;
            //xrPivotGrid2.OptionsView.ShowColumnGrandTotals = false;
            //xrPivotGrid2.OptionsView.ShowGrandTotalsForSingleValues = false;
            //xrPivotGrid2.OptionsView.ShowColumnGrandTotalHeader = false;
            //xrPivotGrid2.OptionsView.ShowColumnGrandTotals = false;
            //xrPivotGrid2.OptionsView.ShowRowGrandTotals = false;
            //xrPivotGrid2.OptionsView.ShowRowGrandTotalHeader = false;
            this.idtkb = idtkb;
            load();
            lbgiaovien.Text = tengv;
            lbnx2.Text = nx2;
            lblnhanxet2.Text = nx3;
            lblnhanxet3.Text = nx4;
            lblop.Text = tenlop;
         //   lbtenp.Text = tenp.ToUpper();
           
        }
     //   BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        DataTable dtlop = new DataTable();
        string idhocvien, idlop;
        string lopgoc, idtkb;
        string tre = "";
      //  string lop = "";
        string cophep = "";
        string khongphep = "";
        //    string strlop = "-2";

        bdlqdDataSet1TableAdapters.getHocVien2TableAdapter hv = new bdlqdDataSet1TableAdapters.getHocVien2TableAdapter();
        bdlqdDataSet1TableAdapters.getlopgocTableAdapter loptb1 = new bdlqdDataSet1TableAdapters.getlopgocTableAdapter();
        bdlqdDataSet1TableAdapters.getDiemDanh5TableAdapter diemdanh5 = new bdlqdDataSet1TableAdapters.getDiemDanh5TableAdapter();
        bdlqdDataSet1TableAdapters.getDiemDanh3TableAdapter diemdanh3 = new bdlqdDataSet1TableAdapters.getDiemDanh3TableAdapter();
        bdlqdDataSet1TableAdapters.getDiemDanh4TableAdapter diemdanh4 = new bdlqdDataSet1TableAdapters.getDiemDanh4TableAdapter();
        bdlqdDataSet1TableAdapters.getChamTap2TableAdapter chamtap2 = new bdlqdDataSet1TableAdapters.getChamTap2TableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua15TableAdapter ketqua15 = new bdlqdDataSet1TableAdapters.getKetQua15TableAdapter();
       // coSoBoiDuongDataSetTableAdapters.LopTableAdapter loptb = new coSoBoiDuongDataSetTableAdapters.LopTableAdapter();
     //   coSoBoiDuongDataSetTableAdapters.chamTapTableAdapter chamtap = new coSoBoiDuongDataSetTableAdapters.chamTapTableAdapter();
    //    coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter diemdanh = new coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter();
        //coSoBoiDuongDataSetTableAdapters.kiemTra1TableAdapter kt = new coSoBoiDuongDataSetTableAdapters.kiemTra1TableAdapter();
     //   coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter kq = new coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter();
        void load()
        {
            string tentkb = tkb.get1(idtkb).Tables[0].Rows[0]["Tên TKB"].ToString().ToLower().Replace("thời khóa biểu", "").ToUpper();
            string nh = tkb.get1(idtkb).Tables[0].Rows[0]["Năm học"].ToString();
            lbtenp.Text = tentkb.ToUpper();
            int tmp = 0;
            try
            {
                lbhotenhs.Text = hoten;
                if (hv.GetData(Convert.ToInt32(idhocvien)).Rows[0]["dienThoaiMe"].ToString().Trim() != "")
                    lbdienthoai.Text = hv.GetData(Convert.ToInt32(idhocvien)).Rows[0]["dienThoaiMe"].ToString().Trim();
                else if (hv.GetData(Convert.ToInt32(idhocvien)).Rows[0]["dienThoaiCha"].ToString().Trim() != "")
                    lbdienthoai.Text = hv.GetData(Convert.ToInt32(idhocvien)).Rows[0]["dienThoaiCha"].ToString().Trim();
                else if (hv.GetData(Convert.ToInt32(idhocvien)).Rows[0]["dienThoaiNguoiNuoiDuong"].ToString().Trim() != "")
                    lbdienthoai.Text = hv.GetData(Convert.ToInt32(idhocvien)).Rows[0]["dienThoaiNguoiNuoiDuong"].ToString().Trim();
            }
            catch
            {
            }
            
            dtlop = loptb1.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(idlop));
            lopgoc = dtlop.Rows[0]["lopGoc"].ToString();
        //    XtraMessageBox.Show(lopgoc);
            try
            {
              

                for (int j = 0; j < diemdanh5.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows.Count; j++)
                {
                    //    lop = loptb.getlop(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc)).Rows[j]["idLop"].ToString();
                    //     XtraMessageBox.Show(lop);
                    try
                    {
                        //   XtraMessageBox.Show(tre);
                        tre += diemdanh5.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows[j]["Trễ"].ToString();
                        tre += " ngày ";
                        //  XtraMessageBox.Show(tre);
                        tre += Convert.ToDateTime(diemdanh5.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows[j]["Ngày"].ToString()).ToShortDateString();
                        if (j == diemdanh5.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows.Count - 1)
                            tre += " .";
                        else
                            tre += "; ";

                    }
                    catch { }
                }
            }
            catch
            {
            }
            try
            {
               // for (int i = 0; i < loptb.getlop(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc)).Rows.Count; i++)
               // {
               //     lop = loptb.getlop(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc)).Rows[i]["idLop"].ToString();

                for (int i = 0; i < diemdanh3.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows.Count; i++)
                {
                    try
                    {
                        cophep += Convert.ToDateTime(diemdanh3.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows[i]["Có phép"].ToString()).ToShortDateString();
                        cophep += "; ";
                    }
                    catch { }
                }
                for (int i = 0; i < diemdanh4.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows.Count; i++)
                {
                    try
                    {

                        khongphep += Convert.ToDateTime(diemdanh4.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto).Rows[i]["Không phép"].ToString()).ToShortDateString();
                        khongphep += "; ";
                    }
                    catch
                    {
                    }
                }
               //     strlop = strlop + ", " + lop;
              //  }
            }
            catch
            {
            }
            tmp = chamtap2.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc),dtfrom, dtto).Rows.Count;
            if (tre.Length == 0)
                lbtre.Text = "Không.";
            else
                try
                {
                    lbtre.Text = tre.Substring(0, tre.Length - 1) + ".";
                }
                catch { }
            if (cophep.Length == 0)
                lbvang.Text = "Không.";
            else
                try
                {
                    lbvang.Text = cophep.Substring(0, cophep.Length - 2) + ".";
                }
                catch { }
            if (khongphep.Trim().Length == 0)
                lbkop.Text = "Không.";
            else
                try
                {
                    lbkop.Text = khongphep.Substring(0, khongphep.Length - 2) + ".";
                }
                catch { }
            
            /////// stop here
            ////
            ////
            ////
            ////
         //   min = Convert.ToInt32(chamtap.GetDataBy3(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc)).Rows[0]["minum"].ToString());
        //    max = Convert.ToInt32(chamtap.GetDataBy3(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc)).Rows[0]["maxmum"].ToString());
       //     int sodong=0;
        //    sodong=tmp/3;
     //       xrPivotGrid1.OptionsDataField
         //   xrPivotGrid1.DataSource = chamtap.GetDataBy4(5, 5);
      //      xrPivotGrid1.
     //       xrPivotGrid1.DataSource = chamtap.getfn(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc),dtfrom, dtto);
        //    min = min + sodong;
            DataTable dt = new DataTable();
            dt = chamtap2.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto);
            DataTable dt4 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            dt2 = dt.Clone();
            dt3 = dt.Clone();
            dt4 = dt.Clone();
            DataRow rows;
       //     xrPivotGrid2.DataSource = chamtap.GetDataBy5(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc),dtfrom, dtto);
        //    min = min + sodong;
         //   xrPivotGrid3.DataSource = chamtap.GetDataBy6(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc),dtfrom, dtto);
            if (10 < tmp && tmp <= 20)
            {
                GroupFooter2.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    rows = dt.Rows[i];
                    dt4.ImportRow(rows);
                }
                for (int i = 10; i < dt.Rows.Count; i++)
                {
                    rows = dt.Rows[i];
                    dt2.ImportRow(rows);
                }
                xrPivotGrid1.DataSource = dt4;
                xrPivotGrid2.DataSource = dt2;
            }
            if (tmp > 20)
            {
                for (int i = 0; i < 10; i++)
                {
                    rows = dt.Rows[i];
                    dt4.ImportRow(rows);
                }
                for (int i = 10; i < 20; i++)
                {
                    rows = dt.Rows[i];
                    dt2.ImportRow(rows);
                }
                for (int i = 20; i < dt.Rows.Count; i++)
                {
                    rows = dt.Rows[i];
                    dt3.ImportRow(rows);
                }
                xrPivotGrid1.DataSource = dt4;
                xrPivotGrid2.DataSource = dt2;
                xrPivotGrid3.DataSource = dt3;
            }
              //  xrPivotGrid3.Visible = false;
             if (0 < tmp && tmp <= 10){
                 //
                 for (int i = 0; i < dt.Rows.Count; i++)
                 {
                     rows = dt.Rows[i];
                     dt4.ImportRow(rows);
                 }
                 xrPivotGrid1.DataSource = dt4;
                 GroupFooter1.Visible = false;
                 GroupFooter2.Visible = false;
                }
             if (tmp == 0)
             {
                 xrPivotGrid3.Visible = false;
                 xrPivotGrid2.Visible = false;
                 xrPivotGrid1.Visible = false;  
             }
          //   XtraMessageBox.Show(tmp.ToString());
         //    kt.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc));
             DataTable dt1 = new DataTable();
             dt1 = ketqua15.GetData(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), dtfrom, dtto);
        //     XtraMessageBox.Show(dt1.Rows.Count.ToString());
             double sum = 0;
             if (dt1.Rows.Count >= 4)
             {
                 ngay1.Text = Convert.ToDateTime(dt1.Rows[0]["ngayLam"].ToString()).ToShortDateString();
                 hs1.Text = dt1.Rows[0]["heSo"].ToString();
                 d1.Text = dt1.Rows[0]["Điểm"].ToString();
                 ngay2.Text = Convert.ToDateTime(dt1.Rows[1]["ngayLam"].ToString()).ToShortDateString();
                 hs2.Text = dt1.Rows[1]["heSo"].ToString();
                 d2.Text = dt1.Rows[1]["Điểm"].ToString();
                 ngay3.Text = Convert.ToDateTime(dt1.Rows[2]["ngayLam"].ToString()).ToShortDateString();
                 hs3.Text = dt1.Rows[2]["heSo"].ToString();
                 d3.Text = dt1.Rows[2]["Điểm"].ToString();
                 ngay4.Text = Convert.ToDateTime(dt1.Rows[3]["ngayLam"].ToString()).ToShortDateString();
                 hs4.Text = dt1.Rows[3]["heSo"].ToString();
                 d4.Text = dt1.Rows[3]["Điểm"].ToString();
                 sum = (Convert.ToDouble(hs1.Text) * Convert.ToDouble(d1.Text) + Convert.ToDouble(hs2.Text) * Convert.ToDouble(d2.Text) + Convert.ToDouble(hs3.Text) * Convert.ToDouble(d3.Text) + Convert.ToDouble(hs4.Text) * Convert.ToDouble(d4.Text)) / (Convert.ToDouble(hs1.Text) + Convert.ToDouble(hs2.Text) + Convert.ToDouble(hs3.Text) + Convert.ToDouble(hs4.Text));
                 tb2.Text = sum.ToString();
                 tb2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
           //      tb.Visible = false;
            //     tb1.Visible = false;
               
                // tb2.Visible = false;
                 tb3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | BorderSide.Right;
                 tb.Borders = DevExpress.XtraPrinting.BorderSide.Right;
                 tb2.Borders = DevExpress.XtraPrinting.BorderSide.Right;
                 tb1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
              //   tb.HeightF = 4f;
             }
             if (dt1.Rows.Count == 3)
             {
                 ngay4.Visible = false;
                 hs4.Visible = false;
                 d4.Visible = false;
                 ngay1.Text = Convert.ToDateTime(dt1.Rows[0]["ngayLam"].ToString()).ToShortDateString();
                 hs1.Text = dt1.Rows[0]["heSo"].ToString();
                 d1.Text = dt1.Rows[0]["Điểm"].ToString();
                 ngay2.Text = Convert.ToDateTime(dt1.Rows[1]["ngayLam"].ToString()).ToShortDateString();
                 hs2.Text = dt1.Rows[1]["heSo"].ToString();
                 d2.Text = dt1.Rows[1]["Điểm"].ToString();
                 ngay3.Text = Convert.ToDateTime(dt1.Rows[2]["ngayLam"].ToString()).ToShortDateString();
                 hs3.Text = dt1.Rows[2]["heSo"].ToString();
                 d3.Text = dt1.Rows[2]["Điểm"].ToString();
                 sum = (Convert.ToDouble(hs1.Text) * Convert.ToDouble(d1.Text) + Convert.ToDouble(hs2.Text) * Convert.ToDouble(d2.Text) + Convert.ToDouble(hs3.Text) * Convert.ToDouble(d3.Text)) / (Convert.ToDouble(hs1.Text) + Convert.ToDouble(hs2.Text) + Convert.ToDouble(hs3.Text));
                 tb1.Text =  Math.Round(sum,2).ToString();
                 tb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
             //    tb1.Visible = false;
            //     tb.Visible = false;
            //     tb3.Visible = false;
                 tb2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | BorderSide.Right;
                 tb.Borders = DevExpress.XtraPrinting.BorderSide.Right;
                 tb1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
             //    tb.HeightF = 3f;
             }
             if (dt1.Rows.Count == 2)
             {
                 ngay4.Visible = false;
                 ngay3.Visible = false;
                 hs4.Visible = false;
                 hs3.Visible = false;
                 d4.Visible = false;
                 d3.Visible = false;
                 ngay1.Text = Convert.ToDateTime(dt1.Rows[0]["ngayLam"].ToString()).ToShortDateString();
                 hs1.Text = dt1.Rows[0]["heSo"].ToString();
                 d1.Text = dt1.Rows[0]["Điểm"].ToString();
                 ngay2.Text = Convert.ToDateTime(dt1.Rows[1]["ngayLam"].ToString()).ToShortDateString();
                 hs2.Text = dt1.Rows[1]["heSo"].ToString();
                 d2.Text = dt1.Rows[1]["Điểm"].ToString();
                 sum = (Convert.ToDouble(hs1.Text) * Convert.ToDouble(d1.Text) + Convert.ToDouble(hs2.Text) * Convert.ToDouble(d2.Text)) / (Convert.ToDouble(hs1.Text) + Convert.ToDouble(hs2.Text));
                 tb1.Text = Math.Round(sum, 2).ToString();
                 tb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
             //    tb.Visible = false;
             //    tb2.Visible = false;
            //     tb3.Visible = false;
                 tb1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | BorderSide.Right;
                 tb.Borders = DevExpress.XtraPrinting.BorderSide.Right;
               //  tb.HeightF = 2f;
             }
             if (dt1.Rows.Count == 1)
             {
                 ngay4.Visible = false;
                 ngay3.Visible = false;
                 ngay2.Visible = false;
                 hs4.Visible = false;
                 hs3.Visible = false;
                 hs2.Visible = false;
                 d4.Visible = false;
                 d3.Visible = false;
                 d2.Visible = false;
                 ngay1.Text = Convert.ToDateTime(dt1.Rows[0]["ngayLam"].ToString()).ToShortDateString();
                 hs1.Text = dt1.Rows[0]["heSo"].ToString();
                 d1.Text = dt1.Rows[0]["Điểm"].ToString();
                 sum = (Convert.ToDouble(hs1.Text) * Convert.ToDouble(d1.Text)) / (Convert.ToDouble(hs1.Text));
                 tb.Text = Math.Round(sum, 2).ToString();
                 tb.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | BorderSide.Right; 
           //      tb1.Visible = false;
          //       tb2.Visible = false;
           //      tb3.Visible = false;
           //      tb.BorderWidth = 0;
            //     tb.HeightF = 1f;
             }
             if (dt1.Rows.Count == 0)
             {
                 ngay4.Visible = false;
                 ngay3.Visible = false;
                 ngay2.Visible = false;
                 hs4.Visible = false;
                 hs3.Visible = false;
                 hs2.Visible = false;
                 d4.Visible = false;
                 d3.Visible = false;
                 d2.Visible = false;
                 ngay1.Visible = false;
                 d1.Visible = false;
                 hs1.Visible = false;
                 tb.Visible = false;
                 tb.HeightF = 5f;
             }
             for (int i = 0; i < 4; i++)
             {
             }
        }

        private void xrPivotGrid1_PrintFieldValue(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportFieldValueEventArgs e)
        {
            TextBrick textBrick = (TextBrick)e.Brick;

            //if (e.Field.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea)
            //    textBrick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            //else if (e.Field.Area == DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            //    textBrick.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        private void xrPivotGrid1_CustomCellValue(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCellValueEventArgs e)
        {
            
        }

        private void xrPivotGrid1_CustomCellDisplayText(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCellDisplayTextEventArgs e)
        {
            //XtraMessageBox.Show(e.DisplayText.ToString());
            //if (e.DisplayText.Contains("AM"))
            //{
            //    XtraMessageBox.Show(e.Value.ToString());
            //    e.DisplayText = Convert.ToDateTime(e.Value.ToString()).ToShortDateString();
            //}
        }

        private void xrPivotGrid1_CustomRowHeight(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs e)
        {
            e.RowHeight = 0;
        }

        private void xrPivotGrid2_CustomRowHeight(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs e)
        {
            e.RowHeight = 0;
        }

        private void xrPivotGrid3_CustomRowHeight(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs e)
        {
            e.RowHeight = 0;
        }

    }
}
