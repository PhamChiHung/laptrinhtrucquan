using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien
{
    public class ConnectionStringSql
    {
        static public void connection(ref SqlConnection cnn)
        {
            string connectionString = @"Data Source=DESKTOP-VO4Q3H8\PHU;Initial Catalog=QLKS;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
        }

    }
}
