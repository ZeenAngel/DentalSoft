using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class Factura
    {
        // Variables
        #region -> Variables
        private string numFactura;
        private string fecha;
        private string nifCentro;
        private string nombreCentro;
        private string direccion;
        private string localidad;
        private string cp;
        private string telefono;
        private string dniPaciente;
        private string nombrePaciente;
        private string apellido1Paciente;
        private string apellido2Paciente;
        private string presupuesto;
        private List<DetalleFactura> detalles = new List<DetalleFactura>();
        #endregion

        // Constructores
        #region -> Constructores
        public Factura() { }

        public Factura(string numFactura)
        {
            this.numFactura = numFactura;
            CargarFactura();
        }
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public string NumFactura { get => numFactura; set => numFactura = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string NifCentro { get => nifCentro; set => nifCentro = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string Apellido1Paciente { get => apellido1Paciente; set => apellido1Paciente = value; }
        public string Apellido2Paciente { get => apellido2Paciente; set => apellido2Paciente = value; }
        public string Presupuesto { get => presupuesto; set => presupuesto = value; }
        public List<DetalleFactura> Detalles { get => detalles; set => detalles = value; }
        public string NombreCentro { get => nombreCentro; set => nombreCentro = value; }
        #endregion

        // Métodos
        #region -> Métodos
        private void CargarDetalles()
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM detalle_factura WHERE factura = '" + this.numFactura + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    DetalleFactura detalle = null;
                    while (reader.Read())
                    {
                        detalle = new DetalleFactura(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetFloat(3), reader.GetString(4));
                        detalles.Add(detalle);
                    }
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        public bool CargarFactura()
        {
            return CargarFactura(this.numFactura);
        }

        public bool CargarFactura(string numFactura)
        {
            this.numFactura = numFactura;
            ConexionBD conexion = new ConexionBD();
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM factura WHERE num_factura = '" + this.numFactura + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    this.fecha = reader.GetDateTime(1).ToString("dd-MM-yyyy");
                    this.nifCentro = reader.GetString(2);
                    this.nombreCentro = reader.GetString(3);
                    this.direccion = reader.GetString(4);
                    this.localidad = reader.GetString(5);
                    this.cp = reader.GetString(6);
                    this.telefono = reader.GetString(7);
                    this.dniPaciente = reader.GetString(8);
                    this.nombrePaciente = reader.GetString(9);
                    this.apellido1Paciente = reader.GetString(10);
                    if (! reader.IsDBNull(11))
                        this.apellido2Paciente = reader.GetString(11);
                    if (! reader.IsDBNull(12))
                        this.presupuesto = reader.GetString(12);
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
