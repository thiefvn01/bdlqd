using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALChitietTKB
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,STT,monhoc as N'Môn học', lop as N'Lớp', giaovien as N'Giáo viên',thu as N'Thứ', thoigian as N'Thời gian', hocphi as N'Học phí' FROM ChiTietTKB WHERE idTKB>=(SELECT MAX(id) FROM ThoiKhoaBieu)", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(int a)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,lop as N'Lớp', giaovien as N'Giáo viên' FROM ChiTietTKB WHERE idTKB>=(SELECT MAX(id) FROM ThoiKhoaBieu)", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getgv(string lop)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT giaovien as 'Giáo viên',thu as [Thứ],lop as [Lớp],thoigian as [Thời gian] FROM ChiTietTKB WHERE ID="+lop+"", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, lop as N'Lớp',thu as  [Thứ],thoigian as [Thời gian] FROM ChiTietTKB WHERE idTKB=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet gettkb(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,STT,monhoc as N'Môn học', lop as N'Lớp', giaovien as N'Giáo viên',thu as N'Thứ', thoigian as N'Thời gian', hocphi as N'Học phí' FROM ChiTietTKB WHERE idTKB=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet gett(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT hocphi as N'Học phí' FROM ChiTietTKB WHERE ID=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getlop(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT lop as N'Lớp' FROM ChiTietTKB WHERE ID=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get2(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idTKB FROM ChiTietTKB WHERE id=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //public DataSet getlop(string id)
        //{
        //    SqlConnection conn = access.AccessData();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT id FROM ChiTietTKB WHERE lop=" + id, conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet dt = new DataSet();
        //    da.Fill(dt);
        //    conn.Close();
        //    return dt;
        //}
        public DataSet get1(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, monhoc as N'Môn học', lop as N'Lớp' FROM ChiTietTKB WHERE idTKB=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string stt, string monhoc, string lop, string giaovien, string thu, string thoigian, string hocphi,  string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ChiTietTKB SET STT=" + stt + ",monhoc=N'" + monhoc + "',lop=N'" + lop + "',giaovien=N'" + giaovien + "',thu=N'" + thu + "',thoigian=N'"+thoigian+"',hocphi='"+hocphi+"'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string stt, string monhoc, string lop, string giaovien, string thu, string thoigian, string hocphi,string idTKB)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietTKB (STT, monhoc,lop,giaovien,thu,thoigian,hocphi,idTKB) values (" + stt + ",N'" + monhoc + "',N'" + lop + "',N'" + giaovien + "',N'" + thu + "',N'"+thoigian+"','"+hocphi+"',"+idTKB+")", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietTKB WHERE id=" + id, conn);
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
