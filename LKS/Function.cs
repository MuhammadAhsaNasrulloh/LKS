using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS
{
    internal class Function
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=INV-KEPEGAWAIAN;Initial Catalog=repetisiLKS;Integrated Security=True;");
        public static string id_user = "";
        public static string tipe_user = "";
        public static string nama = "";
    }
}
