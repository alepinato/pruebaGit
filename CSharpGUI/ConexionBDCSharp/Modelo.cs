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
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios(usuario, password, tipo_usuario) VALUES(@usuario, @password,@tipo_usuario)";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
            cmd.Parameters.AddWithValue("@password", usu.Password);
            cmd.Parameters.AddWithValue("@tipo_usuario", 1);

            int resultado = cmd.ExecuteNonQuery();

            return resultado;


        }

    }
}
