using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Clases
{
    internal class ConexionBD
    {

        #region -> Variables
        // Variables
        public MySqlConnection conexionSql = new MySqlConnection();
        static string servidor = "localhost";
        static string basedatos = "dentalsoftdb";
        static string usuario = "adminDB";
        static string contraseña = "oretania";
        static string puerto = "3306";
        string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + contraseña + "; database=" + basedatos + ";";
        bool isConectado = false;
        #endregion

        public bool EstablecerConexion()
        {
            try
            {
                conexionSql.ConnectionString = cadenaConexion; // Asignar la cadena de conexión al objeto conexión
                conexionSql.Open(); // Abrir la conexión
                isConectado = true;
            }
            catch(MySqlException e)
            {
                // MessageBox.Show(" No se pudo conectar a la base de datos. Error: " + e.ToString());
            }
            return isConectado;
        }

        public bool CerrarConexion()
        {
            try
            {
                conexionSql.Close(); // Cerrar la conexión
                isConectado = false;
            }catch(MySqlException e)
            {
                MessageBox.Show("Se ha producido un error al cerrar la base de datos: " + e.ToString());
            }
            return isConectado;
        }
    }
}
