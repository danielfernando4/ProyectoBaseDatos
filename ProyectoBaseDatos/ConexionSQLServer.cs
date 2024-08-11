using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoBaseDatos
{
    public class ConexionSQLServer
    {
        //atributos
        private string _strConexion;


        //constructor
        public ConexionSQLServer(string strConexion)
        {
            _strConexion = strConexion;
        }

        public ConexionSQLServer()
        {
            _strConexion = "Data Source=DESKTOP-LUT2TPL; Initial Catalog=NumismaticaBaseDatos; Integrated Security=SSPI";
        }



        //métodos
        public void GenerarTabla(string consulta, DataGridView tabla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(_strConexion))
                {
                    conexion.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    tabla.DataSource = dataTable;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        public void GenerarTabla(string consulta, DataGridView tabla, string[] parametros)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(_strConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    // Asignar parámetros a la consulta
                    for (int i = 0; i < parametros.Length; i++)
                    {
                        comando.Parameters.AddWithValue($"@param{i}", parametros[i]);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    tabla.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }






        public void GenerarOpcionesBox(string consulta, ComboBox comboBox)
        {
          
            try
            {
                using (SqlConnection conexion = new SqlConnection(_strConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        comboBox.Items.Clear();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            comboBox.Items.Add(reader.GetName(i));
                        }
                    }    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public string StrConexion()
        {
            { return _strConexion; }
        }

    }
}
