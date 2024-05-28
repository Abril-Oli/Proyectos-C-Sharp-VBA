using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase9
{
    public class UsuariosRepo
    {
        public List<Usuario> getAll()
           
        {
            //defino string de conexion//
            string conectionString = "Server=LAPTOP-M7QP70RN\\SQLEXPRESS; Database=CLASE9; Integrated Security=True";
            //levantamos el conectionString//
            SqlConnection conexion = new SqlConnection(conectionString); 

            conexion.Open();

            var comando = conexion.CreateCommand(); //creo comando

            comando.CommandText = "SELECT ID, NOMBRE, CLAVE FROM USUARIOS";

            SqlDataReader lector = comando.ExecuteReader();
            List<Usuario> listado = new List<Usuario>();

            while (lector.Read()) //mientras el lector de true.
            {
                Usuario usuario = new Usuario();
                usuario.id = lector.GetInt32(0);
                usuario.username = lector.GetString(1);
                usuario.password = lector.GetString(2);

                listado.Add(usuario);
            }

            conexion.Close();

            return listado;
        }



    }
}
