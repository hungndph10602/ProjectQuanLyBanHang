using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class DbContext
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M807K36\SQLEXPRESS;Initial Catalog=DuAnMau;Integrated Security=True");
    }
}
