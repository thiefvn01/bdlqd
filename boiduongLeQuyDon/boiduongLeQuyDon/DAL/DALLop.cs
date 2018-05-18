using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace boiduongLeQuyDon.DAL
{
    class DALLop
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Lop.ID,ChiTietTKB.STT AS [STT TKB], hotenlot + ' ' + ten as [Họ và tên],ChiTietTKB.lop as N'Lớp', SBL, trangthai as N'Trạng thái' FROM Lop INNER JOIN hocVien on Lop.idHocVien=hocVien.ID, ChiTietTKB WHERE ChiTietTKB.ID=Lop.idLop and lophientai=1 ORDER BY ChiTietTKB.IDTKB, ChiTietTKB.STT", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getlg(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idLop, lopgoc, idHocVien from lop WHERE id="+id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getlg()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id,idLop from lop WHERE id=(SELECT max(id) from lop)", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string sbl, string ghiChu,string trangthai, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lop SET SBL='" + sbl + "',ghichu='" + ghiChu + "', trangthai=N'"+ trangthai+"'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updatenew(string lc, string lg, string trangthai)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lop SET lopCu="+lc+" ,lopGoc="+lg+" trangthai=N'" + trangthai + "' WHERE id=(SELECt MAX(ID) FROM LOP)", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updateold(string id, string ht, string trangthai)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lop SET lophientai="+ht+", trangthai=N'"+trangthai + "' WHERE id=(SELECT max(ID) from lop", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updateold1(string id, string ht, string trangthai)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lop SET lophientai=" + ht + ", trangthai=N'" + trangthai + "'  WHERE id="+id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string idHV, string lop, string ghichu,string sbl, string ngaydk, int sotien)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Lop(idHocVien, idLop,ghichu,SBL, lophientai, ngayDK, sotien, trangthai) values ('" + idHV + "','" + lop + "','" + ghichu + "','"+sbl+"',1, '" + sotien + ","+ngaydk +"', N'Bình thường')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string idHV, string lop, string ghichu, string sbl,string lopcu, string lopgoc)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Lop(idHocVien, idLop,ghichu,SBL, lophientai,lopcu, lopgoc, trangthai) values ('" + idHV + "','" + lop + "','" + ghichu + "','" + sbl + "',1,"+lopcu+","+lopgoc+", N'Bình thường')", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Lop WHERE id=" + id, conn);
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
