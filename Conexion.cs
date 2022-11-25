using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave5_Grupo10
{
    class Conexion
    {
        /// <summary>
        /// Abre la conexion a la base de datos
        /// </summary>
        /// <returns>Devuelve la conexion a la base de datos</returns>
       public static MySqlConnection abrirConexion()
        {
            // codigo para conexión
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "clave5_grupo10db"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = "root"; //Contraseña de usuario de acceso a MySQL

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();
            return conexionBD;
        }
        /// <summary>
        /// Cierra la conexion de la base de datos
        /// </summary>
        /// <returns>Devuelve la conexion a la base de datos</returns>
        public static MySqlConnection cerrarConexion()
        {
            MySqlConnection conexionBD = abrirConexion();
            conexionBD.Close();
            return conexionBD;
        }
    }
}
