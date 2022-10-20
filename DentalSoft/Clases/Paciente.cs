using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Clases
{
    public class Paciente
    {
        // Variables
        #region -> Variables
        string dni;
        string nombre;
        string apellido1;
        string apellido2;
        string telefono;
        string email;
        string cp;
        bool consentimiento;
        #endregion

        // Constructores
        public Paciente() { }

        // Getters y Setters
        #region -> Getters y Setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Cp { get => cp; set => cp = value; }
        public bool Consentimiento { get => consentimiento; set => consentimiento = value; }
        #endregion

        // Métodos públicos
        #region -> Métodos públicos
        public bool CargarPaciente(string dni)
        {
            Clases.ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Paciente WHERE Dni='" + dni + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    this.dni = reader.GetString(0);
                    this.nombre = reader.GetString(1);
                    this.apellido1 = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        this.apellido2 = reader.GetString(3);
                    this.telefono = reader.GetString(4);
                    if (!reader.IsDBNull(5))
                        this.email = reader.GetString(5);
                    this.cp = reader.GetString(6);
                    this.consentimiento = reader.GetBoolean(7);
                    reader.Close();
                    conexion.CerrarConexion();
                    return true; // Todo OK
                }
                else
                {
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha encontrado ningún paciente con ese DNI", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
