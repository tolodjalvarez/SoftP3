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
using Soft_P3.Presentacion;

namespace Soft_P3
{
    public partial class frmFactura : Form
    {
        private static frmFactura _instancia;
        private static DataTable dt = new DataTable();
        public frmFactura()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var aux = new Fventa();
            aux.TodasFacturas(dgvFactura);
            dgvFactura.AllowUserToAddRows = false;
        }
        public static frmFactura GetInstance()
        {
            if (_instancia == null)
                _instancia = new frmFactura();
            return _instancia;

        }

        public void SetUsu(string id,string usuario)
        {
            txtIdUsu.Text = id;
            txtUsuario.Text = usuario;
        }
        public void SetCliente(string id, string nombre)
        {
            txtIdCliente.Text = id;
            txtNomClie.Text = nombre;
        }
        public void MostrarGuardarCancelar(bool b)
        {
            btnGuardar.Visible = b;
            btnCancelar.Visible = b;
            btnBuscarCli.Visible = b;
            btnUsu.Visible = b;
            btnNuevo.Visible = !b;
            btnEditar.Visible = !b;
            
            dgvFactura.Enabled = !b;
            dtpFechaFactura.Enabled = b;
            txtCFactura.Enabled = b;
            cmbTipoPago.Enabled = b;

        }
        private void btnBuscarCa_Click(object sender, EventArgs e)
        {
            frmClientes frmcli = new frmClientes();
            frmcli.SetFlag("1");
            frmcli.ShowDialog();
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            frmUsuario frmUSU = new frmUsuario();
            frmUSU.SetFlag("1");
            frmUSU.ShowDialog();
        }
        public string ValidarDatos()
        {
            string Resultados = "";
            if (txtIdCliente.Text == "")
            {
                Resultados = Resultados + "Cliente \n";
            }
            if (txtCFactura.Text == "")
            {
                Resultados = Resultados + "No. Factura \n";
            }

            return Resultados;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultados = ValidarDatos();
                if (sResultados == "")
                {
                    if (txtIdFactura.Text == "")
                    {
                        Venta venta = new Venta();

                        venta.CodCliente.Id = Convert.ToInt32(txtIdCliente.Text);
                        venta.FechaFactura = dtpFechaFactura.Value;
                        venta.TipoPago = cmbTipoPago.Text;
                        venta.CodFactura = txtCFactura.Text;
                        venta.IdUsuario.Id = Convert.ToInt32(txtIdUsu.Text);

                        venta.CodCliente.NombCliente = txtNomClie.Text;
                        

                        int Iventa = Fventa.AgregarFact(venta);

                        if (Iventa>0)
                        {
                            Form1_Load(null, null);
                            venta.NoFactura = Iventa;
                            CargarDetalle(venta);

                        }
                    }
                    else
                    {
                        Venta venta = new Venta();

                        venta.NoFactura = Convert.ToInt32(txtIdFactura.Text);
                        venta.CodCliente.Id = Convert.ToInt32(txtIdCliente.Text);
                        venta.FechaFactura = dtpFechaFactura.Value;
                        venta.TipoPago = cmbTipoPago.Text;
                        venta.CodFactura = txtCFactura.Text;
                        venta.IdUsuario.Id = Convert.ToInt32(txtIdUsu.Text);

                        if (Fventa.Actualizar(venta) == 1)
                        {
                            MessageBox.Show("Datos Actualizados Correctamente");
                            Form1_Load(null, null);
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

        private void CargarDetalle(Venta venta)
        {
            frmDetalleFactura FDtalleVenta=frmDetalleFactura.GetInstance();
            FDtalleVenta.SetVenta(venta);
            FDtalleVenta.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvFactura_CellClick(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            txtIdCliente.Text = "";
            txtNomClie.Text = "";
            txtCFactura.Text = "";
            txtIdFactura.Text = "";
            txtIdFactura.Text = "";
            txtIdUsu.Text = "";
        }

        private void txtBuscarArti_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string cname = String.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = cname;
                DataView dv = dt.DefaultView;
                if (txtBuscarVenta.Text != string.Empty)
                {
                    dv.RowFilter = cname + " LIKE '%" + txtBuscarVenta.Text + "%'";
                    dgvFactura.DataSource = dv;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvFactura.Columns["Eliminar"].Index)
            //{
            //    DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvFactura.Rows[e.RowIndex].Cells["Eliminar"];
            //    chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            //}
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvFactura.CurrentRow != null)
            {

                txtIdFactura.Text = dgvFactura.CurrentRow.Cells["ID_Venta"].Value.ToString();
                txtIdCliente.Text = dgvFactura.CurrentRow.Cells["CodCliente"].Value.ToString();
                txtNomClie.Text = dgvFactura.CurrentRow.Cells["NombreCliente"].Value.ToString() + " "+ dgvFactura.CurrentRow.Cells["ApellidoCliente"].Value.ToString();
                dtpFechaFactura.Text = dgvFactura.CurrentRow.Cells["Fecha"].Value.ToString();
                cmbTipoPago.Text = dgvFactura.CurrentRow.Cells["TipoPago"].Value.ToString();
                txtCFactura.Text = dgvFactura.CurrentRow.Cells["CodFactura"].Value.ToString();
                txtIdUsu.Text = dgvFactura.CurrentRow.Cells["Usuario"].Value.ToString();
                
            }
        }

        private void dgvFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactura.CurrentRow != null)
            {
                Venta venta =new Venta();
                venta.NoFactura =Convert.ToInt32(dgvFactura.CurrentRow.Cells["ID_Venta"].Value.ToString());
                venta.CodCliente.Id =Convert.ToInt32( dgvFactura.CurrentRow.Cells["CodCliente"].Value.ToString());
                venta.CodCliente.NombCliente= dgvFactura.CurrentRow.Cells["NombreCliente"].Value.ToString() + " " + dgvFactura.CurrentRow.Cells["ApellidoCliente"].Value.ToString();
                venta.FechaFactura =Convert.ToDateTime(dgvFactura.CurrentRow.Cells["Fecha"].Value.ToString());
                venta.TipoPago = dgvFactura.CurrentRow.Cells["TipoPago"].Value.ToString();
                venta.CodFactura = dgvFactura.CurrentRow.Cells["CodFactura"].Value.ToString();
                venta.IdUsuario.Id =Convert.ToInt32(dgvFactura.CurrentRow.Cells["Usuario"].Value.ToString());

                CargarDetalle(venta);

            }
        }

        
    }
}
