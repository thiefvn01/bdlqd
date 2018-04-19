using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Excel = Microsoft.Office.Interop.Excel;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class exportVang : SplashScreen
    {
        public exportVang()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        coSoBoiDuongDataSetTableAdapters.LopTableAdapter loptb = new coSoBoiDuongDataSetTableAdapters.LopTableAdapter();
        DataTable dtlop = new DataTable();
        coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter diemdanh = new coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        string path;
        string idhocvien;
        string cophep, khongphep, tre, lopgoc;
        private void bntExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            //cont
            string[,] a = new string[30, 5];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                    a[i, j] = "";
            }
            DataTable tbtmp = new DataTable();
            
            tbtmp = diemdanh.GetDataBy3(Convert.ToInt32(lkLop.EditValue.ToString()));
            for (int z = 0; z < tbtmp.Rows.Count; z++)
            {
                idhocvien = tbtmp.Rows[z]["ID"].ToString();
                cophep = "";
                khongphep = "";
                tre = "";
                dtlop = loptb.getlopgoc(Convert.ToInt32(idhocvien), Convert.ToInt32(lkLop.EditValue.ToString()));
                lopgoc = dtlop.Rows[0]["lopGoc"].ToString();
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
                a[z, 0] = tbtmp.Rows[z]["Họ tên"].ToString(); ;
                a[z, 1] = cophep;
                a[z, 2] = khongphep;
                a[z, 3] = tre;
            }


            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            wcel.Range[wcel.Cells[1, 1], wcel.Cells[1, 10]].Merge();
            ((Excel.Range)wcel.Cells[1, 1]).Value2 = "Tình hình chuyên cần của lớp " + lkLop.Text;
            ((Excel.Range)wcel.Cells[2, 1]).Value2 = "STT";
            ((Excel.Range)wcel.Cells[2, 2]).Value2 = "Họ và tên";
            ((Excel.Range)wcel.Cells[2, 3]).Value2 = "Có phép";
            ((Excel.Range)wcel.Cells[2, 4]).Value2 = "Không phép";
            ((Excel.Range)wcel.Cells[2, 5]).Value2 = "Trễ";
            for (int i = 0; i < tbtmp.Rows.Count; i++)
            {
                ((Excel.Range)wcel.Cells[i + 3, 1]).Value2 = i + 1;
                ((Excel.Range)wcel.Cells[i + 3, 2]).Value2 = a[i, 0];
                ((Excel.Range)wcel.Cells[i + 3, 3]).Value2 = a[i, 1];
                ((Excel.Range)wcel.Cells[i + 3, 4]).Value2 = a[i, 2];
                ((Excel.Range)wcel.Cells[i + 3, 5]).Value2 = a[i, 3];
            }
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

        private void labelControl5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void exportVang_Load(object sender, EventArgs e)
        {
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
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
    }
}