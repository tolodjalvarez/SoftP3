using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Soft_P3.Entidades;
using System;

namespace Soft_P3.Datos
{
    public class Fventa
    {
        public void TodasFacturas(DataGridView datos)
        {
            string consulta = "usp_Data_FFactura_GetTodo";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Connection = conexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            datos.DataSource = dt;
        }
        public static int AgregarFact(Venta venta)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FFactura_Insert", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;
           
            sql.Parameters.Add("@CodCliente", SqlDbType.Int, 0).Value = venta.CodCliente.Id;
            sql.Parameters.Add("@TipoPago", SqlDbType.VarChar, 0).Value = venta.TipoPago;
            sql.Parameters.Add("@FechaFactura", SqlDbType.Date, 0).Value = venta.FechaFactura;
            sql.Parameters.Add("@IdUsuario", SqlDbType.Int, 0).Value = venta.IdUsuario.Id;
            sql.Parameters.Add("@CodFactura", SqlDbType.VarChar, 0).Value = venta.CodFactura;

            
                int resultado = sql.ExecuteNonQuery();
                return Convert.ToInt32(resultado > 0);
            
           
        }
        public static int Actualizar(Venta venta)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FFactura_Actualizar", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@NoFactura", SqlDbType.Int, 0).Value = venta.NoFactura;
            sql.Parameters.Add("@CodCliente", SqlDbType.Int, 0).Value = venta.CodCliente.Id;
            sql.Parameters.Add("@TipoPago", SqlDbType.VarChar, 0).Value = venta.TipoPago;
            sql.Parameters.Add("@FechaFactura", SqlDbType.Date, 0).Value = venta.FechaFactura;
            sql.Parameters.Add("@IdUsuario", SqlDbType.Int, 0).Value = venta.IdUsuario.Id;
            sql.Parameters.Add("@CodFactura", SqlDbType.VarChar, 0).Value = venta.CodFactura;

            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);

        }
        public static int Eliminar(Venta venta)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FFactura_Borrar");
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@NoFactura", venta.NoFactura);
            int resul = sql.ExecuteNonQuery();


            return Convert.ToInt32(resul > 0);


        }
    }
}
