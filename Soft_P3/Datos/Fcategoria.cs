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
    class Fcategoria
    {
        public void Lista(DataGridView data)
        {
            string consulta = "select * from Categoria";

            SqlCommand comando =new SqlCommand(consulta,conexion.ObtenerConexion());
            comando.Connection = conexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter(consulta,conexion.ObtenerConexion());
            da.Fill(dt);
            data.DataSource = dt;
        }

        public static bool Agregar(Categoria categoria)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FCategoria_Insert",conexion.ObtenerConexion());
            sql.CommandType= CommandType.StoredProcedure;

            sql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = categoria.Descripcion;


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

        public static int Actualizar(Categoria categoria)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FCategoria_Actualizar");
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@Id", SqlDbType.Int, 0).Value = categoria.Id;
            sql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = categoria.Descripcion;

            return Convert.ToInt32(sql);
            

        }

        public static int Eliminar(Categoria categoria)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FCategoria_Borrar");
            sql.CommandType=CommandType.StoredProcedure;

            sql.Parameters.Add("@Id", SqlDbType.Int, 0).Value = categoria.Id;

            //try
            //{
            //    int resultado = sql.ExecuteNonQuery();
            //    return resultado > 0;
            //}
            //catch (Exception)
            //{
            //    return false;

            //}
            return Convert.ToInt32(sql);
        }
    }
}
