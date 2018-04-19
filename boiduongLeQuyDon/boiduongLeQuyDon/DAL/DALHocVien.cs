using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALHocVien
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM HocVien", conn);
        //    string sql = "SELECT * from ((hocvien v inner join lop l on l.idhocvien=v.id) inner join chitiettkb c on c.id=l.idlop) inner join thoikhoabieu t on t.id=c.idTKB where [Ngày kết thúc] >=now()";
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getcurr()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT  v.ID,\"Mã học viên\", \"Họ tên lót\", \"Tên\",\"Họ tên lót\" +' ' + \"Tên\" as [Họ và tên],\"Ngày sinh\", \"Trường\",\"Điện thoại\",\"Email\",\"Địa chỉ\",v.\"Ghi chú\" from hocvien v ORDER BY v.ngayDK DESC", conn);
         //   string sql = "SELECT * from ((hocvien v inner join lop l on l.idhocvien=v.id) inner join chitiettkb c on c.id=l.idlop) inner join thoikhoabieu t on t.id=c.idTKB where [Ngày kết thúc] >=now()";
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getdiemdanh(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT hocVien.ID,\"Họ tên lót\" + ' ' + \"Tên\" as \"Họ tên\"  FROM HocVien inner join Lop on hocVien.id=Lop.idHocVien WHERE lophientai=1 and Lop.idLop=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getTKB()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,\"Họ tên lót\",\"Tên\",\"Ngày sinh\", ngayDK FROM HocVien order by ngayDK", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string a)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT DISTINCT v.ID,\"Mã học viên\", \"Họ tên lót\", \"Tên\",\"Họ tên lót\" +' ' + \"Tên\" as [Họ và tên],\"Ngày sinh\", \"Trường\",\"Điện thoại\",\"Email\",\"Địa chỉ\",v.\"Ghi chú\" FROM ((hocvien v inner join lop l on l.idhocvien=v.id) inner join chitiettkb c on c.id=l.idlop) inner join thoikhoabieu t on t.id=c.idTKB where [Ngày kết thúc] >=now()", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get1(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM HocVien WHERE ID="+id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string mahocvien,string hotenlot, string ten, string ngaysinh, string idtruong, string dienthoai, string email, string diachi, string hotencha, string dienthoaicha, string nghenghiepcha, string chucvucha, string hotenme, string dienthoaime, string nghenghiepme, string chucvume, string nguoinuoidung,  string dienthoainguoinuoiduong, string emailphuhuynh,string ghichu, string id )
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE hocVien SET \"Mã học viên\"='" + mahocvien + "',\"Họ tên lót\"='" + hotenlot + "',\"Tên\"='" + ten + "',\"Ngày sinh\"='" + ngaysinh + "',\"Ghi chú\"='" + ghichu + "',\"Trường\"='" + idtruong + "', \"Điện thoại\"='"+dienthoai+"',email='"+email+"',\"Địa chỉ\"='"+diachi+"',hoTenCha='"+hotencha+"', dienThoaiCha='"+dienthoaicha+"',ngheNghiepCha='"+ nghenghiepcha+"', chucVuCha='"+chucvucha+"',hoTenMe='"+hotenme+"',dienThoaiMe='"+dienthoaime+"', ngheNghiepMe='"+nghenghiepme+"', chucVuMe='"+chucvume+"', tenNguoiNuoiDuong='"+nguoinuoidung+"', dienThoaiNguoiNuoiDuong='"+dienthoainguoinuoiduong+"', emailPhuHuynh='"+emailphuhuynh+"' WHERE ID=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string mahocvien,string hotenlot, string ten, string ngaysinh, string idtruong, string dienthoai, string email, string diachi, string hotencha, string dienthoaicha, string nghenghiepcha, string chucvucha, string hotenme, string dienthoaime, string nghenghiepme, string chucvume, string nguoinuoidung, string dienthoainguoinuoiduong, string emailphuhuynh, string ghiChu)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO hocVien(\"Mã học viên\", \"Họ tên lót\", \"Tên\", \"Ngày sinh\",\"Trường\",\"Điện thoại\", Email, \"Địa chỉ\", hoTenCha, dienThoaiCha, ngheNghiepCha, chucVuCha, hoTenMe, dienThoaiMe, ngheNghiepMe, chucVuMe, tenNguoiNuoiDuong, dienThoaiNguoiNuoiDuong, emailPhuHuynh,\"Ghi chú\") values ('"+mahocvien +"','" + hotenlot + "','" + ten + "','" + ngaysinh + "','" + idtruong + "','" + dienthoai + "','" + email + "','" + diachi + "','" + hotencha + "','" + dienthoaicha + "','" + nghenghiepcha + "','" + chucvucha + "','" + hotenme + "','" + dienthoaime + "','" + nghenghiepme + "','" + chucvume + "','" + nguoinuoidung + "','" + dienthoainguoinuoiduong + "','" + emailphuhuynh + "','" + ghiChu + "')", conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM hocVien WHERE id=" + id, conn);
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
