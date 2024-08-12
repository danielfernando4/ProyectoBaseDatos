namespace ProyectoBaseDatos
{
    partial class FormUpdateModelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnActualizarModelo = new Button();
            lblTitulo = new Label();
            lblColumna = new Label();
            lblValor = new Label();
            lblCondicion = new Label();
            txtValor = new TextBox();
            txtCondicion = new TextBox();
            opcionesActualizar = new ComboBox();
            lblColumnaCondicion = new Label();
            opcionesCondicionColumna = new ComboBox();
            SuspendLayout();
            // 
            // btnActualizarModelo
            // 
            btnActualizarModelo.Location = new Point(392, 318);
            btnActualizarModelo.Name = "btnActualizarModelo";
            btnActualizarModelo.Size = new Size(166, 29);
            btnActualizarModelo.TabIndex = 0;
            btnActualizarModelo.Text = "Actualizar Modelo";
            btnActualizarModelo.UseVisualStyleBackColor = true;
            btnActualizarModelo.Click += btnActualizarModelo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(213, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(131, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Actualizar Modelo";
            // 
            // lblColumna
            // 
            lblColumna.AutoSize = true;
            lblColumna.Location = new Point(23, 98);
            lblColumna.Name = "lblColumna";
            lblColumna.Size = new Size(214, 20);
            lblColumna.TabIndex = 2;
            lblColumna.Text = "Ingrese la columna a actualizar";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(364, 98);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(175, 20);
            lblValor.TabIndex = 3;
            lblValor.Text = "Ingresa el valor a insertar";
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(72, 304);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(283, 20);
            lblCondicion.TabIndex = 4;
            lblCondicion.Text = "Ingrese la condición para la actualización";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(333, 156);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(206, 27);
            txtValor.TabIndex = 5;
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(119, 350);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(206, 27);
            txtCondicion.TabIndex = 6;
            // 
            // opcionesActualizar
            // 
            opcionesActualizar.FormattingEnabled = true;
            opcionesActualizar.Location = new Point(23, 156);
            opcionesActualizar.Name = "opcionesActualizar";
            opcionesActualizar.Size = new Size(151, 28);
            opcionesActualizar.TabIndex = 7;
            // 
            // lblColumnaCondicion
            // 
            lblColumnaCondicion.AutoSize = true;
            lblColumnaCondicion.Location = new Point(16, 213);
            lblColumnaCondicion.Name = "lblColumnaCondicion";
            lblColumnaCondicion.Size = new Size(240, 20);
            lblColumnaCondicion.TabIndex = 8;
            lblColumnaCondicion.Text = "Ingrese la columna de la condición";
            // 
            // opcionesCondicionColumna
            // 
            opcionesCondicionColumna.FormattingEnabled = true;
            opcionesCondicionColumna.Location = new Point(23, 252);
            opcionesCondicionColumna.Name = "opcionesCondicionColumna";
            opcionesCondicionColumna.Size = new Size(151, 28);
            opcionesCondicionColumna.TabIndex = 9;
            // 
            // FormUpdateModelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 425);
            Controls.Add(opcionesCondicionColumna);
            Controls.Add(lblColumnaCondicion);
            Controls.Add(opcionesActualizar);
            Controls.Add(txtCondicion);
            Controls.Add(txtValor);
            Controls.Add(lblCondicion);
            Controls.Add(lblValor);
            Controls.Add(lblColumna);
            Controls.Add(lblTitulo);
            Controls.Add(btnActualizarModelo);
            Name = "FormUpdateModelo";
            Text = "Actualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizarModelo;
        private Label lblTitulo;
        private Label lblColumna;
        private Label lblValor;
        private Label lblCondicion;
        private TextBox txtValor;
        private TextBox txtCondicion;
        private ComboBox opcionesActualizar;
        private Label lblColumnaCondicion;
        private ComboBox opcionesCondicionColumna;
    }
}