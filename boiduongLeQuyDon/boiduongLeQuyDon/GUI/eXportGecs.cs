using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraSplashScreen;
using Excel = Microsoft.Office.Interop.Excel;

namespace boiduongLeQuyDon.GUI
{
    public partial class eXportGecs : SplashScreen
    {
        public eXportGecs()
        {
            InitializeComponent();
           
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        DateTime dtfrom, dtto;
 
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSHocVien hv = new BUSHocVien();
        coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter kq = new coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter();
        coSoBoiDuongDataSetTableAdapters.ChiTietTKBTableAdapter ct = new coSoBoiDuongDataSetTableAdapters.ChiTietTKBTableAdapter();
        coSoBoiDuongDataSetTableAdapters.chamTapTableAdapter chamtap = new coSoBoiDuongDataSetTableAdapters.chamTapTableAdapter();
        int[] idhv = new int[100];
        //   int a = 0;
        coSoBoiDuongDataSetTableAdapters.LopTableAdapter da = new coSoBoiDuongDataSetTableAdapters.LopTableAdapter();
        DataTable dt = new DataTable();
        coSoBoiDuongDataSetTableAdapters.LopTableAdapter loptb = new coSoBoiDuongDataSetTableAdapters.LopTableAdapter();
        DataTable dtlop = new DataTable();
        coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter ktra=new coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
        coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter diemdanh = new coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter();
        coSoBoiDuongDataSetTableAdapters.hocVienTableAdapter hvv = new coSoBoiDuongDataSetTableAdapters.hocVienTableAdapter();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        string path;
        string idhocvien;
        string cophep, khongphep, tre, lopgoc, ngaylam, diem;
        public enum SplashScreenCommand
        {
        }

        private void eXportGecs_Load(object sender, EventArgs e)
        {
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
        }
        string[] lop1 = new string[50];
   //     SaveFileDialog saveFileDialog1 = new SaveFileDialog();
   //     string path;
        DataTable dthv = new DataTable();
        private void bntExport_Click(object sender, EventArgs e)
        {
            dtfrom = Convert.ToDateTime(dtFrom.Text);
            dtto = Convert.ToDateTime(dtTo.Text);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            //cont
            string[,] a = new string[50, 6];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                    a[i, j] = "";
            }
            int n=0;
            DataTable tbtmp = new DataTable();
            DataTable dt1 = new DataTable();
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            Excel.Worksheet wcel1 = new Excel.Worksheet();
            wcel.Name = "Chuyen can va Ktra";
            wcel1 = wbExcel.Worksheets.Add();
            wcel1.Name = "Cham tap";
            DataTable dsdotktra = new DataTable();
            string[] ngay = new string[200];
            DataTable dtngay = new DataTable();
            int p = 0;
            int dong = 2;
            int thutu = 1;
            DataTable dtmp = new DataTable();
            dtngay = chamtap.getngay(Convert.ToInt32(lkLop.EditValue.ToString()), dtfrom, dtto);
            int tmpp = 3;
            int hocvienid;
            foreach (DataRow row in dtngay.Rows)
            {
            //    ((Excel.Range)wcel1.Cells[4, tmpp]).Value2 = 0;
                ((Excel.Range)wcel1.Cells[1, tmpp]).Value2 = Convert.ToDateTime(row["Ngày"].ToString()).ToShortDateString();
            //    wcel.Cells[5, tmpp].Font.Bold = true;
                lop1[p] = Convert.ToDateTime(row["Ngày"].ToString()).ToShortDateString();
                p++;
                tmpp = tmpp + 1;
            }
            dsdotktra = ktra.getdsdotktra(dtfrom, dtto, Convert.ToInt32(lkLop.EditValue.ToString()));
            //   Mã đề
            for (int i = 0; i < dsdotktra.Rows.Count; i++)
            {
         //       MessageBox.Show(dsdotktra.Rows[i]["Mã đề"].ToString());
                ((Excel.Range)wcel.Cells[2, 6 + i]).Value2 = dsdotktra.Rows[i]["Mã đề"].ToString();
              
            }
            
                
            tbtmp = diemdanh.GetDataBy3(Convert.ToInt32(lkLop.EditValue.ToString()));
            DataTable dttam = new DataTable();
            dttam=hvv.gethsexport(Convert.ToInt32(lkLop.EditValue.ToString()));
            for (int z = 0; z < dttam.Rows.Count; z++)
            {
                idhocvien = dttam.Rows[z]["ID"].ToString();
                cophep = "";
                khongphep = "";
                tre = "";
                dtlop = loptb.getlopgoc(Convert.ToInt32(idhocvien), Convert.ToInt32(lkLop.EditValue.ToString()));
                lopgoc = dtlop.Rows[0]["lopGoc"].ToString();
                dt1 = kq.getforexport(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToInt32(idhocvien), dtfrom, dtto);
                dtmp.Clear();
                hocvienid=Convert.ToInt32(idhocvien);
                //xuat chamtap
                string baitap = "";
                
                string ngaytmp = "";
                dtmp = chamtap.getexport(hocvienid, Convert.ToInt32(lopgoc), dtfrom, dtto);
                DataColumn dtc = new DataColumn();
                dtc.ColumnName = "tmp";
                dtmp.Columns.Add(dtc);
                for (int i = 0; i < dtmp.Rows.Count;i++ )
                {
                    baitap = "";
                    baitap = dtmp.Rows[i]["Kiểm tra"].ToString();
                //    ten = dttam.Rows[i]["Họ Tên"].ToString();
                    ngaytmp = Convert.ToDateTime(dtmp.Rows[i]["Ngày"].ToString()).ToShortDateString();
                    for (int j = i + 1; j < dtmp.Rows.Count; j++)
                        if (ngaytmp == Convert.ToDateTime(dtmp.Rows[j]["Ngày"].ToString()).ToShortDateString())
                        {
                            baitap = baitap + ", " + dtmp.Rows[j]["Kiểm tra"].ToString();
                            dtmp.Rows[j]["tmp"] = "1";
                        }
                    if (Array.IndexOf(lop1, Convert.ToDateTime(dtmp.Rows[i]["Ngày"].ToString()).ToShortDateString()) > -1 && dtmp.Rows[i]["tmp"].ToString() !="1")
                    {
                        ((Excel.Range)wcel1.Cells[dong, Array.IndexOf(lop1, Convert.ToDateTime(dtmp.Rows[i]["Ngày"].ToString()).ToShortDateString()) + 3]).NumberFormat = "@";
                        ((Excel.Range)wcel1.Cells[dong, Array.IndexOf(lop1, Convert.ToDateTime(dtmp.Rows[i]["Ngày"].ToString()).ToShortDateString()) + 3]).Value2 = baitap;
                        ((Excel.Range)wcel1.Cells[dong, 1]).Value2 = thutu;

                        //  ((Excel.Range)wcel1.Cells[dong, 2]).Value2 = row["Họ và tên"].ToString();

                        //   ((Excel.Range)wcel1.Cells[4, Array.IndexOf(lop1, row["Lớp"].ToString()) + 7]).Value2 = ((Excel.Range)wcel.Cells[4, Array.IndexOf(lop1, row["Lớp"].ToString()) + 7]).Value2 + 1;
                    }


                }
                ((Excel.Range)wcel1.Cells[dong, 2]).Value2 = dttam.Rows[z]["Họ tên"].ToString();
                thutu++;
                dong++;   
                try
                {


                    for (int j = 0; j < diemdanh.gettrexp(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows.Count; j++)
                    {
                        //    lop = loptb.getlop(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc)).Rows[j]["idLop"].ToString();
                        //     XtraMessageBox.Show(lop);
                        try
                        {
                            //   XtraMessageBox.Show(tre);
                            tre += diemdanh.gettrexp(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows[j]["Trễ"].ToString();
                            tre += " ngày ";
                            //  XtraMessageBox.Show(tre);
                            tre += Convert.ToDateTime(diemdanh.gettrexp(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows[j]["Ngày"].ToString()).ToShortDateString();
                            if (j == diemdanh.gettrexp(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows.Count - 1)
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

                    for (int i = 0; i < diemdanh.getphep(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows.Count; i++)
                    {
                        try
                        {
                            cophep += Convert.ToDateTime(diemdanh.getphep(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows[i]["Có phép"].ToString()).ToShortDateString();
                            cophep += "; ";
                        }
                        catch { }
                    }
                    for (int i = 0; i < diemdanh.getKhong(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows.Count; i++)
                    {
                        try
                        {

                            khongphep += Convert.ToDateTime(diemdanh.getKhong(Convert.ToInt32(idhocvien), Convert.ToInt32(lopgoc), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text)).Rows[i]["Không phép"].ToString()).ToShortDateString();
                            khongphep += "; ";
                        }
                        catch
                        {
                        }
                    }
                    //     strlop = strlop + ", " + lop;
                    //  }
                }
                catch { }
                a[z, 0] = dttam.Rows[z]["Họ tên"].ToString(); ;
                a[z, 1] = cophep;
                a[z, 2] = khongphep;
                a[z, 3] = tre;
                ((Excel.Range)wcel.Cells[n + 3, 1]).Value2 = n + 1;
                ((Excel.Range)wcel.Cells[n + 3, 2]).Value2 = dttam.Rows[z]["Họ tên"].ToString();
                
                ((Excel.Range)wcel.Cells[n + 3, 3]).Value2 = cophep;
                ((Excel.Range)wcel.Cells[n + 3, 4]).Value2 = khongphep;
                ((Excel.Range)wcel.Cells[n + 3, 5]).Value2 = tre;

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    ngaylam = dt1.Rows[i]["Mã đề"].ToString();
                    diem = dt1.Rows[i]["Điểm"].ToString();
                    for (int j=6;j<20;j++){
                        try
                        {
                            if (ngaylam == ((Excel.Range)wcel.Cells[2, j]).Value2.ToString())
                                ((Excel.Range)wcel.Cells[n + 3, j]).Value2 = diem;
                        }
                        catch { }
                    }

                }
                n++;

        //        a[z, 4] = idhocvien;
            }
         
            wcel.Range[wcel.Cells[1, 1], wcel.Cells[1, 10]].Merge();
            ((Excel.Range)wcel.Cells[1, 1]).Value2 = "Tình hình học tập của lớp " + lkLop.Text + " từ ngày:" + dtfrom.ToShortDateString() + " đến ngày:" + dtto.ToShortDateString() ;
            ((Excel.Range)wcel.Cells[2, 1]).Value2 = "STT";
            ((Excel.Range)wcel.Cells[2, 2]).Value2 = "Họ và tên";
            ((Excel.Range)wcel.Cells[2, 3]).Value2 = "Có phép";
            ((Excel.Range)wcel.Cells[2, 4]).Value2 = "Không phép";
            ((Excel.Range)wcel.Cells[2, 5]).Value2 = "Trễ";
            ((Excel.Range)wcel1.Cells[1, 1]).Value2 = "STT";
            ((Excel.Range)wcel1.Cells[1, 2]).Value2 = "Họ và tên";
          
            //       wcel.Range[wcel.Cells[10, 11], wcel.Cells[10, 12]].Merge();
            //        ((Excel.Range)wcel.Cells[10, 11]).Value2 = "13456";
            wcel.Cells[1, 1].Font.Bold = true;
            wcel.Cells[2, 1].Font.Bold = true;
            wcel.Cells[2, 2].Font.Bold = true;
            wcel.Cells[2, 3].Font.Bold = true;
            wcel.Cells[2, 4].Font.Bold = true;
            wcel.Cells[2, 5].Font.Bold = true;
            wcel.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();
            this.Close();
           
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void lkPhep_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void lkLop_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                dthv.Clear();
                dthv = hv.getdiemdanh(lkLop.EditValue.ToString()).Tables[0];
              
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}