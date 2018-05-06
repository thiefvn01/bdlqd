using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALThoiKhoaBieu
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThoiKhoaBieu WHERE ngayketthuc IS NULL OR ngayketthuc >=getdate()", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(int id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,tentkb as [Tên TKB],namhoc as [Năm học] FROM ThoiKhoaBieu ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet gettt()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,tentkb as [Tên TKB], namhoc as [Năm học] FROM ThoiKhoaBieu WHERE ngayketthuc IS NULL OR ngayketthuc >= getdate()", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getinf(string ID)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT khaigiang as N'Khaigiang' FROM ThoiKhoaBieu WHERE id="+ID, conn);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThoiKhoaBieu WHERE ID=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string ten, string lop, string namhoc, string khaigiang,string ngayketthuc, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ThoiKhoaBieu SET tentkb='" + ten + "',lop='" + lop + "',namhoc='" + namhoc + "',khaigiang='" + khaigiang + "',ngayketthuc='"+ngayketthuc+"'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int update(string ten, string lop, string namhoc, string khaigiang, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ThoiKhoaBieu SET tentkb='" + ten + "',lop='" + lop + "',namhoc='" + namhoc + "',khaigiang='" + khaigiang + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string ten, string lop, string namhoc, string khaigiang, string ngayketthuc)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ThoiKhoaBieu (tentkb, lop,namhoc,khaigiang,ngayketthuc) values ('" + ten + "','" + lop + "','" + namhoc + "','" + khaigiang + "','"+ngayketthuc+"')", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM ThoiKhoaBieu WHERE id=" + id, conn);
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
