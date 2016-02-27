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
    public partial class frmArticulo : Form
    {
        private static frmArticulo _instancia;
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

        }

        private void btnBuscarCa_Click(object sender, EventArgs e)
        {
            frmCategoria frmCat =new frmCategoria();
            frmCat.SetFlag("1");
            frmCat.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
