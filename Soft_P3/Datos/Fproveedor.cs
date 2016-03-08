using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soft_P3.Entidades;

namespace Soft_P3.Datos
{
    class Fproveedor
    {
        public void Lista(DataGridView datos)
        {
            string consulta = "usp_Data_FProveedor_GetAll";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Connection = conexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            datos.DataSource = dt;
        }

        public static bool Agregar(Proveedor proveedor)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FProveedor_Insert", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@NombProveedor", SqlDbType.VarChar, 100).Value = proveedor.Nombre;
            sql.Parameters.Add("@Telefono", SqlDbType.VarChar, 100).Value = proveedor.Telefono;
            sql.Parameters.Add("@RNC", SqlDbType.VarChar, 100).Value = proveedor.Rnc;
            sql.Parameters.Add("@Pais", SqlDbType.VarChar, 100).Value = proveedor.Pais;
            sql.Parameters.Add("@Ciudad", SqlDbType.VarChar, 100).Value = proveedor.Ciudad;
            sql.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = proveedor.Email;

            try
            {
                int resultado = sql.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static int Actualizar(Proveedor proveedor)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FProveedor_Actualizar", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@IdProveedor", proveedor.Id);
            sql.Parameters.AddWithValue("@NombProveedor", proveedor.Nombre);
            sql.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
            sql.Parameters.AddWithValue("@RNC", proveedor.Rnc);
            sql.Parameters.AddWithValue("@Pais", proveedor.Pais);
            sql.Parameters.AddWithValue("@Ciudad", proveedor.Ciudad);
        
            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);

        }
        public static int Eliminar(Proveedor proveedor)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FProveedor_Borrar");
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@IdProveedor", proveedor.Id);
            int resul = sql.ExecuteNonQuery();


            return Convert.ToInt32(resul > 0);


        }
    }
}
