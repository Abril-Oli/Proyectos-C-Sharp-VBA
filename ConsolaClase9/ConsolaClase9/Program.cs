using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definimos string de conexion y desactivamos la autenticacion de Windows//

            string conectionString = "Server=LAPTOP-M7QP70RN\\SQLEXPRESS;Database=CLASE9; Integrated Security =True";

            //levantamos el conection string//
            SqlConnection conexion = new SqlConnection(conectionString);

            //Abrimos la conexion//

            conexion.Open();

            //creamos la variable para usar el comando//

            var comando = conexion.CreateCommand();

            //creamos el comando//
            comando.CommandText = "Insert into usuarios (nombre, clave)" +
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

            //Creamos el objeto usuario ,y se le asignan valores del primer registro de BD//
            //sus propiedades ID Y Username almacenan esos valores//
            Usuario usuario1 = new Usuario();
            usuario1.id = cursor.GetInt32(0);  
            usuario1.username = cursor.GetString(1);

            //mostramos en consola id y nombre de usuario obtenido de BD//
            Console.WriteLine(usuario1.id);
            Console.WriteLine(usuario1.username);

            //LISTADO USUARIOS BD//
            //creamos objeto usuario repo //
                       
            UsuariosRepo repo = new UsuariosRepo();
            //metodo getAll para obtener lista de todos los usuarios//
            List<Usuario> listaUsuarios = repo.getAll();

            //hacemos con foreach un recorrido iterando la lista de usuarios//
            //mostramos Id, nombre y clave dde cada usuario//
            foreach (Usuario usuario in listaUsuarios)
            {
                Console.WriteLine($"ID: {usuario.id}");
                Console.WriteLine($"UserName: {usuario.username}");
                Console.WriteLine($"Password: {usuario.password}");
                Console.WriteLine("");
            }
            //cerramos la conexion de la BD//
            conexion.Close(); 

            Console.ReadLine();
        }


    }
}

