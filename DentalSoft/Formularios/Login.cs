using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using DentalSoft.Clases;
using DentalSoft.Formularios;

namespace DentalSoft
{
    public partial class Login : Form
    {
        // Variables
        DatosGlobales datosGlobales = new DatosGlobales();

        // Constructor
        public Login()
        {
            InitializeComponent();
        }

        #region -> Funcionalidades
        // Funcionalidades arrastrar formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        #region -> Métodos privados
        // Métodos privados
        private void MostrarMensajeError(string cadena)
        {
            lblErrorLogin.Text = "      " + cadena; // Los espacios iniciales es para dar espacio al mensaje de advertencia
            lblErrorLogin.Visible = true;
        }
        #endregion

        #region -> Eventos
        // Eventos
        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAccederLogin_Click(object sender, EventArgs e)
        {
            if(txtUsuarioLogin.Texto != "" && txtContraseñaLogin.Texto != "")
            {
                ConexionBD conexion = new ConexionBD();
                string usuario = txtUsuarioLogin.Texto;
                string password = txtContraseñaLogin.Texto;
                string sentencia = "SELECT * FROM identificacion_empleado WHERE Usuario='" + usuario + "'";
                if (conexion.EstablecerConexion())
                {
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows) // Comprobar si el reader tiene tuplas cargadas
                    {
                        reader.Read(); // Leer el registro. Como solo debe haber uno no lo meto en un while
                        bool cambiarPassword = reader.GetBoolean(4);
                        if (reader.GetBoolean(3)) // Comprobar si el usuario está activo
                        {
                            if (reader.GetInt32(2) > 0) // Comprobar el número de intentos
                            {
                                if (password.Equals(reader.GetString(1))) // Comprobar si coincide la contraseña
                                {
                                    string dni = reader.GetString(0);
                                    if (reader.GetInt32(2) < 3) // Establecer el número de intentos a 3 por si el usuario ha fallado
                                    {
                                        reader.Close();
                                        sentencia = "UPDATE identificacion_empleado SET intentos=3 WHERE Usuario='" + usuario + "'";
                                        comando = new MySqlCommand(sentencia, conexion.conexionSql);
                                        comando.ExecuteNonQuery();
                                    }
                                    conexion.CerrarConexion();
                                    if (cambiarPassword)
                                    {
                                        LoginCambioContraseña formLoginCambioContraseña = new LoginCambioContraseña();
                                        formLoginCambioContraseña.dniEmpleado = dni;                                        
                                        formLoginCambioContraseña.ShowDialog();
                                    }
                                    MenuPrincipal formPrincipal = new MenuPrincipal();
                                    formPrincipal.dniEmpleado = dni;
                                    formPrincipal.Show();
                                    this.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    sentencia = "UPDATE identificacion_empleado SET intentos=intentos-1 WHERE Usuario='" + usuario + "'"; // Restar 1 intento al usuario
                                    comando = new MySqlCommand(sentencia, conexion.conexionSql);
                                    comando.ExecuteNonQuery();
                                    MostrarMensajeError("La contraseña introducida no es correcta");
                                    txtContraseñaLogin.Limpiar();
                                }
                            }
                            else
                            {
                                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Ha superado el límite de intentos, por favor pongase en contacto con el administrador", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MostrarMensajeError("El usuario no está activo");
                            txtContraseñaLogin.Limpiar();
                        }
                    }
                    else
                    {
                        MostrarMensajeError("El usuario introducido no existe");
                        txtContraseñaLogin.Limpiar();
                    }
                }
                else
                {
                    MostrarMensajeError("No se ha podido conectar con la base de datos");
                }
                conexion.CerrarConexion();
            }
            else
            {
                MostrarMensajeError("Debe introducir un usuario y contraseña");
            }    
        }

        private void txtUsuarioLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnAccederLogin_Click(sender, e);
            }
        }

        private void txtContraseñaLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnAccederLogin_Click(sender, e);
            }
        }

        #endregion

        private void linkRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginRecuperacionContraseña loginRecuperacionContraseña = new LoginRecuperacionContraseña();
            loginRecuperacionContraseña.ShowDialog();
        }
    }
}
