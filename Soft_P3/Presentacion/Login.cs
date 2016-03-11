using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_P3.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static Login _instancia;

        public static Login GetInstance()
        {
            if (_instancia == null)
                _instancia = new Login();
            return _instancia;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
        }

        
    }
}
