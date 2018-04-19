using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALGiaoVien
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID, [Họ tên lót] , [Tên],[Địa chỉ],[Số điện thoại],[Email],[Vị trí] ,[Mức lương],[userName], [Giới tính],[Ghi chú] FROM nhanVien WHERE ID <> 1", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getpq()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,[Họ tên lót] + ' ' + [Tên] AS [Họ tên],IIF(NV=1,'x','') as [Nhân viên],IiF(HV=1,'x','') as [Học viên],IiF(KQ=1,'x','') as [Kết quả],IiF(PQ=1,'x','') as [Phân quyền] FROM nhanVien where ID<>1", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getpq(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,[Họ tên lót] + ' ' + [Tên] AS [Họ tên],IIF(NV=1,'x','') as [Nhân viên],IiF(HV=1,'x','') as [Học viên],IiF(KQ=1,'x','') as [Kết quả],IiF(PQ=1,'x','') as [Phân quyền] FROM nhanVien where ID<>1 AND ID=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get1()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID, [Họ tên lót] + ' ' + [Tên] AS [Họ tên],[Địa chỉ],[Số điện thoại],[Email],[Vị trí],[Ghi chú] FROM nhanVien WHERE ID <> 1", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet login(string a)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT passWord FROM nhanVien WHERE userName='"+a+"'", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int updatepq(string nv, string hv, string kq, string pq, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE nhanVien SET nv=" + nv + ", HV= " + hv + ",KQ=" + kq + ", PQ=" + pq + "  WHERE id=" + id, conn);
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
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID FROM nhanVien WHERE userName='" + a + "'", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string ho, string ten, string diachi, string sodienthoai, string email, string vitri, string gioitinh, string mucluong,string ghiChu,string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE nhanVien SET \"Họ tên lót\"='" + ho + "',\"Tên\"='" + ten + "',\"Địa chỉ\"='" + diachi + "',\"Ghi chú\"='" + ghiChu + "',\"Số điện thoại\"='" + sodienthoai + "', Email='"+email+"',\"Vị trí\"='"+vitri+"',\"Giới tính\"='"+gioitinh+"',\"Mức lương\"="+mucluong+"  WHERE ID=" + id, conn);
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
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE nhanVien SET \"Họ tên lót\"='" + ho + "',\"Tên\"='" + ten + "',\"Địa chỉ\"='" + diachi + "',\"Ghi chú\"='" + ghiChu + "',\"Số điện thoại\"='" + sodienthoai + "', Email='" + email + "',\"Vị trí\"='" + vitri + "',userName='" + uname + "',passWord='" + passwd + "',\"Giới tính\"='" + gioitinh + "',\"Mức lương\"=" + mucluong + "  WHERE ID=" + id, conn);
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
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO nhanVien(\"Họ tên lót\",\"Tên\", \"Địa chỉ\", \"Số điện thoại\", Email, \"Vị trí\", userName, passWord, \"Giới tính\", \"Mức lương\", \"Ghi chú\") values ('" + ho + "','" + ten + "','" + diachi + "','" + sodienthoai + "','" + email + "','" + vitri + "','" + uname + "','" + passwd + "','" + gioitinh + "'," + mucluong + ",'" + ghiChu +"')", conn);
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
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("DELETE FROM nhanVien WHERE id=" + id, conn);
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
