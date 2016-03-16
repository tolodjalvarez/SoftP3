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

<<<<<<< HEAD:Soft_P3/Datos/conexion.cs
            SqlConnection conectar = new SqlConnection(@"Data Source=local;Initial Catalog=SoftP3;Integrated Security=True");
=======
            SqlConnection conectar = new SqlConnection(@"Data Source=JIMROD-PC;Initial Catalog=SoftPT3;Integrated Security=True");
>>>>>>> origin/master:Soft_P3/conexion.cs

            conectar.Open();
            return conectar;
        }
    }
}
