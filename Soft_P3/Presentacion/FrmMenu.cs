using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soft_P3.Presentacion;

namespace Soft_P3.Presentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private static FrmMenu _instancia;
        
        public static FrmMenu GetInstance()
        {
            if (_instancia == null)
                _instancia = new FrmMenu();
            return _instancia;

        }

        private void abrirFormulario(Form f)
        {

            f.MdiParent = this;
            f.Icon = this.Icon;
            f.Show();
        }

        

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void mnuCatProduct_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmArticulo());
        }

        private void mnuCatClient_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmClientes());
        }

        private void mnuCatProvider_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmProveedor());
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmEmpleado());
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmCategoria());
        }

        private void compañiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmCompania());
        }

        private void mnuUsers_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmUsuario());
        }

        private void mnuBilling_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmDetalleFactura());
        }

        private void mnuLogOff_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Desea cerrar sesion?", "Confirmacion", MessageBoxButtons.OKCancel);
            if(Result == DialogResult.OK)
            {
                this.Hide();
                Login Lg = new Login();
                Lg.Show();
            }
            
        }
    }
}
