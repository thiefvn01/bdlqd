using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;

namespace boiduongLeQuyDon.BUS
{
    class BUSgiaoVien
    {
        DALGiaoVien dal = new DALGiaoVien();
        public DataSet get()
        {
            return dal.get();
        }
        public DataSet getpq()
        {
            return dal.getpq();
        }
        public DataSet getpq(string id)
        {
            return dal.getpq(id);
        }
        public DataSet get1()
        {
            return dal.get1();
        }
        public DataSet login(string a)
        {
            return dal.login(a);
        }
        public int updatepass(string pass, string uname)
        {
            return dal.updatepass(pass, uname);
        }
        public DataSet login1(string a)
        {
            return dal.login1(a);
        }
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insert(string ho, string ten, string diachi, string sodienthoai,string email, string vitri, string uname, string passwd, string gioitinh, string mucluong, string ghiChu)
        {
            return dal.insert(ho, ten, diachi, sodienthoai,email,vitri, uname,passwd,gioitinh,mucluong,ghiChu);
        }
        public int update(string ho, string ten, string diachi, string sodienthoai, string email, string vitri, string gioitinh, string mucluong, string ghiChu, string id)
        {
            return dal.update(ho, ten,diachi,sodienthoai,email,vitri,gioitinh,mucluong,ghiChu,id);
        }
        public int updatepw(string ho, string ten, string diachi, string sodienthoai, string email, string vitri, string uname, string passwd, string gioitinh, string mucluong, string ghiChu, string id)
        {
            return dal.updatepw(ho, ten, diachi, sodienthoai, email, vitri, uname, passwd, gioitinh, mucluong, ghiChu, id);
        }
        public int updatepq(string nv, string hv, string kq, string pq, string id)
        {
            return dal.updatepq(nv, hv, kq, pq, id);
        }
    }
}
