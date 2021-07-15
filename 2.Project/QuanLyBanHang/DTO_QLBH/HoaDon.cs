using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class HoaDon
    {
        [Key]
        public int mahd { get; set; }

        [ForeignKey("khachhang")]
        public int mskh { get; set; }

        [ForeignKey("nhanvien")]
        public int msnv { get; set; }

        public DateTime ngaylap { get; set; }

        public virtual KhachHang khachhang { get; set; }
        public virtual NhanVien nhanvien { get; set; }

        public string khanhAnBoi { get; set; }
    }
}
