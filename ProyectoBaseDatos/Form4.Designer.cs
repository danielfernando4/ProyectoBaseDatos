namespace ProyectoBaseDatos
{
    partial class FormInsertarTronquel
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
            lblCodigoTronquel = new Label();
            lblCodigoModelo = new Label();
            lblAnioAcu = new Label();
            lblAnioGrabado = new Label();
            lblDescripcion = new Label();
            txtCodigoTronquel = new TextBox();
            txtCodigoModelo = new TextBox();
            txtAnioAcu = new TextBox();
            txtAnioGrab = new TextBox();
            txtDescripcion = new TextBox();
            btnIngresarTronquel = new Button();
            SuspendLayout();
            // 
            // lblCodigoTronquel
            // 
            lblCodigoTronquel.AutoSize = true;
            lblCodigoTronquel.Location = new Point(26, 49);
            lblCodigoTronquel.Name = "lblCodigoTronquel";
            lblCodigoTronquel.Size = new Size(209, 20);
            lblCodigoTronquel.TabIndex = 0;
            lblCodigoTronquel.Text = "Ingrese el código del tronquel";
            // 
            // lblCodigoModelo
            // 
            lblCodigoModelo.AutoSize = true;
            lblCodigoModelo.Location = new Point(26, 159);
            lblCodigoModelo.Name = "lblCodigoModelo";
            lblCodigoModelo.Size = new Size(205, 20);
            lblCodigoModelo.TabIndex = 1;
            lblCodigoModelo.Text = "Ingrese el código del modelo";
            // 
            // lblAnioAcu
            // 
            lblAnioAcu.AutoSize = true;
            lblAnioAcu.Location = new Point(26, 267);
            lblAnioAcu.Name = "lblAnioAcu";
            lblAnioAcu.Size = new Size(194, 20);
            lblAnioAcu.TabIndex = 2;
            lblAnioAcu.Text = "Ingrese el año de acuñación";
            // 
            // lblAnioGrabado
            // 
            lblAnioGrabado.AutoSize = true;
            lblAnioGrabado.Location = new Point(364, 49);
            lblAnioGrabado.Name = "lblAnioGrabado";
            lblAnioGrabado.Size = new Size(184, 20);
            lblAnioGrabado.TabIndex = 3;
            lblAnioGrabado.Text = "Ingrese el año de grabado";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(364, 159);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(153, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Ingrese la descripción";
            // 
            // txtCodigoTronquel
            // 
            txtCodigoTronquel.Location = new Point(56, 97);
            txtCodigoTronquel.Name = "txtCodigoTronquel";
            txtCodigoTronquel.Size = new Size(237, 27);
            txtCodigoTronquel.TabIndex = 5;
            // 
            // txtCodigoModelo
            // 
            txtCodigoModelo.Location = new Point(56, 214);
            txtCodigoModelo.Name = "txtCodigoModelo";
            txtCodigoModelo.Size = new Size(237, 27);
            txtCodigoModelo.TabIndex = 6;
            // 
            // txtAnioAcu
            // 
            txtAnioAcu.Location = new Point(56, 302);
            txtAnioAcu.Name = "txtAnioAcu";
            txtAnioAcu.Size = new Size(237, 27);
            txtAnioAcu.TabIndex = 7;
            // 
            // txtAnioGrab
            // 
            txtAnioGrab.Location = new Point(406, 97);
            txtAnioGrab.Name = "txtAnioGrab";
            txtAnioGrab.Size = new Size(237, 27);
            txtAnioGrab.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(406, 214);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(237, 27);
            txtDescripcion.TabIndex = 9;
            // 
            // btnIngresarTronquel
            // 
            btnIngresarTronquel.Location = new Point(445, 277);
            btnIngresarTronquel.Name = "btnIngresarTronquel";
            btnIngresarTronquel.Size = new Size(189, 29);
            btnIngresarTronquel.TabIndex = 10;
            btnIngresarTronquel.Text = "Ingresar campos";
            btnIngresarTronquel.UseVisualStyleBackColor = true;
            btnIngresarTronquel.Click += btnIngresarTronquel_Click;
            // 
            // FormInsertarTronquel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 352);
            Controls.Add(btnIngresarTronquel);
            Controls.Add(txtDescripcion);
            Controls.Add(txtAnioGrab);
            Controls.Add(txtAnioAcu);
            Controls.Add(txtCodigoModelo);
            Controls.Add(txtCodigoTronquel);
            Controls.Add(lblDescripcion);
            Controls.Add(lblAnioGrabado);
            Controls.Add(lblAnioAcu);
            Controls.Add(lblCodigoModelo);
            Controls.Add(lblCodigoTronquel);
            Name = "FormInsertarTronquel";
            Text = "Insertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoTronquel;
        private Label lblCodigoModelo;
        private Label lblAnioAcu;
        private Label lblAnioGrabado;
        private Label lblDescripcion;
        private TextBox txtCodigoTronquel;
        private TextBox txtCodigoModelo;
        private TextBox txtAnioAcu;
        private TextBox txtAnioGrab;
        private TextBox txtDescripcion;
        private Button btnIngresarTronquel;
    }
}