namespace proyecto_2
{
    public partial class consulta_expediente : Form
    {
        string archivo = Path.Combine(
            Application.StartupPath, "expedientes.txt");
        public consulta_expediente()
        {
            InitializeComponent();
        }

        void actualizarTabla()
        {
            dgvExpediente.Rows.Clear();

            if (!File.Exists(archivo))
            {
                lblMensaje.Text =
                    "Todavia no hay expedientes registrados";
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);
            int contador = 0;

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Trim() == "")
                {
                    continue;
                }

                string[] datos = lineas[i].Split('|');

                if (datos.Length == 6)
                {
                    dgvExpediente.Rows.Add(
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[3],
                        datos[4]);

                    contador++;
                }
            }

            lblMensaje.Text =
                "Expedientes encontrados: " + contador;
        }

        void ordenarExpedientes()
        {
            if (!File.Exists(archivo))
            {
                lblMensaje.Text =
                    "No hay expedientes para ordenar";
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);

            for (int i = 0; i < lineas.Length - 1; i++)
            {
                for (int j = 0; j < lineas.Length - 1 - i; j++)
                {
                    string[] datos1 = lineas[j].Split('|');
                    string[] datos2 = lineas[j + 1].Split('|');

                    if (datos1.Length == 6 && datos2.Length == 6)
                    {
                        if (string.Compare(
                            datos1[0], datos2[0],
                            StringComparison.OrdinalIgnoreCase) > 0)
                        {
                            string auxiliar = lineas[j];
                            lineas[j] = lineas[j + 1];
                            lineas[j + 1] = auxiliar;
                        }
                    }
                }
            }

            File.WriteAllLines(archivo, lineas);

            actualizarTabla();

            lblMensaje.Text =
                "Expedientes ordenados por codigo";
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

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenarExpedientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
    }
}
