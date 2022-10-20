using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Clases
{
    public class Empleado
    {
        #region -> Información de campos
        /*
         * Puesto:
         *      1 - Gerencia
         *      2 - Administración
         *      3 - Odontologo
         *      4 - Auxiliar
         *      5 - Externo
         * Especialidad:
         *      1 - Odontología General
         *      2 - Endodoncia
         *      3 - Patología maxilofacial y oral
         *      4 - Cirugía oral y maxilofacial
         *      5 - Ortodoncia
         *      6 - Prostodoncia y odontología protésica
         *      7 - Odontopediatría
         *      8 - Periodoncia
         * Estado Reserva:
         *      1 - Pendiente
         *      2 - No presentado
         *      3 - Atendida
         */
        #endregion

        #region -> Variables

        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string telefono;
        private string email;
        private bool vacaciones;
        private int puesto;
        private int especialidad;
        private string numColegiado;
        private int centro;
        private bool estadoFichaje;

        #endregion

        // Constructores
        public Empleado() { }

        #region -> Getters y Setters

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public bool Vacaciones { get => vacaciones; set => vacaciones = value; }
        public int Puesto { get => puesto; set => puesto = value; }
        public int Especialidad { get => especialidad; set => especialidad = value; }
        public string NumColegiado { get => numColegiado; set => numColegiado = value; }
        public int Centro { get => centro; set => centro = value; }
        public bool EstadoFichaje { get => estadoFichaje; set => estadoFichaje = value; }

        #endregion

        #region -> Métodos

        public bool CargarEmpleado(string dni)
        {
            Clases.ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Empleado WHERE Dni='" + dni + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    this.dni = reader.GetString(0);
                    this.nombre = reader.GetString(1);
                    this.apellido1 = reader.GetString(2);
                    this.apellido2 = reader.GetString(3);
                    this.telefono = reader.GetString(4);
                    this.email = reader.GetString(5);
                    this.vacaciones = reader.GetBoolean(6);
                    this.puesto = reader.GetInt32(7);
                    if (!reader.IsDBNull(8))
                        especialidad = reader.GetInt32(8);
                    if (!reader.IsDBNull(9))
                        numColegiado = reader.GetString(9);
                    this.centro = reader.GetInt32(10);
                    this.estadoFichaje = reader.GetBoolean(11);
                    reader.Close();
                    conexion.CerrarConexion();
                    return true; // Todo OK
                }
                else
                {
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha encontrado ningún usuario con ese DNI", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conexion.CerrarConexion();
                    return false; // No se encuentra
                }
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido establecer conexión con la base de datos", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conexion.CerrarConexion();
                return false; // No se ha conectado
            }
        }

        #endregion
    }
}
