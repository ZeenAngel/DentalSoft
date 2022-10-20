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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class MenuPrincipal : Form
    {
        #region -> Variables
        private Form formularioActivo = null;
        public string dniEmpleado;
        public Empleado empleado = new Empleado();
        Clases.ConexionBD conexion = new Clases.ConexionBD();
        #endregion

        #region -> Funcionalidades
        // Funcionalidades arrastrar formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        #region -> Métodos privados
        public void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null) // Si hay un formulario activo se cierra
                formularioActivo.Close();
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedorMenuPrincipal.Controls.Add(formularioHijo);
            pnlContenedorMenuPrincipal.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void RellenarDatosEmpleado()
        {
            string sentencia = "SELECT Descripcion FROM Puesto_Trabajo WHERE Id=" + empleado.Puesto;
            if (conexion.EstablecerConexion())
            {
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblCargoMenuPrincipal.Text = reader.GetString(0);
                }
                else
                {
                    // ¿SI YA TENGO CARGADO EL DNI, SERÍA RARO NO ENCONTRAR EL PUESTO, PERO POR SI ACASO LO DEJO?
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha encontrado ningún usuario con ese DNI", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                sentencia = "SELECT Nombre FROM Centro WHERE Id=" + empleado.Centro;
                comando = new MySqlCommand(sentencia, conexion.conexionSql);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblCentroMenuPrincipal.Text = reader.GetString(0);
                }
                else
                {
                    // ¿SI YA TENGO CARGADO EL DNI, SERÍA RARO NO ENCONTRAR EL CENTRO, PERO POR SI ACASO LO DEJO?
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha encontrado ningún usuario con ese DNI", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conexion.CerrarConexion();
                lblNombreMenuPrincipal.Text = empleado.Nombre;
                lblApellidosEmpleado.Text = empleado.Apellido1 + " " + empleado.Apellido2;
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido establecer conexión con la base de datos", "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarEmpleado()
        {
            if (empleado.CargarEmpleado(dniEmpleado))
                RellenarDatosEmpleado();

        }
        #endregion

        #region -> Eventos
        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRedimensionarMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState ^= FormWindowState.Maximized;
                btnRedimensionarMenuPrincipal.Image = System.Drawing.Image.FromFile("imagenes/botones/boton_redimensionar_blanco.png");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnRedimensionarMenuPrincipal.Image = System.Drawing.Image.FromFile("imagenes/botones/boton_maximizar_blanco.png");
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarEmpleado();
        }

        private void btnCerrarSesionMenuLateral_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnAgendaMenuLateral_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda(this);
            agenda.empleado = empleado;
            AbrirFormularioHijo(agenda);
        }
         
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPacientesMenuLateral_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes(this);
            pacientes.empleado = empleado;
            AbrirFormularioHijo(pacientes);
        }

        #endregion

        /************** IMPORTANTE, EN LA REGIÓN EVENTOS, AL ABRIR EL FORMULARIO AGENDA, HAY QUE PASARLE EL DNI DEL EMPLEADO PARA QUE APAREZCAN LAS RESERVAS SOLO DE ESE ODONTOLOGO, O SI ES
         * ADMINISTRATIVO QUE SALGA EL DE TODOS LOS PACIENTES
         ***************************/
    }
}
