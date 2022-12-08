using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DentalSoft.Clases
{
    public class ConexionMail
    {
        // Variables
        #region -> Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private SmtpClient clienteSmtp;
        private string emailRemitente;
        private string emailContraseña;
        private string codigo;
        private string host;
        private int puerto;
        private bool ssl;
        #endregion

        // Constructor
        public ConexionMail()
        {
            this.emailRemitente = datosGlobales.CorreoRemitente;
            this.emailContraseña = datosGlobales.ContraseñaCorreoRemitente;
            this.host = datosGlobales.HostCorreoRemitente;
            this.puerto = datosGlobales.PuertoCorreoRemitente;
            this.ssl = datosGlobales.CifradoSsl;
        }

        // Getters y Setters
        #region -> Getters y Setters
        public SmtpClient ClienteSmtp { get => clienteSmtp; set => clienteSmtp = value; }
        public string EmailRemitente { get => emailRemitente; set => emailRemitente = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Host { get => host; set => host = value; }
        public string EmailContraseña { get => emailContraseña; set => emailContraseña = value; }
        public int Puerto { get => puerto; set => puerto = value; }
        public bool Ssl { get => ssl; set => ssl = value; }
        #endregion

        // Métodos
        #region -> Métodos
        private void GenerarCodigo()
        {
            Random aleatorio = new Random();
            this.codigo = aleatorio.Next(1000, 9999).ToString();
        }

        public void InicializarClienteSmtp()
        {
            clienteSmtp = new SmtpClient();
            clienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Credentials = new NetworkCredential(this.emailRemitente, this.emailContraseña);
            clienteSmtp.Host = this.host;
            clienteSmtp.Port = this.puerto;
            clienteSmtp.EnableSsl = this.ssl;
        }

        public bool EnviarEmail(string asunto, string mensaje, List<string> destinatarios)
        {
            bool sw = false;
            MailMessage correo = new MailMessage();
            try
            {
                correo.From = new MailAddress(this.emailRemitente); // Remitente
                foreach (string destinatario in destinatarios) // Destinatarios
                    correo.To.Add(destinatario);
                correo.Subject = asunto; // Asunto
                correo.Body = mensaje; // Cuerpo
                correo.Priority = MailPriority.Normal;
                clienteSmtp.Send(correo);
                sw = true;
            }catch(Exception ex) 
            {
                DialogResult cuadroTexto = MessageBoxPersonalizadoControl.Show("Error al enviar el correo electrónico: " + ex.Message, datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                correo.Dispose();
                clienteSmtp.Dispose();
            }
            return sw;
        }

        public bool RecordarCita(string fecha)
        {
            bool sw = false;
            List<string> destinatarios = new List<string>();
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT paciente.Email FROM reserva INNER JOIN paciente ON reserva.Paciente = paciente.Dni WHERE paciente.Consentimiento = 1 " +
                    "AND paciente.Email IS NOT NULL AND reserva.Fecha = '" + fecha + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                        destinatarios.Add(reader.GetString(0));
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
                DateTime fechaTemporal = DateTime.Parse(fecha);
                string asunto = "Recordatorio de cita";
                string mensaje = "Le recordamos que tiene cita en nuestra clínica el día " + fechaTemporal.ToString("dd-MM-yyyy") + ". " +
                    "En caso de no poder acudir rogamos que modifique su cita o la cancele\n Saludos,\nDentalSoft";
                sw = EnviarEmail(asunto, mensaje, destinatarios);
            }
            return sw;
        }

        public string RecuperarContraseña(string destinatario)
        {
            MailMessage correo = new MailMessage();
            try
            {
                correo.From = new MailAddress(this.emailRemitente);
                correo.To.Add(destinatario);
                correo.Subject = "Recuperar contraseña DentalSoft";
                GenerarCodigo(); // Crear código recuperación
                correo.Body = "Para recuperar su contraseña, introduzca el siguiente código: " + this.codigo;
                correo.Priority = MailPriority.Normal;
                clienteSmtp.Send(correo);
            }
            catch (Exception ex)
            {
                DialogResult cuadroTexto = MessageBoxPersonalizadoControl.Show("Error al enviar el correo electrónico: " + ex.Message, datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                correo.Dispose();
                clienteSmtp.Dispose();
            }
            return this.codigo;
        }
        #endregion
    }
}
