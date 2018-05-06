using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALHocVien
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HocVien", conn);
        //    string sql = "SELECT * from ((hocvien v inner join lop l on l.idhocvien=v.id) inner join chitiettkb c on c.id=l.idlop) inner join thoikhoabieu t on t.id=c.idTKB where [Ngày kết thúc] >=now()";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getcurr()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT  v.ID,MaHV, hotenlot as N'Họ tên lót', ten as N'Tên' ,hotenlot +' ' + ten as [Họ và tên],ngaysinh as N'Ngày sinh', truong as N'Trường',dienthoai as N'Điện thoại',email, diachi as N'Địa chỉ',v.ghichu as N'Ghi chú' from hocvien v ORDER BY v.ngayDK DESC", conn);
         //   string sql = "SELECT * from ((hocvien v inner join lop l on l.idhocvien=v.id) inner join chitiettkb c on c.id=l.idlop) inner join thoikhoabieu t on t.id=c.idTKB where [Ngày kết thúc] >=now()";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getdiemdanh(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT hocVien.ID,hotenlot + ' ' + ten as \"Họ tên\"  FROM HocVien inner join Lop on hocVien.id=Lop.idHocVien WHERE lophientai=1 and Lop.idLop=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getTKB()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,hotenlot as N'Họ tên lót',ten as N'Tên',ngaysinh as N'Ngày sinh', ngayDK FROM HocVien order by ngayDK", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string a)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT v.ID,MaHV as N'Mã HV', hotenlot as 'Họ tên lót', ten as N'Tên',hotenlot +' ' + ten as [Họ và tên],ngaysinh as N'Ngày sinh', truong as N'Trường',dienthoai as N'Điện thoại',email,diachi as N'Địa chỉ',v.ghichu as N'Ghi chú' FROM ((hocvien v inner join lop l on l.idhocvien=v.id) inner join chitiettkb c on c.id=l.idlop) inner join thoikhoabieu t on t.id=c.idTKB where ngayketthuc >=getdate()", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get1(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HocVien WHERE ID="+id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string mahocvien,string hotenlot, string ten, string ngaysinh, string idtruong, string dienthoai, string email, string diachi, string hotencha, string dienthoaicha, string nghenghiepcha, string chucvucha, string hotenme, string dienthoaime, string nghenghiepme, string chucvume, string nguoinuoidung,  string dienthoainguoinuoiduong, string emailphuhuynh,string ghichu, string id )
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE hocVien SET MaHV='" + mahocvien + "',hotenlot='" + hotenlot + "',ten='" + ten + "',ngaysinh='" + ngaysinh + "',ghichu='" + ghichu + "',truong='" + idtruong + "', dienthoai='"+dienthoai+"',email='"+email+"',diachi='"+diachi+"',hoTenCha='"+hotencha+"', dienThoaiCha='"+dienthoaicha+"',ngheNghiepCha='"+ nghenghiepcha+"', chucVuCha='"+chucvucha+"',hoTenMe='"+hotenme+"',dienThoaiMe='"+dienthoaime+"', ngheNghiepMe='"+nghenghiepme+"', chucVuMe='"+chucvume+"', tenNguoiNuoiDuong='"+nguoinuoidung+"', dienThoaiNguoiNuoiDuong='"+dienthoainguoinuoiduong+"', emailPhuHuynh='"+emailphuhuynh+"' WHERE ID=" + id, conn);
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
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO hocVien(MaHV, hotenlot, ten, ngaysinh,truong,dienthoai, Email, diachi, hoTenCha, dienThoaiCha, ngheNghiepCha, chucVuCha, hoTenMe, dienThoaiMe, ngheNghiepMe, chucVuMe, tenNguoiNuoiDuong, dienThoaiNguoiNuoiDuong, emailPhuHuynh,ghichu) values ('"+mahocvien +"','" + hotenlot + "','" + ten + "','" + ngaysinh + "','" + idtruong + "','" + dienthoai + "','" + email + "','" + diachi + "','" + hotencha + "','" + dienthoaicha + "','" + nghenghiepcha + "','" + chucvucha + "','" + hotenme + "','" + dienthoaime + "','" + nghenghiepme + "','" + chucvume + "','" + nguoinuoidung + "','" + dienthoainguoinuoiduong + "','" + emailphuhuynh + "','" + ghiChu + "')", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM hocVien WHERE id=" + id, conn);
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
