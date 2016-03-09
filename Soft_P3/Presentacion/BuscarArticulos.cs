using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Soft_P3.Presentacion
{
    public partial class BuscarArticulos : Form
    {
        public BuscarArticulos()
        {
            InitializeComponent();
        }

        private static DataTable dt = new DataTable();
        private SqlDataAdapter da;

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNombre.Checked == true)
            {
                txtCod.Enabled = false;
                txtCod.BackColor = System.Drawing.Color.LightGray;
                txtNombre.Enabled = true;
                txtNombre.BackColor = System.Drawing.Color.White;
            }
        }

        private void radioCod_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCod.Checked == true)
            {
                txtCod.Enabled = true;
                txtCod.BackColor = System.Drawing.Color.White;
                txtNombre.Enabled = false;
                txtNombre.BackColor = System.Drawing.Color.LightGray;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cname = String.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = cname;
                DataView dv = dt.DefaultView;
                if (txtNombre.Text != string.Empty)
                {
                    dv.RowFilter = cname + " LIKE '%" + txtNombre.Text + "%'";
                    dataGridView1.DataSource = dv;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cname = String.Concat("[", dt.Columns[0].ColumnName, "]");
                dt.DefaultView.Sort = cname;
                DataView dv = dt.DefaultView;
                if (txtCod.Text != string.Empty)
                {
                    dv.RowFilter = cname + " LIKE '%" + txtCod.Text + "%'";
                    dataGridView1.DataSource = dv;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarArticulos_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("usp_Data_FArticulo_All", conexion.ObtenerConexion());
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            radioNombre.Checked = true;
        }
    }
}
