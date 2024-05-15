using PokeServices.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Containers
{
    //cambiar internal por public//
    public class Pokedex

    //creamos una lista que funciona como pasamanos pasando por el container//
    {
        private readonly List<Pokemon> PokemonList;

        //preparamos nujestro objeto//
        public Pokedex()
        {
            this.PokemonList = new List<Pokemon>();
        }

        //metodo Search//

        /// <summary>
        /// Busca y retorna un pokemon en base a su numero
        /// </summary>
        /// <param name="number"> el num del pokemon buscado</param>
        /// <returns>El pokemon (si lo encontro) o null </returns>

        public Pokemon SearchPerNumber(long NumberSearched)
        {
            //valor null + for each//


            Pokemon PokemonSearched = null;

            foreach (Pokemon poke in PokemonList)

                if (poke.number == NumberSearched)
                {
                    PokemonSearched = poke;
                    break;
                }
            return PokemonSearched;
        }

        public bool existByNumber(long NumberSearched)

        //si el resultado es distinto(!=) de null, existe//
        {
            return this.SearchPerNumber(NumberSearched) != null;
        }
        //METODO SEARCH SI NO EXISTE -void o boolean valid //
        public bool add(Pokemon poke)
        {
            //uso de dato unico, no permitir que se repita//
            bool itAdd = !this.existByNumber(poke.number);

            if (itAdd)
            {
                this.PokemonList.Add(poke);
            }

            return itAdd;

        }
        //mostrar la lista(fotocopia)//

        public List<Pokemon> GetPokemons()
        {
            //crea una nueva lista, basada en la anterior
            return new List<Pokemon>(this.PokemonList);
        }








    }
}
