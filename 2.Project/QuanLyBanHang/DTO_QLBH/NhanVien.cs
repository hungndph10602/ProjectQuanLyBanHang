using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class NhanVien
    {
        [Key]
        public int manv { get; set; }
        public string hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string diachi { get; set; }
        public string vaitro { get; set; }
        public string matkhau { get; set; }
        public string tinhtrang { get; set; }

        public virtual NhanVien nhanvien { get; set; }

        public NhanVien(int manv, string hoten, DateTime ngaysinh, string diachi, string vaitro, string matkhau, string tinhtrang)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.vaitro = vaitro;
            this.matkhau = matkhau;
            this.tinhtrang = tinhtrang;
        }
    }
}
