namespace proyecto_2
{
    partial class consulta_expediente
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
            dgvExpediente = new DataGridView();
            dgvCodigo = new DataGridViewTextBoxColumn();
            dgvDni = new DataGridViewTextBoxColumn();
            dgvSolicitante = new DataGridViewTextBoxColumn();
            dgvTipo = new DataGridViewTextBoxColumn();
            dgvAsunto = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            lblMensaje = new Label();
            btnActualizar = new Button();
            btnOrdenar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpediente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(530, 60);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Expedientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(325, 21);
            label2.TabIndex = 1;
            label2.Text = "Lista de expedientes registrados en el sistema";
            // 
            // dgvExpediente
            // 
            dgvExpediente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpediente.Columns.AddRange(new DataGridViewColumn[] { dgvCodigo, dgvDni, dgvSolicitante, dgvTipo, dgvAsunto });
            dgvExpediente.Location = new Point(77, 164);
            dgvExpediente.Margin = new Padding(4, 4, 4, 4);
            dgvExpediente.Name = "dgvExpediente";
            dgvExpediente.RowHeadersWidth = 56;
            dgvExpediente.Size = new Size(696, 253);
            dgvExpediente.TabIndex = 2;
            // 
            // dgvCodigo
            // 
            dgvCodigo.HeaderText = "Codigo";
            dgvCodigo.MinimumWidth = 7;
            dgvCodigo.Name = "dgvCodigo";
            dgvCodigo.Width = 135;
            // 
            // dgvDni
            // 
            dgvDni.HeaderText = "DNI";
            dgvDni.MinimumWidth = 7;
            dgvDni.Name = "dgvDni";
            dgvDni.Width = 135;
            // 
            // dgvSolicitante
            // 
            dgvSolicitante.HeaderText = "Solicitante";
            dgvSolicitante.MinimumWidth = 7;
            dgvSolicitante.Name = "dgvSolicitante";
            dgvSolicitante.Width = 135;
            // 
            // dgvTipo
            // 
            dgvTipo.HeaderText = "Tipo de Documento";
            dgvTipo.MinimumWidth = 7;
            dgvTipo.Name = "dgvTipo";
            dgvTipo.Width = 135;
            // 
            // dgvAsunto
            // 
            dgvAsunto.HeaderText = "Asunto";
            dgvAsunto.MinimumWidth = 7;
            dgvAsunto.Name = "dgvAsunto";
            dgvAsunto.Width = 135;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(436, 327);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 30);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(55, 533);
            lblMensaje.Margin = new Padding(4, 0, 4, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(312, 21);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "Aqui se mostraran los mensajes del sistema";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.PeachPuff;
            btnActualizar.Location = new Point(130, 449);
            btnActualizar.Margin = new Padding(4, 4, 4, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(145, 64);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.AntiqueWhite;
            btnOrdenar.Location = new Point(333, 449);
            btnOrdenar.Margin = new Padding(4, 4, 4, 4);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(149, 64);
            btnOrdenar.TabIndex = 8;
            btnOrdenar.Text = "Ordenar por Codigo";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.Location = new Point(546, 449);
            btnCerrar.Margin = new Padding(4, 4, 4, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 64);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnCerrar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnActualizar);
            Controls.Add(lblMensaje);
            Controls.Add(dgvExpediente);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvExpediente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvExpediente;
        private DataGridViewTextBoxColumn dgvCodigo;
        private DataGridViewTextBoxColumn dgvDni;
        private DataGridViewTextBoxColumn dgvSolicitante;
        private DataGridViewTextBoxColumn dgvTipo;
        private DataGridViewTextBoxColumn dgvAsunto;
        private Button button1;
        private Button button2;
        private Button btnSalir;
        private Label lblMensaje;
        private Button btnActualizar;
        private Button btnOrdenar;
        private Button btnCerrar;
    }
}
