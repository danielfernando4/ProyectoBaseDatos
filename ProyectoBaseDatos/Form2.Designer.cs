namespace ProyectoBaseDatos
{
    partial class Form2
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
            tablaElementos = new DataGridView();
            btnSalirAdmin = new Button();
            menuStrip1 = new MenuStrip();
            itemInsertarElemento = new ToolStripMenuItem();
            itemInsertarModelo = new ToolStripMenuItem();
            itemInsertarTronquel = new ToolStripMenuItem();
            itemEliminarElemento = new ToolStripMenuItem();
            itemEliminarModelo = new ToolStripMenuItem();
            itemEliminarTronquel = new ToolStripMenuItem();
            itemActualizarElemento = new ToolStripMenuItem();
            itemActualizarModelo = new ToolStripMenuItem();
            itemActualizarTronquel = new ToolStripMenuItem();
            itemMostrarElementos = new ToolStripMenuItem();
            itemFiltrar = new ToolStripMenuItem();
            txtValorRead = new ToolStripTextBox();
            txtValor = new ToolStripTextBox();
            opcionesFiltrado = new ToolStripComboBox();
            opcionesCondicion = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)tablaElementos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tablaElementos
            // 
            tablaElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaElementos.Location = new Point(23, 67);
            tablaElementos.Name = "tablaElementos";
            tablaElementos.RowHeadersWidth = 51;
            tablaElementos.Size = new Size(1042, 496);
            tablaElementos.TabIndex = 0;
            // 
            // btnSalirAdmin
            // 
            btnSalirAdmin.Location = new Point(955, 585);
            btnSalirAdmin.Name = "btnSalirAdmin";
            btnSalirAdmin.Size = new Size(94, 29);
            btnSalirAdmin.TabIndex = 1;
            btnSalirAdmin.Text = "SALIR";
            btnSalirAdmin.UseVisualStyleBackColor = true;
            btnSalirAdmin.Click += btnSalirAdmin_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemInsertarElemento, itemEliminarElemento, itemActualizarElemento, itemMostrarElementos, itemFiltrar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1090, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemInsertarElemento
            // 
            itemInsertarElemento.DropDownItems.AddRange(new ToolStripItem[] { itemInsertarModelo, itemInsertarTronquel });
            itemInsertarElemento.Name = "itemInsertarElemento";
            itemInsertarElemento.Size = new Size(139, 24);
            itemInsertarElemento.Text = "insertar elemento";
            // 
            // itemInsertarModelo
            // 
            itemInsertarModelo.Name = "itemInsertarModelo";
            itemInsertarModelo.Size = new Size(201, 26);
            itemInsertarModelo.Text = "Insertar modelo";
            itemInsertarModelo.Click += itemInsertarModelo_Click;
            // 
            // itemInsertarTronquel
            // 
            itemInsertarTronquel.Name = "itemInsertarTronquel";
            itemInsertarTronquel.Size = new Size(201, 26);
            itemInsertarTronquel.Text = "Insertar tronquel";
            itemInsertarTronquel.Click += itemInsertarTronquel_Click;
            // 
            // itemEliminarElemento
            // 
            itemEliminarElemento.DropDownItems.AddRange(new ToolStripItem[] { itemEliminarModelo, itemEliminarTronquel });
            itemEliminarElemento.Name = "itemEliminarElemento";
            itemEliminarElemento.Size = new Size(144, 24);
            itemEliminarElemento.Text = "Eliminar elemento";
            // 
            // itemEliminarModelo
            // 
            itemEliminarModelo.Name = "itemEliminarModelo";
            itemEliminarModelo.Size = new Size(206, 26);
            itemEliminarModelo.Text = "Eliminar modelo";
            itemEliminarModelo.Click += itemEliminarModelo_Click;
            // 
            // itemEliminarTronquel
            // 
            itemEliminarTronquel.Name = "itemEliminarTronquel";
            itemEliminarTronquel.Size = new Size(206, 26);
            itemEliminarTronquel.Text = "Eliminar tronquel";
            itemEliminarTronquel.Click += itemEliminarTronquel_Click;
            // 
            // itemActualizarElemento
            // 
            itemActualizarElemento.DropDownItems.AddRange(new ToolStripItem[] { itemActualizarModelo, itemActualizarTronquel });
            itemActualizarElemento.Name = "itemActualizarElemento";
            itemActualizarElemento.Size = new Size(156, 24);
            itemActualizarElemento.Text = "Actualizar elemento";
            // 
            // itemActualizarModelo
            // 
            itemActualizarModelo.Name = "itemActualizarModelo";
            itemActualizarModelo.Size = new Size(224, 26);
            itemActualizarModelo.Text = "Actualizar modelo";
            itemActualizarModelo.Click += itemActualizarModelo_Click;
            // 
            // itemActualizarTronquel
            // 
            itemActualizarTronquel.Name = "itemActualizarTronquel";
            itemActualizarTronquel.Size = new Size(224, 26);
            itemActualizarTronquel.Text = "Actualizar tronquel";
            itemActualizarTronquel.Click += itemActualizarTronquel_Click;
            // 
            // itemMostrarElementos
            // 
            itemMostrarElementos.Name = "itemMostrarElementos";
            itemMostrarElementos.Size = new Size(147, 24);
            itemMostrarElementos.Text = "mostrar elementos";
            itemMostrarElementos.Click += itemMostrarElementos_Click;
            // 
            // itemFiltrar
            // 
            itemFiltrar.DropDownItems.AddRange(new ToolStripItem[] { txtValorRead, txtValor, opcionesFiltrado, opcionesCondicion });
            itemFiltrar.Name = "itemFiltrar";
            itemFiltrar.Size = new Size(61, 24);
            itemFiltrar.Text = "Filtrar";
            itemFiltrar.Click += itemFiltrar_Click;
            // 
            // txtValorRead
            // 
            txtValorRead.Name = "txtValorRead";
            txtValorRead.ReadOnly = true;
            txtValorRead.Size = new Size(100, 27);
            txtValorRead.Text = "valor:";
            // 
            // txtValor
            // 
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 27);
            // 
            // opcionesFiltrado
            // 
            opcionesFiltrado.Name = "opcionesFiltrado";
            opcionesFiltrado.Size = new Size(121, 28);
            opcionesFiltrado.Text = "Columna";
            opcionesFiltrado.Click += opcionesFiltrado_Click;
            // 
            // opcionesCondicion
            // 
            opcionesCondicion.Name = "opcionesCondicion";
            opcionesCondicion.Size = new Size(121, 28);
            opcionesCondicion.Text = "Condición";
            opcionesCondicion.Click += opcionesCondicion_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 633);
            Controls.Add(btnSalirAdmin);
            Controls.Add(tablaElementos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)tablaElementos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaElementos;
        private Button btnSalirAdmin;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemInsertarElemento;
        private ToolStripMenuItem itemInsertarModelo;
        private ToolStripMenuItem itemInsertarTronquel;
        private ToolStripMenuItem itemEliminarElemento;
        private ToolStripMenuItem itemEliminarModelo;
        private ToolStripMenuItem itemEliminarTronquel;
        private ToolStripMenuItem itemActualizarElemento;
        private ToolStripMenuItem itemActualizarModelo;
        private ToolStripMenuItem itemActualizarTronquel;
        private ToolStripMenuItem itemMostrarElementos;
        private ToolStripMenuItem itemFiltrar;
        private ToolStripTextBox txtValorRead;
        private ToolStripTextBox txtValor;
        private ToolStripComboBox opcionesFiltrado;
        private ToolStripComboBox opcionesCondicion;
    }
}