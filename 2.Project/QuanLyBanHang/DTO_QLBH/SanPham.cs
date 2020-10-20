using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class SanPham
    {
        [Key]
        public int masp { get; set; }
        public string tensp { get; set; }
        public int soluong { get; set; }
        public double gianhap { get; set; }
        public double giaban { get; set; }
        public string hinhanh { get; set; }

        public virtual SanPham sanpham { get; set; }
    }
}
