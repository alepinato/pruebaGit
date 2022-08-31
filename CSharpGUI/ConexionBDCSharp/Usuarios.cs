using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBDCSharp
{
    public class Usuarios
    {
        int id, tipo_usuario;
        string usuario, password, conpassword;

        public string Conpassword
        {
            get
            {
                return conpassword;
            }

            set
            {
                conpassword = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Tipo_usuario
        {
            get
            {
                return tipo_usuario;
            }

            set
            {
                tipo_usuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }
    }
}
