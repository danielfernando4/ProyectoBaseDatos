﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBaseDatos
{
    public partial class FormEliminarTronqueles : Form
    {
        private ConexionSQLServer conexionGenerador = new ConexionSQLServer();
        public FormEliminarTronqueles()
        {
            InitializeComponent();
            this.opcionesEliminar.Items.Add("codigo_tronquel");
            this.opcionesEliminar.Items.Add("codigo_modelo");
            this.opcionesEliminar.Items.Add("año_acuñacion");
            this.opcionesEliminar.Items.Add("año_grabado");
            this.opcionesEliminar.Items.Add("descripcion");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexion = conexionGenerador.StrConexion();
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    string query = "DELETE FROM tronqueles WHERE " + this.opcionesEliminar.SelectedItem.ToString() + " = @opcion";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@opcion", this.txtCualidadEliminar.Text);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Elemento(s) eliminado(s) con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
