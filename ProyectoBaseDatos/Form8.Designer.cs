namespace ProyectoBaseDatos
{
    partial class FormUpdateTronqueles
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
            lblTitulo = new Label();
            lblColumna = new Label();
            lblValor = new Label();
            btnActualizarTronquel = new Button();
            opcionesColumna = new ComboBox();
            opcionesColumnaCondicion = new ComboBox();
            lblColumnaCondicion = new Label();
            lblCondicion = new Label();
            txtValor = new TextBox();
            txtCondicion = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(245, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(137, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Actualizar Tronquel";
            // 
            // lblColumna
            // 
            lblColumna.AutoSize = true;
            lblColumna.Location = new Point(30, 78);
            lblColumna.Name = "lblColumna";
            lblColumna.Size = new Size(237, 20);
            lblColumna.TabIndex = 1;
            lblColumna.Text = "Seleccione la columna a actualizar";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(386, 108);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(175, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "Ingrese el valor a insertar";
            // 
            // btnActualizarTronquel
            // 
            btnActualizarTronquel.Location = new Point(461, 307);
            btnActualizarTronquel.Name = "btnActualizarTronquel";
            btnActualizarTronquel.Size = new Size(157, 29);
            btnActualizarTronquel.TabIndex = 3;
            btnActualizarTronquel.Text = "Actualizar Tronquel";
            btnActualizarTronquel.UseVisualStyleBackColor = true;
            btnActualizarTronquel.Click += btnActualizarTronquel_Click;
            // 
            // opcionesColumna
            // 
            opcionesColumna.FormattingEnabled = true;
            opcionesColumna.Location = new Point(44, 124);
            opcionesColumna.Name = "opcionesColumna";
            opcionesColumna.Size = new Size(151, 28);
            opcionesColumna.TabIndex = 4;
            // 
            // opcionesColumnaCondicion
            // 
            opcionesColumnaCondicion.FormattingEnabled = true;
            opcionesColumnaCondicion.Location = new Point(44, 251);
            opcionesColumnaCondicion.Name = "opcionesColumnaCondicion";
            opcionesColumnaCondicion.Size = new Size(151, 28);
            opcionesColumnaCondicion.TabIndex = 5;
            // 
            // lblColumnaCondicion
            // 
            lblColumnaCondicion.AutoSize = true;
            lblColumnaCondicion.Location = new Point(30, 207);
            lblColumnaCondicion.Name = "lblColumnaCondicion";
            lblColumnaCondicion.Size = new Size(240, 20);
            lblColumnaCondicion.TabIndex = 6;
            lblColumnaCondicion.Text = "Ingrese la columna de la condición";
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(157, 307);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(216, 20);
            lblCondicion.TabIndex = 7;
            lblCondicion.Text = "Ingrese el valor de la condición";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(351, 152);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(225, 27);
            txtValor.TabIndex = 8;
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(172, 350);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(225, 27);
            txtCondicion.TabIndex = 9;
            // 
            // FormUpdateTronqueles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 413);
            Controls.Add(txtCondicion);
            Controls.Add(txtValor);
            Controls.Add(lblCondicion);
            Controls.Add(lblColumnaCondicion);
            Controls.Add(opcionesColumnaCondicion);
            Controls.Add(opcionesColumna);
            Controls.Add(btnActualizarTronquel);
            Controls.Add(lblValor);
            Controls.Add(lblColumna);
            Controls.Add(lblTitulo);
            Name = "FormUpdateTronqueles";
            Text = "Actualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblColumna;
        private Label lblValor;
        private Button btnActualizarTronquel;
        private ComboBox opcionesColumna;
        private ComboBox opcionesColumnaCondicion;
        private Label lblColumnaCondicion;
        private Label lblCondicion;
        private TextBox txtValor;
        private TextBox txtCondicion;
    }
}