using System;
using System.Data;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraSplashScreen;
using Excel = Microsoft.Office.Interop.Excel;

namespace boiduongLeQuyDon.GUI
{
    public partial class exportHV : SplashScreen
    {
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        bdlqdDataSet1TableAdapters.getHocVien3TableAdapter gethocvien3 = new bdlqdDataSet1TableAdapters.getHocVien3TableAdapter();
        bdlqdDataSet1TableAdapters.getHocVien4TableAdapter gethocvien4 = new bdlqdDataSet1TableAdapters.getHocVien4TableAdapter();
        //coSoBoiDuongDataSetTableAdapters.hocVienTableAdapter da = new coSoBoiDuongDataSetTableAdapters.hocVienTableAdapter();
        public exportHV()
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
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        string path;
        DateTime tungay = Convert.ToDateTime("01/01/1990");
        DateTime denngay = Convert.ToDateTime("12/12/2100");
        DataTable dt = new DataTable();
        int lop = 0;
        private void bntExport_Click(object sender, EventArgs e)
        {
            if (dtFrom.Text != "")
                tungay = Convert.ToDateTime(dtFrom.Text);
            if (dtTo.Text != "")
                denngay = Convert.ToDateTime(dtTo.Text);
            try
            {
                lop = Convert.ToInt32(lkLop.EditValue.ToString());
            }
            catch { lop = 0; }
            if (lop == 0)
            {
             //   MessageBox.Show("!23");
                dt = gethocvien3.GetData(0, tungay, denngay);
             //   MessageBox.Show(dt.Rows.Count.ToString());
            }
            else
            {
                dt = gethocvien4.GetData(lop, tungay, denngay);
            }
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            wcel.Range[wcel.Cells[1, 1], wcel.Cells[1, 10]].Merge();
            if(lop!=0)
            ((Excel.Range)wcel.Cells[1, 1]).Value2 = "Danh sách học viên đăng ký từ ngày " + tungay.ToShortDateString() +" đến ngày " + denngay.ToShortDateString() + " cuẩ lớp " + lkLop.Text;
            else
                ((Excel.Range)wcel.Cells[1, 1]).Value2 = "Danh sách học viên đăng ký từ ngày " + tungay.ToShortDateString() + " đến ngày " + denngay.ToShortDateString() ;

            ((Excel.Range)wcel.Cells[2, 1]).Value2 = "STT";
            ((Excel.Range)wcel.Cells[2, 2]).Value2 = "Họ tên lót";
            ((Excel.Range)wcel.Cells[2, 3]).Value2 = "Tên";
            ((Excel.Range)wcel.Cells[2, 4]).Value2 = "Trường";
            ((Excel.Range)wcel.Cells[2, 5]).Value2 = "Địa chỉ";
            ((Excel.Range)wcel.Cells[2, 6]).Value2 = "Email";
            ((Excel.Range)wcel.Cells[2, 7]).Value2 = "Điện thoại";
            ((Excel.Range)wcel.Cells[2, 8]).Value2 = "Ngày sinh";
            ((Excel.Range)wcel.Cells[2, 9]).Value2 = "Họ tên cha";
            ((Excel.Range)wcel.Cells[2, 10]).Value2 = "Điện thoại cha";
            ((Excel.Range)wcel.Cells[2, 11]).Value2 = "Nghề nghiệp cha";
            ((Excel.Range)wcel.Cells[2, 12]).Value2 = "Chức vụ cha";
            ((Excel.Range)wcel.Cells[2, 13]).Value2 = "Họ tên mẹ";
            ((Excel.Range)wcel.Cells[2, 14]).Value2 = "Điện thoại mẹ";
            ((Excel.Range)wcel.Cells[2, 15]).Value2 = "Nghề nghiệp mẹ";
            ((Excel.Range)wcel.Cells[2, 16]).Value2 = "Chức vụ mẹ";
            ((Excel.Range)wcel.Cells[2, 17]).Value2 = "Họ tên người nuôi dưỡng";
            ((Excel.Range)wcel.Cells[2, 18]).Value2 = "Điện thoại người nuôi dưỡng";
            ((Excel.Range)wcel.Cells[2, 19]).Value2 = "Email phụ huynh";
            ((Excel.Range)wcel.Cells[2, 20]).Value2 = "Ngày đăng ký";
            ((Excel.Range)wcel.Cells[2, 21]).Value2 = "Ghi chú";
            wcel.Cells[1, 1].Font.Bold = true;
            wcel.Cells[2, 1].Font.Bold = true;
            wcel.Cells[2, 2].Font.Bold = true;
            wcel.Cells[2, 3].Font.Bold = true;
            wcel.Cells[2, 4].Font.Bold = true;
            wcel.Cells[2, 5].Font.Bold = true;
            wcel.Cells[2, 6].Font.Bold = true;
            wcel.Cells[2, 7].Font.Bold = true;
            wcel.Cells[2, 8].Font.Bold = true;
            wcel.Cells[2, 9].Font.Bold = true;
            wcel.Cells[2, 10].Font.Bold = true;
            wcel.Cells[2, 11].Font.Bold = true;
            wcel.Cells[2, 12].Font.Bold = true;
            wcel.Cells[2, 13].Font.Bold = true;
            wcel.Cells[2, 14].Font.Bold = true;
            wcel.Cells[2, 15].Font.Bold = true;
            wcel.Cells[2, 16].Font.Bold = true;
            wcel.Cells[2, 17].Font.Bold = true;
            wcel.Cells[2, 18].Font.Bold = true;
            wcel.Cells[2, 19].Font.Bold = true;
            wcel.Cells[2, 20].Font.Bold = true;
            wcel.Cells[2, 21].Font.Bold = true;
        //    MessageBox.Show(dt.Rows.Count.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                ((Excel.Range)wcel.Cells[i + 3, 1]).Value2 = i + 1;
                ((Excel.Range)wcel.Cells[i + 3, 2]).Value2 = dt.Rows[i]["Họ tên lót"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 3]).Value2 = dt.Rows[i]["Tên"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 4]).Value2 = dt.Rows[i]["Trường"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 5]).Value2 = dt.Rows[i]["Địa chỉ"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 6]).Value2 = dt.Rows[i]["Email"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 7]).Value2 = dt.Rows[i]["Điện thoại"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 8]).Value2 = dt.Rows[i]["Ngày sinh"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 9]).Value2 = dt.Rows[i]["hoTenCha"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 10]).Value2 = dt.Rows[i]["dienThoaiCha"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 11]).Value2 = dt.Rows[i]["NgheNghiepCha"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 12]).Value2 = dt.Rows[i]["chucVuCha"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 13]).Value2 = dt.Rows[i]["hoTenMe"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 14]).Value2 = dt.Rows[i]["dienThoaiMe"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 15]).Value2 = dt.Rows[i]["ngheNghiepMe"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 16]).Value2 = dt.Rows[i]["chucVuMe"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 17]).Value2 = dt.Rows[i]["tenNguoiNuoiDuong"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 18]).Value2 = dt.Rows[i]["dienThoaiNguoiNuoiDuong"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 19]).Value2 = dt.Rows[i]["emailPhuHuynh"].ToString();
                ((Excel.Range)wcel.Cells[i + 3, 20]).Value2 = Convert.ToDateTime(dt.Rows[i]["ngayDK"].ToString()).ToShortDateString();
                ((Excel.Range)wcel.Cells[i + 3, 21]).Value2 = dt.Rows[i]["Ghi chú"].ToString();
               
            }
            wcel.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();
            this.Close();
        }

        private void exportHV_Load(object sender, EventArgs e)
        {
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
        }

        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {
            this.Close();
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