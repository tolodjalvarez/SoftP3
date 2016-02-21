using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            var aux = new Fcategoria();
            aux.Lista(dgvCategoria);
            dgvCategoria.AllowUserToAddRows = false;
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
            MostrarGuardarCancelar(true);
            txtId.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategoria.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Elimiar"].Value))
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(row.Cells["Id"].Value);
                    if (Fcategoria.Eliminar(categoria) != 1)
                    {
                        MessageBox.Show("La Categoria no pudo ser eliminado! ", "Eliminacion de Categorias", MessageBoxButtons.OK, MessageBoxIcon
                            .Warning);
                        frmCategoria_Load(null,null);
                    }
                }
            }
        }
    }
}
