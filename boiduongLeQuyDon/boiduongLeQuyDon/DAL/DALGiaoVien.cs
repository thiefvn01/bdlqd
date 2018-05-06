using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALGiaoVien
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, hotenlot as [Họ tên lót] , ten as [Tên],diachi as [Địa chỉ], sodienthoai as[Số điện thoại],[Email], vitri as [Vị trí] ,[Mức lương],[userName], gioitinh as [Giới tính], ghichu as [Ghi chú] FROM nhanVien WHERE ID <> 1", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getpq()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,hotenlot + ' ' + ten AS [Họ tên],IIF(NV=1,'x','') as [Nhân viên],IiF(HV=1,'x','') as [Học viên],IiF(KQ=1,'x','') as [Kết quả],IiF(PQ=1,'x','') as [Phân quyền] FROM nhanVien where ID<>1", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getpq(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, hotenlot + ' ' + ten AS [Họ tên],IIF(NV=1,'x','') as [Nhân viên],IiF(HV=1,'x','') as [Học viên],IiF(KQ=1,'x','') as [Kết quả],IiF(PQ=1,'x','') as [Phân quyền] FROM nhanVien where ID<>1 AND ID=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get1()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, hotenlot + ' ' + ten AS [Họ tên],diachi as [Địa chỉ], sodienthoai as[Số điện thoại],[Email], vitri as [Vị trí], ghichu as [Ghi chú] FROM nhanVien WHERE ID <> 1", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet login(string a)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT passWord FROM nhanVien WHERE userName='"+a+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int updatepq(string nv, string hv, string kq, string pq, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE nhanVien SET nv=" + nv + ", HV= " + hv + ",KQ=" + kq + ", PQ=" + pq + "  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataSet login1(string a)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM nhanVien WHERE userName='" + a + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string ho, string ten, string diachi, string sodienthoai, string email, string vitri, string gioitinh, string mucluong,string ghiChu,string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE nhanVien SET \"Họ tên lót\"='" + ho + "',\"Tên\"='" + ten + "',\"Địa chỉ\"='" + diachi + "',\"Ghi chú\"='" + ghiChu + "',sodienthoai='" + sodienthoai + "', Email='"+email+"',vitri='"+vitri+"',gioitinh='"+gioitinh+"',\"Mức lương\"="+mucluong+"  WHERE ID=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updatepw(string ho, string ten, string diachi, string sodienthoai, string email, string vitri, string uname, string passwd, string gioitinh, string mucluong, string ghiChu, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE nhanVien SET hotenlot='" + ho + "',ten='" + ten + "',diachi='" + diachi + "',ghichu='" + ghiChu + "',sodienthoai='" + sodienthoai + "', Email='" + email + "',vitri='" + vitri + "',userName='" + uname + "',passWord='" + passwd + "',gioitinh='" + gioitinh + "',\"Mức lương\"=" + mucluong + "  WHERE ID=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string ho, string ten, string diachi, string sodienthoai, string email, string vitri, string uname, string passwd, string gioitinh, string mucluong, string ghiChu)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO nhanVien(\"Họ tên lót\",\"Tên\", \"Địa chỉ\", sodienthoai, Email, vitri, userName, passWord, gioitinh, \"Mức lương\", \"Ghi chú\") values ('" + ho + "','" + ten + "','" + diachi + "','" + sodienthoai + "','" + email + "','" + vitri + "','" + uname + "','" + passwd + "','" + gioitinh + "'," + mucluong + ",'" + ghiChu +"')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int delete(string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM nhanVien WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
