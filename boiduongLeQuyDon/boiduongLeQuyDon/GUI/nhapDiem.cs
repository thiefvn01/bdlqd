using System;
using System.Data;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraReports.UI;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Linq;
using System.Xml.Linq;
namespace boiduongLeQuyDon.GUI
{
    public partial class nhapDiem : DevExpress.XtraEditors.XtraUserControl
    {
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSHocVien hv = new BUSHocVien();
        bdlqdDataSet1TableAdapters.getKiemTraTableAdapter getkiemtra = new bdlqdDataSet1TableAdapters.getKiemTraTableAdapter();
        bdlqdDataSet1TableAdapters.getKiemTra3TableAdapter getkiemtra3 = new bdlqdDataSet1TableAdapters.getKiemTra3TableAdapter();
        bdlqdDataSet1TableAdapters.getKiemTra1TableAdapter getkiemtra1 = new bdlqdDataSet1TableAdapters.getKiemTra1TableAdapter();
        bdlqdDataSet1TableAdapters.getDe3TableAdapter getde3 = new bdlqdDataSet1TableAdapters.getDe3TableAdapter();
        bdlqdDataSet1TableAdapters.getKetqua17TableAdapter getketqua17 = new bdlqdDataSet1TableAdapters.getKetqua17TableAdapter();
        bdlqdDataSet1TableAdapters.getSoCauTableAdapter getsocau = new bdlqdDataSet1TableAdapters.getSoCauTableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua1TableAdapter getketqua1 = new bdlqdDataSet1TableAdapters.getKetQua1TableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua9TableAdapter getketqua9 = new bdlqdDataSet1TableAdapters.getKetQua9TableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua11TableAdapter getketqua11 = new bdlqdDataSet1TableAdapters.getKetQua11TableAdapter();
        //  bdlqdDataSet1TableAdapters.getKetqua17TableAdapter getketqua17 = new bdlqdDataSet1TableAdapters.getKetqua17TableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua18TableAdapter getketqua18 = new bdlqdDataSet1TableAdapters.getKetQua18TableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua19TableAdapter getketqua19 = new bdlqdDataSet1TableAdapters.getKetQua19TableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua20TableAdapter getketqua20 = new bdlqdDataSet1TableAdapters.getKetQua20TableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua21TableAdapter getketqua21 = new bdlqdDataSet1TableAdapters.getKetQua21TableAdapter();
        bdlqdDataSet1TableAdapters.getDe11TableAdapter getde11 = new bdlqdDataSet1TableAdapters.getDe11TableAdapter();
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua4TableAdapter getketqua4 = new bdlqdDataSet1TableAdapters.getKetQua4TableAdapter();
        //  coSoBoiDuongDataSetTableAdapters.DataTable4TableAdapter dt4 = new coSoBoiDuongDataSetTableAdapters.DataTable4TableAdapter();
        // coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter da = new coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter();
        //  coSoBoiDuongDataSetTableAdapters.deTableAdapter de = new coSoBoiDuongDataSetTableAdapters.deTableAdapter();
        //   coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter kt = new coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
        //   coSoBoiDuongDataSetTableAdapters.DataTable3TableAdapter dt3 = new coSoBoiDuongDataSetTableAdapters.DataTable3TableAdapter();
        bdlqdDataSet1TableAdapters.getDeHVKhongKiemTraTableAdapter khongktra = new bdlqdDataSet1TableAdapters.getDeHVKhongKiemTraTableAdapter();
        bdlqdDataSet1TableAdapters.getCauThieuDiemTableAdapter thieudiem = new bdlqdDataSet1TableAdapters.getCauThieuDiemTableAdapter();
        bdlqdDataSet1TableAdapters.gethocvienthuocLopTableAdapter hvthuoclop = new bdlqdDataSet1TableAdapters.gethocvienthuocLopTableAdapter();
        bdlqdDataSet1TableAdapters.getCauThuocDeTableAdapter cauthuocde = new bdlqdDataSet1TableAdapters.getCauThuocDeTableAdapter();
        //   bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        bdlqdDataSet1TableAdapters.report_Diem_1TableAdapter reporttong = new bdlqdDataSet1TableAdapters.report_Diem_1TableAdapter();
        bdlqdDataSet1TableAdapters.report_Diem_theodeTableAdapter report1bai = new bdlqdDataSet1TableAdapters.report_Diem_theodeTableAdapter();
        bdlqdDataSet1TableAdapters.getDeThieuDiemTableAdapter dethieudiem = new bdlqdDataSet1TableAdapters.getDeThieuDiemTableAdapter();
        string dang = "";
        DataTable dt = new DataTable();
        public nhapDiem()
        {
            InitializeComponent();
     //       gridControl1.DataSource = da.GetData();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            this.Dock = DockStyle.Fill;
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
            lkdotkiemtra.Properties.DataSource = getkiemtra.GetData() ;
            lkdotkiemtra.Properties.DisplayMember = "Mã đề";
            lkdotkiemtra.Properties.ValueMember = "ID";
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
                lkPhep.Properties.DataSource = hv.getdiemdanh(lkLop.EditValue.ToString()).Tables[0];
                lkPhep.Properties.DisplayMember = "Họ tên";
                lkPhep.Properties.ValueMember = "ID";
                lkdotkiemtra.Properties.DataSource = getkiemtra3.GetData(int.Parse(lkLop.EditValue.ToString()));
                lkdotkiemtra.Properties.DisplayMember = "Mã đề";
                lkdotkiemtra.Properties.ValueMember = "ID";
            }
            catch
            {
            }
        }
        int tmp;
        private void lkdotkiemtra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = getketqua17.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));
                //lkde.Properties.DataSource = de.GetDataBy3(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()));
                //lkde.Properties.DisplayMember = "Mã đề";
                //lkde.Properties.ValueMember = "ID";
                this.dang = getkiemtra1.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString())).Rows[0]["dang"].ToString();
                this.dt = getde3.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()));
                this.tmp = Convert.ToInt32(getsocau.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString())).Rows[0]["dem"].ToString());
            }
            catch
            {
            }
        }
        string trungtam = "";
        private void nhapDiem_Load(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("config.xml");
            trungtam = doc.Element("sets").Elements("dong1").FirstOrDefault().Value.ToString();
            //d2.Text = doc.Element("sets").Elements("dong2").FirstOrDefault().Value.ToString();
            //d3.Text = doc.Element("sets").Elements("dong3").FirstOrDefault().Value.ToString();
            //d4.Text = doc.Element("sets").Elements("dong4").FirstOrDefault().Value.ToString();
            //d5.Text = doc.Element("sets").Elements("dong5").FirstOrDefault().Value.ToString();
            //d6.Text = doc.Element("sets").Elements("dong6").FirstOrDefault().Value.ToString();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            ThemDiem td = new ThemDiem(dt, Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkdotkiemtra.EditValue.ToString()),dang);
            if (td.IsDisposed)
            {
                td = new ThemDiem(dt, Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), dang);
            }
            else
            td.Show();
        }
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        string path = "";
        void inNhieuBai()
        {
            //getdata
            //  DataTable dt1bai = report1bai.GetData(Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToInt32(lkdotkiemtra.EditValue.ToString()));
            //gettong bị sai do đứa học viên đó có thể học nhiều khóa => cần thông tin về lớp
            DataTable dt1bai = reporttong.GetData(Convert.ToInt32(lkPhep.EditValue.ToString()),Convert.ToInt32(lkKhoa.EditValue.ToString()));

            //tạo excel với eppplus
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            wcel.Name = "Diem";
            ((Excel.Range)wcel.Cells[1, 1]).Value2 = trungtam;
            ((Excel.Range)wcel.Cells[2, 1]).Value2 = "KẾT QUẢ KIỂM TRA";
            ((Excel.Range)wcel.Cells[3, 1]).Value2 = "MÔN: " + dt1bai.Rows[1][9].ToString();
            ((Excel.Range)wcel.Cells[4, 1]).Value2 = "Học sinh: " + dt1bai.Rows[1][0].ToString();
            ((Excel.Range)wcel.Cells[4, 4]).Value2 = "Lớp: " + dt1bai.Rows[1][2].ToString();
            ((Excel.Range)wcel.Cells[5, 1]).Value2 = "Giáo viên: " + dt1bai.Rows[1][1].ToString();
            ((Excel.Range)wcel.Cells[1, 1]).ColumnWidth = 23;
            for (int i = 3; i < 13; i++)
            {
                ((Excel.Range)wcel.Cells[1, i]).ColumnWidth = 4.5;
            }
            wcel.Range[wcel.Cells[1, 1], wcel.Cells[1, 2]].Merge();
            wcel.Range[wcel.Cells[2, 1], wcel.Cells[2, 12]].Merge();
            ((Excel.Range)wcel.Cells[2, 1]).Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[1, 1]).Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[5, 1]).Value2 = "Kiểm tra";
            ((Excel.Range)wcel.Cells[5, 3]).Value2 = "Kết quả";
            //kết quả xuất ra
            int[] catngang = new int[20];
            for (int i = 0; i < 20; i++)
                catngang[i] = 0;
            int cn = 0;
            int j = 0;
            string tam = "";
            //số chia là số chênh lệch giữa số hiện tại của i khi xuống dòng và 10 để bắt đầu bài luôn luôn ở vị trí số 1
            int sochia = 10;
            int cot = 3;
            for (int i = 0; i < dt1bai.Rows.Count; i++)
            {
                if (i > 1 && dt1bai.Rows[i][8].ToString() != dt1bai.Rows[i - 1][8].ToString())
                {
                    tam = dt1bai.Rows[i][8].ToString() + "\n" + Convert.ToDateTime(dt1bai.Rows[i][7].ToString()).ToShortDateString();
                    ((Excel.Range)wcel.Cells[j + 6, 1]).Value2 = tam;
                    catngang[cn++] = j;
                  //    j += 3;
                    cot = 3;
                    sochia = i % 10;
                }

                if (i > 0 && (i - sochia) % 10 == 0)
                {
                    cot = 3;
                    j += 3;
                }
                //if (i % 10 - sochia == 0 && i != 0 && dt1bai.Rows[i][8].ToString() == dt1bai.Rows[i - 1][8].ToString())
                //    j += 3;
                //if (sochia != 10)
                //{
                    ((Excel.Range)wcel.Cells[j + 6, cot]).Value2 = dt1bai.Rows[i][4].ToString();
                    ((Excel.Range)wcel.Cells[j + 6, 2]).Value2 = "Câu";
                    ((Excel.Range)wcel.Cells[j + 7, cot]).Value2 = dt1bai.Rows[i][5].ToString();
                    ((Excel.Range)wcel.Cells[j + 7, 2]).Value2 = "Tối đa";
                    ((Excel.Range)wcel.Cells[j + 8, cot++]).Value2 = dt1bai.Rows[i][6].ToString();
                    ((Excel.Range)wcel.Cells[j + 8, 2]).Value2 = "Điểm";
              //  }
                //else
                //{
                //    ((Excel.Range)wcel.Cells[j + 6, i % 10 + 3]).Value2 = dt1bai.Rows[i][4].ToString();
                //    ((Excel.Range)wcel.Cells[j + 6, 2]).Value2 = "Câu";
                //    ((Excel.Range)wcel.Cells[j + 7, i % 10 + 3]).Value2 = dt1bai.Rows[i][5].ToString();
                //    ((Excel.Range)wcel.Cells[j + 7, 2]).Value2 = "Tối đa";
                //    ((Excel.Range)wcel.Cells[j + 8, i % 10 + 3]).Value2 = dt1bai.Rows[i][6].ToString();
                //    ((Excel.Range)wcel.Cells[j + 8, 2]).Value2 = "Điểm";
                //}

                //nếu 2 bài kiểm tra khác nhau thì set tên bài kiếm tra mới
               
            }


            // wcel.Range[wcel.Cells[6, 1], wcel.Cells[j + 8, 1]].Merge();
            //   wcel.Range[wcel.Cells[5, 3], wcel.Cells[5, 12]].Merge();
            // wcel.Range[wcel.Cells[6, 1], wcel.Cells[j + 8, 1]].Merge();
            catngang[cn] = j;
            tam = dt1bai.Rows[dt1bai.Rows.Count-1][8].ToString() + "\n" + Convert.ToDateTime(dt1bai.Rows[dt1bai.Rows.Count - 1][7].ToString()).ToShortDateString();
            ((Excel.Range)wcel.Cells[j + 6, 1]).Value2 = tam;
            wcel.Range[wcel.Cells[6, 1], wcel.Cells[catngang[0] + 8, 1]].Merge();
            int ii = 1;
           for (; ii < 20; ii++)
            {
                if (catngang[ii] != 0)
                    wcel.Range[wcel.Cells[catngang[ii-1]+8+1, 1], wcel.Cells[catngang[ii] + 8, 1]].Merge();
            }
            wcel.Range[wcel.Cells[5, 3], wcel.Cells[5, 12]].Merge();
            wcel.Range[wcel.Cells[3, 1], wcel.Cells[3, 12]].Merge();
            wcel.Range[wcel.Cells[4, 4], wcel.Cells[4, 6]].Merge();
            ((Excel.Range)wcel.Cells[4, 4]).Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            ((Excel.Range)wcel.Cells[3, 1]).Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[6, 1]).Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[6, 1]).Style.VerticalAlignment = Excel.XlVAlign.xlVAlignJustify;
            //   wcel.Range[wcel.Cells[6, 1], wcel.Cells[j + 8, 12]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle=Excel.XlLineStyle.xlContinuous;
            //save
            for (int k = 5; k < j + 9; k++)
                for (int i = 1; i < 13; i++)
                    allborder(wcel.Cells[k, i]);

            wbExcel.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, path.Replace(".xlsx", ".pdf"));
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();

            // allborder()
        }
        void inTungBai()
        {
            //getdata
            //  DataTable dt1bai = report1bai.GetData(Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToInt32(lkdotkiemtra.EditValue.ToString()));
            DataTable dt1bai = report1bai.GetData(Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));

            //tạo excel với eppplus
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            wcel.Name = "Diem";
            ((Excel.Range)wcel.Cells[1,1]).Value2 = trungtam; 
            ((Excel.Range)wcel.Cells[2, 1]).Value2 = "KẾT QUẢ KIỂM TRA";
            ((Excel.Range)wcel.Cells[3, 1]).Value2 = "MÔN: " + dt1bai.Rows[1][9].ToString();
            ((Excel.Range)wcel.Cells[4, 1]).Value2 = "Học sinh: " + dt1bai.Rows[1][0].ToString();
            ((Excel.Range)wcel.Cells[4, 4]).Value2 = "Lớp: " + dt1bai.Rows[1][2].ToString();
            ((Excel.Range)wcel.Cells[5, 1]).Value2 = "Giáo viên: " + dt1bai.Rows[1][1].ToString();
            ((Excel.Range)wcel.Cells[1, 1]).ColumnWidth=23;
            for(int i=3;i<13;i++)
            {
                ((Excel.Range)wcel.Cells[1, i]).ColumnWidth = 4.5;
            }
            wcel.Range[wcel.Cells[1, 1], wcel.Cells[1, 2]].Merge();
            wcel.Range[wcel.Cells[2, 1], wcel.Cells[2, 12]].Merge();
            ((Excel.Range)wcel.Cells[2, 1]).Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[1, 1]).Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[5, 1]).Value2 = "Kiểm tra";
            ((Excel.Range)wcel.Cells[5, 3]).Value2 = "Kết quả";
            int j = 0;
            for (int i = 0; i < dt1bai.Rows.Count; i++)
            {                
                if (i % 10 == 0 && i != 0)
                    j+=3;
                ((Excel.Range)wcel.Cells[j + 6, i%10 + 3]).Value2 = dt1bai.Rows[i][4].ToString();
                ((Excel.Range)wcel.Cells[j + 6, 2]).Value2 = "Câu";
                ((Excel.Range)wcel.Cells[j + 7, i % 10 + 3]).Value2 = dt1bai.Rows[i][5].ToString();
                ((Excel.Range)wcel.Cells[j + 7,  2]).Value2 = "Tối đa";
                ((Excel.Range)wcel.Cells[j + 8, i % 10 + 3]).Value2 = dt1bai.Rows[i][6].ToString();
                ((Excel.Range)wcel.Cells[j + 8, 2]).Value2 = "Điểm";
            }
            string tam = "";
            tam = dt1bai.Rows[1][8].ToString() + "\n" + Convert.ToDateTime(dt1bai.Rows[1][7].ToString()).ToShortDateString();
            ((Excel.Range)wcel.Cells[6, 1]).Value2 = tam;
            wcel.Range[wcel.Cells[6, 1], wcel.Cells[j +8, 1 ]].Merge();
            wcel.Range[wcel.Cells[5, 3], wcel.Cells[5, 12]].Merge();
            wcel.Range[wcel.Cells[3, 1], wcel.Cells[3, 12]].Merge();
            wcel.Range[wcel.Cells[4, 4], wcel.Cells[4, 6]].Merge();
            ((Excel.Range)wcel.Cells[4, 4]).Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            ((Excel.Range)wcel.Cells[3, 1]).Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[6, 1]).Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)wcel.Cells[6, 1]).Style.VerticalAlignment = Excel.XlVAlign.xlVAlignJustify;
         //   wcel.Range[wcel.Cells[6, 1], wcel.Cells[j + 8, 12]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle=Excel.XlLineStyle.xlContinuous;
            //save
            for (int k = 5; k < j +9; k++)
                for (int i = 1; i < 13; i++)
                    allborder(wcel.Cells[k, i]);
            
            wbExcel.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, path.Replace(".xlsx", ".pdf"));
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();
            
           // allborder()
        }
        private void allborder(Excel.Range range)
        {
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
           

        }
        private void bntIn_Click(object sender, EventArgs e)
        {
            inTungBai();
    //        string tam = "";
    //        int tmp = 0;
    //        XtraReport dummyReport = new XtraReport();
    //        //code mới
    //        int socau = 0;
    //        int ktra = 0;
    //        int vitri1, vitri2, vitri3, vitri11, vitri22;
    //        vitri1 = 0;
    //        vitri2 = 0;
    //        vitri3 = 1;
    //        vitri11 = 0;
    //        vitri22 = 0;
    //        string[] cau = new string[100];
    //        DataView dv = new DataView();
    //        DataView dvs = new DataView();
            
    //        //     DataView dvs = new DataView();
    //        //kiểm tra ràng buộc chưa kiểm tra
    //        //kiểm tra ràng buộc chưa có điểm
    //        //chưa kiểm tra: lấy idlop, idhocvien chưa kiểm tra
    //        //id lớp đã có
    //        //idhocvien và đề chưa kiểm tra: cho mỗi idlop được chọn, get tất cả học viên thuộc lớp đó,
    //        //cho mỗi học viên get được, check với lớp ra đề chưa kiểm tra
    //        //cho mỗi câu thuộc đề chưa kiểm tra => insert 0 điểm
    //        DataTable dt_hv = hvthuoclop.GetData(Convert.ToInt32(lkLop.EditValue.ToString()));
    //       // DataTable dt_khongktra = new DataTable();
    //        foreach (DataRow r in dt_hv.Rows)
    //        {
    //            //if học viên chưa kiểm tra =>get id để chưa kiểm tra
    //            DataTable dt_khongktra = khongktra.GetData(Convert.ToInt32(r[0].ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));
    //            foreach (DataRow r1 in dt_khongktra.Rows)
    //            {
    //                //nếu không kiểm tra
    //                //insert điểm vào cho người không ktra
    //                DataTable dtcauthuocde = cauthuocde.GetData(Convert.ToInt32(r1[0].ToString()));
    //                foreach (DataRow r2 in dtcauthuocde.Rows)
    //                {
    //                    queries.InsertKetQua(Convert.ToInt32(r[0].ToString()), Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(r2[0].ToString()), 0);
    //                }
    //            }
    //            //nếu học viên thiếu điểm => get câu chưa có điểm
    //            //đặt sai tên, đề thiếu điểm chính xác là lấy câu thuộc đề nhưng chưa có điểm
    //            DataTable dt_dethieudiem = dethieudiem.GetData(Convert.ToInt32(r[0].ToString()), Convert.ToInt32(lkdotkiemtra.EditValue.ToString()));
    //            foreach (DataRow r3 in dt_dethieudiem.Rows)
    //            {
    //                queries.InsertKetQua(Convert.ToInt32(r[0].ToString()), Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(r3[0].ToString()), 0);
    //            }

    //        }
    //        //xong học viên không kiểm tra
    //        // DataTable dt_diemthieu = thieudiem.GetData()
    //        //DataSet ds1 = new DataSet();
    //        //ds1.EnforceConstraints = true;
    //        //getketqua1.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));
            
    //        dvs = getketqua1.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString())).AsDataView(); 
    //        dv = getketqua9.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()),Convert.ToInt32(lkLop.EditValue.ToString())).AsDataView();
    //        dv.Sort = "Câu";
    //        dvs.Sort = "Cau";
    //        DataTable sortedDT = dv.ToTable();            
    //        DataTable dtmp = dv.ToTable();
    //        DataTable dtmp1 = new DataTable();
    //        DataTable dtmps1 = new DataTable();
    //        DataTable dtmp2 = new DataTable();
    //        DataTable dtmp3 = new DataTable();
    //        DataTable dtmp4 = new DataTable();
          
    // //       DataTable dtmps1 = new DataTable();
    //        dtmps1 = dvs.ToTable();
    ////        int hv = dv.ToTable(true, "Họ tên").Rows.Count;
    //        foreach (DataRow r in dtmp.Rows)
    //        {
    //            for (int i = 0; i < cau.Length; i++)
    //            {
    //                if (r["Câu"].ToString() == cau[i])
    //                {
    //                    i = cau.Length;
    //                    ktra = 1;
    //                }

    //            }
    //            if (ktra == 0)
    //            {
    //                cau[socau] = r["Câu"].ToString();
    //                socau++;
    //                if (socau == 20)
    //                    vitri1 = dtmp.Rows.IndexOf(r);
    //                if (socau == 40)
    //                    vitri2 = dtmp.Rows.IndexOf(r);
    //                if (socau == 21)
    //                    vitri11 = dtmp.Rows.IndexOf(r);
    //                if (socau == 41)
    //                    vitri22 = dtmp.Rows.IndexOf(r);        

    //            }
    //            ktra = 0;
    //            vitri3++;
    //        }
    //        vitri3--;
    //        if (socau <= 20)
    //        {
    //             dv.Sort = "Câu";
    //             dtmp1 = dv.ToTable();
    //           //  DataRow[] r1 = coSoBoiDuongDataSet.ketQuaHocTap.NewketQuaHocTapRow[100];
    //             for (int i = 0; i < dtmps1.Rows.Count; i++)
    //             {
    //                tam = dtmps1.Rows[i]["Cau"].ToString();
    //                tam.Replace('.', '-').Replace("a", "a-");
    //                dtmp1.Rows.Add("9998", "Trung bình", dtmp1.Rows[5]["Lớp"], dtmps1.Rows[i]["trungbinh"], tam, "Zzy", dtmps1.Rows[i]["diemToiDa"]);
    //                 dtmp1.Rows.Add("9999", "Phần trăm", dtmp1.Rows[5]["Lớp"], dtmps1.Rows[i]["phantram"], tam, "Zzz", dtmps1.Rows[i]["diemToiDa"]);
    //             }
    //             boiduongLeQuyDon.GUI.Report.getTheoDe report = new boiduongLeQuyDon.GUI.Report.getTheoDe(lkLop.EditValue.ToString(), lkLop.Text, Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), lkdotkiemtra.Text, dtmp1, dtmp2, dtmp3,  1);
    //             report.ShowPreviewDialog();
    //        }
    //        if (socau > 20 && socau <= 40)
    //        {
    //            dv.Sort = "Câu";
    //            dtmp1 = dv.ToTable();
    //            tmp = vitri3 -1;
    //            dtmp2 = dv.ToTable();
                
    //            for (int i = tmp; i >vitri11-1; i--)
    //            {
    //                dtmp1.Rows[i].Delete();              
    //            }
    //            for (int i = 0; i <20; i++)
    //            {
    //                tam = dtmps1.Rows[i]["Cau"].ToString();
    //                tam.Replace('.', '-').Replace("a", "a-");
    //                dtmp1.Rows.Add("9998", "Trung bình", dtmp1.Rows[5]["Lớp"], dtmps1.Rows[i]["trungbinh"], tam, "Zzy", dtmps1.Rows[i]["diemToiDa"]);
    //                dtmp1.Rows.Add("9999", "Phần trăm", dtmp1.Rows[5]["Lớp"], dtmps1.Rows[i]["phantram"], tam, "Zzz", dtmps1.Rows[i]["diemToiDa"]);
    //            }
    //            tmp = 0;
    //            while (tmp < vitri11)
    //            {
    //                dtmp2.Rows[0].Delete();           
    //                tmp++;
    //            }
    //            for (int i = 20; i < dtmps1.Rows.Count; i++)
    //            {
    //                tam = dtmps1.Rows[i]["Cau"].ToString();
    //                tam.Replace('.', '-').Replace("a", "a-");
    //                dtmp2.Rows.Add("9998", "Trung bình", dtmp2.Rows[5]["Lớp"], dtmps1.Rows[i]["trungbinh"], tam, "Zzy", dtmps1.Rows[i]["diemToiDa"]);
    //                dtmp2.Rows.Add("9999", "Phần trăm", dtmp2.Rows[5]["Lớp"], dtmps1.Rows[i]["phantram"], tam, "Zzz", dtmps1.Rows[i]["diemToiDa"]);
    //            }
    //            boiduongLeQuyDon.GUI.Report.getTheoDe report = new boiduongLeQuyDon.GUI.Report.getTheoDe(lkLop.EditValue.ToString(), lkLop.Text, Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), lkdotkiemtra.Text, dtmp1, dtmp2, dtmp3, 2);
    //            report.ShowPreviewDialog();
    //        }
    //        if (socau > 40)
    //        {
    //          //  ketQuaHocTapTableAdapter.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString())).AsDataView();
    //            dv.Sort = "Câu";
    //            dtmp1 = dv.ToTable();
    //            dtmp3 = dv.ToTable();
    //            dtmp2 = dv.ToTable();
    //            for (int i = vitri3 - 1; i > vitri11-1 ; i--)
    //            {
    //                dtmp1.Rows[i].Delete();     
    //            }
    //            for (int i = 0; i < 20; i++)
    //            {
    //                tam = dtmps1.Rows[i]["Cau"].ToString();
    //                tam.Replace('.', '-').Replace("a", "a-");
    //                dtmp1.Rows.Add("9998", "Trung bình", dtmp1.Rows[5]["Lớp"], dtmps1.Rows[i]["trungbinh"], tam, "Zzy", dtmps1.Rows[i]["diemToiDa"]);
    //                dtmp1.Rows.Add("9999", "Phần trăm", dtmp1.Rows[5]["Lớp"], dtmps1.Rows[i]["phantram"], tam, "Zzz", dtmps1.Rows[i]["diemToiDa"]);
    //            }
    //            tmp = vitri3 -1;
    //            for (int i = tmp; i > vitri22-1; i--)
    //            {
    //                dtmp2.Rows[i].Delete();
    //            }             
    //            tmp = vitri1;
    //            for (int i = 0 ; i <vitri11; i++) //nếu không được thì đếm từ 0 đến vtri1 và xóa row[0]
    //            {
    //                dtmp2.Rows[0].Delete();              
    //            }
    //            for (int i = 20; i < 40; i++)
    //            {
    //                tam = dtmps1.Rows[i]["Cau"].ToString();
    //                tam.Replace('.', '-').Replace("a", "a-");
    //                dtmp2.Rows.Add("9998", "Trung bình", dtmp2.Rows[5]["Lớp"], dtmps1.Rows[i]["trungbinh"], tam, "Zzy", dtmps1.Rows[i]["diemToiDa"]);
    //                dtmp2.Rows.Add("9999", "Phần trăm", dtmp2.Rows[5]["Lớp"], dtmps1.Rows[i]["phantram"], tam, "Zzz", dtmps1.Rows[i]["diemToiDa"]);
    //            }
    //            tmp = 0;
    //            while (tmp < vitri22)
    //            {
    //                dtmp3.Rows[0].Delete();
    //                tmp++;
    //            }
    //            for (int i = 40; i < dtmps1.Rows.Count; i++)
    //            {
    //                tam = dtmps1.Rows[i]["Cau"].ToString();
    //                tam.Replace('.', '-').Replace("a", "a-");
    //                dtmp3.Rows.Add("9998", "Trung bình", dtmp3.Rows[5]["Lớp"], dtmps1.Rows[i]["trungbinh"], tam, "Zzy", dtmps1.Rows[i]["diemToiDa"]);
    //                dtmp3.Rows.Add("9999", "Phần trăm", dtmp3.Rows[5]["Lớp"], dtmps1.Rows[i]["phantram"], tam, "Zzz", dtmps1.Rows[i]["diemToiDa"]);
    //            }
    //            boiduongLeQuyDon.GUI.Report.getTheoDe report = new boiduongLeQuyDon.GUI.Report.getTheoDe(lkLop.EditValue.ToString(), lkLop.Text, Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), lkdotkiemtra.Text, dtmp1, dtmp2, dtmp3, 3);
    //             report.ShowPreviewDialog();          
    //        }
        
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                queries.deleteKetqua(Convert.ToInt32(lblID.Text));
                gridControl1.DataSource =getketqua17.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));

            }
            catch
            {
            }
        }
        int idbaitap;
        
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString();
            cau = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Câu").ToString();
            txtdiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Điểm").ToString();
            lbdiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Điểm").ToString();
            idbaitap = Convert.ToInt32(getketqua18.GetData(Convert.ToInt32(lblID.Text)).Rows[0]["idBaiTap"].ToString());
            nhomcau = getketqua18.GetData(idbaitap).Rows[0]["nhomcau"].ToString();
            idhocvien = Convert.ToInt32(getketqua18.GetData(Convert.ToInt32(lblID.Text)).Rows[0]["idHocVien"].ToString());
            tenhocvien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Họ tên").ToString();
        }
        string tenhocvien;
        int idhocvien;
        int deid = 0;
        string nhomcau;
        string cau;
        private void bntEdit_Click(object sender, EventArgs e)
        {
            int c = 0;
            deid = Convert.ToInt32(lkdotkiemtra.EditValue.ToString());
            //if (cau == "   Tổng")
            //{
            //    da.UpdateQuery(Convert.ToDouble(txtdiem.Text), Convert.ToInt32(lblID.Text));
            // //   c = Convert.ToInt32(da.getid(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), "  Tổng").Rows[0]["id"].ToString());
            //  //  da.updatespencial(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text), c, idhocvien);
            //}
            
             try
            {
               queries.UpdateKetQua(Convert.ToDouble(txtdiem.Text),Convert.ToInt32(lblID.Text));
            //    da.updatespencial(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text));
                if (cau != "   Tổng")
                {
                    c = Convert.ToInt32(getketqua20.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), "  Tổng").Rows[0]["id"].ToString());
                   queries.updateKetQua2(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text), c, idhocvien);
                }

                if(nhomcau=="Đại số")
                {
                    c = Convert.ToInt32(getketqua20.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), " Đại").Rows[0]["id"].ToString());
                    queries.updateKetQua2(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text), c, idhocvien);
                 //   da.updatespencial(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text),idhocvien, deid, "  Đại");
                }
                if (nhomcau == "Hình học")
                {
                    c = Convert.ToInt32(getketqua20.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), " Hình").Rows[0]["id"].ToString());
                    //       c = Convert.ToInt32(da.getid(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), " Hình"));
                    queries.updateKetQua2(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text), c, idhocvien);
                 //    da.updatespencial(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text),idhocvien, deid, " Hình");
                }
                if (nhomcau == "Tự luận")
                {
                    c = Convert.ToInt32(getketqua20.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), " TL").Rows[0]["id"].ToString());
                    //       c = Convert.ToInt32(da.getid(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), " TL"));
                    queries.updateKetQua2(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text), c, idhocvien);
                  //   da.updatespencial(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text),idhocvien, deid, " TL");
                }
                if (nhomcau == "Trắc nghiệm")
                {
                    c = Convert.ToInt32(getketqua20.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), " TN").Rows[0]["id"].ToString());
                    //        c = Convert.ToInt32(da.getid(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), " TN"));
                    queries.updateKetQua2(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text), c, idhocvien);
                 //    da.updatespencial(Convert.ToDouble(txtdiem.Text), Convert.ToDouble(lbdiem.Text),idhocvien, deid, "TN");
                }
                gridControl1.DataSource = getketqua17.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));
            }
            catch
            {
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = getketqua17.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa điểm của học viên " + tenhocvien + " ?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    queries.deleteKetQua1(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), idhocvien);
                gridControl1.DataSource = getketqua17.GetData(Convert.ToInt32(lkdotkiemtra.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));

            }
            catch
            {
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            inNhieuBai();
    //        int socau = 0;
    //        int ktra = 0;
    //  //      int tmp = 0;
    //        int vitri1, vitri2, vitri3, vitri4, vitri11, vitri22, vitri33;
    //        vitri1 = 0;
    //        vitri2 = 0;
    //        vitri3 = 0;
    //        vitri4 = 1;
    //        vitri11 = 0;
    //        vitri22 = 0;
    //        vitri33 = 0;
    //        string[] cau=new string[100];
    //        DataTable dtde = new DataTable();
    //        DataView dv = new DataView();
    //        dv=getketqua4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()),Convert.ToInt32(lkPhep.EditValue.ToString())).AsDataView();
    //        dv.Sort = "Câu";
    //  //      int hv = dv.ToTable(true, "maDe").Rows.Count;
    //        DataTable sortedDT = dv.ToTable();
    //        DataTable dtmp = dv.ToTable();
    //        DataTable dtmp1 = new DataTable();
    //        DataTable dtmp2 = new DataTable();
    //        DataTable dtmp3 = new DataTable();
    //        DataTable dtmp4 = new DataTable();           
    //        dtde = dv.ToTable(true, "maDe","ngaylam", "Câu", "diemtoida", "IDde");
    //        for (int i = 0; i < dtde.Rows.Count; i++)
    //        {// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            DataRowView newRow = dv.AddNew();
    //            newRow["IDde"] = Convert.ToInt32(dtde.Rows[i]["IDde"].ToString())  - 1;
    //            newRow["Họ tên"] = dtmp.Rows[5]["Họ tên"];
    //            newRow["Lớp"] = dtmp.Rows[5]["Lớp"];
    //            newRow["Điểm"] = dtde.Rows[i]["diemtoida"];
    //            newRow["Câu"] = dtde.Rows[i]["Câu"];
    //            newRow["Tên"] = dtmp.Rows[5]["Tên"];
    //            newRow["diemtoida"] = dtde.Rows[i]["diemtoida"];
    //            newRow["maDe"] = ""; ///dtde.Rows[i]["maDe"];
    //            newRow["ngayLam"] = dtde.Rows[i]["ngayLam"];
    //            newRow["id"] = i;
    //            newRow.EndEdit();
    //        }
    //        dv.Sort = "Câu";
    //        dtmp1 = dv.ToTable();
    //        dtmp2 = dv.ToTable();
    //        dtmp3 = dv.ToTable();
    //        dtmp4 = dv.ToTable();
    //       // int cong = 0;
    //   /*      for (int i = 0; i < dtmp1.Rows.Count; i++)
    //        {
    //            dtmp1.Rows[i]["id"] = Convert.ToInt32(dtmp1.Rows[i]["IDde"].ToString())* 10 ;
    //            dtmp2.Rows[i]["id"] = Convert.ToInt32(dtmp2.Rows[i]["IDde"].ToString()) * 10;
    //            dtmp3.Rows[i]["id"] = Convert.ToInt32(dtmp3.Rows[i]["IDde"].ToString()) * 10;
    //            dtmp4.Rows[i]["id"] = Convert.ToInt32(dtmp4.Rows[i]["IDde"].ToString()) * 10;
    //        } */
    //        foreach (DataRow r in dtmp1.Rows)
    //        {
    //            for (int i = 0; i <= socau; i++)
    //            {
    //                if (r["Câu"].ToString() == cau[i])
    //                {
    //                    i = cau.Length;
    //                    ktra = 1;
    //                }
                   
    //             }
    //            if (ktra == 0)
    //            {
    //                cau[socau] = r["Câu"].ToString();
    //                socau++;
    //                if (socau == 20)
    //                    vitri1 = dtmp1.Rows.IndexOf(r);
    //                if (socau == 40)
    //                    vitri2 = dtmp1.Rows.IndexOf(r);
    //                if (socau == 60)
    //                    vitri3 = dtmp1.Rows.IndexOf(r);
    //                if (socau == 21)
    //                    vitri11 = dtmp1.Rows.IndexOf(r);
    //                if (socau == 41)
    //                    vitri22 = dtmp1.Rows.IndexOf(r);
    //                if (socau == 61)
    //                    vitri33 = dtmp1.Rows.IndexOf(r);                   
    //            }
    //            ktra = 0;
    //            vitri4++;
    //        }
    //    //    MessageBox.Show(socau.ToString());
    //        vitri4--;
    //        dtmp.Dispose();
    //        if (socau <= 20)
    //        {            

    //          //  dtmp1 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            boiduongLeQuyDon.GUI.Report.GetTheoHV report = new boiduongLeQuyDon.GUI.Report.GetTheoHV(dtmp1,lkLop.EditValue.ToString(), lkLop.Text,  lkPhep.Text,  Convert.ToInt32(lkPhep.EditValue.ToString()), dtmp2, dtmp3, dtmp4,1);
    //            report.ShowPreviewDialog();
              
    //        }
    //        if (socau > 20 && socau <= 40)
    //        {
                
    //        //    dtmp1 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            tmp = 0;
    //            for (int i = vitri4 - 1; i>=vitri11 ; i--)
    //            {
    //                dtmp1.Rows[i].Delete();
    //            }
    //            //for (int i = 0; i < dtmp1.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp1.Rows.Add(Convert.ToDateTime(dtmp1.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp1.Rows[i]["Họ tên"], dtmp1.Rows[i]["Lớp"], dtmp1.Rows[i]["diemtoida"], dtmp1.Rows[i]["Câu"], dtmp1.Rows[i]["Tên"], dtmp1.Rows[i]["diemtoida"], dtmp1.Rows[i]["maDe"], dtmp1.Rows[i]["ngayLam"]);
    //            //}
    //            //  report.ShowPreviewDialog();
            
                
    //       //     dtmp2 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = 0; i < vitri11 ; i++)
    //            {
    //                dtmp2.Rows[0].Delete();
    //            }
    //            //for (int i = 0; i < dtmp2.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp2.Rows.Add(Convert.ToDateTime(dtmp2.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp2.Rows[i]["Họ tên"], dtmp2.Rows[i]["Lớp"], dtmp2.Rows[i]["diemtoida"], dtmp2.Rows[i]["Câu"], dtmp2.Rows[i]["Tên"], dtmp2.Rows[i]["diemtoida"], dtmp2.Rows[i]["maDe"], dtmp2.Rows[i]["ngayLam"]);
    //            //}
    //            boiduongLeQuyDon.GUI.Report.GetTheoHV report = new boiduongLeQuyDon.GUI.Report.GetTheoHV(dtmp1, lkLop.EditValue.ToString(), lkLop.Text, lkPhep.Text, Convert.ToInt32(lkPhep.EditValue.ToString()), dtmp2, dtmp3, dtmp4, 2);
    //            report.ShowPreviewDialog();
    //            //  report.ShowPreviewDialog();
             
    //        }
    //        if (socau > 40 && socau <=60)
    //        {

    //       //     dtmp1 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = vitri4 - 1; i >= vitri11; i--)
    //            {
    //                dtmp1.Rows[i].Delete();
    //            }

    //            //for (int i = 0; i < dtmp1.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp1.Rows.Add(Convert.ToDateTime(dtmp1.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp1.Rows[i]["Họ tên"], dtmp1.Rows[i]["Lớp"], dtmp1.Rows[i]["diemtoida"], dtmp1.Rows[i]["Câu"], dtmp1.Rows[i]["Tên"], dtmp1.Rows[i]["diemtoida"], dtmp1.Rows[i]["maDe"], dtmp1.Rows[i]["ngayLam"]);
    //            //}
    //      //      dtmp2 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = vitri4 - 1; i >= vitri22; i--)
    //            {
    //                dtmp2.Rows[i].Delete();
    //            }
    //            for (int i = 0; i < vitri11; i++)
    //            {
    //                dtmp2.Rows[0].Delete();
    //            }
    //            //for (int i = 0; i < dtmp2.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp2.Rows.Add(Convert.ToDateTime(dtmp2.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp2.Rows[i]["Họ tên"], dtmp2.Rows[i]["Lớp"], dtmp2.Rows[i]["diemtoida"], dtmp2.Rows[i]["Câu"], dtmp2.Rows[i]["Tên"], dtmp2.Rows[i]["diemtoida"], dtmp2.Rows[i]["maDe"], dtmp2.Rows[i]["ngayLam"]);
    //            //}
    //     //       dtmp3 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = 0; i < vitri2; i++)
    //            {
    //                dtmp3.Rows[0].Delete();
    //            }
    //            //for (int i = 0; i < dtmp3.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp3.Rows.Add(Convert.ToDateTime(dtmp3.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp3.Rows[i]["Họ tên"], dtmp3.Rows[i]["Lớp"], dtmp3.Rows[i]["diemtoida"], dtmp3.Rows[i]["Câu"], dtmp3.Rows[i]["Tên"], dtmp3.Rows[i]["diemtoida"], dtmp3.Rows[i]["maDe"], dtmp3.Rows[i]["ngayLam"]);
    //            //}
    //            boiduongLeQuyDon.GUI.Report.GetTheoHV report = new boiduongLeQuyDon.GUI.Report.GetTheoHV(dtmp1, lkLop.EditValue.ToString(), lkLop.Text, lkPhep.Text, Convert.ToInt32(lkPhep.EditValue.ToString()), dtmp2, dtmp3, dtmp4, 3);
    //            report.ShowPreviewDialog();
    //        }
    //        if (socau > 60)
    //        {
               
    //    //        dtmp1 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = vitri4 - 1; i > vitri1; i--)
    //            {
    //                dtmp1.Rows[i].Delete();
    //            }
    //            //for (int i = 0; i < dtmp1.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp1.Rows.Add(Convert.ToDateTime(dtmp1.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp1.Rows[i]["Họ tên"], dtmp1.Rows[i]["Lớp"], dtmp1.Rows[i]["diemtoida"], dtmp1.Rows[i]["Câu"], dtmp1.Rows[i]["Tên"], dtmp1.Rows[i]["diemtoida"], dtmp1.Rows[i]["maDe"], dtmp1.Rows[i]["ngayLam"]);
    //            //}
    //   //         dtmp2 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = vitri4 - 1 ; i >= vitri22; i--)
    //            {
    //                dtmp2.Rows[i].Delete();
    //            }
    //            for (int i = 0; i < vitri11; i++)
    //            {
    //                dtmp2.Rows[0].Delete();
    //            }
    //            //for (int i = 0; i < dtmp2.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp2.Rows.Add(Convert.ToDateTime(dtmp2.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp2.Rows[i]["Họ tên"], dtmp2.Rows[i]["Lớp"], dtmp2.Rows[i]["diemtoida"], dtmp2.Rows[i]["Câu"], dtmp2.Rows[i]["Tên"], dtmp2.Rows[i]["diemtoida"], dtmp2.Rows[i]["maDe"], dtmp2.Rows[i]["ngayLam"]);
    //            //}
    ////            MessageBox.Show(hv.ToString());
    //  //          dtmp3 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = vitri4-1 ; i >= vitri33 ; i--)
    //            {
    //                dtmp3.Rows[i].Delete();
    //            }
    //            for (int i = 0; i < vitri2 ; i++)
    //            {
    //                dtmp3.Rows[0].Delete();
    //            }
    //            //for (int i = 0; i < dtmp3.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp3.Rows.Add(Convert.ToDateTime(dtmp3.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp3.Rows[i]["Họ tên"], dtmp3.Rows[i]["Lớp"], dtmp3.Rows[i]["diemtoida"], dtmp3.Rows[i]["Câu"], dtmp3.Rows[i]["Tên"], dtmp3.Rows[i]["diemtoida"], dtmp3.Rows[i]["maDe"], dtmp3.Rows[i]["ngayLam"]);
    //            //}
    //  //          dtmp4 = dt4.GetData(Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToInt32(lkPhep.EditValue.ToString()));
    //            for (int i = 0; i < vitri3; i++)
    //            {
    //                dtmp4.Rows[0].Delete();
    //            }
    //            //for (int i = 0; i < dtmp4.Rows.Count; i++)
    //            //{// id   Họ tên // Lớp // Điểm  // Câu // Tên // diemToiDa // maDe // ngayLam
    //            //    dtmp4.Rows.Add(Convert.ToDateTime(dtmp4.Rows[i]["ngayLam"].ToString()).Ticks / 1000000000 + 9, dtmp4.Rows[i]["Họ tên"], dtmp4.Rows[i]["Lớp"], dtmp4.Rows[i]["diemtoida"], dtmp4.Rows[i]["Câu"], dtmp4.Rows[i]["Tên"], dtmp4.Rows[i]["diemtoida"], dtmp4.Rows[i]["maDe"], dtmp4.Rows[i]["ngayLam"]);
    //            //}
    //            boiduongLeQuyDon.GUI.Report.GetTheoHV report = new boiduongLeQuyDon.GUI.Report.GetTheoHV(dtmp1, lkLop.EditValue.ToString(), lkLop.Text, lkPhep.Text, Convert.ToInt32(lkPhep.EditValue.ToString()), dtmp2, dtmp3, dtmp4, 4);
    //            report.ShowPreviewDialog();
    //        }
          

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string path = "";
         //   DataTable dt = new DataTable();
            DataTable dtde = new DataTable();
          //  coSoBoiDuongDataSetTableAdapters.deTableAdapter de=new coSoBoiDuongDataSetTableAdapters.deTableAdapter();
            dtde = getde11.GetData(int.Parse(lkdotkiemtra.EditValue.ToString()));
            SaveFileDialog savaFileDialog1 = new SaveFileDialog();
            dt = getketqua21.GetData(Convert.ToInt32(lkLop.EditValue.ToString()));
            savaFileDialog1.FileName = "";
            savaFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (savaFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = savaFileDialog1.FileName;
            }
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            ((Excel.Range)wcel.Cells[2, 1]).Value2 = "STT";
            ((Excel.Range)wcel.Cells[2, 2]).Value2 = "idhocvien";
            ((Excel.Range)wcel.Cells[2, 3]).Value2 = "idlop";
            ((Excel.Range)wcel.Cells[2, 4]).Value2 = "Họ tên";
            ((Excel.Range)wcel.Cells[2, 5]).Value2 = "Lớp";
      //      wcel.Cells[3, 1].Font.Bold = true;
            Excel.Range formatRange;
            formatRange = wcel.get_Range("a2:a70");
            formatRange.EntireRow.NumberFormat = "General";
            ((Excel.Range)wcel.Cells[3, 1]).Value2 = dtde.Rows[0]["IDde"].ToString();
            ((Excel.Range)wcel.Cells[1, 2]).Value2 = dtde.Rows[0]["Mã đề"].ToString();
            for (int i = 0; i < dtde.Rows.Count; i++)
            {
                ((Excel.Range)wcel.Cells[3, i + 6]).Value2 = dtde.Rows[i]["ID"].ToString();
                ((Excel.Range)wcel.Cells[2, i + 6]).Value2 = dtde.Rows[i]["Câu"].ToString();
                ((Excel.Range)wcel.Cells[4, i + 6]).Value2 = dtde.Rows[i]["Điểm tối đa"].ToString();
            }
            ////      wcel.Cells[2, 1].Font.Bold = true;
            //wcel.Cells[3, 2].Font.Bold = true;
            //wcel.Cells[3, 3].Font.Bold = true;
            //wcel.Cells[3, 4].Font.Bold = true;
            //wcel.Cells[3, 5].Font.Bold = true;
            //wcel.Cells[3, 6].Font.Bold = true;
            //wcel.Cells[3, 7].Font.Bold = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ((Excel.Range)wcel.Cells[i + 5, 1]).Value2 = i + 1;
                ((Excel.Range)wcel.Cells[i + 5, 2]).Value2 = dt.Rows[i]["id"].ToString();
                ((Excel.Range)wcel.Cells[i + 5, 3]).Value2 = dt.Rows[i]["idLop"].ToString();
                ((Excel.Range)wcel.Cells[i + 5, 4]).Value2 = dt.Rows[i]["Họ tên"].ToString();
                ((Excel.Range)wcel.Cells[i + 5, 5]).Value2 = dt.Rows[i]["Lớp"].ToString();
            }
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();
            MessageBox.Show("Xuất file thành công");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            readExcel();
            
      //      MessageBox.Show(dtdocde.Rows.Count.ToString());
     //       MessageBox.Show(dtdocde.Columns.Count.ToString());
            //     MessageBox.Show(dt1.Rows.Count.ToString());
            string trung = "";
   //         MessageBox.Show(dtdocde.Rows[3][1].ToString()); // 218 but 108
   //         MessageBox.Show(dtdocde.Rows[0][0].ToString()); //167 but ''
   //         MessageBox.Show(dtdocde.Rows[3][2].ToString()); //
    //        MessageBox.Show(dtdocde.Rows[0][5].ToString());
    //        MessageBox.Show(dtdocde.Rows[0][0].ToString());
  //          MessageBox.Show(dtdocde.Rows[3][0].ToString());
            
            for (int i = 3; i < dtdocde.Rows.Count; i++)
            {
                   try
                    {
                      trung =  getketqua11.GetData(int.Parse(dtdocde.Rows[i][1].ToString()), int.Parse(dtdocde.Rows[1][0].ToString())).Rows[0]["kq"].ToString();
                    }
                    catch
                   {
                        trung = "";
                    }
                    try
                    {
                    if( trung == "1")
                        queries.deleteKetQua1(int.Parse(dtdocde.Rows[1][0].ToString()), int.Parse(dtdocde.Rows[i][1].ToString()));
                    for (int j = 5; j < dtdocde.Columns.Count; j++)
                       {                                    
                           queries.InsertKetQua(int.Parse(dtdocde.Rows[i][1].ToString()), int.Parse(dtdocde.Rows[i][2].ToString()), int.Parse(dtdocde.Rows[1][j].ToString()), double.Parse(dtdocde.Rows[i][j].ToString()));
                        // tt.InsertQuery(Convert.ToInt32(dtdocde.Rows[i]["idhocvien"].ToString()), Convert.ToInt32(dt1.Rows[i]["idlop"].ToString()), dt1.Rows[i]["Tên giáo viên"].ToString(), dt1.Rows[i]["Nhận xét"].ToString());
                        }
                    }
                    catch
                    {
                    }                
            }
            MessageBox.Show("Đã import thành công");
        }
        DataTable dtdocde = new DataTable();
        private void readExcel()
        {
            string path = "";
            OpenFileDialog op = new OpenFileDialog();
            OleDbDataAdapter da1 = new OleDbDataAdapter();
           
            op.FileName = "";
            op.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
            }
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path + "; Extended Properties=Excel 12.0 Xml;";
            OleDbConnection ole = new OleDbConnection(connectionString);
            try
            {
                ole.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * from [SHEET1$]", ole);
                da1.SelectCommand = cmd;
                da1.Fill(dtdocde);
            }
            catch
            { }
            finally
            {
                ole.Close();
            }
        }
    }
}
