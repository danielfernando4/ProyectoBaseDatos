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
    public partial class FormEliminarModelo : Form
    {
        public FormEliminarModelo()
        {
            InitializeComponent();
            this.opcionesEliminado.Items.Add("codigo_modelo");
            this.opcionesEliminado.Items.Add("valor_facial");
            this.opcionesEliminado.Items.Add("unidad_monetaria");
            this.opcionesEliminado.Items.Add("diametro");
            this.opcionesEliminado.Items.Add("peso");
            this.opcionesEliminado.Items.Add("descripcion");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexion = "Data Source=DESKTOP-LUT2TPL; Initial Catalog=NumismaticaBaseDatos; Integrated Security=SSPI";
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    string query = "DELETE FROM modelos WHERE " + this.opcionesEliminado.SelectedItem.ToString() + " = @opcion";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@opcion", this.txtCualidadEliminar);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Elemento(s) eliminado(s) con éxito");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
