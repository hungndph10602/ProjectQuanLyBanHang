
using System.Data.SqlClient;


namespace DAL_QLBH
{
    public class DbContext
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M807K36\SQLEXPRESS;Initial Catalog=DuAnMau;Integrated Security=True");
    }
}
