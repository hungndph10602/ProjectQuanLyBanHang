using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;
namespace DAL_QLBH
{
    class DAL_SANPHAM : DbContext
    {
        public bool Add(SanPham sp)
        {
            try
            {
                con.Open();
                string query = string.Format("Insert into SANPHAM(TENSP,SOLUONG,DONGIANHAP,DONGIABAN,HINHANH) Values('{0}','{1}','{2}','{3}','{4}')", sp.tensp, sp.soluong, sp.gianhap, sp.giaban, sp.hinhanh);
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                con.Close();
            }
            catch
            {

            }
            return false;
        }

        public bool Update(SanPham sp)
        {
            try
            {
                con.Open();
                string query = string.Format("Update SANPHAM set TENSP ='{0}', SOLUONG = '{1}', DONGIANHAP = '{2}', DONGIABAN = '{3}', HINHANH = '{4}', Where ID = '{5}'", sp.tensp, sp.soluong, sp.gianhap, sp.giaban, sp.hinhanh, sp.masp);
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                con.Close();
            }
            catch
            {

            }
            return false;
        }

        public bool xoa(int Id)
        {
            try
            {
                con.Open();
                string query = string.Format("Delete from SANPHAM Where ID = '{0}'", Id);
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                con.Close();
            }
            catch
            {

            }
            return false;
        }
    }
}
