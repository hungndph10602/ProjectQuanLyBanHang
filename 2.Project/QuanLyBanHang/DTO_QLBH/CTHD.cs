using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class CTHD
    {
        [Key]
        public int macthd { get; set; }
        [ForeignKey("HoaDon")]
        public int mshd { get; set; }
       
        [ForeignKey("sanphams")]
        public int mssp { get; set; }
        
        public int soluong { get; set; }
        public double gia { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual ICollection<SanPham> sanphams { get; set; }
    }
}
