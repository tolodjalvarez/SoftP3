using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soft_P3.Entidades;

namespace Soft_P3.Presentacion
{
    public partial class frmDetalleFactura : Form
    {
        private static frmDetalleFactura _instancia;
        public frmDetalleFactura()
        {
            InitializeComponent();
        }
        public static frmDetalleFactura GetInstance()
        {
            if (_instancia == null)
                _instancia = new frmDetalleFactura();
            return _instancia;

        }

        internal void SetArticulo(string articuloId,string descArt)
        {
            txtArtId.Text = articuloId;
            txtArtDes.Text = descArt;
        }
        private void btnBuscArt_Click(object sender, EventArgs e)
        {
            frmArticulo frmArt = new frmArticulo();
            frmArt.SetFlag("1");
            frmArt.ShowDialog();
        }

        internal void SetVenta(Venta venta)
        {
            txtIdFactura.Text = venta.CodFactura.ToString();
            txtClieId.Text = venta.CodCliente.Id.ToString();
            txtClieNom.Text = venta.CodCliente.NombCliente;
            dtpFechaFactura.Text = venta.FechaFactura.ToLongDateString();
            cmbTipoPago.Text = venta.TipoPago;
            txtCFactura.Text = venta.NoFactura.ToString();
        }
    }
}
