using System;
using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Data.SqlTypes;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaConexionBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definimos string de conexion y desactivamos la autenticacion de Windows//

            string conectionString = "Server=LAPTOP-M7QP70RN\\SQLEXPRESS;Database=Semana9; Integrated Security =True";

            //levantamos el conection string//
            SqlConnection conexion = new SqlConnection(conectionString);

            //Abrimos la conexion//

            conexion.Open();

            //creamos la variable para usar el comando//
            
            var comando = conexion.CreateCommand();
           
            //creamos el comando//
            comando.CommandText = "Insert into usuarios (username, password)" +
                 " Values ('Pedropedro', 'abc123');";

            //try and catch para que no explote el programa y seguir utilizandolo//

            try
            {
                //ejecutamos una query ,vacia, sin resultados
                comando.ExecuteNonQuery();

            }
                //catcheamos un error//
            catch (SqlException sqlEx)
            {
                //dejamos un mensaje de error//
                Console.Write(sqlEx.Message);
            }

            //Traer informacion desde la Base de datos//
            //creamos un comando nuevo- comando leer//

            SqlCommand comandoLeer = conexion.CreateCommand();

            //Agregamos a la query//
            comandoLeer.CommandText = "Select ID, nombre from usuarios order by id";
           
            //Agregamos el comando que trae la informacion//
            SqlDataReader cursor = comandoLeer.ExecuteReader();

            //este metodo permite mover a la siguiente linea, posicionandonos en el 1er registro//
            cursor.Read();
        }
    }
}
