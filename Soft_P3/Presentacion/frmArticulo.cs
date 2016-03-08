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

        public static frmArticulo GetInstance()
        {
            if (_instancia==null)
                _instancia=new frmArticulo();
            return _instancia;
            
        }

        public void SetFlag(string svalor)
        {
            txtFlag.Text = svalor;
        }
        public void SetCategoria(string id, string descripcion)
        {
            txtIdCat.Text = id;
            txtDescCat.Text = descripcion;
        }

        public void SetProveedor(string id, string nombre)
        {
            txtIdProveedor.Text = id;
            txtProveedor.Text = nombre;
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
            if (txtNombre.Text == "")
            {
                Resultados = Resultados + "Descripcion \n";
            }
            if (txtDescCat.Text == "")
            {
                Resultados = Resultados + "Descripcion Categoria \n";
            }
            

            if (txtMin.Text == "")
            {
                Resultados = Resultados + "Maximo\n";
            }
            if (txtStock.Text == "")
            {
                Resultados = Resultados + "Minimo \n";
            }

           if (txtStock.Text=="")
            {
                Resultados = Resultados + "Existencia \n";
            }
            if (txtPrecioV.Text=="")
            {
                Resultados = Resultados + "Precio de Venta \n";
            }
            if (txtPrecioC.Text=="")
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
            btnBuscarCa.Visible = b;
            btnBuscPro.Visible = b;

            txtNombre.Enabled = b;
            txtDescripcion.Enabled = b;
            txtIdCat.Enabled = b;
            txtDescCat.Enabled = b;
            
            txtIdProveedor.Enabled = b;
            txtProveedor.Enabled = b;
            txtMin.Enabled = b;
            txtStock.Enabled = b;
            txtPrecioV.Enabled = b;
            txtPrecioC.Enabled = b;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);

            txtCodArt.Text = "";
            txtIdCat.Text = "";
            txtDescCat.Text = "";
            txtNombre.Text = "";
            txtIdProveedor.Text = "";
            txtMin.Text = "";
            txtStock.Text = "";
            txtProveedor.Text = "";
            txtPrecioV.Text = "";
            txtPrecioC.Text = "";
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

                        articulo.nombre = txtNombre.Text;
                        articulo.DescArt = txtNombre.Text;
                        articulo.categoria1.Id = Convert.ToInt32(txtIdCat.Text);
                        articulo.precioCompra = Convert.ToDouble(txtPrecioC.Text);
                        articulo.precioVenta = Convert.ToDouble(txtPrecioV.Text);
                        articulo.existencia = Convert.ToInt32(txtStock.Text);
                        articulo.minimo = Convert.ToInt32(txtMin.Text);
                       
                        articulo.nProveedor.Id= Convert.ToInt32(txtIdProveedor);
                        articulo.FechaVencimiento = dtFechaVencimiento.Value;
                    
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
                        articulo.nombre = txtNombre.Text;
                        articulo.DescArt = txtNombre.Text;
                        articulo.categoria1.Id = Convert.ToInt32(txtIdCat.Text);
                        articulo.precioCompra = Convert.ToDouble(txtPrecioC.Text);
                        articulo.precioVenta = Convert.ToDouble(txtPrecioV.Text);
                        articulo.existencia = Convert.ToInt32(txtStock.Text);
                        articulo.minimo = Convert.ToInt32(txtMin.Text);

                        articulo.nProveedor.Id = Convert.ToInt32(txtIdProveedor);
                        articulo.FechaVencimiento = dtFechaVencimiento.Value;

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
                txtNombre.Text = dgvArticulos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvArticulos.CurrentRow.Cells["DescArt"].Value.ToString();
                txtIdCat.Text = dgvArticulos.CurrentRow.Cells["IdCategoria"].Value.ToString();
                txtDescCat.Text = dgvArticulos.CurrentRow.Cells["CategoriaDescripcion"].Value.ToString();
                txtPrecioC.Text = dgvArticulos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                txtPrecioV.Text = dgvArticulos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = dgvArticulos.CurrentRow.Cells["Stock"].Value.ToString();
                txtMin.Text = dgvArticulos.CurrentRow.Cells["Minimo"].Value.ToString();
                txtIdProveedor.Text = dgvArticulos.CurrentRow.Cells["Proveedor"].Value.ToString();
                txtProveedor.Text = dgvArticulos.CurrentRow.Cells["NombreProveedor"].Value.ToString();
                dtFechaVencimiento.Text = dgvArticulos.CurrentRow.Cells["FechaVencimiento"].Value.ToString();
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
            frmProveedor frmPro = new frmProveedor();
            frmPro.SetFlag("1");
            frmPro.ShowDialog();
        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar los Articulos seleccionados?", "Eliminacion de Articulos,", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvArticulos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Articulo articulo = new Articulo();
                            articulo.Id = Convert.ToInt32(row.Cells["IdProveedor"].Value);
                            if (Farticulo.Eliminar(articulo) != 1)
                            {
                                MessageBox.Show("El Articulo no pudo ser eliminado! ", "Eliminacion de Articulos", MessageBoxButtons.OK, MessageBoxIcon
                                    .Warning);
                                frmArticulo_Load(null, null);
                            }
                        }
                    }
                    frmArticulo_Load(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscarArti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cname = String.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = cname;
                DataView dv = dt.DefaultView;
                if (txtBuscarArti.Text != string.Empty)
                {
                    dv.RowFilter = cname + " LIKE '%" + txtBuscarArti.Text + "%'";
                    dgvArticulos.DataSource = dv;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarCa_Click_1(object sender, EventArgs e)
        {
            frmCategoria frmcate = new frmCategoria();
            frmcate.SetFlag("1");
            frmcate.ShowDialog();
        }
    }
}
