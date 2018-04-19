using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;

namespace boiduongLeQuyDon.BUS
{
    class BUSHocVien
    {
        DALHocVien dal = new DALHocVien();
        public DataSet get()
        {
            return dal.get();
        }
        public DataSet getdiemdanh(string id)
        {
            return dal.getdiemdanh(id);
        }
        public DataSet getTKB()
        {
            return dal.getTKB();
        }
        public DataSet get(string a)
        {
            return dal.get(a);
        }
        public DataSet getcurr()
        {
            return dal.getcurr();
        }
        public DataSet get1(string a)
        {
            return dal.get1(a);
        }
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insert(string mahocvien,string hotenlot, string ten, string ngaysinh, string idtruong, string dienthoai, string email, string diachi, string hotencha, string dienthoaicha, string nghenghiepcha, string chucvucha, string hotenme,string dienthoaime, string nghenghiepme, string chucvume, string nguoinuoidung, string dienthoainguoinuoiduong, string emailphuhuynh, string ghiChu)
        {
            return dal.insert(mahocvien,hotenlot, ten, ngaysinh, idtruong, dienthoai, email, diachi, hotencha, dienthoaicha, nghenghiepcha, chucvucha, hotenme, dienthoaime, nghenghiepme, chucvume, nguoinuoidung, dienthoainguoinuoiduong, emailphuhuynh, ghiChu);
        }
        public int update(string mahocvien,string hotenlot, string ten, string ngaysinh, string idtruong, string dienthoai, string email, string diachi, string hotencha, string dienthoaicha, string nghenghiepcha, string chucvucha, string hotenme, string dienthoaime, string nghenghiepme, string chucvume, string nguoinuoidung, string dienthoainguoinuoiduong, string emailphuhuynh, string ghiChu, string id)
        {
            return dal.update(mahocvien,hotenlot,ten,ngaysinh,idtruong,dienthoai,email,diachi,hotencha,dienthoaicha,nghenghiepcha,chucvucha,hotenme,dienthoaime,nghenghiepme,chucvume,nguoinuoidung,dienthoainguoinuoiduong,emailphuhuynh,ghiChu,id);
        }
    }
}
