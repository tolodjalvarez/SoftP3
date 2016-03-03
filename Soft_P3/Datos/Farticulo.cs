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
        public void ListarArticulos(DataGridView datos)
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

            sql.Parameters.Add("@DesArt", SqlDbType.VarChar, 0).Value = articulo.DescArt;
            sql.Parameters.Add("@PrecioVenta", SqlDbType.Decimal,0).Value = articulo.PrecioVenta;
            sql.Parameters.Add("@Existencia", SqlDbType.VarChar,0).Value = articulo.Existencia;
            sql.Parameters.Add("@IdCategoria", SqlDbType.Int, 0).Value = articulo.Categoria1.Id;
           sql.Parameters.Add("@Minimo", SqlDbType.Int, 0).Value = articulo.Minimo;
            sql.Parameters.Add("@Proveedor", SqlDbType.Int, 0).Value = articulo.nProveedor.Id;
            sql.Parameters.Add("@Nombre", SqlDbType.VarChar, 0).Value = articulo.Nombre;
            sql.Parameters.Add("@PrecioCompra", SqlDbType.Decimal, 0).Value = articulo.PrecioCompra;
            sql.Parameters.Add("@FechaVencimiento", SqlDbType.VarChar, 0).Value = articulo.FechaVencimiento;

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
            sql.Parameters.Add("@Existencia", SqlDbType.VarChar, 0).Value = articulo.Existencia;
            sql.Parameters.Add("@IdCategoria", SqlDbType.Int, 0).Value = articulo.Categoria1.Id;
           
            sql.Parameters.Add("@Minimo", SqlDbType.Int, 0).Value = articulo.Minimo;
            sql.Parameters.Add("@Proveedor", SqlDbType.Int, 0).Value = articulo.nProveedor.Id;
            sql.Parameters.Add("@Nombre", SqlDbType.VarChar, 0).Value = articulo.Nombre;
            sql.Parameters.Add("@PrecioCompra", SqlDbType.Decimal, 0).Value = articulo.PrecioCompra;
            sql.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime, 0).Value = articulo.FechaVencimiento;

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
