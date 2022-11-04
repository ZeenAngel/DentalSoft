using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Clases
{
    public class Historial
    {
        // Variables
        private string paciente;
        private string fecha;
        private string alergias;
        private string medicacion;
        private string observaciones;
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();

        // Constructor
        public Historial() { }

        public Historial(string paciente)
        {
            this.paciente = paciente;
        }

        // Getters y Setters
        public string Paciente { get => paciente; set => paciente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public string Medicacion { get => medicacion; set => medicacion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        // Métodos públicos
        public bool CargarHistorial()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Historial_Clinico WHERE Paciente='" + this.paciente + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows) // Comprobar si el reader tiene tuplas cargadas
                {
                    reader.Read();
                    this.paciente = reader.GetString(0);
                    this.fecha = reader.GetString(1);
                    this.alergias = reader.GetString(2);
                    this.medicacion = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        this.observaciones = reader.GetString(4);
                    reader.Close();
                    conexion.CerrarConexion();
                    return true;
                }
                else
                {
                    reader.Close();
                    conexion.CerrarConexion();
                    return false;
                }
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar con la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }
}
