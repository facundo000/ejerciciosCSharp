namespace Personas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            //Al hacer Click se activan
            BtnGrabar.Enabled = true;
            BtnCancelar.Enabled = true;
            LblApellido.Enabled = true;
            LblNombre.Enabled = true;
            LblTipoDni.Enabled = true;
            LblNumeroDni.Enabled = true;
            LblEstadoCivil.Enabled = true;
            RadioBtnFemenino.Enabled = true;
            RadioBtnMaculino.Enabled = true;

            //Al hacer Click se desactivan
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnBorrar.Enabled = false;
            BtnSalir.Enabled = false;
            Lst.Enabled = false;

            //Al hacer Click se limpian los campos
            LblApellido.Text = string.Empty;
            LblNombre.Text = string.Empty;
            LblNumeroDni.Text = string.Empty;
            LblEstadoCivil.Text = string.Empty;
            //Deschequeck
            RadioBtnMaculino.Checked = false;

            //Foco en el campo apellido
            LblApellido.Focus();
        }

        private void LimpiarForm()
        {
            LblApellido.Text = "";
            LblNombre.Text = "";
            LblTipoDni.Text = "";
            LblNumeroDni.Text = "";
            LblEstadoCivil.Text = "";
            RadioBtnMaculino.Checked = false;
            RadioBtnFemenino .Checked = false;
            LblFallecido.Visible = true;
            
            CheckBox.Visible = true;
            CheckBox.Checked = false;

            LblApellido.Focus ();
        }

        private void ActualizarPersonas()
        {
            LstPersonas.Items.Clear ();

            foreach (Persona persona in personas)
            {
                lstPersonas.Items.Add(persona.NombreCompleto()); // Agregar el nombre completo de la persona a la lista
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grabación Exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarForm();

            Persona nuevaPersona = new Persona("Apellido", "Nombre", "Tipo Dni", "Numero DNI", "Estado Civil");
            personas.add(nuevaPersona);

            ActualizarPersonas();
        }

            private void BtnEditar_Click(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = true;
            BtnCancelar.Enabled = true;

            LblApellido.Enabled = true;
            LblNombre.Enabled = true;
            LblTipoDni.Enabled = true;
            LblNumeroDni.Enabled = true;
            LblEstadoCivil.Enabled = true;

            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnSalir.Enabled = false;
            Lst.Enabled = false;

            LblApellido.Focus();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de querer borrar los datos?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes) {
                LblApellido.Enabled = true;
                LblNombre.Enabled = true;
                LblTipoDni.Enabled = true;
                LblNumeroDni.Enabled = true;
                LblEstadoCivil.Enabled = true;
                RadioBtnFemenino.Enabled = true;
                RadioBtnMaculino.Enabled = true;
                LblFallecido.Enabled = true;
                CheckBox.Enabled = true;

                BtnBorrar.Enabled = false;

                LblApellido.Text = string.Empty;
                LblNombre.Text = string.Empty;
                LblNumeroDni.Text = string.Empty;
                LblEstadoCivil.Text = string.Empty;
                LblTipoDni.Text = string.Empty;


                RadioBtnMaculino.Checked = false;
            } else
            {
                MessageBox.Show("Acción cancelada.");
            }
        }
    }
}
