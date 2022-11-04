using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        string direccion;
        int edad;
        string genero;
        bool consentimiento;
        List<Pieza> odontograma;
        DatosGlobales datosGlobales = new DatosGlobales();
        #endregion

        // Constructores
        public Paciente() 
        {
            odontograma = new List<Pieza>();
        }

        public Paciente(string dni)
        {
            this.dni = dni;
            odontograma = new List<Pieza>();
            CargarOdontograma();
        }

        // Getters y Setters
        #region -> Getters y Setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Cp { get => cp; set => cp = value; }   
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public bool Consentimiento { get => consentimiento; set => consentimiento = value; }
        public List<Pieza> Odontograma { get => odontograma; set => odontograma = value; }
        #endregion

        // Métodos públicos
        #region -> Métodos públicos
        public bool CargarOdontograma()
        {
            return CargarOdontograma(this.dni);
        }

        public bool CargarOdontograma(string dni)
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT episodio_clinico.Pieza, seccion.Nombre AS Seccion, diagnostico.Nombre AS Diagnostico, tratamiento.Nombre AS Tratamiento FROM episodio_clinico " +
                    "INNER JOIN seccion ON episodio_clinico.Seccion = seccion.Id " +
                    "INNER JOIN diagnostico ON episodio_clinico.Diagnostico = diagnostico.Id " +
                    "INNER JOIN tratamiento ON episodio_clinico.Tratamiento = tratamiento.Id " +
                    "INNER JOIN(SELECT MAX(Fecha) AS lastfecha, Pieza, Seccion, Diagnostico, Tratamiento FROM episodio_clinico " +
                    "GROUP BY Pieza) busqueda ON episodio_clinico.Pieza = busqueda.Pieza AND episodio_clinico.Fecha = busqueda.lastfecha WHERE episodio_clinico.Historial = '" + dni + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Pieza pieza = new Pieza(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        odontograma.Add(pieza);
                    }
                    reader.Close();
                    conexion.CerrarConexion();
                    return true;
                }
                else
                    return false; // No tiene historial, Se distingue del false de sin conexión porque no hay DialogResult
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido establecer conexión con la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return false; // No se ha conectado
            }
        }

        public bool CargarPaciente()
        {
            return CargarPaciente(this.dni);
        }

        public bool CargarPaciente(string dni)
        {
            ConexionBD conexion = new ConexionBD();
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
                    this.direccion = reader.GetString(7);
                    this.edad = reader.GetInt32(8);
                    this.genero = reader.GetString(9);
                    this.consentimiento = reader.GetBoolean(10);
                    reader.Close();
                    conexion.CerrarConexion();
                    return true; // Todo OK
                }
                else
                {
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha encontrado ningún paciente con ese DNI", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conexion.CerrarConexion();
                    return false; // No se encuentra
                }
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido establecer conexión con la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);;
                return false; // No se ha conectado
            }
        }
        #endregion
    }
}
