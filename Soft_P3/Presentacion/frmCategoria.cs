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
    public partial class frmCategoria : Form
    {
        private static DataTable dt = new DataTable();
        private DataSet ds=new DataSet();
        public frmCategoria()
        {
            InitializeComponent();
        }
        public void SetFlag(string valor)
        {
            txtFlag.Text = valor;
        }
        private SqlDataAdapter da;
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            //var aux = new Fcategoria();
            //aux.Lista(dgvCategoria);
            //dgvCategoria.AllowUserToAddRows = false;

            da = new SqlDataAdapter("usp_Data_FCategoria_GetAll",conexion.ObtenerConexion());
            dt=new DataTable();
            da.Fill(dt);
            dgvCategoria.DataSource = dt;
        }
        public string ValidarDatos()
        {
            string Resultados = "";
            if (txtDescripcion.Text == "")
            {
                Resultados = Resultados + "Descripcion \n";
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
            dgvCategoria.Enabled = !b;

            txtDescripcion.Enabled = b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = ValidarDatos();
                if (sResultado=="")
                {
                    if (txtId.Text=="")
                    {
                        Categoria categoria = new Categoria();
                        categoria.Descripcion = txtDescripcion.Text;
                        if (Fcategoria.Agregar(categoria))
                        {
                            MessageBox.Show("Categoria Guardada Exitosamente!");
                            frmCategoria_Load(null,null);
                        }
                    }
                    else
                    {
                        Categoria categoria=new Categoria();
                        categoria.Id = Convert.ToInt32(txtId.Text);
                        categoria.Descripcion = txtDescripcion.Text;
                        if (Fcategoria.Actualizar(categoria)==1)
                        {
                            MessageBox.Show("Datos Actualizados Correctamente!");
                            frmCategoria_Load(null,null);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Faltan Datos! \n" + sResultado);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvCategoria.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvCategoria.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvCategoria_CellClick(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar las Categorias seleccionadas?", "Eliminacion de Categorias,", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvCategoria.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Categoria categoria = new Categoria();
                            categoria.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (Fcategoria.Eliminar(categoria) != 1)
                            {
                                MessageBox.Show("Las Categorias no pudieron ser eliminadas! ", "Eliminacion de Categorias", MessageBoxButtons.OK, MessageBoxIcon
                                    .Warning);
                                frmCategoria_Load(null, null);
                            }
                        }
                    }
                    frmCategoria_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                
            }
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cname= String.Concat("[",dt.Columns[1].ColumnName,"]");
                dt.DefaultView.Sort = cname;
                DataView dv =dt.DefaultView;
                if (txtBuscar.Text != string.Empty)
                {
                    dv.RowFilter = cname + " LIKE '%" + txtBuscar.Text + "%'";
                    dgvCategoria.DataSource = dv; 
                }
                
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                txtId.Text = dgvCategoria.CurrentRow.Cells["Id"].Value.ToString();
                txtDescripcion.Text = dgvCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            txtId.Text = "";
            txtDescripcion.Text = "";
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            
           
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtFlag.Text == "1")
            {

                frmArticulo Art = frmArticulo.GetInstance();
                if (dgvCategoria.CurrentRow != null)
                {
                    Art.SetCategoria(dgvCategoria.CurrentRow.Cells[1].Value.ToString(),
                        dgvCategoria.CurrentRow.Cells[2].Value.ToString());
                    Art.Show();
                    Close();
                }
            }
        }
    }
}
