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
using Soft_P3.Datos;
using Soft_P3.Entidades;

namespace Soft_P3.Presentacion
{
    public partial class frmProveedor : Form
    {
        private static DataTable dt = new DataTable();
        private SqlDataAdapter da;
        public frmProveedor()
        {
            InitializeComponent();
        }
    
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("usp_Data_FProveedor_GetAll", conexion.ObtenerConexion());
            dt = new DataTable();
            da.Fill(dt);
            dgvProveedor.DataSource = dt;
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
            if (txtTelefono.Text == "")
            {
                Resultados = Resultados + "Telefono \n";
            }
            if (txtCiudad.Text == "")
            {
                Resultados = Resultados + "Ciudad\n";
            }

            if (txtRNC.Text == "")
            {
                Resultados = Resultados + "RNC\n";
            }
            if (txtPais.Text == "")
            {
                Resultados = Resultados + "Pais \n";
            }

            if (txtEmail.Text == "")
            {
                Resultados = Resultados + "Email \n";
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
            dgvProveedor.Enabled = !b;

            txtNombre.Enabled = b;
            txtTelefono.Enabled = b;
            txtCiudad.Enabled = b;
            txtPais.Enabled = b;
            txtRNC.Enabled = b;
            txtEmail.Enabled = b;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            txtId.Text = "";
            txtNombre.Text = "";
            txtRNC.Text = "";
            txtCiudad.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtPais.Text = "";
        }

      
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvProveedor_CellClick(null, null);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar los Proveedores seleccionados?", "Eliminacion de Proveedores,", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvProveedor.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Proveedor proveedor = new Proveedor();
                            proveedor.Id = Convert.ToInt32(row.Cells["IdProveedor"].Value);
                            if (Fproveedor.Eliminar(proveedor) != 1)
                            {
                                MessageBox.Show("El Proveedor no pudo ser eliminado! ", "Eliminacion de Proveedores", MessageBoxButtons.OK, MessageBoxIcon
                                    .Warning);
                                frmProveedor_Load(null, null);
                            }
                        }
                    }
                    frmProveedor_Load(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.CurrentRow != null)
            {

                txtId.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
                txtRNC.Text = dgvProveedor.CurrentRow.Cells[4].Value.ToString();
                txtPais.Text = dgvProveedor.CurrentRow.Cells[5].Value.ToString();
                txtCiudad.Text = dgvProveedor.CurrentRow.Cells[6].Value.ToString();
                txtEmail.Text = dgvProveedor.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProveedor.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvProveedor.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
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
                    dgvProveedor.DataSource = dv;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtFlag.Text == "1")
            {

                frmArticulo Art = frmArticulo.GetInstance();
                if (dgvProveedor.CurrentRow != null)
                {
                    Art.SetCategoria(dgvProveedor.CurrentRow.Cells[1].Value.ToString(),
                        dgvProveedor.CurrentRow.Cells[2].Value.ToString());
                    Art.Show();
                    Close();
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
             try
            {
                string sResultados = ValidarDatos();
                if (sResultados == "")
                {
                    if (txtId.Text == "")
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor.Nombre = txtNombre.Text;
                        proveedor.Telefono = txtTelefono.Text;
                        proveedor.Pais = txtPais.Text;
                        proveedor.Ciudad = txtCiudad.Text;
                        proveedor.Rnc = txtRNC.Text;
                        proveedor.Email = txtEmail.Text;

                        if (Fproveedor.Agregar(proveedor))
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            frmProveedor_Load(null, null);
                        }
                    }
                    else
                    {
                        
                        Proveedor proveedor = new Proveedor();

                        proveedor.Id = Convert.ToInt32(txtId.Text);
                        proveedor.Nombre = txtNombre.Text;
                        proveedor.Telefono = txtTelefono.Text;
                        proveedor.Pais = txtPais.Text;
                        proveedor.Ciudad = txtCiudad.Text;
                        proveedor.Rnc = txtRNC.Text;
                        proveedor.Email = txtEmail.Text;

                        if (Fproveedor.Actualizar(proveedor) == 1)
                        {
                            MessageBox.Show("Datos Actualizados Correctamente");
                            frmProveedor_Load(null, null);
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
        
    }
}
