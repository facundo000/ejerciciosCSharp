using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Problema_5_3
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-Q6GKN7O\SQLEXPRESS;Initial Catalog=supermercado;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand comando = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Activo(bool x)
        {
            TBoxCodigo.Enabled = x;
            TBoxDetalle.Enabled = x;
            CBoxMarca.Enabled = x;
            RBtnNotebook.Enabled = x;
            RBtnNetbook.Enabled = x;
            TBoxPrecio.Enabled = x;
            DTimeFecha.Enabled = x;
            BtnCancelar.Enabled = x;
            BtnGrabar.Enabled = x;
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Activo(true);
        }
    }
}
