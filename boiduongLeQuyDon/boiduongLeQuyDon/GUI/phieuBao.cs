using System;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraReports.UI;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
namespace boiduongLeQuyDon.GUI
{
    public partial class phieuBao : DevExpress.XtraEditors.XtraUserControl
    {
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSHocVien hv = new BUSHocVien();
        public phieuBao()
        {
            InitializeComponent();
        }
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        bdlqdDataSet1TableAdapters.getKetQua21TableAdapter ketqua21 = new bdlqdDataSet1TableAdapters.getKetQua21TableAdapter();
        bdlqdDataSet1TableAdapters.getThongTinPhieuBaoTableAdapter ttphieubao = new bdlqdDataSet1TableAdapters.getThongTinPhieuBaoTableAdapter();
      //  coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter da = new coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter();
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
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                queries.insertPhieuBao(Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()), txtnx1.Text, txtnx2.Text, txtnx3.Text, txtnx4.Text);
            }
            catch
            {
            }
            Report.phieuBaoHocTap rp = new Report.phieuBaoHocTap(lkPhep.Text, lkPhep.EditValue.ToString(), lkLop.EditValue.ToString(),lkLop.Text, txtnx1.Text,txtnx2.Text,txtnx3.Text, txtnx4.Text, lkKhoa.EditValue.ToString(), Convert.ToDateTime(dtFrom.Text), Convert.ToDateTime(dtTo.Text));
            rp.ShowPreview();
        }

        private void phieuBao_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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
        DataTable dt = new DataTable();
        SaveFileDialog savaFileDialog1 = new SaveFileDialog();
        private void btxExport_Click(object sender, EventArgs e)
        {

            dt = ketqua21.GetData(Convert.ToInt32(lkLop.EditValue.ToString()));
            savaFileDialog1.FileName = "";
            savaFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.savaFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = savaFileDialog1.FileName;
            }
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook wbExcel = appExcel.Workbooks.Add(Type.Missing);
            Excel.Worksheet wcel = (Excel.Worksheet)wbExcel.Worksheets[1];
            ((Excel.Range)wcel.Cells[1, 1]).Value2 = "STT";
            ((Excel.Range)wcel.Cells[1, 2]).Value2 = "idhocvien";
            ((Excel.Range)wcel.Cells[1, 3]).Value2 = "idlop";
            ((Excel.Range)wcel.Cells[1, 4]).Value2 = "Họ tên";
            ((Excel.Range)wcel.Cells[1, 5]).Value2 = "Lớp";
            ((Excel.Range)wcel.Cells[1, 6]).Value2 = "Tên giáo viên";
            ((Excel.Range)wcel.Cells[1, 7]).Value2 = "Nhận xét 1";
            ((Excel.Range)wcel.Cells[1, 8]).Value2 = "Nhận xét 2";
            ((Excel.Range)wcel.Cells[1, 9]).Value2 = "Nhận xét 3";
            wcel.Cells[1, 1].Font.Bold = true;
      //      wcel.Cells[2, 1].Font.Bold = true;
            wcel.Cells[1, 2].Font.Bold = true;
            wcel.Cells[1, 3].Font.Bold = true;
            wcel.Cells[1, 4].Font.Bold = true;
            wcel.Cells[1, 5].Font.Bold = true;
            wcel.Cells[1, 6].Font.Bold = true;
            wcel.Cells[1, 7].Font.Bold = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ((Excel.Range)wcel.Cells[i + 2, 1]).Value2 = i + 1;
                ((Excel.Range)wcel.Cells[i + 2, 2]).Value2 = dt.Rows[i]["id"].ToString();
                ((Excel.Range)wcel.Cells[i + 2, 3]).Value2 = dt.Rows[i]["idLop"].ToString();
                ((Excel.Range)wcel.Cells[i + 2, 4]).Value2 = dt.Rows[i]["Họ tên"].ToString();
                ((Excel.Range)wcel.Cells[i + 2, 5]).Value2 = dt.Rows[i]["Lớp"].ToString();
            }
            wbExcel.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); appExcel.Quit();
            MessageBox.Show("Xuất file thành công");
        }
       
        string path;
        OpenFileDialog op = new OpenFileDialog();
     //   coSoBoiDuongDataSetTableAdapters.ttphieubaoTableAdapter tt = new coSoBoiDuongDataSetTableAdapters.ttphieubaoTableAdapter();
        private void bntImp_Click(object sender, EventArgs e)
        {
            readExcel();
       //     MessageBox.Show(dt1.Rows.Count.ToString());
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                try
                {
                   
                    queries.insertPhieuBao(Convert.ToInt32(dt1.Rows[i]["idhocvien"].ToString()), Convert.ToInt32(dt1.Rows[i]["idlop"].ToString()), dt1.Rows[i]["Tên giáo viên"].ToString(), dt1.Rows[i]["Nhận xét 1"].ToString(), dt1.Rows[i]["Nhận xét 2"].ToString(), dt1.Rows[i]["Nhận xét 3"].ToString());
                }
                catch
                {
                }
            }
            MessageBox.Show("Đã import thành công");
        }
        OleDbDataAdapter da1 = new OleDbDataAdapter();
        DataTable dt1 = new DataTable();
        private void readExcel()
        {
            op.FileName = "";
            op.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (this.op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
            }
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + this.path + "; Extended Properties=Excel 12.0 Xml;";
            OleDbConnection ole = new OleDbConnection(connectionString);
            try
            {
                ole.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * from [SHEET1$]", ole);
                this.da1.SelectCommand = cmd;
                this.da1.Fill(dt1);
            }
            catch
            { }
            finally
            {
                ole.Close();
            }
        }
        DataTable dt2 = new DataTable();
        private void lkPhep_EditValueChanged(object sender, EventArgs e)
        {
           try{
           dt2= ttphieubao.GetData(Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToInt32(lkLop.EditValue.ToString()));
           txtnx1.Text = dt2.Rows[0]["giaovien"].ToString();
           txtnx2.Text = dt2.Rows[0]["nhanxet"].ToString();
}
catch {}
        }
    }
}
