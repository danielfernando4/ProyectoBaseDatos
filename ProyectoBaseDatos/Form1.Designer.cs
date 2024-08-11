namespace ProyectoBaseDatos
{
    partial class FormNumesmatica
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
            tablaDatos = new DataGridView();
            comboFiltros = new ComboBox();
            btnConsulta = new Button();
            txtConsulta = new TextBox();
            lblTitulo = new Label();
            lblTituloTabla = new Label();
            lblConsulta = new Label();
            btnAdministracion = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaDatos).BeginInit();
            SuspendLayout();
            // 
            // tablaDatos
            // 
            tablaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos.Location = new Point(29, 104);
            tablaDatos.Name = "tablaDatos";
            tablaDatos.RowHeadersWidth = 51;
            tablaDatos.Size = new Size(722, 514);
            tablaDatos.TabIndex = 0;
            // 
            // comboFiltros
            // 
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(780, 81);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(151, 28);
            comboFiltros.TabIndex = 1;
            comboFiltros.SelectedIndexChanged += comboFiltros_SelectedIndexChanged;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(807, 353);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(144, 29);
            btnConsulta.TabIndex = 2;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(769, 192);
            txtConsulta.Multiline = true;
            txtConsulta.Name = "txtConsulta";
            txtConsulta.PlaceholderText = "Escribe una consulta SQL con SELECT...";
            txtConsulta.Size = new Size(499, 129);
            txtConsulta.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(1, -1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(318, 37);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Empresa Numesmática";
            // 
            // lblTituloTabla
            // 
            lblTituloTabla.AutoSize = true;
            lblTituloTabla.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloTabla.Location = new Point(263, 60);
            lblTituloTabla.Name = "lblTituloTabla";
            lblTituloTabla.Size = new Size(319, 31);
            lblTituloTabla.TabIndex = 5;
            lblTituloTabla.Text = "Tabla resultados de SELECT";
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConsulta.Location = new Point(873, 145);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(282, 27);
            lblConsulta.TabIndex = 6;
            lblConsulta.Text = "Escribe una consulta SELECT";
            // 
            // btnAdministracion
            // 
            btnAdministracion.Location = new Point(932, 449);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(310, 52);
            btnAdministracion.TabIndex = 7;
            btnAdministracion.Text = "Ir al apartado de administración";
            btnAdministracion.UseVisualStyleBackColor = true;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1132, 543);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 53);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormNumesmatica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 650);
            Controls.Add(btnSalir);
            Controls.Add(btnAdministracion);
            Controls.Add(lblConsulta);
            Controls.Add(lblTituloTabla);
            Controls.Add(lblTitulo);
            Controls.Add(txtConsulta);
            Controls.Add(btnConsulta);
            Controls.Add(comboFiltros);
            Controls.Add(tablaDatos);
            Name = "FormNumesmatica";
            Text = "Numesmática";
            ((System.ComponentModel.ISupportInitialize)tablaDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaDatos;
        private ComboBox comboFiltros;
        private Button btnConsulta;
        private TextBox txtConsulta;
        private Label lblTitulo;
        private Label lblTituloTabla;
        private Label lblConsulta;
        private Button btnAdministracion;
        private Button btnSalir;
    }
}
