using Soft_P3.Datos;
using Soft_P3.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_P3.Presentacion
{
    public partial class frmUsuario : Form
    {
        private static frmUsuario _instancia;

        private static DataTable dt = new DataTable();
        private SqlDataAdapter da;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("usp_Data_FUsuarios_GetAll", conexion.ObtenerConexion());
            dt = new DataTable();
            da.Fill(dt);
            dgvUsuario.DataSource = dt;
        }
        public static frmUsuario GetInstance()
        {
            if (_instancia == null)
                _instancia = new frmUsuario();
            return _instancia;

        }

        public void SetFlag(string svalor)
        {
            txtFlag.Text = svalor;
        }
       
        public string ValidarDatos()
        {
            string Resultados = "";
            if (txtNombre.Text == "")
            {
                Resultados = Resultados + "Nombre \n";
            }
            if (txtTel.Text == "")
            {
                Resultados = Resultados + "Telefono \n";
            }

            if (txtApellido.Text == "")
            {
                Resultados = Resultados + "Apellidos";
            }
            if (txtCedula.Text == "")
            {
                Resultados = Resultados + "Cedula \n";
            }

            if (txtDirec.Text == "")
            {
                Resultados = Resultados + "DIreccion \n";
            }

            return Resultados;
        }
        public void MostrarGuardarCancelar(bool b)
        {
            btnGuardar.Visible = b;
            btnCancelar.Visible = b;
            btnNuevo.Visible = !b;
            btnEditar.Visible = !b;
            
            btnEliminar.Visible = !b;
            dgvUsuario.Enabled = !b;

            txtNombre.Enabled = b;
            txtApellido.Enabled = b;
            txtTel.Enabled = b;
            txtCedula.Enabled = b;
            txtDirec.Enabled = b;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultados = ValidarDatos();
                if (sResultados == "")
                {
                    if (txtId.Text == "")
                    {
                        Usuario usuario = new Usuario();
                        usuario.Nombre = txtNombre.Text;
                        usuario.Apellido = txtApellido.Text;
                        usuario.Telefono = txtTel.Text;
                        usuario.Cedula = txtCedula.Text;
                        usuario.Direccion = txtDirec.Text;
                        usuario.Usuario1 = txtNombreUsu.Text;
                        usuario.Password = txtPass.Text;
                        usuario.Tipo = cmbTipoUsu.Text;

                        if (Fusuario.Agregar(usuario))
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            frmUsuario_Load(null, null);
                        }
                    }
                    else
                    {
                        Usuario usuario = new Usuario();
                        usuario.Nombre = txtNombre.Text;
                        usuario.Apellido = txtApellido.Text;
                        usuario.Telefono = txtTel.Text;
                        usuario.Cedula = txtCedula.Text;
                        usuario.Direccion = txtDirec.Text;
                        usuario.Usuario1 = txtNombreUsu.Text;
                        usuario.Password = txtPass.Text;
                        usuario.Tipo = cmbTipoUsu.Text;

                        if (Fusuario.Actualizar(usuario) == 1)
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            frmUsuario_Load(null, null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Datos! \n" + sResultados);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTel.Text = "";
            txtDirec.Text = "";
            txtCedula.Text = "";
            txtNombreUsu.Text = "";
            txtPass.Text = "";
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {

                txtId.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
                txtApellido.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
                txtCedula.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
                txtDirec.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
                txtNombreUsu.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
                txtPass.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuario.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvUsuario.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar los Usuarios seleccionados?", "Eliminacion de Usuarios,", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(row.Cells["IdUsuario"].Value);
                            if (Fusuario.Eliminar(usuario) != 1)
                            {
                                MessageBox.Show("El Usuario no pudo ser eliminado! ", "Eliminacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon
                                    .Warning);
                                frmUsuario_Load(null, null);
                            }
                        }
                    }
                    frmUsuario_Load(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscarUsu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cname = String.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = cname;
                DataView dv = dt.DefaultView;
                if (txtBuscarUsu.Text != string.Empty)
                {
                    dv.RowFilter = cname + " LIKE '%" + txtBuscarUsu.Text + "%'";
                    dgvUsuario.DataSource = dv;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtFlag.Text == "1")
            {

                frmFactura frmFat = frmFactura.GetInstance();
                if (dgvUsuario.CurrentRow != null)
                {
                    frmFat.SetUsu(dgvUsuario.CurrentRow.Cells["Id"].Value.ToString(),
                        dgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString());
                    frmFat.Show();
                    Close();
                }
            }
        }
    }
}
