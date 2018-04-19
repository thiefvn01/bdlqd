using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;
namespace boiduongLeQuyDon.BUS
{
    class BUSsoDauBai
    {
        DALSoDauBai dal = new DALSoDauBai();
        public DataSet get()
        {
            return dal.get();
        }
        public DataSet get(string id)
        {
            return dal.get(id);
        } 
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insert(string noidung, string baitap, string nhanxet, string ngay,string lop)
        {
            return dal.insert(noidung,baitap,nhanxet,ngay,lop);
        }
        public int update(string noidung, string baitap, string nhanxet, string ngay, string id)
        {
            return dal.update(noidung,baitap,nhanxet,ngay,id);
        }
    }
}
