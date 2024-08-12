namespace ProyectoBaseDatos
{
    partial class FormEliminarTronqueles
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
            lblCualidadEliminar = new Label();
            opcionesEliminar = new ComboBox();
            txtCualidadEliminar = new TextBox();
            btnEliminar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(135, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Eliminar Tronquel";
            // 
            // lblCualidadEliminar
            // 
            lblCualidadEliminar.AutoSize = true;
            lblCualidadEliminar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCualidadEliminar.Location = new Point(325, 71);
            lblCualidadEliminar.Name = "lblCualidadEliminar";
            lblCualidadEliminar.Size = new Size(234, 20);
            lblCualidadEliminar.TabIndex = 1;
            lblCualidadEliminar.Text = "Ingresa la cualidad a eliminar";
            // 
            // opcionesEliminar
            // 
            opcionesEliminar.FormattingEnabled = true;
            opcionesEliminar.Location = new Point(28, 107);
            opcionesEliminar.Name = "opcionesEliminar";
            opcionesEliminar.Size = new Size(151, 28);
            opcionesEliminar.TabIndex = 2;
            // 
            // txtCualidadEliminar
            // 
            txtCualidadEliminar.Location = new Point(295, 107);
            txtCualidadEliminar.Name = "txtCualidadEliminar";
            txtCualidadEliminar.Size = new Size(251, 27);
            txtCualidadEliminar.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(387, 185);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(-2, 85);
            label1.Name = "label1";
            label1.Size = new Size(283, 20);
            label1.TabIndex = 5;
            label1.Text = "Seleccione la columna de referencia";
            // 
            // FormEliminarTronqueles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 245);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(txtCualidadEliminar);
            Controls.Add(opcionesEliminar);
            Controls.Add(lblCualidadEliminar);
            Controls.Add(lblTitulo);
            Name = "FormEliminarTronqueles";
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCualidadEliminar;
        private ComboBox opcionesEliminar;
        private TextBox txtCualidadEliminar;
        private Button btnEliminar;
        private Label label1;
    }
}