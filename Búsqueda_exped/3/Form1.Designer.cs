namespace _3
{
    partial class Form1
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
            txtCodigoBuscar = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            grpResultado = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(448, 50);
            label1.TabIndex = 0;
            label1.Text = "Busqueda de Expediente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 1;
            label2.Text = "Codigo de Expediente:";
            // 
            // txtCodigoBuscar
            // 
            txtCodigoBuscar.Location = new Point(57, 134);
            txtCodigoBuscar.Margin = new Padding(4, 4, 4, 4);
            txtCodigoBuscar.Name = "txtCodigoBuscar";
            txtCodigoBuscar.Size = new Size(544, 29);
            txtCodigoBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Moccasin;
            btnBuscar.Location = new Point(73, 209);
            btnBuscar.Margin = new Padding(4, 4, 4, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 57);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.PeachPuff;
            btnLimpiar.Location = new Point(255, 209);
            btnLimpiar.Margin = new Padding(4, 4, 4, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 57);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.Location = new Point(424, 209);
            btnSalir.Margin = new Padding(4, 4, 4, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 57);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // grpResultado
            // 
            grpResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpResultado.Location = new Point(73, 315);
            grpResultado.Margin = new Padding(4, 4, 4, 4);
            grpResultado.Name = "grpResultado";
            grpResultado.Padding = new Padding(4, 4, 4, 4);
            grpResultado.Size = new Size(508, 255);
            grpResultado.TabIndex = 6;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado de Busqueda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 630);
            Controls.Add(grpResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigoBuscar);
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
        private TextBox txtCodigoBuscar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnSalir;
        private GroupBox grpResultado;
    }
}
