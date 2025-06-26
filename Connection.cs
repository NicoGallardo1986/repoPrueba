using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Peluqueria
{
    public class Conexion
    {
        private const string servidor = "datasource=127.0.0.1";
        private const string puerto = "port=3306";
        private const string username = "username = ";
        private const string password = "password=";
        private const string bd = "database=peluqueria";

        public Conexion() //El constructor queda vacío.
        { //El compilador se encarga de implementarlo

        } //si no lo hacemos nosotros
        public MySqlConnection getConexion()
        {

            string cadenaConexion = servidor + ";" + puerto + ";" +
            username + ";" + password + ";" + bd;
            return new MySqlConnection(cadenaConexion);
        }
    }
}
