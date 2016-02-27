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
    public partial class frmArticulo : Form
    {
        private static frmArticulo _instancia;
        public static DataTable dt=new DataTable();
        public frmArticulo()
        {
            InitializeComponent();
        }

        public static frmArticulo GetInstancia()
        {
            if (_instancia==null)
                _instancia=new frmArticulo();
            return _instancia;
            
        }
        public void SetCategoria(string id, string descripcion)
        {
            txtIdCat.Text = id;
            txtDescCat.Text = descripcion;
        }
        private void frmArticulo_Load(object sender, EventArgs e)
        {
            var aux = new Farticulo();
            aux.ListarArticulos(dgvArticulos);
            dgvArticulos.AllowUserToAddRows = false;
        }

        private void btnBuscarCa_Click(object sender, EventArgs e)
        {
            frmCategoria frmCat =new frmCategoria();
            frmCat.SetFlag("1");
            frmCat.ShowDialog();
        }
        public string ValidarDatos()
        {
            string Resultados = "";
            if (txtDescripcion.Text == "")
            {
                Resultados = Resultados + "Descripcion \n";
            }
            if (txtDescCat.Text == "")
            {
                Resultados = Resultados + "Descripcion Categoria \n";
            }
            if (txtUbicacion.Text == "")
            {
                Resultados = Resultados + "Ubicacion\n";
            }

            if (txtMax.Text == "")
            {
                Resultados = Resultados + "Maximo\n";
            }
            if (txtMin.Text == "")
            {
                Resultados = Resultados + "Minimo \n";
            }

            if (txtSalida.Text == "")
            {
                Resultados = Resultados + "Salida \n";
            }
            if (txtEntrada.Text == "")
            {
                Resultados = Resultados + "Entrada \n";
            }
            if (txtExistencia.Text=="")
            {
                Resultados = Resultados + "Existencia \n";
            }
            if (txtPrecioV.Text=="")
            {
                Resultados = Resultados + "Precio de Venta \n";
            }
            if (txtCostoU.Text=="")
            {
                Resultados = Resultados + "Costo Unitario \n";
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
            dgvArticulos.Enabled = !b;

            txtIdCat.Enabled = b;
            txtDescCat.Enabled = b;
            txtDescripcion.Enabled = b;
            txtUbicacion.Enabled = b;
            txtMax.Enabled = b;
            txtMin.Enabled = b;
            txtSalida.Enabled = b;
            txtEntrada.Enabled = b;
            txtExistencia.Enabled = b;
            txtPrecioV.Enabled = b;
            txtCostoU.Enabled = b;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            txtCodArt.Text = "";
            txtIdCat.Text = "";
            txtDescCat.Text = "";
            txtDescripcion.Text = "";
            txtUbicacion.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
            txtSalida.Text = "";
            txtEntrada.Text = "";
            txtExistencia.Text = "";
            txtPrecioV.Text = "";
            txtCostoU.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultados = ValidarDatos();
                if (sResultados == "")
                {
                    if (txtCodArt.Text == "")
                    {
                        Articulo articulo = new Articulo();
                        articulo.DescArt = txtDescripcion.Text;
                        articulo.categoria1.Id = Convert.ToInt32(txtIdCat.Text);
                        articulo.ubicacion = txtUbicacion.Text;
                        articulo.maximo = Convert.ToInt32(txtMax.Text);
                        articulo.minimo = Convert.ToInt32(txtMin.Text);
                        articulo.entrada = Convert.ToInt32(txtEntrada);
                        articulo.salida = Convert.ToInt32(txtSalida);
                        articulo.costUnitario = Convert.ToDouble(txtCostoU.Text);
                        articulo.precioVenta = Convert.ToDouble(txtPrecioV.Text);
                        articulo.existencia = Convert.ToInt32(txtExistencia.Text);

                        if (Farticulo.Agregar(articulo))
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            frmArticulo_Load(null, null);
                        }
                    }
                    else
                    {
                        Articulo articulo = new Articulo();
                        articulo.Id = Convert.ToInt32(txtCodArt.Text);
                        articulo.DescArt = txtDescripcion.Text;
                        articulo.categoria1.Id = Convert.ToInt32(txtIdCat.Text);
                        articulo.ubicacion = txtUbicacion.Text;
                        articulo.maximo = Convert.ToInt32(txtMax.Text);
                        articulo.minimo = Convert.ToInt32(txtMin.Text);
                        articulo.entrada = Convert.ToInt32(txtEntrada);
                        articulo.salida = Convert.ToInt32(txtSalida);
                        articulo.costUnitario = Convert.ToDouble(txtCostoU.Text);
                        articulo.precioVenta = Convert.ToDouble(txtPrecioV.Text);
                        articulo.existencia = Convert.ToInt32(txtExistencia.Text);

                        if (Farticulo.Actualizar(articulo) == 1)
                        {
                            MessageBox.Show("Datos Actualizados Correctamente");
                            frmArticulo_Load(null, null);
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
            dgvArticulos_CellClick(null, null);
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {

                txtCodArt.Text = dgvArticulos.CurrentRow.Cells["CodArt"].Value.ToString();
                txtDescripcion.Text = dgvArticulos.CurrentRow.Cells["DescArt"].Value.ToString();
                txtIdCat.Text = dgvArticulos.CurrentRow.Cells["IdCategoria"].Value.ToString();
                txtDescCat.Text = dgvArticulos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecioV.Text = dgvArticulos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                txtExistencia.Text = dgvArticulos.CurrentRow.Cells["Existencia"].Value.ToString();
                txtEntrada.Text = dgvArticulos.CurrentRow.Cells["Entrada"].Value.ToString();
                txtSalida.Text = dgvArticulos.CurrentRow.Cells["Salida"].Value.ToString();
                txtUbicacion.Text = dgvArticulos.CurrentRow.Cells["Ubicacion"].Value.ToString();
                txtMax.Text = dgvArticulos.CurrentRow.Cells["Maximo"].Value.ToString();
                txtMin.Text = dgvArticulos.CurrentRow.Cells["Minimo"].Value.ToString();
                txtCostoU.Text = dgvArticulos.CurrentRow.Cells["CostUnitario"].Value.ToString();
                txtIdProveedor.Text = dgvArticulos.CurrentRow.Cells["Proveedor"].Value.ToString();
                txtProveedor.Text = dgvArticulos.CurrentRow.Cells["NombProveedor"].Value.ToString();
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvArticulos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvArticulos.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProveedor frmpro = new frmProveedor();
            frmpro.SetFlag("1");
            frmpro.ShowDialog();
        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
