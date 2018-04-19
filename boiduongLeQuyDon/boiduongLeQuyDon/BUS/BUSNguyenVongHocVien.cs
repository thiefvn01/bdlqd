using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;
namespace boiduongLeQuyDon.BUS
{
    class BUSNguyenVongHocVien
    {
        DALNguyenVong dal = new DALNguyenVong();
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
        public int insert(string idhocvien, string truong, string ghichu, string mon)
        {
            return dal.insert(idhocvien, truong, ghichu, mon);
        }
        public int update(string truong, string ghichu, string mon, string id)
        {
            return dal.update(truong,ghichu,mon, id);
        }
    }
}
