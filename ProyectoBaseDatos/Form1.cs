using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoBaseDatos
{
    public partial class FormNumesmatica : Form
    {

        //private string strConexion = "Data Source=DESKTOP-LUT2TPL; Initial Catalog=NumismaticaBaseDatos; Integrated Security=SSPI";
        private ConexionSQLServer generadorConexion;


        public FormNumesmatica()
        {
            //generadorConexion = new ConexionSQLServer(strConexion);
            generadorConexion = new ConexionSQLServer();
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string consulta = this.txtConsulta.Text;
            generadorConexion.GenerarTabla(consulta, this.tablaDatos);

            generadorConexion.GenerarOpcionesBox(consulta, this.comboFiltros);
        }


        private void comboFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = this.txtConsulta.Text;
            string filtro = "";

            if (null != this.comboFiltros.SelectedItem)
            {
                filtro = this.comboFiltros.SelectedItem.ToString();
            }

            consulta = consulta + " ORDER BY " + filtro;

            generadorConexion.GenerarTabla(consulta, this.tablaDatos);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();



            form2.Show();
            //Application.OpenForms["Form2"].Activate();
           // this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
