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
    public partial class FormInsertarModelo : Form
    {
        public FormInsertarModelo()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexion = "Data Source=DESKTOP-LUT2TPL; Initial Catalog=NumismaticaBaseDatos; Integrated Security=SSPI";
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    string query = "INSERT INTO modelos VALUES(@codigo_modelo, @valor_facial, @unidad_monetaria, @diametro, @peso, @descripcion)";
                    SqlCommand command = new SqlCommand(query, conexion);

                    command.Parameters.AddWithValue("@codigo_modelo", txtCodigoM.Text);
                    command.Parameters.AddWithValue("@valor_facial", txtValorFacial.Text);
                    command.Parameters.AddWithValue("@unidad_monetaria", txtUnidadMonetaria.Text);
                    command.Parameters.AddWithValue("@diametro", txtDiametro.Text);
                    command.Parameters.AddWithValue("@peso", txtPeso.Text);
                    command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los valores con éxito!!!!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
