using System;
using boiduongLeQuyDon.BUS;
using System.Data;
namespace boiduongLeQuyDon.GUI.Report
{
    public partial class SoDauBai : DevExpress.XtraReports.UI.XtraReport
    {
        BUSChiTietTKB bus = new BUSChiTietTKB();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        public SoDauBai(string lop, string tenlop, string idtkb,string ngay, string ca1, string ca2, string ca3,string ca4)
        {
            InitializeComponent();
            this.lop = lop;
            this.hocVienAdapter1.GetData(lop);
            this.tenlop = tenlop;
            this.idtkb = idtkb;
            this.ngay = ngay;
       //     this.ngay1 = ngay1;
         //   this.ngay2 = ngay2;
        //    this.ngay3 = ngay3;
            this.ca1 = ca1;
            this.ca2 = ca2;
            this.ca3 = ca3;
            this.ca4 = ca4;
        //    this.ngay4 = ngay4;
       //     this.gv1 = gv1;
      //      this.gv2 = gv2;
//this.gv3 = gv3;
            load();
       //     XtraMessageBox.Show(t1.WidthF.ToString() + "A " + t2.WidthF.ToString() + "Q" +t3.WidthF.ToString());
        }

        string lop, tenlop, idtkb, ngay, ca1, ca2, ca3, ca4;
        private void load()
        {
            DateTime dtNow = System.DateTime.Parse(ngay);
            int nowdayofweek = Convert.ToInt32(dtNow.DayOfWeek) ;
            DateTime weekStartDate = DateTime.MinValue;
            DateTime weekEndDate = DateTime.MinValue;
            //get the first day of the week
            weekStartDate = dtNow.AddDays(0 - nowdayofweek+1);
            weekEndDate = dtNow.AddDays(7 - nowdayofweek);
            //get the last day of the week
            string ngaybd = tkb.get(idtkb).Tables[0].Rows[0]["Khai giảng"].ToString();
            DateTime bd = System.DateTime.Parse(ngaybd);
            int tuan = Convert.ToInt32((weekEndDate-Convert.ToDateTime(bd)).TotalDays / 7);
            xrLabel3.Text = "TUẦN "+tuan+" (" + weekStartDate.ToShortDateString() + " - " + weekEndDate.ToShortDateString() + ")";
            string giangvien = bus.getgv(lop).Tables[0].Rows[0]["Giáo viên"].ToString();
            ///

            if (giangvien.Contains("-"))
            {
                int ind = giangvien.IndexOf('-');

              //  tgv1.Text = giangvien.Substring(0, giangvien.Length - ind - 2);
                string tmp;
                
                tmp = giangvien.Substring(ind+1, giangvien.Length-ind-1);
               
                if (tmp.Contains("-"))
                {
                    int ind2 = tmp.IndexOf('-');
                    tgv1.Text = giangvien.Substring(0, ind);
                 //   tgv1.Text = ind.ToString();
                 //   tgv2.Text = ind2.ToString();
                    tgv2.Text = tmp.Substring(0, ind2);
                    tmp = tmp.Substring(ind2+1, tmp.Length - ind2-1);
                 //   tmp = tmp;
                    
                    tgv3.Text = tmp;
                }
                else
                {
                    tgv1.Text = giangvien.Substring(0,ind);
                    tgv2.Text = tmp;
                }
                
            }
            else
            {
                tgv1.Text = giangvien;
            }
            
        //    catch { }
            //tgv1.Text = gv1;
            //tgv2.Text = gv2;
            //tgv3.Text = gv3;
            DataSet ds = new DataSet();
           ds= bus.getgv(lop);
           lp.Text = "LỚP: "+tenlop;
       //    string tmp;
         //  tmp = ds.Tables[0].Rows[0]["Thứ"].ToString();
          // int a1 = 0;
       //    thu1.Text = ngay1;
      //     thu2.Text = ngay2;
      //     thu3.Text = ngay3;
     //      thu4.Text = ngay4;
           cat1.Text = ca1;
           cat2.Text = ca2;
           cat3.Text = ca3;
              cat4.Text = ca4;

              //if (ngay2.Trim() == "")
              //{
              //    t2.Visible = false;
              //    t21.Visible = false;
              //    t22.Visible = false;
              //    t23.Visible = false;
              //    t24.Visible = false;
              //    t25.Visible = false;
              //    t26.Visible = false;
              //    t27.Visible = false;
              //    t28.Visible = false;
              //    t29.Visible = false;
              //    t30.Visible = false;
              //    t3.Visible = false;
              //    t31.Visible = false;
              //    t32.Visible = false;
              //    t33.Visible = false;
              //    t34.Visible = false;
              //    t35.Visible = false;
              //    t36.Visible = false;
              //    t37.Visible = false;
              //    t38.Visible = false;
              //    t39.Visible = false;
              //    t40.Visible = false;
              //    t4.Visible = false;
              //    t41.Visible = false;
              //    t42.Visible = false;
              //    t43.Visible = false;
              //    t44.Visible = false;
              //    t45.Visible = false;
              //    t46.Visible = false;
              //    t47.Visible = false;
              //    t48.Visible = false;
              //    t49.Visible = false;
              //    t50.Visible = false;


              //    //t1.WidthF = 464;
              //    //t11.WidthF = 464;
              //    //t12.WidthF = 464;
              //    //t13.WidthF = 464;
              //    //t14.WidthF = 464;
              //    //t15.WidthF = 464;
              //    //t16.WidthF = 464;
              //    //t17.WidthF = 464;
              //    //t18.WidthF = 464;
              //    //t19.WidthF = 464;
              //    //t20.WidthF = 464;
              //}
              ////if (ngay3.Trim() == "")
              ////{
              ////    t3.Visible = false;
              ////    t31.Visible = false;
              ////    t32.Visible = false;
              ////    t33.Visible = false;
              ////    t34.Visible = false;
              ////    t35.Visible = false;
              ////    t36.Visible = false;
              ////    t37.Visible = false;
              ////    t38.Visible = false;
              ////    t39.Visible = false;
              ////    t40.Visible = false;
              ////    t4.Visible = false;
              ////    t41.Visible = false;
              ////    t42.Visible = false;
              ////    t43.Visible = false;
              ////    t44.Visible = false;
              ////    t45.Visible = false;
              ////    t46.Visible = false;
              ////    t47.Visible = false;
              ////    t48.Visible = false;
              ////    t49.Visible = false;
              ////    t50.Visible = false;

              ////    //t2.WidthF = 232;
              ////    //t21.WidthF = 232;
              ////    //t22.WidthF = 232;
              ////    //t23.WidthF = 232;
              ////    //t24.WidthF = 232;
              ////    //t25.WidthF = 232;
              ////    //t26.WidthF = 232;
              ////    //t27.WidthF = 232;
              ////    //t28.WidthF = 232;
              ////    //t29.WidthF = 232;
              ////    //t30.WidthF = 232;
              ////    //t1.WidthF = 232;
              ////    //t11.WidthF = 232;
              ////    //t12.WidthF = 232;
              ////    //t13.WidthF = 232;
              ////    //t14.WidthF = 232;
              ////    //t15.WidthF = 232;
              ////    //t16.WidthF = 232;
              ////    //t17.WidthF = 232;
              ////    //t18.WidthF = 232;
              ////    //t19.WidthF = 232;
              ////    //t20.WidthF = 232;

              ////}
        
           //if (ngay3.Trim() == "")
           //{
           //    t3.Visible = false;
           //    t31.Visible = false;
           //    t32.Visible = false;
           //    t33.Visible = false;
           //    t34.Visible = false;
           //    t35.Visible = false;
           //    t36.Visible = false;
           //    t37.Visible = false;
           //    t38.Visible = false;
           //    t39.Visible = false;
           //    t40.Visible = false;
           //    t4.Visible = false;
           //    t41.Visible = false;
           //    t42.Visible = false;
           //    t43.Visible = false;
           //    t44.Visible = false;
           //    t45.Visible = false;
           //    t46.Visible = false;
           //    t47.Visible = false;
           //    t48.Visible = false;
           //    t49.Visible = false;
           //    t50.Visible = false;
               
           //    //t2.WidthF = 232;
           //    //t21.WidthF = 232;
           //    //t22.WidthF = 232;
           //    //t23.WidthF = 232;
           //    //t24.WidthF = 232;
           //    //t25.WidthF = 232;
           //    //t26.WidthF = 232;
           //    //t27.WidthF = 232;
           //    //t28.WidthF = 232;
           //    //t29.WidthF = 232;
           //    //t30.WidthF = 232;
           //    //t1.WidthF = 232;
           //    //t11.WidthF = 232;
           //    //t12.WidthF = 232;
           //    //t13.WidthF = 232;
           //    //t14.WidthF = 232;
           //    //t15.WidthF = 232;
           //    //t16.WidthF = 232;
           //    //t17.WidthF = 232;
           //    //t18.WidthF = 232;
           //    //t19.WidthF = 232;
           //    //t20.WidthF = 232;

           //}
            thu1.Text="";
            thu2.Text="";
            thu3.Text="";
            thu4.Text="";
         ////  string t1 = "";
          //  string t2="";
         //   string t3="";
            int a1=0;
            string tmp1="";
            tmp1=bus.getgv(lop).Tables[0].Rows[0]["Thứ"].ToString();
            for (int i = 0; i < tmp1.Length; i++)
            {
                switch (tmp1.Substring(i, 1).ToLower())
                {
                    case "2":
                        if (a1 == 0)
                        {
                            thu1.Text = "THỨ 2";

                        }
                        if (a1 == 1)
                        {
                            thu2.Text = "THỨ 2";

                        }
                        if (a1 == 2)
                        {
                            thu3.Text = "THỨ 2";

                        }
                        if (a1 == 3)
                        {
                            thu4.Text = "THỨ 2";

                        }
                        a1++;
                        break;
                    case "3":
                        if (a1 == 0)
                        {
                            thu1.Text = "THỨ 3";

                        }
                        if (a1 == 1)
                        {
                            thu2.Text = "THỨ 3";

                        }
                        if (a1 == 2)
                        {
                            thu3.Text = "THỨ 3";
                        }
                        if (a1 == 3)
                        {
                            thu4.Text = "THỨ 3";

                        }
                        a1++;
                        break;
                    case "4":
                        if (a1 == 0)
                        {
                            thu1.Text = "THỨ 4";

                        }
                        if (a1 == 1)
                        {
                            thu2.Text = "THỨ 4";

                        }
                        if (a1 == 2)
                        {
                            thu3.Text = "THỨ 4";

                        }
                        if (a1 == 3)
                        {
                            thu4.Text = "THỨ 4";

                        }
                        a1++;
                        break;
                    case "5":
                        if (a1 == 0)
                        {
                            thu1.Text = "THỨ 5";

                        }
                        if (a1 == 1)
                        {
                            thu2.Text = "THỨ 5";

                        }
                        if (a1 == 2)
                        {
                            thu3.Text = "THỨ 5";

                        }
                        if (a1 == 3)
                        {
                            thu4.Text = "THỨ 5";

                        }
                        a1++;
                        break;
                    case "6":
                        if (a1 == 0)
                        {
                            thu1.Text = "THỨ 6";

                        }
                        if (a1 == 1)
                        {
                            thu2.Text = "THỨ 6";

                        }
                        if (a1 == 2)
                        {
                            thu3.Text = "THỨ 6";

                        }
                        if (a1 == 3)
                        {
                            thu4.Text = "THỨ 6";

                        }
                        a1++;
                        break;
                    case "7":
                        if (a1 == 0)
                        {
                            thu1.Text = "THỨ 7";

                        }
                        if (a1 == 1)
                        {
                            thu2.Text = "THỨ 7";

                        }
                        if (a1 == 2)
                        {
                            thu3.Text = "THỨ 7";

                        }
                        if (a1 == 3)
                        {
                            thu4.Text = "THỨ 7";

                        }
                        a1++;
                        break;
                    case "c":
                        if (a1 == 0)
                        {
                            thu1.Text = "CN";

                        }
                        if (a1 == 1)
                        {
                            thu2.Text = "CN";

                        }
                        if (a1 == 2)
                        {
                            thu3.Text = "CN";

                        }
                        if (a1 == 3)
                        {
                            thu4.Text = "CN";
                        }
                        a1++;
                        break;
                    default:
                        break;

                }
            }
                 if (thu4.Text.Trim() == "" &&thu3.Text.Trim()!="" && thu2.Text.Trim()!="")
           {
             //  XtraMessageBox.Show("4");
               t4.Visible = false;
               t41.Visible = false;
               t42.Visible = false;
               t43.Visible = false;
               t44.Visible = false;
               t45.Visible = false;
               t46.Visible = false;
               t47.Visible = false;
               t48.Visible = false;
               t49.Visible = false;
               t50.Visible = false;
               t4444.Visible = false;
               //t3.WidthF = 154;
               //t31.WidthF = 154;
               //t32.WidthF = 154;
               //t33.WidthF = 154;
               //t34.WidthF = 154;
               //t35.WidthF = 154;
               //t36.WidthF = 154;
               //t37.WidthF = 154;
               //t38.WidthF = 154;
               //t39.WidthF = 154;
               //t40.WidthF = 154;
               //t2.WidthF = 154;
               //t21.WidthF = 155;
               //t22.WidthF = 155;
               //t23.WidthF = 155;
               //t24.WidthF = 155;
               //t25.WidthF = 155;
               //t26.WidthF = 155;
               //t27.WidthF = 155;
               //t28.WidthF = 155;
               //t29.WidthF = 155;
               //t30.WidthF = 155;
               //t1.WidthF = 154;
               //t11.WidthF = 154;
               //t12.WidthF = 154;
               //t13.WidthF = 154;
               //t14.WidthF = 154;
               //t15.WidthF = 154;
               //t16.WidthF = 154;
               //t17.WidthF = 154;
               //t18.WidthF = 154;
               //t19.WidthF = 154;
               //t20.WidthF = 154;
           }
           else if (thu3.Text.Trim() == "" && thu2.Text.Trim()!="")
           {
               //XtraMessageBox.Show("3");
               t3.Visible = false;
               t31.Visible = false;
               t32.Visible = false;
               t33.Visible = false;
               t34.Visible = false;
               t35.Visible = false;
               t36.Visible = false;
               t37.Visible = false;
               t38.Visible = false;
               t39.Visible = false;
               t40.Visible = false;
               t4.Visible = false;
               t41.Visible = false;
               t42.Visible = false;
               t43.Visible = false;
               t44.Visible = false;
               t45.Visible = false;
               t46.Visible = false;
               t47.Visible = false;
               t48.Visible = false;
               t49.Visible = false;
               t50.Visible = false;
               t333.Visible = false;
               t4444.Visible = false;
               //t1.WidthF = 232;
               //t11.WidthF = 232;
               //t12.WidthF = 232;
               //t13.WidthF = 232;
               //t14.WidthF = 232;
               //t15.WidthF = 232;
               //t16.WidthF = 232;
               //t17.WidthF = 232;
               //t18.WidthF = 232;
               //t19.WidthF = 232;
               //t20.WidthF = 232;
               //t2.WidthF = 233;
               //t21.WidthF = 233;
               //t22.WidthF = 233;
               //t23.WidthF = 233;
               //t24.WidthF = 233;
               //t25.WidthF = 233;
               //t26.WidthF = 233;
               //t27.WidthF = 233;
               //t28.WidthF = 233;
               //t29.WidthF = 233;
               //t30.WidthF = 233;
          //     XtraMessageBox.Show(t3.WidthF.ToString() +" " + t2.WidthF.ToString());

           }
           else if (thu2.Text.Trim() == "")
           {
              // XtraMessageBox.Show("2");
               t2.Visible = false;
               t21.Visible = false;
               t22.Visible = false;
               t23.Visible = false;
               t24.Visible = false;
               t25.Visible = false;
               t26.Visible = false;
               t27.Visible = false;
               t28.Visible = false;
               t29.Visible = false;
               t30.Visible = false;
               t3.Visible = false;
               t31.Visible = false;
               t32.Visible = false;
               t33.Visible = false;
               t34.Visible = false;
               t35.Visible = false;
               t36.Visible = false;
               t37.Visible = false;
               t38.Visible = false;
               t39.Visible = false;
               t40.Visible = false;
               t4.Visible = false;
               t41.Visible = false;
               t42.Visible = false;
               t43.Visible = false;
               t44.Visible = false;
               t45.Visible = false;
               t46.Visible = false;
               t47.Visible = false;
               t48.Visible = false;
               t49.Visible = false;
               t50.Visible = false;
               t222.Visible = false;
               t333.Visible = false;
               t4444.Visible = false;
               t1.WidthF = 464;
               t11.WidthF = 464;
               t12.WidthF = 464;
               t13.WidthF = 464;
               t14.WidthF = 464;
               t15.WidthF = 464;
               t16.WidthF = 464;
               t17.WidthF = 464;
               t18.WidthF = 464;
               t19.WidthF = 464;
               t20.WidthF = 464;
               t111.WidthF = 464;

           }
          // }
          // if (a1 == 2)
          // {
          //     t3.Visible = false;
          //     tb1.Visible = false;
          //     tb11.Visible = false;
          //     tb12.Visible = false;
          //     tb13.Visible = false;
          //     tb14.Visible = false;
          //     tb15.Visible = false;
              
          //  //   t1.WidthF = t1.WidthF + t3.WidthF / 2;
          ////     t2.WidthF = t2.WidthF + t3.WidthF / 2;
          // }
         
           //if (a1 == 1)
           //{
               
           ////    t1.WidthF = t1.WidthF + t2.WidthF + t3.WidthF;
           //}
           string tentkb = tkb.get(idtkb).Tables[0].Rows[0]["Tên TKB"].ToString().ToLower().Replace("thời khóa biểu","").ToUpper();
           string nh = tkb.get(idtkb).Tables[0].Rows[0]["Năm học"].ToString();
           xrLabel1.Text = tentkb.ToUpper() + " -  NĂM HỌC " + nh;
        }

        private void reportHeaderBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
