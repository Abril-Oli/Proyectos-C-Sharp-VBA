using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Models
{
    public class Article
    {
        public long Id { get; private set; }
        public string description { get; set; }
        public decimal price { get; set; }

        public Article(long id, string description, decimal price)
        {
            this.Id = id;
            this.description = description;
            this.price = price;
        }

        //Ejemplo de metodo//
        //[obsolete]
        //  private void foo()
        //  {
        //      Console.WriteLine("Hello");
        //  }


    }
}
