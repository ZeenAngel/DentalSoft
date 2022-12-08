using DentalSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Formularios
{
    public partial class LoginRecuperacionContraseña : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private string codigo;
        private string dni;

        // Constructor
        public LoginRecuperacionContraseña()
        {
            InitializeComponent();
        }

        // Funcionalidades arrastrar formulario
        #region -> Funcionalidades
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Métodos privados
        private void OcultarMensajes()
        {
            lblCodigo.Visible = false;
            lblErrorDni.Visible = false;
            lblErrorCodigo.Visible = false;
            txtCodigo.Visible = false;
        }

        private void MostrarMensaje(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "dni":
                    lblErrorDni.Text = "     " + cadena;
                    lblErrorDni.Visible = true;
                    break;
                case "codigo":
                    lblErrorCodigo.Text = "     " + cadena;
                    lblErrorCodigo.Visible = true;
                    break;
            }
        }

        private void MostrarTextboxCodigo()
        {
            txtDni.Visible = false;
            lblCodigo.Visible = true;
            txtCodigo.Visible = true;
        }

        private bool EnviarCodigo()
        {
            bool sw = false;
            ConexionBD conexion = new ConexionBD();
            string emailReceptor = "";
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT email FROM empleado WHERE dni = '" + txtDni.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    emailReceptor = reader.GetString(0);
                    ConexionMail conexionMail = new ConexionMail();
                    conexionMail.InicializarClienteSmtp();
                    this.codigo = conexionMail.RecuperarContraseña(emailReceptor);
                    if (this.codigo != null)
                        sw = true;
                    this.dni = txtDni.Texto; // Guardar el Dni para el cambio de contraseña
                }
                else
                    MostrarMensaje("El DNI introducido no existe", "dni");
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        // Eventos
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginRecuperacionContraseña_Load(object sender, EventArgs e)
        {
            OcultarMensajes();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(btnEnviar.Text.Equals("Enviar código"))
            {
                if (EnviarCodigo())
                {
                    btnEnviar.Text = "Cambiar contraseña";
                    MostrarTextboxCodigo();
                }
            }
            else
            {
                if (txtCodigo.Texto.Equals(this.codigo))
                {
                    LoginCambioContraseña loginCambioContraseña = new LoginCambioContraseña();
                    loginCambioContraseña.dniEmpleado = this.dni;
                    loginCambioContraseña.ShowDialog();
                    this.Close(); // Cerrar para volver al Login
                }
                else
                    MostrarMensaje("El código introducido no es correcto", "codigo");
            }
        }
    }
}
