using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using ServiciosVehiculos.Models;

namespace ServiciosVehiculos.DAO
{
    public class VehiculosDao
    {
        private IDbConnection prepararConexion()
        {
            string conectionString = "server=LAPTOP-M7QP70RN\\SQLEXPRESS;Database=ConcesonariaGo;Integrated Security=true";
            //hacemos un var con el tipo de dato sqlconnection//
            SqlConnection conexion = new SqlConnection(conectionString);
            //abrimos la conexion//
            conexion.Open();

            return conexion;
        }

        //armamos lista y traemos info desde la DB con metodo conexion //

        public List<Vehiculo> getAll()
        {
            IDbConnection conexion = this.prepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT ID, PATENTE, TIPO_ID, VELOCIDAD FROM Vehiculos";
            //comando lector//
            //nos deja leer renlgon x renglon lo que nos de nuestra query//
            IDataReader lector = comando.ExecuteReader();

            var listadin= new List<Vehiculo>();
           //RECORRIDO DE RESPUESTAS RENGLON X RENGLON EN QUERY//
           //crea un vehiculo por cada elemento de nuestra DB//
            while (lector.Read())
            {
                //objeto//
                Vehiculo vehiculin = new Vehiculo()
                {
                    id = lector.GetInt32(0),
                    patente = lector.GetString(1),
                    tipo_id = lector.GetInt32(2),
                    velocidad = lector.GetDecimal(3)
                };

                listadin.Add( vehiculin );
            }
            //cierre de conexion y retorno de lista//
            conexion.Close();
            return listadin;
        }

        //metodo de guardado//
        public void insert(Vehiculo newV)
        {
             //PASAJE DATOS Y VALORES A QUERY//
            //EL SIGNO PESO NOS DEJA PONER VAR EN STRING A VAL A INSERTAR//
            string query = $"INSERT INTO Vehiculos (PATENTE, TIPO_ID, VELOCIDAD) VALUES('{newV.patente}', {newV.tipo_id}, {newV.velocidad})";

            //nos conectamos, le pasamos la query y ejecutamos//
            IDbConnection conexion = this.prepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            comando.ExecuteNonQuery();
            //cierre de conexion//
            conexion.Close();
        }

    }
}
