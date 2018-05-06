using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALSoDauBai
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT s.ID, noidung as [Nội dung], baitapvenha as [Bài tập về nhà], nhanxet as [Nhận xét],ngay as [Ngày],lop as [Lớp], idlop as lid FROM soDauBai s inner join chitiettkb c on s.idlop=c.id order by ngay", conn);
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
            SqlCommand cmd = new SqlCommand("SELECT s.ID, noidung as [Nội dung], baitapvenha as [Bài tập về nhà], nhanxet as [Nhận xét],ngay as [Ngày],lop as [Lớp], idlop as lid FROM soDauBai s inner join chitiettkb c on s.idlop=c.id WHERE idlop=" + id+" order by [Ngày]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //public DataSet get(string id)
        //{
        //    SqlConnection conn = access.AccessData();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM nguyenVongHocVien WHERE idHocVien=" + id, conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet dt = new DataSet();
        //    da.Fill(dt);
        //    conn.Close();
        //    return dt;
        //}
        public int update(string noidung, string baitap, string nhanxet, string ngay, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE soDauBai SET noidung='" + noidung + "',baitapvenha='" + baitap + "',nhanxet='" + nhanxet + "',ngay='" + ngay + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string noidung, string baitap, string nhanxet, string ngay, string lop)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO soDauBai (noidung, baitapvenha,nhanxet, ngay,idLop) values ('" + noidung + "','" + baitap + "','" + nhanxet + "','" + ngay + "',"+lop+")", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM soDauBai WHERE id=" + id, conn);
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
