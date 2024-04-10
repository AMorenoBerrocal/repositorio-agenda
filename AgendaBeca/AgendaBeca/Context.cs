using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBeca
{
    public class Context
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=WINAPUO5K7YUPCF\SQLEXPRESS02;Initial Catalog=Agenda; Integrated Security=True;");
        public static SqlCommand cmd = new SqlCommand();
    }
}
