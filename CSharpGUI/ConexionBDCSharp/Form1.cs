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
            string servidor = txtServidor.Text;
            string usuarios = txtUsuario.Text;
            string pass = txtpass.Text;
            string puerto = txtPuerto.Text;

            string cadenaconexion = "server=" + servidor + 
                                    ";port=" + puerto + 
                                    ";user id=" + usuarios + 
                                    ";password=" + pass + 
                                    ";database=mysql;";
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
