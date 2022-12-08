using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class Centro
    {
        // Variables
        #region -> Variables
        private string cif;
        private string nombre;
        private string direccion;
        private string localidad;
        private string cp;
        private string telefono;
        #endregion

        // Constructores
        #region -> Constructores
        public Centro() { }

        public Centro(string cif)
        {
            this.cif = cif;
            CargarCentro();
        }

        public Centro(string cif, string nombre, string direccion, string localidad, string cp, string telefono)
        {
            this.cif = cif;
            this.nombre = nombre;
            this.direccion = direccion;
            this.localidad = localidad;
            this.cp = cp;
            this.telefono = telefono;
        }
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public string Cif { get => cif; set => cif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        #endregion

        // Métodos
        #region -> Métodos
        private bool CargarCentro()
        {
            return CargarCentro(this.cif);
        }

        private bool CargarCentro(string cif)
        {
            ConexionBD conexion = new ConexionBD();
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM centro";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    this.cif = reader.GetString(0);
                    this.nombre = reader.GetString(1);
                    this.direccion = reader.GetString(2);
                    this.localidad = reader.GetString(3);
                    this.cp = reader.GetString(4);
                    this.telefono = reader.GetString(5);
                    sw = true;
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }
        #endregion
    }
}
