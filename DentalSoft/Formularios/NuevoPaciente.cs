using DentalSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class NuevoPaciente : Form
    {
        // Variables
        private Paciente pa;
        private DatosGlobales datosGlobales = new DatosGlobales();
        private TextboxPersonalizado paciente;
        private bool isDesdeReserva = false;
        private bool isDesdeEditar = false;
        private string dni;

        // Constructores
        #region -> Constructores
        public NuevoPaciente()
        {
            InitializeComponent();
        }

        public NuevoPaciente(ref TextboxPersonalizado dni)
        {
            InitializeComponent();
            this.paciente = dni;
            this.paciente.Texto = this.paciente.Texto.ToUpper();
            this.isDesdeReserva = true;
        }

        public NuevoPaciente(string dni)
        {
            InitializeComponent();
            isDesdeEditar = true;
            this.dni = dni;
        }
        #endregion

        // Funcionalidades arrastrar formulario
        #region -> Funcionalidades
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private int ComprobarEdad()
        {
            bool isNumero = int.TryParse(txtEdad.Texto, out int edad);
            if (isNumero)
                return edad;
            else
                return 0; // Devuelvo cero que es como false
        }

        private void LimpiarCampos()
        {
            txtNombre.Texto = "";
            if(! this.isDesdeReserva)
                txtDni.Texto = "";
            txtApellido1.Texto = "";
            txtApellido2.Texto = "";
            txtTelefono.Texto = "";
            txtEmail.Texto = "";
            txtCp.Texto = "";
            txtDireccion.Texto = "";
            txtEdad.Texto = "";
            this.gbGenero.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) => // Lambda con bucle foreach para desmarcar todos los RadioButtons
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });
            chConsentimiento.Checked = false;
        }

        private bool ComprobarEmail()
        {
            bool sw = false;
            string expRegular = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtEmail.Texto, expRegular))
                if (Regex.Replace(txtEmail.Texto, expRegular, String.Empty).Length == 0)
                    sw = true;
            return sw;
        }

        private bool ComprobarNulos()
        {
            bool sw = false;
            if (!txtNombre.Texto.Equals(""))
                if (!txtDni.Texto.Equals("") || isDesdeReserva)
                    if (!txtApellido1.Texto.Equals(""))
                        if (!txtTelefono.Texto.Equals(""))
                            if (!txtEmail.Texto.Equals("") && ComprobarEmail())
                                if (!txtCp.Texto.Equals(""))
                                    if (!txtDireccion.Texto.Equals(""))
                                        if (!txtEdad.Texto.Equals(""))
                                            if (ComprobarEdad() > 0)
                                                if (rbMasculino.Checked || rbFemenino.Checked)
                                                    sw = true;
                                                else
                                                    MostrarMensajeError("Debe seleccionar un género", "genero");
                                            else
                                                MostrarMensajeError("Debe introducir una edad válida", "edad");
                                        else
                                            MostrarMensajeError("El campo Edad no puede estar vacío", "edad");
                                    else
                                        MostrarMensajeError("El campo Dirección no puede estar vacío", "direccion");
                                else
                                    MostrarMensajeError("El campo Código Postal no puede estar vacío", "cp");
                            else
                                MostrarMensajeError("El Email introducido no tiene un formato válido", "email");
                        else
                            MostrarMensajeError("El campo Teléfono no puede estar vacío", "telefono");
                    else
                        MostrarMensajeError("El campo Primer Apellido no puede estar vacío", "apellido");
                else
                    MostrarMensajeError("El campo DNI no puede estar vacío", "dni");
            else
                MostrarMensajeError("El campo Nombre no puede estar vacío", "nombre");
            return sw;
        }

        private void OcultarMensajeError()
        {
            lblErrorDni.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorApellido.Visible = false;
            lblErrorTelefono.Visible = false;
            lblErrorEmail.Visible = true;
            lblErrorCp.Visible = false;
            lblErrorDireccion.Visible = false;
            lblErrorEdad.Visible = false;
            lblErrorGenero.Visible = false;
        }

        private void MostrarMensajeError(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "dni":
                    lblErrorDni.Text = "      " + cadena; // Los espacios iniciales es para dar espacio al mensaje de advertencia
                    lblErrorDni.Visible = true;
                    break;
                case "nombre":
                    lblErrorNombre.Text = "      " + cadena;
                    lblErrorNombre.Visible = true;
                    break;
                case "apellido":
                    lblErrorApellido.Text = "      " + cadena;
                    lblErrorApellido.Visible = true;
                    break;
                case "telefono":
                    lblErrorTelefono.Text = "      " + cadena;
                    lblErrorTelefono.Visible = true;
                    break;
                case "email":
                    lblErrorEmail.Text = "      " + cadena;
                    lblErrorEmail.Visible = true;
                    break;
                case "cp":
                    lblErrorCp.Text = "      " + cadena;
                    lblErrorCp.Visible = true;
                    break;
                case "direccion":
                    lblErrorDireccion.Text = "      " + cadena;
                    lblErrorDireccion.Visible = true;
                    break;
                case "edad":
                    lblErrorEdad.Text = "      " + cadena;
                    lblErrorEdad.Visible = true;
                    break;
                case "genero":
                    lblErrorGenero.Text = "      " + cadena;
                    lblErrorGenero.Visible = true;
                    break;
                case "existe":
                    lblErrorDni.Text = "     " + cadena;
                    lblErrorDni.Visible = true;
                    break;
            }
        }

        private bool ComprobarLetraDni(int dniNumeros, string letra)
        {
            bool sw = false;
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            int posicion = dniNumeros % 23;
            if (control[posicion].Equals(letra))
                sw = true;
            return sw;
        }

        private bool ComprobarDni()
        {
            bool sw = true;
            string dni = txtDni.Texto.ToUpper();
            string numeros = dni.Substring(0, dni.Length - 1);
            string letra = dni.Substring(dni.Length - 1, 1);
            if (dni.Length != 9) {
                MostrarMensajeError("El Dni debe tener una longitud de 9 caracteres", "dni");
                sw = false;
            }
            bool isNumero = int.TryParse(numeros, out int dniNumeros);
            if (!isNumero) { 
                MostrarMensajeError("El Dni debe comenzar por 8 dígitos", "dni");
                sw = false;
            }
            if (!ComprobarLetraDni(dniNumeros, letra)) { 
                MostrarMensajeError("La letra del Dni no es correcta", "dni");
                sw = false;
            }
            return sw;
        }

        private void CargarPacienteTextbox()
        {
            // Cargar los textbox con texto
            txtDni.Texto = pa.Dni;
            txtNombre.Texto = pa.Nombre;
            txtApellido1.Texto = pa.Apellido1;
            if (pa.Apellido2 != null)
                txtApellido2.Texto = pa.Apellido2;
            txtTelefono.Texto = pa.Telefono;
            if (pa.Email != null)
                txtEmail.Texto = pa.Email;
            txtCp.Texto = pa.Cp;
            txtDireccion.Texto = pa.Direccion;
            txtEdad.Texto = pa.Edad.ToString();
            if (pa.Genero.Equals("M"))
                rbMasculino.Checked = true;
            else
                rbFemenino.Checked = true;
            if (pa.Consentimiento)
                chConsentimiento.Checked = true;
        }

        private bool ExistePaciente()
        {
            ConexionBD conexion = new ConexionBD();
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Dni FROM Paciente WHERE Dni = '" + txtDni.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                    sw = true;
                reader.Close();
                conexion.CerrarConexion();
            }
            return sw;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState ^= FormWindowState.Maximized;
                btnRedimensionar.Image = System.Drawing.Image.FromFile(datosGlobales.PathBotonRedimensionar);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnRedimensionar.Image = System.Drawing.Image.FromFile(datosGlobales.PathBotonMaximizar);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            OcultarMensajeError();
            DialogResult mensaje;
            bool sw = false;
            if (ComprobarNulos())
            {
                if (!isDesdeReserva && !isDesdeEditar)
                    sw = ComprobarDni();
                if (sw || isDesdeReserva)
                {
                    if (!ExistePaciente()) // No existe el paciente
                    {
                        ConexionBD conexion = new ConexionBD();
                        if (conexion.EstablecerConexion())
                        {
                            string sentencia = "INSERT INTO Paciente VALUES('";
                            if (isDesdeReserva) // DNI
                                sentencia += this.paciente.Texto;
                            else
                                sentencia += txtDni.Texto;
                            sentencia += "', '" + txtNombre.Texto + "', '" + txtApellido1.Texto + "', "; // NOMBRE Y APELLIDO1
                            if (txtApellido2.Texto.Equals("")) // APELLIDO2
                                sentencia += "NULL, ";
                            else
                                sentencia += "'" + txtApellido2.Texto + "', '";
                            sentencia += txtTelefono.Texto + "', "; // TELÉFONO
                            if (txtEmail.Texto.Equals("")) // EMAIL
                                sentencia += "NULL, ";
                            else
                                sentencia += "'" + txtEmail.Texto + "', ";
                            sentencia += "'" + txtCp.Texto + "', "; // CÓDIGO POSTAL
                            sentencia += "'" + txtDireccion.Texto + "', "; // DIRECCIÓN
                            sentencia += txtEdad.Texto + ", "; // EDAD
                            if (rbMasculino.Checked) // GÉNERO
                                sentencia += "'M', ";
                            else
                                sentencia += "'F', ";
                            if (chConsentimiento.Checked) // CONSENTIMIENTO
                                sentencia += "1)";
                            else
                                sentencia += "0)";
                            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                            int resultado = comando.ExecuteNonQuery();
                            if (resultado > 0)
                            {
                                LimpiarCampos();
                                mensaje = MessageBoxPersonalizadoControl.Show("Paciente creado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK);
                            }
                            else
                                mensaje = MessageBoxPersonalizadoControl.Show("No se ha guardado el paciente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conexion.CerrarConexion();
                            if (isDesdeReserva || isDesdeEditar)
                                this.Close();
                        }
                        else
                            mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MostrarMensajeError("El paciente ya existe", "existe");
                }
                else // Es porque la ventana se creo para EDITAR al paciente
                {
                    ConexionBD conexion = new ConexionBD();
                    if (conexion.EstablecerConexion())
                    {
                        string sentencia = "UPDATE Paciente SET Nombre='" + txtNombre.Texto + "', Apellido1='" + txtApellido1.Texto + "'";
                        if (!txtApellido2.Texto.Equals("")) // APELLIDO2
                            sentencia += ", Apellido2='" + txtApellido2.Texto + "'";
                        sentencia += ", Telefono='" + txtTelefono.Texto + "'"; // TELÉFONO
                        if (!txtEmail.Texto.Equals("")) // EMAIL
                            sentencia += ", Email='" + txtEmail.Texto + "'";
                        sentencia += ", CP='" + txtCp.Texto + "', "; // CÓDIGO POSTAL
                        sentencia += ", Direccion='" + txtDireccion.Texto + "'"; // DIRECCIÓN
                        sentencia += ", Edad=" + txtEdad.Texto; // EDAD
                        if (rbMasculino.Checked) // GENERO
                            sentencia += ", Genero='M'";
                        else
                            sentencia += ", Genero='F'";
                        if (chConsentimiento.Checked) // CONSENTIMIENTO
                            sentencia += "', CONSENTIMIENTO=1";
                        else
                            sentencia += "', CONSENTIMIENTO=0";
                        sentencia += " WHERE Dni='" + this.dni + "'";
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            LimpiarCampos();
                            mensaje = MessageBoxPersonalizadoControl.Show("Paciente editado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK);
                        }
                        else
                            mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido editar el paciente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conexion.CerrarConexion();
                        if (isDesdeReserva)
                            this.Close();
                        else if (isDesdeEditar)
                            this.Close();
                    }
                }
            }
        }

        private void NuevoPaciente_Load(object sender, EventArgs e)
        {
            if (isDesdeReserva)
            {
                string dni = this.paciente.Texto;
                txtDni.Texto = dni;
                txtDni.Enabled = false;
            }
            else if (isDesdeEditar)
            {
                txtDni.Enabled = false;
                pa = new Paciente();
                pa.CargarPaciente(this.dni);
                CargarPacienteTextbox();
            }
        }
        #endregion
    }
}
