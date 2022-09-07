using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace ConexionBDCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string servidor = "localhost";
            string usuarios = "root";
            string pass = "";
            string puerto = "3306";

            string cadenaconexion = "server=" + servidor + 
                                    ";port=" + puerto + 
                                    ";user id=" + usuarios + 
                                    ";password=" + pass + 
                                    ";database=almacenbd;";
            string datos = "";
            MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);

            try
            {
                conexionBD.Open();
                MySqlDataReader reader = null;
                string sql = "SHOW DATABASES";
                MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
                //Ejecuto la sentencia y guardo el resultado en reader
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    datos += reader.GetString(0)+"\n";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());                
            }
            MessageBox.Show(datos);
        }
    }
}
