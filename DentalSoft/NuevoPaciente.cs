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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class NuevoPaciente : Form
    {
        // Variables
        private Paciente pa;
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
            chConsentimiento.Checked = false;
        }

        private bool ComprobarNulos()
        {
            bool sw = false;
            if (! txtNombre.Texto.Equals(""))
                if (! txtDni.Texto.Equals("") || isDesdeReserva)
                    if(!txtApellido1.Texto.Equals(""))
                        if (!txtTelefono.Texto.Equals(""))
                            if (!txtCp.Texto.Equals(""))
                                sw = true;
                            else
                                MostrarMensajeError("El campo Código Postal no puede estar vacío", "nombre");
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
                case "cp":
                    lblErrorCp.Text = "      " + cadena;
                    lblErrorCp.Visible = true;
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
            if (pa.Consentimiento)
                chConsentimiento.Checked = true;
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
                btnRedimensionar.Image = System.Drawing.Image.FromFile("imagenes/botones/boton_redimensionar_blanco.png");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnRedimensionar.Image = System.Drawing.Image.FromFile("imagenes/botones/boton_maximizar_blanco.png");
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
            DialogResult mensaje;
            bool sw = false;
            if (ComprobarNulos())
            {
                if (!isDesdeReserva && !isDesdeEditar)
                    sw = ComprobarDni();
                if (sw || isDesdeReserva)
                {
                    Clases.ConexionBD conexion = new ConexionBD();
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
                        if (chConsentimiento.Checked) // CONSENTIMIENTO
                            sentencia += "1)";
                        else
                            sentencia += "0)";
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            LimpiarCampos();
                            mensaje = MessageBoxPersonalizadoControl.Show("Paciente creado correctamente", "DentalSoft", MessageBoxButtons.OK);
                        }
                        else
                            mensaje = MessageBoxPersonalizadoControl.Show("No se ha guardado el paciente", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conexion.CerrarConexion();
                        if (isDesdeReserva || isDesdeEditar)
                            this.Close();
                    }
                    else
                        mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // Es porque la ventana se creo para EDITAR al paciente
                {
                    Clases.ConexionBD conexion = new ConexionBD();
                    if (conexion.EstablecerConexion())
                    {
                        string sentencia = "UPDATE Paciente SET Nombre='" + txtNombre.Texto + "', Apellido1='" + txtApellido1.Texto + "'";
                        if (!txtApellido2.Texto.Equals("")) // APELLIDO2
                            sentencia += ", Apellido2='" + txtApellido2.Texto + "'";
                        sentencia += ", Telefono='" + txtTelefono.Texto + "'"; // TELÉFONO
                        if (!txtEmail.Texto.Equals("")) // EMAIL
                            sentencia += ", Email='" + txtEmail.Texto + "'";
                        sentencia += ", CP='" + txtCp.Texto + "', CONSENTIMIENTO="; // CÓDIGO POSTAL
                        if (chConsentimiento.Checked) // CONSENTIMIENTO
                            sentencia += "1";
                        else
                            sentencia += "0";
                        sentencia += " WHERE Dni='" + this.dni + "'";
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            LimpiarCampos();
                            mensaje = MessageBoxPersonalizadoControl.Show("Paciente editado correctamente", "DentalSoft", MessageBoxButtons.OK);
                        }
                        else
                            mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido editar el paciente", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
