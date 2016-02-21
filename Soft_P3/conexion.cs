using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_P3
{
    class conexion
    {
        public static SqlConnection ObtenerConexion()
        {

            SqlConnection conectar = new SqlConnection(@"Data Source=JIMROD-PC;Initial Catalog=SoftPT3;Integrated Security=True");

            conectar.Open();
            return conectar;
        }
    }
}
