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
    public class FdetalleVenta
    {
        public void TodoDetalleFacturas(DataGridView datos)
        {
            string consulta = "usp_Data_FFacturaVenta_GetTodo";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Connection = conexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            datos.DataSource = dt;
        }
        public static bool AgregarFact(DetalleVenta detalle)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FFacturaVenta_Insert", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            
            sql.Parameters.Add("@NoFactura", SqlDbType.Int, 0).Value = detalle.NoFactura.NoFactura;
            sql.Parameters.Add("@CodArticulo", SqlDbType.Int, 0).Value = detalle.CodArticulo.id;
            sql.Parameters.Add("@Cantidad", SqlDbType.Int, 0).Value = detalle.Cantidad;
            sql.Parameters.Add("@PrecioVenta", SqlDbType.Decimal, 0).Value = detalle.PrecioVenta;
            sql.Parameters.Add("@Impuesto", SqlDbType.Decimal, 0).Value = detalle.Impuesto;

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
        public static int Actualizar(DetalleVenta detalle)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FFacturaVenta_Actualizar", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@Id", SqlDbType.Int, 0).Value = detalle.Id;
            sql.Parameters.Add("@NoFactura", SqlDbType.Int, 0).Value = detalle.NoFactura.NoFactura;
            sql.Parameters.Add("@CodArticulo", SqlDbType.Int, 0).Value = detalle.CodArticulo.id;
            sql.Parameters.Add("@Cantidad", SqlDbType.Int, 0).Value = detalle.Cantidad;
            sql.Parameters.Add("@PrecioVenta", SqlDbType.Decimal, 0).Value = detalle.PrecioVenta;
            sql.Parameters.Add("@Impuesto", SqlDbType.Decimal, 0).Value = detalle.Impuesto;

            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);

        }
        public static int Eliminar(DetalleVenta detalle)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FFacturaVenta_Borrar");
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@Id", detalle.Id);
            int resul = sql.ExecuteNonQuery();


            return Convert.ToInt32(resul > 0);


        }
    }
}
