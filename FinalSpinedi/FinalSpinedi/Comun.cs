using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FinalSpinedi
{
    public static class Comun
    {
        public static SqlConnection establecerConexion = new SqlConnection("Data Source=HACHITO\\SQLEXPRESS; database=stock; integrated security= true");
    }
}
