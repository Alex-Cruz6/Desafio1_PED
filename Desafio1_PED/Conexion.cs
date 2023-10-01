using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_PED
{
     class Conexion
    {
        static string servidor = "localhost";
        static string bd = "desafio1";
        static string user = "root"; 
        static string password = "";
        static string puerto = "3306";

        static string cadenaConexion = "server="+servidor+";"+"port="+puerto+";"+"user id="+user+";"+"password="+password+";"+"database="+bd+";";
        public  MySqlConnection conexion = new MySqlConnection(cadenaConexion);

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexión: " + ex);
                return false;
            }
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }
    }

}
