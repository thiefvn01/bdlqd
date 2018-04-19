using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraSplashScreen;
using Excel = Microsoft.Office.Interop.Excel;
namespace boiduongLeQuyDon.GUI
{
    public partial class xuatLSHV : SplashScreen
    {
        public xuatLSHV()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSHocVien hv = new BUSHocVien();
     //   BUSHocVien bus = new BUSHocVien();
        coSoBoiDuongDataSetTableAdapters.ChiTietTKBTableAdapter ct = new coSoBoiDuongDataSetTableAdapters.ChiTietTKBTableAdapter();
        int[] idhv = new int[100];
     //   int a = 0;
        coSoBoiDuongDataSetTableAdapters.LopTableAdapter da = new coSoBoiDuongDataSetTableAdapters.LopTableAdapter();
        DataTable dt = new DataTable();
        public enum SplashScreenCommand
        {
        }

        private void xuatLSHV_Load(object sender, EventArgs e)
        {
            lkPhep.Properties.DataSource = tkb.get(1).Tables[0];
            lkPhep.Properties.DisplayMember = "Tên TKB";
            lkPhep.Properties.ValueMember = "ID";
        }


  
        private void bntAdd_Click(object sender, EventArgs e)
        {
      //      a = 0;
         
        }
     //   string[] ten= new string[500];

        string[] lop1=new string[50];
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        string path;
        private void bntExport_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            DataTable dtmp = new DataTable();
            dtt = ct.GetDataBy(Convert.ToInt32(lkPhep.EditValue.ToString()));
            int dong = 1;
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            string lop = "";
            string ten = "";
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];           
            try
            {
                dt.Clear();
                      
                dt = da.exportnhan(Convert.ToInt32(lkPhep.EditValue.ToString()));
                DataColumn dtc = new DataColumn();
                dtc.ColumnName = "tmp";
                dt.Columns.Add(dtc);
                int cot = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ten = "";
                    lop = "";
                    if (dt.Rows[i]["tmp"].ToString() != "1")
                    {
                        ten = dt.Rows[i]["Họ tên"].ToString();                       
                        lop = dt.Rows[i]["Lớp"].ToString();
                        for (int j = i + 1; j < dt.Rows.Count; j++)
                            if (ten == dt.Rows[j]["Họ tên"].ToString())
                            {
                                if(lop=="")
                                    lop = dt.Rows[j]["Lớp"].ToString();
                                else
                                lop = lop + ", " + dt.Rows[j]["Lớp"].ToString();
                                dt.Rows[j]["tmp"] = 1;
                            }                       
                        ((Excel.Range)wcel.Cells[dong, cot]).Value2 = "Kính gửi: PHHS em:\n" + ten + "\nLớp: " + lop;
                        wcel.Cells[dong, cot].ColumnWidth = 20;
                        if (cot == 1)
                            cot = 2;
                        else if (cot == 2)
                            cot = 3;
                        else if (cot == 3)
                            cot = 4;
                        else
                        {
                            cot = 1;
                            dong++;
                        }                    
                    }

                }
            }
            // }              
            catch
            {
            }
            wcel.Columns.ColumnWidth = 24;
            wcel.Rows.RowHeight = 95;
            wcel.PageSetup.TopMargin = 0.25;
            wcel.PageSetup.LeftMargin = 0.25;
            wcel.PageSetup.RightMargin = 0.25;
            wcel.PageSetup.BottomMargin = 0.25;

          //  wcel.UsedRange.EntireRow.Height = 20;
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();
            this.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     //   int tatca = 0;
        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void bntNhan_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            DataTable dtmp = new DataTable();
            dtt = ct.GetDataBy(Convert.ToInt32(lkPhep.EditValue.ToString()));
            int dong = 2;
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }

            string ten = "";
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            wcel.Range[wcel.Cells[1, 1], wcel.Cells[1, 10]].Merge();
            ((Excel.Range)wcel.Cells[1, 1]).Value2 = lkPhep.Text.ToLower().Replace("thời khóa biểu", "").ToUpper();
            ((Excel.Range)wcel.Cells[2, 1]).Value2 = "(đã đóng học phí nửa khóa / toàn khóa)";
            ((Excel.Range)wcel.Cells[4, 2]).Value = "Tổng ĐK mỗi lớp";
            ((Excel.Range)wcel.Cells[5, 1]).Value2 = "SBL";
            ((Excel.Range)wcel.Cells[5, 2]).Value2 = "Họ tên";
            ((Excel.Range)wcel.Cells[5, 3]).Value2 = "Trường";
            ((Excel.Range)wcel.Cells[5, 4]).Value2 = "Số điện thoại học sinh";
            ((Excel.Range)wcel.Cells[5, 5]).Value2 = "Họ tên phụ huynh";
            ((Excel.Range)wcel.Cells[5, 6]).Value2 = "Số điện thoại phụ huynh";
            int tmpp = 7;
            int j1 = 0;
            string hotencha, hotenme, dtcha, dtme, tennd, dtnd, sbl, ghichu;
            if (cktt.Checked == true)
            {
                foreach (DataRow row in dtt.Rows)
                {
                    ((Excel.Range)wcel.Cells[4, tmpp]).Value2 = 0;
                    ((Excel.Range)wcel.Cells[5, tmpp]).Value2 = row["Lớp"].ToString();
                    wcel.Cells[5, tmpp].Font.Bold = true;
                    lop1[j1] = row["Lớp"].ToString();
                    j1++;
                    tmpp = tmpp + 1;
                }
                ((Excel.Range)wcel.Cells[5, tmpp]).Value2 = "Ghi chú";
            }
            else
            {
                for (int j = 7; j < 40; j++)
                {
                    ((Excel.Range)wcel.Cells[4, j]).Value2 = 0;
                    wcel.Cells[5, j].Font.Bold = true;
                }
                //
                ((Excel.Range)wcel.Cells[5, 7]).Value2 = "T12D";
                lop1[0] = "T12D";
                lop1[1] = "L12A";
                lop1[2] = "H12B";
                lop1[3] = "V12";
                lop1[4] = "E12";
                lop1[5] = "T11G";
                lop1[6] = "T10S";
                lop1[7] = "T10C";
                lop1[8] = "T10D";
                lop1[9] = "T10ĐB";
                lop1[10] = "L10B";
                lop1[11] = "H10A";
                lop1[12] = "E10G";
                lop1[13] = "E10C";
                lop1[14] = "T9C";
                lop1[15] = "T9A";
                lop1[16] = "T9G";
                lop1[17] = "T9D";
                lop1[18] = "V9G";
                lop1[19] = "V9";
                lop1[20] = "E9G";
                lop1[21] = "E9C";
                lop1[22] = "H9G";
                lop1[23] = "L9F";
                lop1[24] = "T8S";
                lop1[25] = "T8C";
                lop1[26] = "T8D";
                lop1[27] = "L8S";
                lop1[28] = "L8D";
                lop1[29] = "H8S";
                lop1[30] = "T7S";
                lop1[31] = "T7D";
                lop1[32] = "L7S";
                ((Excel.Range)wcel.Cells[5, 8]).Value2 = "L12A";
                ((Excel.Range)wcel.Cells[5, 9]).Value2 = "H12B";
                ((Excel.Range)wcel.Cells[5, 10]).Value2 = "V12";
                ((Excel.Range)wcel.Cells[5, 11]).Value2 = "E12";
                ((Excel.Range)wcel.Cells[5, 12]).Value2 = "T11G";
                ((Excel.Range)wcel.Cells[5, 13]).Value2 = "T10S";
                ((Excel.Range)wcel.Cells[5, 14]).Value2 = "T10C";
                ((Excel.Range)wcel.Cells[5, 15]).Value2 = "T10D";
                ((Excel.Range)wcel.Cells[5, 16]).Value2 = "T10ĐB";
                ((Excel.Range)wcel.Cells[5, 17]).Value2 = "L10B";
                ((Excel.Range)wcel.Cells[5, 18]).Value2 = "H10A";
                ((Excel.Range)wcel.Cells[5, 19]).Value2 = "E10G";
                ((Excel.Range)wcel.Cells[5, 20]).Value2 = "E10C";
                ((Excel.Range)wcel.Cells[5, 21]).Value2 = "T9C";
                ((Excel.Range)wcel.Cells[5, 22]).Value2 = "T9A";
                ((Excel.Range)wcel.Cells[5, 23]).Value2 = "T9G";
                ((Excel.Range)wcel.Cells[5, 24]).Value2 = "T9D";
                ((Excel.Range)wcel.Cells[5, 25]).Value2 = "V9G";
                ((Excel.Range)wcel.Cells[5, 26]).Value2 = "V9";
                ((Excel.Range)wcel.Cells[5, 27]).Value2 = "E9G";
                ((Excel.Range)wcel.Cells[5, 28]).Value2 = "E9C";
                //
                ((Excel.Range)wcel.Cells[5, 29]).Value2 = "H9G";
                ((Excel.Range)wcel.Cells[5, 30]).Value2 = "L9F";
                ((Excel.Range)wcel.Cells[5, 31]).Value2 = "T8S";
                ((Excel.Range)wcel.Cells[5, 32]).Value2 = "T8C";
                ((Excel.Range)wcel.Cells[5, 33]).Value2 = "T8D";
                ((Excel.Range)wcel.Cells[5, 34]).Value2 = "L8S";
                ((Excel.Range)wcel.Cells[5, 35]).Value2 = "L8D";
                ((Excel.Range)wcel.Cells[5, 36]).Value2 = "H8S";
                ((Excel.Range)wcel.Cells[5, 37]).Value2 = "T7S";
                ((Excel.Range)wcel.Cells[5, 38]).Value2 = "T7D";
                ((Excel.Range)wcel.Cells[5, 39]).Value2 = "L7S";
                ((Excel.Range)wcel.Cells[5, 40]).Value2 = "Ghi chú";
            }
            wcel.Cells[1, 1].Font.Bold = true;
            wcel.Cells[5, 1].Font.Bold = true;
            wcel.Cells[5, 2].Font.Bold = true;
            wcel.Cells[5, 3].Font.Bold = true;
            wcel.Cells[5, 4].Font.Bold = true;
            wcel.Cells[5, 5].Font.Bold = true;
            wcel.Cells[5, 6].Font.Bold = true;
            try
            {
                dt.Clear();
                ten = "";
                if (cktc.Checked == true)
                {
                    dt = da.hv4();
                }
                else
                {
                    dt = da.exporthv1(Convert.ToInt32(lkPhep.EditValue.ToString()));
                }
                DataColumn dtc = new DataColumn();
                dtc.ColumnName = "tmp";
                dt.Columns.Add(dtc);
                //  int i = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["tmp"].ToString() != "1")
                    {
                        ten = dt.Rows[i]["Họ tên"].ToString();
                        hotencha = dt.Rows[i]["hoTenCha"].ToString();
                        hotenme = dt.Rows[i]["hoTenMe"].ToString();
                        dtcha = dt.Rows[i]["dienThoaiCha"].ToString();
                        dtme = dt.Rows[i]["dienThoaiMe"].ToString();
                        tennd = dt.Rows[i]["tenNguoiNuoiDuong"].ToString();
                        dtnd = dt.Rows[i]["dienThoaiNguoiNuoiDuong"].ToString();
                        sbl = dt.Rows[i]["SBL"].ToString();
                        ghichu = dt.Rows[i]["Ghi chú"].ToString();


                        for (int j = i + 1; j < dt.Rows.Count; j++)
                            if (ten == dt.Rows[j]["Họ tên"].ToString())
                            {

                                sbl = sbl + ", " + dt.Rows[j]["SBL"].ToString();
                                dt.Rows[j]["tmp"] = 1;
                            }
                        //   i++;
                        //if (sbl == "1234w")
                        //{
                        //    MessageBox.Show("12356 " + i.ToString());  //32
                        //}

                        //tmp = dong + 5;
                        //for (int m = dong + 5; m >= 5; m--)
                        //{                               
                        //    if (((Excel.Range)wcel.Cells[m, 2]).Value2 == ten)
                        //    {
                        //       tmp = m;
                        //       m = -1;                                                                                     
                        //    }                              
                        //}
                        //if (tmp < dong+5)
                        //{
                        //    sobienlai = ((Excel.Range)wcel.Cells[dong + 5, 1]).Value2;
                        //    sobienlai = sobienlai + "; " + sbl;
                        //    ((Excel.Range)wcel.Cells[dong + 5, 1]).Value2 = sobienlai;
                        //    if (ten == "Phạm Nguyễn Thành Huy")
                        //    {                                  
                        //        ((Excel.Range)wcel.Cells[3, 1]).Value2 = sobienlai;
                        //    }
                        //}
                        //if (tmp ==dong+5)
                        //{

                        ((Excel.Range)wcel.Cells[dong + 5, 1]).Value2 = sbl;
                        ((Excel.Range)wcel.Cells[dong + 5, 2]).Value2 = ten;
                        ((Excel.Range)wcel.Cells[dong + 5, 3]).Value2 = dt.Rows[i]["Trường"].ToString(); ;
                        ((Excel.Range)wcel.Cells[dong + 5, 4]).Value2 = dt.Rows[i]["Điện thoại"].ToString(); ;
                        //       ((Excel.Range)wcel.Cells["D:D"]).NumberFormat = "@";
                        if (hotenme != "")
                        {
                            ((Excel.Range)wcel.Cells[dong + 5, 5]).Value2 = hotenme;
                            ((Excel.Range)wcel.Cells[dong + 5, 6]).Value2 = dtme;
                        }
                        else if (hotencha != "")
                        {
                            ((Excel.Range)wcel.Cells[dong + 5, 5]).Value2 = hotencha;
                            ((Excel.Range)wcel.Cells[dong + 5, 6]).Value2 = dtcha;
                        }
                        else
                        {
                            ((Excel.Range)wcel.Cells[dong + 5, 5]).Value2 = tennd;
                            ((Excel.Range)wcel.Cells[dong + 5, 6]).Value2 = dtnd;
                        }
                        if (cktc.Checked == true)
                        {

                            dtmp = da.HV5(Convert.ToInt32(dt.Rows[i]["idHocVien"].ToString()));
                        }
                        else
                        {
                            dtmp = da.exporthv(Convert.ToInt32(dt.Rows[i]["idHocVien"].ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
                        }
                        foreach (DataRow row in dtmp.Rows)
                        {

                            if (Array.IndexOf(lop1, row["Lớp"].ToString()) > -1)
                            {
                                ((Excel.Range)wcel.Cells[dong + 5, Array.IndexOf(lop1, row["Lớp"].ToString()) + 7]).Value2 = "x";
                                ((Excel.Range)wcel.Cells[4, Array.IndexOf(lop1, row["Lớp"].ToString()) + 7]).Value2 = ((Excel.Range)wcel.Cells[4, Array.IndexOf(lop1, row["Lớp"].ToString()) + 7]).Value2 + 1;
                            }

                        }
                        ((Excel.Range)wcel.Cells[dong + 5, 40]).Value2 = ghichu;
                        dong++;
                    }

                }
            }
            // }              
            catch
            {
            }
            wcel.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();
            this.Close();
        }

   
    }
}