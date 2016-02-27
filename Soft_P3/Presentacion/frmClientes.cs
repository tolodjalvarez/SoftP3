using Soft_P3.Datos;
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
using Soft_P3.Entidades;

namespace Soft_P3.Presentacion
{
    public partial class frmClientes : Form
    {
        private static DataTable dt = new DataTable();
        //private DataSet ds = new DataSet();
        //private SqlDataAdapter da;
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            var aux = new Fcliente();
            aux.Lista(dgvClientes);
            dgvClientes.AllowUserToAddRows = false;
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
            
                string cname = String.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = cname;
                DataView dv = dt.DefaultView;
                if (txtBuscar.Text != string.Empty)
                {
                    dv.RowFilter = cname + " LIKE '%" + txtBuscar.Text + "%'";
                    dgvClientes.DataSource = dv;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string ValidarDatos()
        {
            string Resultados = "";
            if (txtCedula.Text == "")
            {
                Resultados = Resultados + "Nombre \n";
            }
            if (txtNombre.Text == "")
            {
                Resultados = Resultados + "Apellidos \n";
            }
            if (txtApellido.Text == "")
            {
                Resultados = Resultados + "Cedula";
            }
            
            if (txtDireccion.Text == "")
            {
                Resultados = Resultados + "Direccion";
            }
            if (txtRNC.Text == "")
            {
                Resultados = Resultados + "RNC \n";
            }
          
            if (txtNacionalidad.Text == "")
            {
                Resultados = Resultados + "Nacionalidad \n";
            }
            if (txtTelefono.Text == "")
            {
                Resultados = Resultados + "Telefono";
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
            dgvClientes.Enabled = !b;

            txtCedula.Enabled = b;
            txtNombre.Enabled = b;
            txtApellido.Enabled = b;
            txtCelular.Enabled = b;
            txtTelefono.Enabled = b;
            dtpFechaNac.Enabled = b;
            txtDireccion.Enabled = b;
            txtNacionalidad.Enabled = b;
            txtEmail.Enabled = b;
            txtRNC.Enabled = b;
            
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
                        Cliente cliente = new Cliente();
                        cliente.NombCliente = txtCedula.Text;
                        cliente.ApelliCliente = txtNombre.Text;
                        cliente.Cedula = txtApellido.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Celular = txtCelular.Text;
                        cliente.Nacionalidad = txtNacionalidad.Text;
                        cliente.Rnc = txtRNC.Text;
                        cliente.Fecha = dtpFechaNac.Value;
                        cliente.Email = txtEmail.Text;

                        if (Fcliente.Agregar(cliente))
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            frmClientes_Load(null, null);
                        }
                    }
                    else
                    {
                        Cliente cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(txtId.Text);
                        cliente.NombCliente = txtCedula.Text;
                        cliente.ApelliCliente = txtNombre.Text;
                        cliente.Cedula = txtApellido.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Celular = txtCelular.Text;
                        cliente.Nacionalidad = txtNacionalidad.Text;
                        cliente.Rnc = txtRNC.Text;
                        cliente.Fecha = dtpFechaNac.Value;
                        cliente.Email = txtEmail.Text;

                        if (Fcliente.Actualizar(cliente) == 1)
                        {
                            MessageBox.Show("Datos Actualizados Correctamente");
                            frmClientes_Load(null, null);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            txtId.Text = "";
            txtCedula.Text="";
            txtNombre.Text="";
            txtApellido.Text="";
            txtDireccion.Text="";
            txtTelefono.Text="";
            txtCelular.Text="";
            txtNacionalidad.Text="";
            txtRNC.Text="";
            txtEmail.Text="";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvClientes_CellClick(null,null);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {

                txtId.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtCedula.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                txtCelular.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
                txtNacionalidad.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
                txtRNC.Text = dgvClientes.CurrentRow.Cells[10].Value.ToString();
                dtpFechaNac.Text = dgvClientes.CurrentRow.Cells[11].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar los clientes seleccionados?", "Eliminacion de Clientes,", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Cliente cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (Fcliente.Eliminar(cliente) != 1)
                            {
                                MessageBox.Show("El cliente no pudo ser eliminado! ", "Eliminacion de Clientes", MessageBoxButtons.OK, MessageBoxIcon
                                    .Warning);
                                frmClientes_Load(null, null);
                            }
                        }
                    }
                    frmClientes_Load(null,null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==dgvClientes.Columns["Eliminar"].Index)
            {
               DataGridViewCheckBoxCell chkEliminar= (DataGridViewCheckBoxCell) dgvClientes.Rows[e.RowIndex].Cells["Eliminar"];
               chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value); 
            }
        }

        
    }
}
