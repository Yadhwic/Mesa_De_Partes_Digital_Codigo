7namespace _3
{
    public partial class Form1 : Form
    {

        string archivo = Path.Combine(Application.StartupPath, "expedientes.txt");

        public Form1()
        {
            InitializeComponent();
        }

        void buscarExpediente()
        {
            string codigoBuscado = txtCodigoBuscar.Text.Trim();

            if (codigoBuscado == "")
            {
                MessageBox.Show("Debe ingresar un código para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBuscar.Focus();
                return;
            }

            if (!File.Exists(archivo))
            {
                MessageBox.Show("No existe el archivo de expedientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);
            bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }

                string[] datos = lineas[i].Split('|');

                if (datos.Length == 6 && datos[0].Equals(codigoBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    string resultado = "¡Expediente Encontrado!\n\n" +
                                       "Código: " + datos[0] + "\n" +
                                       "DNI: " + datos[1] + "\n" +
                                       "Solicitante: " + datos[2] + "\n" +
                                       "Tipo de Documento: " + datos[3] + "\n" +
                                       "Asunto: " + datos[4] + "\n" +
                                       "Fecha: " + datos[5];

                    MessageBox.Show(resultado, "Resultado de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Mensaje: El código de expediente no existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        void limpiar()
        {
            txtCodigoBuscar.Clear();
            txtCodigoBuscar.Focus();
        }

        void cerrar()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la búsqueda?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarExpediente();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrar();
        }
    }
}
