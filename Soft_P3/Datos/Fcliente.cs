using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soft_P3.Entidades;
using System.Windows.Forms;

namespace Soft_P3.Datos
{
    class Fcliente
    {
        public void Lista(DataGridView datos)
        {
            string consulta = "usp_Data_FCliente_GetTodo";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Connection = conexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            datos.DataSource = dt;
        }

        public static bool Agregar(Cliente cliente)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FCliente_Insert", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@NombCliente", SqlDbType.VarChar, 0).Value = cliente.NombCliente;
            sql.Parameters.Add("@ApelliCliente",SqlDbType.VarChar, 0).Value = cliente.ApelliCliente;
            sql.Parameters.Add("@Telefono", SqlDbType.VarChar, 0).Value = cliente.Telefono;
            sql.Parameters.Add("@Celular", SqlDbType.VarChar, 0).Value = cliente.Celular;
            sql.Parameters.Add("@Email", SqlDbType.VarChar, 0).Value = cliente.Email;
            sql.Parameters.Add("@Cedula", SqlDbType.VarChar, 0).Value = cliente.Cedula;
            sql.Parameters.Add("@Direccion", SqlDbType.VarChar, 0).Value = cliente.Direccion;
            sql.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 0).Value = cliente.Nacionalidad;
            sql.Parameters.Add("@RNC", SqlDbType.VarChar, 0).Value = cliente.Rnc;
            sql.Parameters.Add("@Fecha", SqlDbType.DateTime, 0).Value=cliente.Fecha;

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
        public static int Actualizar(Cliente cliente)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FCliente_Actualizar", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@IdClient", cliente.Id);
            sql.Parameters.Add("@NombCliente", SqlDbType.VarChar, 0).Value = cliente.NombCliente;
            sql.Parameters.Add("@ApelliCliente", SqlDbType.VarChar, 0).Value = cliente.ApelliCliente;
            sql.Parameters.Add("@Telefono", SqlDbType.VarChar, 0).Value = cliente.Telefono;
            sql.Parameters.Add("@Celular", SqlDbType.VarChar, 0).Value = cliente.Celular;
            sql.Parameters.Add("@Email", SqlDbType.VarChar, 0).Value = cliente.Email;
            sql.Parameters.Add("@Cedula", SqlDbType.VarChar, 0).Value = cliente.Cedula;
            sql.Parameters.Add("@Direccion", SqlDbType.VarChar, 0).Value = cliente.Direccion;
            sql.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 0).Value = cliente.Nacionalidad;
            sql.Parameters.Add("@RNC", SqlDbType.VarChar, 0).Value = cliente.Rnc;
            sql.Parameters.Add("@Fecha", SqlDbType.DateTime, 0).Value = cliente.Fecha;

            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);

        }
        public static int Eliminar(Cliente cliente)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FCliente_Borrar");
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@IdClient", cliente.Id);

            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);
            
            
        }
    }
}
