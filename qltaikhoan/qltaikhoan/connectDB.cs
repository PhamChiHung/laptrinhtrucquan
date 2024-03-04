using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace qltaikhoan
{
    public class connectDB
    {
        static public void connectDatabase (ref SqlConnection cnn)
        {
            cnn = new SqlConnection(@"Data Source=DESKTOP-VO4Q3H8\PHU;Initial Catalog=QLKS;Integrated Security=True");    
        }

    }
}
