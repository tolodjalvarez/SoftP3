using Soft_P3.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Soft_P3.Datos
{
    public class Fusuario
    {
        public void Lista(DataGridView datos)
        {
            string consulta = "usp_Data_FUsuarios_GetAll";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Connection = conexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            datos.DataSource = dt;
        }
        public static bool Agregar(Usuario usuario)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FUsuario_Insert", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@Nombre", SqlDbType.VarChar,0).Value = usuario.Nombre;
            sql.Parameters.Add("@Apellido", SqlDbType.VarChar, 0).Value = usuario.Apellido;
            sql.Parameters.Add("@Cedula", SqlDbType.VarChar, 0).Value = usuario.Cedula;
            sql.Parameters.Add("@Direccion", SqlDbType.VarChar, 0).Value = usuario.Direccion;
            sql.Parameters.Add("@Telefono", SqlDbType.VarChar, 0).Value = usuario.Telefono;
            sql.Parameters.Add("@Usuario", SqlDbType.VarChar, 0).Value = usuario.Usuario1;
            sql.Parameters.Add("@Password", SqlDbType.VarChar, 0).Value = usuario.Password;
            sql.Parameters.Add("@Tipo", SqlDbType.VarChar, 100).Value = usuario.Tipo;

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
        public static int Actualizar(Usuario usuario)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FUsuarios_Actualizar", conexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@Id", usuario.Id);
            sql.Parameters.Add("@Nombre", SqlDbType.VarChar, 0).Value = usuario.Nombre;
            sql.Parameters.Add("@Apellido", SqlDbType.VarChar, 0).Value = usuario.Apellido;
            sql.Parameters.Add("@Cedula", SqlDbType.VarChar, 0).Value = usuario.Cedula;
            sql.Parameters.Add("@Direccion", SqlDbType.VarChar, 0).Value = usuario.Direccion;
            sql.Parameters.Add("@Telefono", SqlDbType.VarChar, 0).Value = usuario.Telefono;
            sql.Parameters.Add("@Usuario", SqlDbType.VarChar, 0).Value = usuario.Usuario1;
            sql.Parameters.Add("@Password", SqlDbType.VarChar, 0).Value = usuario.Password;
            sql.Parameters.Add("@Tipo", SqlDbType.VarChar, 100).Value = usuario.Tipo;


            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);

        }
        public static int Eliminar(Usuario usuario)
        {
            SqlCommand sql = new SqlCommand("usp_Data_FUsuarios_Borrar");
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@Id", usuario.Id);

            int resul = sql.ExecuteNonQuery();
            return Convert.ToInt32(resul > 0);


        }


        public static void Login(Usuario usuario)
        {

            SqlCommand sqlLog = new SqlCommand("usp_Data_FLogin_ValidarLogin", conexion.ObtenerConexion());
            sqlLog.CommandType = CommandType.StoredProcedure;

            sqlLog.Parameters.AddWithValue("@Usuario", usuario.Usuario1);
            sqlLog.Parameters.AddWithValue("@Password", usuario.Password);

            SqlDataReader DR = sqlLog.ExecuteReader();

            int count = 0;
            int Try = 3;

            while (DR.Read())
            {
                count += 1;
            }

            while (Try > 0)
            {

                int Inten = Try -= 1;
                if (count == 1)
                {
                    MessageBox.Show("Bienvenido", "Usuario", MessageBoxButtons.OK);
                    Presentacion.FrmMenu Fr = new Presentacion.FrmMenu();
                    Fr.Show();
                }
                else
                {

                    if (Try == 0)
                    {
                        MessageBox.Show("Informacion incorrecta, le quedan " + Inten + " Intentos ", "Succes", MessageBoxButtons.OK);

                    }

                }
            }
          
        }
    }
}
