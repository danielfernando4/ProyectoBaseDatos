﻿namespace ProyectoBaseDatos
{
    partial class FormEliminarModelo
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
            opcionesEliminado = new ComboBox();
            txtCualidadEliminar = new TextBox();
            lblCualidadEliminar = new Label();
            lblComboBox = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(173, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Eliminar Modelo";
            // 
            // opcionesEliminado
            // 
            opcionesEliminado.FormattingEnabled = true;
            opcionesEliminado.Location = new Point(28, 98);
            opcionesEliminado.Name = "opcionesEliminado";
            opcionesEliminado.Size = new Size(151, 28);
            opcionesEliminado.TabIndex = 1;
            // 
            // txtCualidadEliminar
            // 
            txtCualidadEliminar.Location = new Point(261, 119);
            txtCualidadEliminar.Name = "txtCualidadEliminar";
            txtCualidadEliminar.Size = new Size(250, 27);
            txtCualidadEliminar.TabIndex = 2;
            // 
            // lblCualidadEliminar
            // 
            lblCualidadEliminar.AutoSize = true;
            lblCualidadEliminar.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblCualidadEliminar.Location = new Point(261, 92);
            lblCualidadEliminar.Name = "lblCualidadEliminar";
            lblCualidadEliminar.Size = new Size(268, 24);
            lblCualidadEliminar.TabIndex = 3;
            lblCualidadEliminar.Text = "Ingrese la cualidad a eliminar";
            // 
            // lblComboBox
            // 
            lblComboBox.AutoSize = true;
            lblComboBox.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold | FontStyle.Italic);
            lblComboBox.Location = new Point(27, 68);
            lblComboBox.Name = "lblComboBox";
            lblComboBox.Size = new Size(117, 24);
            lblComboBox.TabIndex = 4;
            lblComboBox.Text = "Eliminar por";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(307, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormEliminarModelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 220);
            Controls.Add(btnEliminar);
            Controls.Add(lblComboBox);
            Controls.Add(lblCualidadEliminar);
            Controls.Add(txtCualidadEliminar);
            Controls.Add(opcionesEliminado);
            Controls.Add(lblTitulo);
            Name = "FormEliminarModelo";
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox opcionesEliminado;
        private TextBox txtCualidadEliminar;
        private Label lblCualidadEliminar;
        private Label lblComboBox;
        private Button btnEliminar;
    }
}