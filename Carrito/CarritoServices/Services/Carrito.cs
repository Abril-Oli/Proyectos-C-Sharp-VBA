using CarritoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Services
{
    public class Carrito
    {
        private readonly List<Article> listado;

        public Carrito()
        {
            this.listado = new List<Article>();
        }

        //funcion para obtener total del carrito//
        public decimal getTotal()
        {
            //var acum//
            decimal total = 0;

            //for each del listado//
            foreach (Article art in listado)
            {
            // por cada art obt precio y sumar a total//
            total += art.price;
            }
            //devuelve el total//
            return total;
         
        }
     
        //funcion para agregar cada articulo a la lista//
        //esta fx agrega el art a lista del carrito//

        public void agregar(Article art)
        {
            this.listado.Add(art);
        }



    }


}
