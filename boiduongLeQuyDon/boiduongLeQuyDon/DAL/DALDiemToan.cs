using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALDiemToan
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KetQuaToan", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string mahocvien, string made, string tongdiem, string daiso, string hinh, string a1, string b1, string c1, string d1, string a2, string b2, string a3, string b3, string a4, string b4, string a5, string b5, string c5, string d5, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE KetQuaToan SET MaHV=" + mahocvien + ",\"Mã đề thi\"=" + made + ",\"  Tổng\"=" + tongdiem + ",\" Đại\"=" + daiso + ",\" Hình\" =" + hinh + ",1a=" + a1 + ",1b=" + b1 + ",1c=" + c1 + ",1d=" + d1 + ",2a=" + a2 + ",2b=" + b2 + ",3a=" + a3 + ",3b=" + b3 + ",4a=" + a4 + ",4b=" + b4 + ",5a=" + a5 + " ,5b=" + b5 + ",5c=" + c5 + " ,5d=" + d5 + " WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string mahocvien, string made, string tongdiem, string daiso, string hinh, string a1, string b1, string c1, string d1, string a2, string b2, string a3, string b3, string a4, string b4, string a5, string b5, string c5, string d5)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO KetQuaToan (maHocVien, \"Mã đề thi\", \"  Tổng\",\" Đại\", \" Hình\",1a,1b,1c,1d,2a,2b,3a,3b,4a,4b,5a,5b,5c,5d) values (" + mahocvien + "," + made + "," + tongdiem + "," + daiso + "," + hinh + "," + daiso + "," + a1 + "," + b1 + "," + c1 + "," + d1 + "," + a2 + "," + b2 + "," + a3 + "," + b3 + "," + a4 + "," + b4 + "," + a5 + "," + b5 + "," + c5 + "," + d5 + ")", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM KetQuaToan WHERE id=" + id, conn);
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
