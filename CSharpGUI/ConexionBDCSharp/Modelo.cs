using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionBDCSharp
{
    class Modelo
    {
        public int registroUsu(Usuarios usu)
        {
            //Establezco conexion y abro la BD
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios(usuario, password, tipo_usuario)"+
                         "VALUES(@usuario, @password,@tipo_usuario)";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
            cmd.Parameters.AddWithValue("@password", usu.Password);
            cmd.Parameters.AddWithValue("@tipo_usuario", 1);

            int resultado = cmd.ExecuteNonQuery();
            
            return resultado;


        }


        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
