using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVehiculos.Models
{
    public class Vehiculo
    {

        public long id {  get; set; }
        public string patente { get; set; }
        public long tipo_id { get; set; }
        //utilizamos el tipo de dato decimal//
        public decimal velocidad { get; set; }

    
        //generamos un constructor//
        public Vehiculo(string patente, long tipo_id, decimal velocidad)
        {
            this.patente = patente;
            this.tipo_id = tipo_id;
            this.velocidad = velocidad;
        }
        //generamos un constructor vacio para levantar un vehiculo desde BD//
        public Vehiculo()
        {

        }
    }
}
