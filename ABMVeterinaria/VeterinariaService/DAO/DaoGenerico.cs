using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.DAO
{
    public  class DaoGenerico
    {
        private const string CONEXION_URL = "server=LAPTOP-M7QP70RN\\SQLEXPRESS;Database=VeterinariaDB;Integrated Security=true";


        protected IDbConnection PrepararConexion()
        {
            SqlConnection conexion = new SqlConnection(CONEXION_URL);

            conexion.Open();

            return conexion;
        }
    }
}
