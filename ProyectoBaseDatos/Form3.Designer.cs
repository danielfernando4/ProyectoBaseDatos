namespace ProyectoBaseDatos
{
    partial class FormInsertarModelo
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
            txtCodigoM = new TextBox();
            txtDescripcion = new TextBox();
            txtValorFacial = new TextBox();
            txtUnidadMonetaria = new TextBox();
            lblModelo = new Label();
            lblValorFacial = new Label();
            lblUnidadM = new Label();
            lblDiametro = new Label();
            lblDescripcion = new Label();
            lblPeso = new Label();
            txtPeso = new TextBox();
            txtDiametro = new TextBox();
            lblTitulo = new Label();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // txtCodigoM
            // 
            txtCodigoM.Location = new Point(125, 115);
            txtCodigoM.Name = "txtCodigoM";
            txtCodigoM.Size = new Size(285, 27);
            txtCodigoM.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(488, 334);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(285, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtValorFacial
            // 
            txtValorFacial.Location = new Point(488, 115);
            txtValorFacial.Name = "txtValorFacial";
            txtValorFacial.Size = new Size(285, 27);
            txtValorFacial.TabIndex = 2;
            // 
            // txtUnidadMonetaria
            // 
            txtUnidadMonetaria.Location = new Point(125, 212);
            txtUnidadMonetaria.Name = "txtUnidadMonetaria";
            txtUnidadMonetaria.Size = new Size(285, 27);
            txtUnidadMonetaria.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(29, 79);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(205, 20);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Ingrese el código del modelo";
            // 
            // lblValorFacial
            // 
            lblValorFacial.AutoSize = true;
            lblValorFacial.Location = new Point(503, 79);
            lblValorFacial.Name = "lblValorFacial";
            lblValorFacial.Size = new Size(150, 20);
            lblValorFacial.TabIndex = 5;
            lblValorFacial.Text = "Ingrese el valor facial";
            // 
            // lblUnidadM
            // 
            lblUnidadM.AutoSize = true;
            lblUnidadM.Location = new Point(29, 166);
            lblUnidadM.Name = "lblUnidadM";
            lblUnidadM.Size = new Size(195, 20);
            lblUnidadM.TabIndex = 6;
            lblUnidadM.Text = "Ingrese la unidad monetaria";
            // 
            // lblDiametro
            // 
            lblDiametro.AutoSize = true;
            lblDiametro.Location = new Point(29, 287);
            lblDiametro.Name = "lblDiametro";
            lblDiametro.Size = new Size(138, 20);
            lblDiametro.TabIndex = 7;
            lblDiametro.Text = "Ingrese el diametro";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(488, 287);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(153, 20);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Ingrese la descripción";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(488, 166);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(109, 20);
            lblPeso.TabIndex = 9;
            lblPeso.Text = "Ingrese el peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(488, 212);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(285, 27);
            txtPeso.TabIndex = 10;
            // 
            // txtDiametro
            // 
            txtDiametro.Location = new Point(125, 334);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(285, 27);
            txtDiametro.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(317, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(191, 20);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Insertar Valores del Modelo";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(334, 395);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(194, 29);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar Campos";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // FormInsertarModelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 448);
            Controls.Add(btnInsertar);
            Controls.Add(lblTitulo);
            Controls.Add(txtDiametro);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(lblDescripcion);
            Controls.Add(lblDiametro);
            Controls.Add(lblUnidadM);
            Controls.Add(lblValorFacial);
            Controls.Add(lblModelo);
            Controls.Add(txtUnidadMonetaria);
            Controls.Add(txtValorFacial);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigoM);
            Name = "FormInsertarModelo";
            Text = "Insertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigoM;
        private TextBox txtDescripcion;
        private TextBox txtValorFacial;
        private TextBox txtUnidadMonetaria;
        private Label lblModelo;
        private Label lblValorFacial;
        private Label lblUnidadM;
        private Label lblDiametro;
        private Label lblDescripcion;
        private Label lblPeso;
        private TextBox txtPeso;
        private TextBox txtDiametro;
        private Label lblTitulo;
        private Button btnInsertar;
    }
}