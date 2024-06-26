using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Modelos
{
    public class Usuario
    {
        public long Usuarioid { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }

        //creamos el constructor de usuario//
        public Usuario(string nombreUsuario, string clave)
        {
            NombreUsuario = nombreUsuario;
            Clave = clave;
        }

        //constructor vacio para dar de altar un usuario desde DB//
        public Usuario()
        {

        }
    }

}
