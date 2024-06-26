using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Dao
{
    public class VeterinariaDAO
    {
        //preparamos nuetra funcion IDBConnection de conexion hacia la DB//
        private IDbConnection PrepararConexion()
        {

            //Generamos la URL de nuestra conexion//
            string connectionString = "server=LAPTOP-M7QP70RN\\SQLEXPRESS;Database=Veterinaria_DB;Integrated Security=true";

            // Generamos la conexión //
            SqlConnection connection = new SqlConnection(connectionString);

            //abrimos la conexion//
            connection.Open(); 

            return connection;
        }



    }
}
