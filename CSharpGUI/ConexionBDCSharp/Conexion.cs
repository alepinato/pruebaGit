using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionBDCSharp
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string usuarios = "root";
            string pass ="";
            string puerto = "3306";
            string bd = "sistema_usuarios";

            string cadenaconexion = "server=" + servidor +
                                    ";port=" + puerto +
                                    ";user id=" + usuarios +
                                    ";password=" + pass +
                                    ";database="+bd;

            MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);
            return conexionBD;
        }

    }
}
