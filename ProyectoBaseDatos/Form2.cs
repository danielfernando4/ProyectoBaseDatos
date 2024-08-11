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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBaseDatos
{
    public partial class Form2 : Form
    {
        ConexionSQLServer conexionGenerador = new ConexionSQLServer();
        public Form2()
        {
            InitializeComponent();
            this.opcionesFiltrado.Items.Add("codigo_modelo");
            this.opcionesFiltrado.Items.Add("valor_facial");
            this.opcionesFiltrado.Items.Add("diametro");
            this.opcionesFiltrado.Items.Add("peso");
            this.opcionesFiltrado.Items.Add("codigo_tronquel");
            this.opcionesFiltrado.Items.Add("año_acuñacion");
            this.opcionesFiltrado.Items.Add("año_grabado");

            this.opcionesCondicion.Items.Add("mayor");
            this.opcionesCondicion.Items.Add("menor");
            this.opcionesCondicion.Items.Add("igual");
        }

        private void btnSalirAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemMostrarElementos_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT modelos.codigo_modelo, valor_facial, diametro, peso, codigo_tronquel, año_acuñacion, año_grabado FROM modelos, tronqueles WHERE modelos.codigo_modelo = tronqueles.codigo_modelo";
            conexionGenerador.GenerarTabla(consulta, this.tablaElementos);
        }

        private void itemInsertarModelo_Click(object sender, EventArgs e)
        {
            FormInsertarModelo formModelo = new FormInsertarModelo();

            formModelo.ShowDialog();
        }

        private void itemInsertarTronquel_Click(object sender, EventArgs e)
        {
            FormInsertarTronquel formTronquel = new FormInsertarTronquel();

            formTronquel.ShowDialog();
        }

        private void itemEliminarModelo_Click(object sender, EventArgs e)
        {
            FormEliminarModelo formModelo = new FormEliminarModelo();

            formModelo.ShowDialog();
        }

        private void itemEliminarTronquel_Click(object sender, EventArgs e)
        {
            FormEliminarTronqueles formTronquel = new FormEliminarTronqueles();

            formTronquel.ShowDialog();
        }

        private void opcionesFiltrado_Click(object sender, EventArgs e)
        {
        }





        private void itemFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void opcionesCondicion_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = "";
                string columnaFiltro = ""; // Columna sobre la que se va a filtrar

                if (this.opcionesCondicion.SelectedItem != null)
                {
                    switch (opcionesCondicion.SelectedItem.ToString())
                    {
                        case "mayor":
                            condicion = ">";
                            break;
                        case "menor":
                            condicion = "<";
                            break;
                        case "igual":
                            condicion = "=";
                            break;
                        default:
                            throw new ArgumentException("Opción de filtrado no válida");
                    }

                    // Suponiendo que estamos filtrando por una columna específica
                    // Asumimos que la columna de filtrado es la primera columna en este ejemplo
                    // Debes cambiar "columnaNombre" a la columna que deseas filtrar
                    columnaFiltro = this.opcionesFiltrado.SelectedItem.ToString();

                    // Construcción segura de la consulta SQL
                    string consulta = $"SELECT modelos.codigo_modelo, valor_facial, diametro, peso, codigo_tronquel, año_acuñacion, año_grabado " +
                                      $"FROM modelos " +
                                      $"JOIN tronqueles ON modelos.codigo_modelo = tronqueles.codigo_modelo " +
                                      $"WHERE {columnaFiltro} {condicion} @valor";

                    using (SqlConnection conexion = new SqlConnection(conexionGenerador.StrConexion()))
                    {
                        SqlCommand command = new SqlCommand(consulta, conexion);
                        command.Parameters.AddWithValue("@valor", this.txtValor.Text);

                        conexion.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        this.tablaElementos.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
