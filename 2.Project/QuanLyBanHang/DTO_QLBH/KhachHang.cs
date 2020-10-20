using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class KhachHang
    {
        [Key]
        public int makh { get; set; }
        public string tenkh { get; set; }
        public string diachi { get; set; }
        public bool gioitinh { get; set; }

        public virtual KhachHang khachhang { get; set; }
    }
}
