using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Modelos
{
    public class Cliente
    {
        public long ClienteID { get; set; }
        public long DNI { get; set; }
        public string Nombre { get; set; }

        //creamos el constructor de Cliente//
        public Cliente(long dNI, string nombre)
        {
            DNI = dNI;
            Nombre = nombre;
        }


        //constructor vacio para dar de altar un cliente desde DB//
        public Cliente()
        {

        }


    }
}
