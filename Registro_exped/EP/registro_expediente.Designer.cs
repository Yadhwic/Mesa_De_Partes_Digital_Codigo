namespace EP
{
    partial class registro_expediente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpFecha = new DateTimePicker();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtCodigo = new TextBox();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            cmbTipo = new ComboBox();
            txtAsunto = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 45);
            label1.TabIndex = 0;
            label1.Text = "Registro de Expediente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 1;
            label2.Text = "Codigo de Expediente: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 132);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "DNI: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 181);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 21);
            label4.TabIndex = 3;
            label4.Text = "Nombre del Ciudadano: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 21);
            label5.TabIndex = 4;
            label5.Text = "Tipo de documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 304);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 5;
            label6.Text = "Asunto del Tramite:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 447);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 21);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Recepcion:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(141, 472);
            dtpFecha.Margin = new Padding(4, 4, 4, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(256, 29);
            dtpFecha.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Bisque;
            btnLimpiar.Location = new Point(203, 540);
            btnLimpiar.Margin = new Padding(4, 4, 4, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 67);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.Location = new Point(364, 540);
            btnCerrar.Margin = new Padding(4, 4, 4, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(137, 67);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(215, 73);
            txtCodigo.Margin = new Padding(4, 4, 4, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(239, 29);
            txtCodigo.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(87, 127);
            txtDni.Margin = new Padding(4, 4, 4, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(273, 29);
            txtDni.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 206);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(505, 29);
            txtNombre.TabIndex = 13;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(188, 252);
            cmbTipo.Margin = new Padding(4, 4, 4, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(226, 29);
            cmbTipo.TabIndex = 14;
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(33, 329);
            txtAsunto.Margin = new Padding(4, 4, 4, 4);
            txtAsunto.Multiline = true;
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(468, 112);
            txtAsunto.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.Location = new Point(33, 540);
            btnRegistrar.Margin = new Padding(4, 4, 4, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 65);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 630);
            Controls.Add(btnRegistrar);
            Controls.Add(txtAsunto);
            Controls.Add(cmbTipo);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(txtCodigo);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(dtpFecha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFecha;
        private Button btnLimpiar;
        private Button button2;
        private Button btnCerrar;
        private TextBox txtCodigo;
        private TextBox txtDni;
        private TextBox txtNombre;
        private ComboBox cmbTipo;
        private TextBox txtAsunto;
        private Button btnRegistrar;
    }
}
