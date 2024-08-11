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
    public partial class FormInsertarTronquel : Form
    {
        public FormInsertarTronquel()
        {
            InitializeComponent();
        }

        private void btnIngresarTronquel_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexion = "Data Source=DESKTOP-LUT2TPL; Initial Catalog=NumismaticaBaseDatos; Integrated Security=SSPI";
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    string query = "INSERT INTO tronqueles VALUES(@codigo_tronquel, @codigo_modelo, @año_acuñacion, @año_grabado, @descripcion)";
                    SqlCommand command = new SqlCommand(query, conexion);

                    command.Parameters.AddWithValue("@codigo_tronquel", txtCodigoTronquel.Text);
                    command.Parameters.AddWithValue("@codigo_modelo", txtCodigoModelo.Text);
                    command.Parameters.AddWithValue("@año_acuñacion", txtAnioAcu.Text);
                    command.Parameters.AddWithValue("@año_grabado", txtAnioGrab.Text);
                    command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los valores con éxito!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
