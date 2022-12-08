using DentalSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Formularios
{
    public partial class NuevoEmpleado : Form
    {
        // Variables
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private Empleado empleado = new Empleado();
        private string dni = null;
        private bool isEditando = false;
        private bool isDesdeNuevo = false;

        // Constructores
        #region -> Constructores
        public NuevoEmpleado()
        {
            InitializeComponent();
            isDesdeNuevo = true;
        }

        public NuevoEmpleado(string dni)
        {
            InitializeComponent();
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
            if (isDesdeNuevo)
                txtDni.Texto = "";
            txtNombre.Texto = "";
            txtApellido1.Texto = "";
            txtApellido2.Texto = "";
            txtTelefono.Texto = "";
            txtEmail.Texto = "";
            cbPuesto.SelectedIndex = 0;
            cbEspecialidad.SelectedIndex = 0;
            cbCentro.SelectedIndex = 0;
            txtColegiado.Texto = "";
            cbActivo.Checked = true;
            cbVacaciones.Checked = false;
        }

        private void OcultarMensajesError()
        {
            lblErrorDni.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorApellido1.Visible = false;
            lblErrorTelefono.Visible = false;
            lblErrorEmail.Visible = false;
            lblErrorPuesto.Visible = false;
            lblErrorEspecialidad.Visible = false;
            lblErrorCentro.Visible = false;
            lblErrorColegiado.Visible = false;
            lblErrorExiste.Visible = false;
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
                    lblErrorApellido1.Text = "      " + cadena;
                    lblErrorApellido1.Visible = true;
                    break;
                case "telefono":
                    lblErrorTelefono.Text = "      " + cadena;
                    lblErrorTelefono.Visible = true;
                    break;
                case "email":
                    lblErrorEmail.Text = "      " + cadena;
                    lblErrorEmail.Visible = true;
                    break;
                case "puesto":
                    lblErrorPuesto.Text = "      " + cadena;
                    lblErrorPuesto.Visible = true;
                    break;
                case "especialidad":
                    lblErrorEspecialidad.Text = "      " + cadena;
                    lblErrorEspecialidad.Visible = true;
                    break;
                case "centro":
                    lblErrorCentro.Text = "      " + cadena;
                    lblErrorCentro.Visible = true;
                    break;
                case "colegiado":
                    lblErrorColegiado.Text = "      " + cadena;
                    lblErrorColegiado.Visible = true;
                    break;
                case "existe":
                    lblErrorExiste.Text = "     " + cadena;
                    lblErrorExiste.Visible = true;
                    break;
            }
        }

        private void DesactivarTextbox()
        {
            lblResetPassword.Visible = false;
            isEditando = false;
            txtDni.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            cbPuesto.Enabled = false;
            cbEspecialidad.Enabled = false;
            if (empleado.Puesto != 3)
            {
                cbEspecialidad.Visible = false;
                txtColegiado.Visible = false;
            }
            cbCentro.Enabled = false;
            txtColegiado.Enabled = false;
            cbActivo.Enabled = false;
            cbVacaciones.Enabled = false;
            btnGuardar.Text = "Editar";
        }

        private void ActivarTextBox(string origen)
        {
            isEditando = true;
            if (origen.Equals("nuevo"))
            {
                txtDni.Enabled = true;
                cbActivo.Checked = true;
            }
            txtNombre.Enabled = true;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            cbPuesto.Enabled = true;
            if (empleado.Puesto == 3)
            {
                cbEspecialidad.Enabled = true;
                cbEspecialidad.Visible = true;
                txtColegiado.Enabled = true;
                txtColegiado.Visible = true;
            };
            cbCentro.Enabled = true;
            cbActivo.Enabled = true;
            cbVacaciones.Enabled = true;
            btnGuardar.Text = "Guardar";
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
            if (dni.Length != 9)
            {
                MostrarMensajeError("El Dni debe tener una longitud de 9 caracteres", "dni");
                sw = false;
            }
            bool isNumero = int.TryParse(numeros, out int dniNumeros);
            if (!isNumero)
            {
                MostrarMensajeError("El Dni debe comenzar por 8 dígitos", "dni");
                sw = false;
            }
            if (!ComprobarLetraDni(dniNumeros, letra))
            {
                MostrarMensajeError("La letra del Dni no es correcta", "dni");
                sw = false;
            }
            return sw;
        }

        private bool ComprobarNulos()
        {
            bool sw = false;
            if (!txtNombre.Texto.Equals(""))
                if (!txtDni.Texto.Equals(""))
                    if (!txtApellido1.Texto.Equals(""))
                        if (!txtTelefono.Texto.Equals(""))
                            if (!txtEmail.Texto.Equals("") && ComprobarEmail())
                                if (cbPuesto.SelectedIndex != 0)
                                    if (empleado.Puesto != 3 || (empleado.Puesto == 3 && !cbEspecialidad.SelectedItem.ToString().Equals("")))
                                        if (cbCentro.SelectedIndex != 0)
                                            if (empleado.Puesto != 3 || (empleado.Puesto == 3 && !txtColegiado.Texto.Equals("")))
                                                sw = true;
                                            else
                                                MostrarMensajeError("El campo Nº Colegiado no puede estar vacío", "colegiado");
                                        else
                                            MostrarMensajeError("El campo Centro no puede estar vacío", "centro");
                                    else
                                        MostrarMensajeError("El campo Especialidad no puede estar vacío", "especialidad");
                                else
                                    MostrarMensajeError("El campo Puesto no puede estar vacío", "puesto");
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

        private void CargarPuestos()
        {
            cbPuesto.Items.Add("");
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Descripcion FROM Puesto_Trabajo";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbPuesto.Items.Add(reader.GetString(0));
                reader.Close();
                conexion.CerrarConexion();
            }
        }

        private void CargarEspecialidades()
        {
            cbEspecialidad.Items.Add("");
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Descripcion FROM Especialidad";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbEspecialidad.Items.Add(reader.GetString(0));
                reader.Close();
                conexion.CerrarConexion();
            }
        }

        private void CargarCentros()
        {
            cbCentro.Items.Add("");
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Nombre FROM Centro";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbCentro.Items.Add(reader.GetString(0));
                reader.Close();
                conexion.CerrarConexion();
            }
        }

        private int PosicionCentro(string centro)
        {
            int posicion = 0;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Cif FROM Centro";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    posicion++;
                    if (reader.GetString(0).Equals(centro))
                        break;
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            return posicion;
        }

        private void CargarDatosEmpleado()
        {
            txtDni.Texto = empleado.Dni;
            txtNombre.Texto = empleado.Nombre;
            txtApellido1.Texto = empleado.Apellido1;
            if (empleado.Apellido2 != null)
                txtApellido2.Texto = empleado.Apellido2;
            txtTelefono.Texto = empleado.Telefono;
            txtEmail.Texto = empleado.Email;
            cbPuesto.SelectedIndex = empleado.Puesto; // No hace falta sumarle 1, pues el Index empieza en 0 y el Id empieza en 1
            if (empleado.Puesto == 3)
            {
                cbEspecialidad.SelectedIndex = empleado.Especialidad;
                txtColegiado.Texto = empleado.NumColegiado;
            }
            cbCentro.SelectedIndex = PosicionCentro(empleado.Centro);
            if (empleado.Activo)
                cbActivo.Checked = true;
            if (empleado.Vacaciones)
                cbVacaciones.Checked = true;
        }

        private void CargarEmpleado()
        {
            if (this.dni != null)
            {
                empleado.CargarEmpleado(this.dni);
                CargarDatosEmpleado();
                DesactivarTextbox();
            }
            else
                ActivarTextBox("nuevo");
        }

        private int ClavePuesto(ConexionBD conexion)
        {
            int puesto = 0;
            string sentencia = "SELECT Id FROM Puesto_Trabajo WHERE Descripcion = '" + cbPuesto.SelectedItem.ToString() + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            puesto = reader.GetInt32(0);
            reader.Close();
            return puesto;
        }

        private int ClaveEspecialidad(ConexionBD conexion)
        {
            int especialidad = 0;
            string sentencia = "SELECT Id FROM Especialidad WHERE Descripcion = '" + cbEspecialidad.SelectedItem.ToString() + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            especialidad = reader.GetInt32(0);
            reader.Close();
            return especialidad;
        }

        private string ClaveCentro(ConexionBD conexion)
        {
            string centro = "";
            string sentencia = "SELECT Cif FROM Centro WHERE Nombre='" + cbCentro.SelectedItem.ToString() + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            centro = reader.GetString(0);
            reader.Close();
            return centro;
        }

        private bool ExisteEmpleado()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Dni FROM Empleado WHERE Dni='" + txtDni.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                    sw = true;
                reader.Close();
                conexion.CerrarConexion();
            }  
            return sw;
        }

        private void OcultarControlesNoOdontologo()
        {
            lblTituloEspecialidad.Visible = false;
            lblTituloColegiado.Visible = false;
            cbEspecialidad.Visible = false;
            txtColegiado.Enabled = false;
            txtColegiado.Visible = false;
        }

        private void MostrarControlesOdontologo()
        {
            lblTituloEspecialidad.Visible = true;
            lblTituloColegiado.Visible = true;
            cbEspecialidad.Visible = true;
            cbEspecialidad.Enabled = true;
            txtColegiado.Enabled = true;
            txtColegiado.Visible = true;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState ^= FormWindowState.Maximized;
                btnRedimensionar.Image = Image.FromFile(datosGlobales.PathBotonRedimensionar);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnRedimensionar.Image = Image.FromFile(datosGlobales.PathBotonMaximizar);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            lblResetPassword.Visible = false;
            CargarPuestos();
            CargarEspecialidades();
            CargarCentros();
            CargarEmpleado();
            OcultarMensajesError();
            OcultarControlesNoOdontologo();
            if (this.dni != null)
                btnResetPasswordLogin.Visible = true;
            else
                btnResetPasswordLogin.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!isEditando) // Va a Editar
                ActivarTextBox("");
            else // Va a Guardar
            {
                string sentencia = "";
                if (this.dni == null) // Nuevo empleado
                {
                    if (ComprobarNulos())
                    {
                        if (!ExisteEmpleado()) // No existe el empleado
                        {
                            if (ComprobarDni())
                            {
                                if (conexion.EstablecerConexion())
                                {
                                    sentencia = "INSERT INTO Empleado(Dni, Nombre, Apellido1, Apellido2, Telefono, Email, Vacaciones, Puesto, Especialidad, Num_Colegiado, Centro, Activo) VALUES " +
                                    "('" + txtDni.Texto + "', '" + txtNombre.Texto + "', '" + txtApellido1.Texto + "', "; // Dni & Nombre & Apellido1
                                    if (!txtApellido2.Texto.Equals(""))
                                        sentencia += "'" + txtApellido2.Texto + "', "; // Apellido2
                                    else
                                        sentencia += "'', ";
                                    sentencia += "'" + txtTelefono.Texto + "', '" + txtEmail.Texto + "', "; // Telefono & Email
                                    if (cbVacaciones.Checked) // Vacaciones
                                        sentencia += "1, ";
                                    else
                                        sentencia += "0, ";
                                    int puesto = ClavePuesto(conexion);
                                    sentencia += puesto + ", "; // Puesto
                                    if (puesto == 3) // Especialidad & Colegiado
                                        sentencia += ClaveEspecialidad(conexion) + ", '" + txtColegiado.Texto + "', ";
                                    else
                                        sentencia += "null, null, ";
                                    sentencia += "'" + ClaveCentro(conexion) + "', "; // Centro
                                    if (cbActivo.Checked)
                                        sentencia += "1)";
                                    else
                                        sentencia += "0)";
                                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                                    comando.ExecuteNonQuery();
                                    conexion.CerrarConexion();
                                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Empleado dado de alta correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            } 
                        }
                        else
                            MostrarMensajeError("Ya existe el empleado", "existe");
                    }
                }
                else // Editar empleado
                {
                    if (ComprobarNulos())
                    {
                        if (conexion.EstablecerConexion())
                        {
                            sentencia = "UPDATE Empleado SET Nombre = '" + txtNombre.Texto + "', Apellido1 = '" + txtApellido1.Texto + "', "; // Nombre & Apellido1
                            if (!txtApellido2.Texto.Equals(""))
                                sentencia += "Apellido2='" + txtApellido2.Texto + "', "; // Apellido2
                            int puesto = ClavePuesto(conexion);
                            sentencia += "Telefono='" + txtTelefono.Texto + "', Email='" + txtEmail.Texto + "', "; // Teléfono & Email
                            if (cbVacaciones.Checked) // Vacaciones
                                sentencia += "Vacaciones = 1, ";
                            else
                                sentencia += "Vacaciones = 0, ";
                            sentencia += "Puesto = " + puesto + ", "; // Puesto
                            if (puesto == 3)
                                sentencia += "Especialidad = " + ClaveEspecialidad(conexion) + ", "; // Especialidad
                            sentencia += "Centro = '" + ClaveCentro(conexion) + "', "; // Centro
                            if (cbActivo.Checked) // Activo
                                sentencia += "Activo = 1 ";
                            else
                                sentencia += "Activo = 0 ";
                            sentencia += "WHERE Dni = '" + txtDni.Texto + "'";
                            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                            comando.ExecuteNonQuery();
                            conexion.CerrarConexion();
                            DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Empleado editado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                this.Close();
            }
        }

        private void cbPuesto_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPuesto.SelectedItem.ToString().Equals("Odontologo"))
            {
                MostrarControlesOdontologo();
            }
            else
            {
                OcultarControlesNoOdontologo();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnResetPasswordLogin_Click(object sender, EventArgs e)
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "UPDATE Identificacion_Empleado SET Cambiar_Password = 0 WHERE Usuario = '" + txtDni.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
                lblResetPassword.Text = "Cambio de contraseña aplicado correctamente";
                lblResetPassword.Visible = true;
                timer1.Start();
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblResetPassword.Visible = false;
            timer1.Stop();
        }
        #endregion
    }
}
