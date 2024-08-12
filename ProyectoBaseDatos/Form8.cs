using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoBaseDatos
{
    public partial class FormUpdateTronqueles : Form
    {
        private ConexionSQLServer conexionGenerador = new ConexionSQLServer();
        public FormUpdateTronqueles()
        {
            InitializeComponent();

            this.opcionesColumna.Items.Add("codigo_tronquel");
            this.opcionesColumna.Items.Add("codigo_modelo");
            this.opcionesColumna.Items.Add("año_acuñacion");
            this.opcionesColumna.Items.Add("año_grabado");
            this.opcionesColumna.Items.Add("descripcion");


            this.opcionesColumnaCondicion.Items.Add("codigo_tronquel");
            this.opcionesColumnaCondicion.Items.Add("codigo_modelo");
            this.opcionesColumnaCondicion.Items.Add("año_acuñacion");
            this.opcionesColumnaCondicion.Items.Add("año_grabado");
            this.opcionesColumnaCondicion.Items.Add("descripcion");
        }

        private void btnActualizarTronquel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionGenerador.StrConexion()))
                {
                    string columnaActualizar = this.opcionesColumna.SelectedItem.ToString();
                    string columnaCondicion = this.opcionesColumnaCondicion.SelectedItem.ToString();
                    string consulta = $"UPDATE tronqueles SET {columnaActualizar} = @valor WHERE {columnaCondicion} = @condicion";
                    using (SqlCommand command = new SqlCommand(consulta, conexion))
                    {
                        command.Parameters.AddWithValue("@valor", this.txtValor.Text);
                        command.Parameters.AddWithValue("@condicion", this.txtCondicion.Text);

                        conexion.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("valor insertado correctamente en la tabla tronqueles!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
