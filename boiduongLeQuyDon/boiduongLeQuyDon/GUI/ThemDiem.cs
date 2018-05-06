using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace boiduongLeQuyDon.GUI
{
    public partial class ThemDiem : SplashScreen
    {
 //       BUSKetQuaToan bus = new BUSKetQuaToan();
    //    coSoBoiDuongDataSetTableAdapters.deTableAdapter da = new coSoBoiDuongDataSetTableAdapters.deTableAdapter();
        DataTable dt = new DataTable();
        bdlqdDataSet1TableAdapters.getKetQua11TableAdapter ketqua11 = new bdlqdDataSet1TableAdapters.getKetQua11TableAdapter();
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
    //    coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter da = new coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter();
   //     coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter ka = new coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
        decimal maxdiem;
        public ThemDiem(DataTable ds, int idhocvien, int idlop, int made,string dang)
        {
            InitializeComponent();
         //   this.de = de;
       //     this.dang = ds.Rows[0]["dang"].ToString(); //them dạng đề vào database
            this.ds = ds;
            this.idhocvien = idhocvien;
            this.idlop = idlop;
            this.made = made;
            this.dang = dang;
         //   string a = "";
     
        }
        string nhomcau;
        string dang;
        int socau, idhocvien, idlop, made;
        int tmp;
        int flag=0;
        DataTable ds;
       // string mahocvien, made, ngaylam, lop, id;
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        double tongdiem=0;
        double dtn =0;
        double dlt =0;
        private void bntCN_Click(object sender, EventArgs e)
        {
            if (txtDiem.Text == "")
                txtDiem.Text = "0";
            if (Convert.ToDecimal(txtDiem.Text) > maxdiem)
            {
                txterr.Text = txterr.Text + "  (" + maxdiem + ")";
                txterr.Visible = true;
            }
            else
            {
                //  MessageBox.Show(lt.ToString() + " haha" + tn.ToString() + "tmp" + tmp.ToString());
                if (tmp < socau)
                {
                    queries.InsertKetQua(idhocvien, idlop, Convert.ToInt32(ds.Rows[tmp]["ID"].ToString()), Convert.ToDouble(txtDiem.Text));
                    tongdiem += Convert.ToDouble(txtDiem.Text);
                    if (nhomcau == "Đại số" || nhomcau == "Tự luận")
                    {
                        dtn += Convert.ToDouble(txtDiem.Text);
                        //MessageBox.Show( dtn.ToString());
                    }
                    if (nhomcau == "Hình học" || nhomcau == "Trắc nghiệm")
                    {
                        dlt += Convert.ToDouble(txtDiem.Text);
                        //        MessageBox.Show(dlt.ToString());
                    }
                    tmp++;
                    try
                    {
                        lblCau.Text = ds.Rows[tmp]["CauLon"].ToString() + " " + ds.Rows[tmp]["Câu"].ToString();
                        maxdiem = Convert.ToDecimal(ds.Rows[tmp]["diemToiDa"].ToString());
                        nhomcau = ds.Rows[tmp]["nhomCau"].ToString();
                    }
                    catch
                    {
                        //try
                        //{
                        ////    da.UpdateQuery1(made.ToString());
                        //}
                        //catch { }
                    }
                }
                if (tmp == socau)
                {
                    if (flag == 1)
                    {
                        queries.InsertKetQua(idhocvien, idlop, Convert.ToInt32(ds.Rows[0]["ID"].ToString()), tongdiem);
                        //  if (dang == "Đề toán")
                        {
                            queries.InsertKetQua(idhocvien, idlop, Convert.ToInt32(ds.Rows[1]["ID"].ToString()), dtn);
                            //     da.InsertQuery(idhocvien, idlop, Convert.ToInt32(ds.Rows[1]["ID"].ToString()), dlt, made);
                            queries.InsertKetQua(idhocvien, idlop, Convert.ToInt32(ds.Rows[2]["ID"].ToString()), dlt);
                        }

                        socau = socau - 3;
                    }
                    if (flag == 0)
                    {
                        queries.InsertKetQua(idhocvien, idlop, Convert.ToInt32(ds.Rows[0]["ID"].ToString()), tongdiem);
                        socau = socau - 1;
                    }
                    /*   */
                    if (flag == 2)
                    {
                //        da.InsertQuery(idhocvien, idlop, Convert.ToInt32(ds.Rows[0]["ID"].ToString()), Convert.ToDecimal(txtDiem.Text), made);
                    }
                    if (MessageBox.Show("Đã hoàn tất", "", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                        this.Close();
                }
                txterr.Visible = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemDiem_Load(object sender, EventArgs e)
        {
            try
            {
                if (ketqua11.GetData(idhocvien, made).Rows[0]["kq"].ToString() == "1")
                {
                    if (MessageBox.Show("Người này đã có điểm, điểm cũ sẽ bị xóa khỏi hệ thống?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        queries.deleteKetQua1(made, idhocvien);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                //else if (da.trungget(idhocvien, idlop, made).Rows[0][0].ToString() == "1" && da.trungget(idhocvien, idlop, made).Rows.Count < ds.Rows.Count)
                //{
                //    this.tmp = da.trungget(idhocvien, idlop, made).Rows.Count;
                //}
            }
            catch { }

            //   this.idbaitap = idbaitap;
            if (dang == "Đề toán")
            {
                tmp = 3;
                flag = 1;



                socau = ds.Rows.Count;
            }
            if (dang == "Đề cơ bản")
            {
                flag = 0;
                tmp = 1;

                socau = ds.Rows.Count;
            }

            if (dang == "Đề hỗn hợp  Trắc nghiệm/Tự luận")
            {
                tmp = 3;
                flag = 1;


                socau = ds.Rows.Count;
            }
            /*   */
            if (dang == "Đề 1 câu")
            {
                flag = 2;
                tmp = 0;

                socau = 1;
            }
            lblCau.Text = ds.Rows[tmp]["CauLon"].ToString() + " " + ds.Rows[tmp]["Câu"].ToString();
            maxdiem = Convert.ToDecimal(ds.Rows[tmp]["diemToiDa"].ToString());
            nhomcau = ds.Rows[tmp]["nhomCau"].ToString();
        }

    }
}