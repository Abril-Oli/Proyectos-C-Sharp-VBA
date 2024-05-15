using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Models
{
    public class Type
    {
        public string nombre { get; }

        public Type(string name)
        {
            this.nombre = nombre;


        }
        //para sobreescribir un metodo usamos override//
        public override string ToString()
        {

            return this.nombre;
        }

    }


}
