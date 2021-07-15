using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH;
using DTO_QLBH;
namespace BUS_QLBH
{
    class BUS_NHANVIEN
    {
        DAL_NHANVIEN dal = new DAL_NHANVIEN();   
        public bool Add(NhanVien nv)
        {
            return dal.Add(nv);
        }

        public bool Update(NhanVien nv)
        {
            return dal.Update(nv);
        }

        public bool Delete(int ID)
        {
            return dal.Delete(ID);
        }
    }
}
