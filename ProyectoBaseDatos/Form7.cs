using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace ProyectoBaseDatos
{
    public partial class FormUpdateModelo : Form
    {
        private ConexionSQLServer conexionGenerador = new ConexionSQLServer();
        public FormUpdateModelo()
        {
            InitializeComponent();

            this.opcionesActualizar.Items.Add("codigo_modelo");
            this.opcionesActualizar.Items.Add("valor_facial");
            this.opcionesActualizar.Items.Add("unidad_monetaria");
            this.opcionesActualizar.Items.Add("diametro");
            this.opcionesActualizar.Items.Add("peso");
            this.opcionesActualizar.Items.Add("descripcion");

            this.opcionesCondicionColumna.Items.Add("codigo_modelo");
            this.opcionesCondicionColumna.Items.Add("valor_facial");
            this.opcionesCondicionColumna.Items.Add("unidad_monetaria");
            this.opcionesCondicionColumna.Items.Add("diametro");
            this.opcionesCondicionColumna.Items.Add("peso");
            this.opcionesCondicionColumna.Items.Add("descripcion");
        }

        private void btnActualizarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionGenerador.StrConexion()))
                {
                    string columnaActualizar = this.opcionesActualizar.SelectedItem.ToString();
                    string columnaCondicion = this.opcionesCondicionColumna.SelectedItem.ToString();
                    string consulta = $"UPDATE modelos SET {columnaActualizar} = @valor WHERE {columnaCondicion} = @condicion";
                    using (SqlCommand command = new SqlCommand(consulta, conexion))
                    {
                        command.Parameters.AddWithValue("@valor",this.txtValor.Text);
                        command.Parameters.AddWithValue("@condicion", this.txtCondicion.Text);

                        conexion.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("valor insertado correctamente en la tabla modelo!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
