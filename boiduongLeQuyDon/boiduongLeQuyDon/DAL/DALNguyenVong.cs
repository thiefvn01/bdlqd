using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALNguyenVong
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM nguyenVongHocVien", conn);
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
            SqlCommand cmd = new SqlCommand("SELECT n.ID, hotenlot + ' ' + [Ten] AS [Họ tên],  truong as [Trường], monchuyen as N'Môn chuyên', ghiChu as [Ghi chú] FROM nguyenVongHocVien n inner join hocVien v on v.id=n.idhocvien WHERE idHocVien=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string truong, string ghiChu, string mon, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE nguyenVongHocVien SET truong='" + truong + "',monchuyen='" + mon + "',ghiChu='" + ghiChu + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string idhocvien, string truong, string ghichu, string mon)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO nguyenVongHocVien (idHocVien, truong,ghiChu, monchuyen) values (" + idhocvien + ",'" + truong + "','" + ghichu + "','" + mon + "')", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM nguyenVongHocVien WHERE id=" + id, conn);
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
