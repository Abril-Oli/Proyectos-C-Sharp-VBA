using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Modelos
{

    public class Especie
    {
        public long EspecieID { get; set; }
        public string NombreEspecie { get; set; }
        public int EdadMadurez { get; set; }
        public decimal PesoPromedio { get; set; }

        //creamos el constructor de especie//
        public Especie(string nombreEspecie, int edadMadurez, decimal pesoPromedio)
        {
            NombreEspecie = nombreEspecie;
            EdadMadurez = edadMadurez;
            PesoPromedio = pesoPromedio;
        }

        //constructor vacio para dar de alta una especie desde DB//
        public Especie()
        {

        }
    }
}

