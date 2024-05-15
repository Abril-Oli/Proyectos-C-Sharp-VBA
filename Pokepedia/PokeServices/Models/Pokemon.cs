using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Models
{
    public class Pokemon
    {

        public long number {get;}
        public string name { get; set; }  

        public Type tipo { get; set; }

        //Element container //
        public Pokemon(long number, string name, Type tipo)
        {
            this.number = number;
            this.name = name;
            this.tipo = tipo;
        }
    }
}
