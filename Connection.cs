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
        //Atributos de Clase
        private const string servidor = "datasource=127.0.0.1";
        private const string puerto = "port=3306";
        private const string username = "username = ";
        private const string password = "password=";
        private const string bd = "database=peluqueria";
        
        //Atributos de Instancia
        private string cadenaConexion;

        public Conexion() 
        { 
            cadenaConexion = servidor + ";" + puerto + ";" +
            username + ";" + password + ";" + bd;
        } 
        //creacion y retorno de un objeto para conexion
        public MySqlConnection getConexion()
        {            
            return new MySqlConnection(cadenaConexion);
        }
    }
}
