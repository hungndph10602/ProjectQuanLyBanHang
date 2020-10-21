using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLBH;

namespace DAL_QLBH
{
    public class DAL_NHANVIEN : DbContext
    {
        public bool Add(NhanVien nv)
        {
            try
            {
                con.Open();
                string query = string.Format("Insert into NHANVIEN(HOTEN,NGAYSINH,DIACHI,VAITRO,MATKHAU,TINHTRANG) Values('{0}','{1}','{2}','{3}','{4}','{5}')", nv.hoten, nv.ngaysinh, nv.diachi, nv.vaitro, nv.matkhau, nv.tinhtrang);
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

        public bool Update(NhanVien nv)
        {
            try
            {
                con.Open();
                string query = string.Format("Update NHANVIEN set HOTEN ='{0}', NGAYSINH = '{1}', DIACHI = '{2}', VAITRO = '{3}', MATKHAU = '{4}', Where ID = '{5}'", nv.hoten, nv.ngaysinh, nv.diachi, nv.vaitro, nv.matkhau, nv.manv);
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

        public bool Delete(int Id)
        {
            try
            {
                con.Open();
                string query = string.Format("Delete from NHANVIEN Where ID = '{0}'", Id);
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
