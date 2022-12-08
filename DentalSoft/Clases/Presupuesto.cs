using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Clases
{
    public class Presupuesto
    {
        // Variables
        #region -> Variables
        private string numPresupuesto;
        private string fecha;
        private string centro;
        private string paciente;
        private List<DetallePresupuesto> detalles = new List<DetallePresupuesto>();
        #endregion

        // Constructores
        #region -> Constructores
        public Presupuesto() { }

        public Presupuesto(string numPresupuesto)
        {
            this.numPresupuesto = numPresupuesto;
            CargarPresupuesto();
        }
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public string NumPresupuesto { get => numPresupuesto; set => numPresupuesto = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Centro { get => centro; set => centro = value; }
        public string Paciente { get => paciente; set => paciente = value; }
        public List<DetallePresupuesto> Detalles { get => detalles; set => detalles = value; }
        #endregion

        // Métodos
        #region -> Métodos
        private void CargarDetalles()
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM detalle_presupuesto WHERE presupuesto = '" + this.numPresupuesto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    DetallePresupuesto detalle = null;
                    while (reader.Read())
                    {
                        detalle = new DetallePresupuesto(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                        detalles.Add(detalle);
                    }
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        public bool CargarPresupuesto()
        {
            return CargarPresupuesto(this.numPresupuesto);
        }

        public bool CargarPresupuesto(string numPresupuesto)
        {
            this.numPresupuesto = numPresupuesto;
            ConexionBD conexion = new ConexionBD();
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM presupuesto WHERE num_presupuesto = '" + this.numPresupuesto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    this.fecha = reader.GetDateTime(1).ToString("dd-MM-yyyy");
                    this.centro = reader.GetString(2);
                    this.paciente = reader.GetString(3);
                    sw = true;
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
                CargarDetalles();
            }
            return sw;
        }
        #endregion
    }
}
