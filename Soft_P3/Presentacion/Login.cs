using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Soft_P3.Datos;
using Soft_P3.Entidades;
using System.Windows.Input;


namespace Soft_P3.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.ForeColor = SystemColors.GrayText;
            txtUser.Text = "Usuario";
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);

            txtPass.ForeColor = SystemColors.GrayText;
            txtPass.Text = "Contraseña";
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
        }

        private static Login _instancia;

        public static Login GetInstance()
        {
            if (_instancia == null)
                _instancia = new Login();
            return _instancia;
        }

        public string ValidarDatos()
        {
            string Resultados = "";
            if (txtUser.Text == "")
            {
                Resultados = Resultados + "Usuario \n";
            }
            if (txtPass.Text == "")
            {
                Resultados = Resultados + "Password \n";
            }

            
            return Resultados;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = FLogin.ValidarLogin(txtUser.Text, txtPass.Text);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                Usuario U = new Usuario();
                U.Apellido = dt.Rows[0]["Apellido"].ToString();
                U.Nombre = dt.Rows[0]["Nombre"].ToString();
                U.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                U.Cedula = Convert.ToString(dt.Rows[0]["Cedula"]);
                U.Usuario1 = dt.Rows[0]["Usuario"].ToString();
                U.Tipo = dt.Rows[0]["Tipo"].ToString();
                U.Telefono = dt.Rows[0]["Telefono"].ToString();
                U.Direccion = dt.Rows[0]["Direccion"].ToString();

                //FrmVenta.GetInscance().Show();
                FrmMenu FM = new FrmMenu();
                FM.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos");
                txtPass.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 0)
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Length == 0)
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

        
}

