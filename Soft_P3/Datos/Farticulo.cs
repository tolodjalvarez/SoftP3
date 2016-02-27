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
    class Farticulo
    {
        public void Articulos(DataGridView datos)
        {
            string consulta = "usp_Data_FArticulo_All";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Connection = conexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            datos.DataSource = dt;
        }

        public static bool Agregar(Articulo articulo)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FArticulo_Insert", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@DesArt", SqlDbType.VarChar, 100).Value = articulo.DescArt;
            sql.Parameters.Add("@PrecioVenta", SqlDbType.Decimal,0).Value = articulo.PrecioVenta;
            sql.Parameters.Add("@Existencia", SqlDbType.VarChar, 100).Value = articulo.Existencia;
            sql.Parameters.Add("@Entrada", SqlDbType.Int, 0).Value = articulo.Entrada;
            sql.Parameters.Add("@Salida", SqlDbType.Int, 0).Value = articulo.Salida;
            sql.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 100).Value = articulo.Ubicacion;
            sql.Parameters.Add("@Maximo", SqlDbType.Int, 0).Value = articulo.Maximo;
            sql.Parameters.Add("@Minimo", SqlDbType.Int, 0).Value = articulo.Minimo;
            sql.Parameters.Add("@CostUnitario", SqlDbType.Decimal, 0).Value = articulo.CostUnitario;
            

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
        public static int Actualizar(Articulo articulo)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FArticulo_Actualizar", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@CodArt", articulo.Id);
            sql.Parameters.AddWithValue("@Descripcion", articulo.DescArt);
            sql.Parameters.AddWithValue("@PrecioVenta", articulo.PrecioVenta);
            sql.Parameters.AddWithValue("@existencia", articulo.Existencia);
            sql.Parameters.AddWithValue("@Entrada", articulo.Entrada);
            sql.Parameters.AddWithValue("@IdCategoria", articulo.Categoria1.Id);

            sql.Parameters.AddWithValue("@Salida", articulo.Salida);
            sql.Parameters.AddWithValue("@Ubicacion", articulo.Ubicacion);
            sql.Parameters.AddWithValue("@Maximo", articulo.Maximo);
            sql.Parameters.AddWithValue("@Minimo", articulo.Minimo);
            sql.Parameters.AddWithValue("@CostUnitario", articulo.CostUnitario);
            sql.Parameters.AddWithValue("@Proveedor", articulo.nProveedor.Id);

            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);

        }
        public static int Eliminar(Articulo articulo)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FArticulo_Borrar");
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@CodArt", articulo.Id);
            int resul = sql.ExecuteNonQuery();


            return Convert.ToInt32(resul > 0);


        }
    }
}
