using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;

namespace boiduongLeQuyDon.BUS
{
    class BUSKetQuaToan
    {
        DALKetQuaToan dal = new DALKetQuaToan();
       public DataSet get()
        {
            return dal.get();
        }
       public DataSet get(string de)
       {
           return dal.get(de);
       }
       public DataSet get(string de,string lop)
       {
           return dal.get(de,lop);
       }
       public int insert(string mahocvien, string madethi, string lop, string a1, string b1, string c1, string d1, string a2, string b2, string a3, string b3, string a4, string b4, string a5, string b5, string c5, string d5, string ngaylam)
       {
           return dal.insert(mahocvien,madethi,lop, a1,b1,c1,d1,a2,b2,a3,b3,a4,b4,a5,b5,c5,d5, ngaylam);
       }
       public int insert1(string cau, string diem, string id)
       {
           return dal.insert1(cau, diem, id);
       }
       public DataSet getde()
       {
           return dal.getde();
       }

       public DataSet getid(string lop, string de, string idhocvien)
       {
           return dal.getid(lop,de,idhocvien);
       }
       public int delete(string id)
       {
           return dal.delete(id);
       }
       public int updatediem()
       {
           return dal.updatediem();
       }
       public int update(string a1, string b1, string c1, string d1, string a2, string b2, string a3, string b3, string a4, string b4, string a5, string b5, string c5, string d5,string id)
       {
           return dal.update(a1,b1,c1,d1,a2,b2,a3,b3,a4,b4,a5,b5,c5,d5,id);
       }
    }
}
