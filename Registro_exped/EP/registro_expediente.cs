namespace EP
{
    public partial class registro_expediente : Form
    {

        public static int max = 100;

        public static string[] codigos = new string[max];
        public static string[] dnis = new string[max];
        public static string[] solicitantes = new string[max];
        public static string[] tiposDocumentos = new string[max];
        public static string[] asuntos = new string[max];
        public static string[] fechas = new string[max];

        public static int cantidad = 0;

        string archivo = Path.Combine(
            Application.StartupPath, "expedientes.txt");


        public registro_expediente()
        {
            InitializeComponent();

            {
                cmbTipo.Items.Clear();
                cmbTipo.Items.Add("Solicitud");
                cmbTipo.Items.Add("Carta");
                cmbTipo.Items.Add("Oficio");
                cmbTipo.Items.Add("Reclamo");
            }

        }
        bool validarDni(string dni)
        {
            if (dni.Length != 8)
            {
                return false;
            }

            for (int i = 0; i < dni.Length; i++)
            {
                if (dni[i] < '0' || dni[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }

        bool existeCodigo(string codigo)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (codigos[i] == codigo)
                {
                    return true;
                }
            }

            return false;
        }

        void registrarExpediente()
        {
            string codigo = txtCodigo.Text.Trim();
            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string tipo = cmbTipo.Text;
            string asunto = txtAsunto.Text.Trim();
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            if (codigo == "" || dni == "" ||
                nombre == "" || tipo == "" || asunto == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

           if (!validarDni(dni))
            {
                MessageBox.Show("El DNI debe tener 8 digitos numericos");
                return;
            }

            if (existeCodigo(codigo))
            {
                MessageBox.Show("El codigo de expediente ya existe");
                return;
            }

            if (cantidad >= max)
            {
                MessageBox.Show("Se alcanzo el limite de expedientes");
                return;
            }

            try
            {
                asunto = asunto.Replace("|", "/");

                codigos[cantidad] = codigo;
                dnis[cantidad] = dni;
                solicitantes[cantidad] = nombre;
                tiposDocumentos[cantidad] = tipo;
                asuntos[cantidad] = asunto;
                fechas[cantidad] = fecha;

                string linea = codigo + "|" + dni + "|" +
                    nombre + "|" + tipo + "|" + asunto + "|" + fecha;

                File.AppendAllText(
                    archivo, linea + Environment.NewLine);

                cantidad++;

                MessageBox.Show(
                    "Expediente registrado correctamente");

                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el expediente");
            }
        }

        void limpiar()
        {
            txtCodigo.Clear();
            txtDni.Clear();
            txtNombre.Clear();
            txtAsunto.Clear();

            cmbTipo.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;

            txtCodigo.Focus();
        }

        void cerrar()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar el formulario?",
                "Cerrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarExpediente();
        }
    }
}
