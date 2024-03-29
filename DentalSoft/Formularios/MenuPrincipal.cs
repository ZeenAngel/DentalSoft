﻿using DentalSoft.Clases;
using DentalSoft.Formularios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class MenuPrincipal : Form
    {
        // Variables
        #region -> Variables
        private Form formularioActivo = null;
        public string dniEmpleado;
        public Empleado empleado = new Empleado();
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        #endregion

        // Constructor
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Funcionalidades
        #region -> Funcionalidades
        // Funcionalidades arrastrar formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Métodos privados
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
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha encontrado ningún usuario con ese DNI", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                sentencia = "SELECT Nombre FROM Centro WHERE Cif='" + empleado.Centro + "'";
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
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha encontrado ningún usuario con ese DNI", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conexion.CerrarConexion();
                lblNombreMenuPrincipal.Text = empleado.Nombre;
                lblApellidosEmpleado.Text = empleado.Apellido1 + " " + empleado.Apellido2;
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido establecer conexión con la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarEmpleado()
        {
            if (empleado.CargarEmpleado(dniEmpleado))
                RellenarDatosEmpleado();
        }

        private void CargarPermisos()
        {
            if(empleado.Puesto == 3 || empleado.Puesto == 4)
            {
                btnPresupuestosMenuLateral.Visible = false;
                btnFacturasMenuLateral.Visible = false;
                btnAgendaMenuLateral.Visible = false;
                btnAjustesMenuLateral.Visible = false;
                btnEstadisticasMenuLateral.Visible = false;
            }
        }

        private void ComprobarEstadoCitas()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "UPDATE reserva SET estado = 2 WHERE estado = 1 AND fecha < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            try // Eliminar el directorio temporal
            {
                DirectoryInfo dirTemporal = new DirectoryInfo(datosGlobales.DirectorioTemporal);
                if(dirTemporal.Exists)
                    dirTemporal.Delete(true);
            }
            catch { }
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
                btnRedimensionarMenuPrincipal.Image = System.Drawing.Image.FromFile(datosGlobales.PathBotonRedimensionar);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnRedimensionarMenuPrincipal.Image = System.Drawing.Image.FromFile(datosGlobales.PathBotonMaximizar);
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarEmpleado();
            CargarPermisos();
            ComprobarEstadoCitas();
        }

        private void btnCerrarSesionMenuLateral_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnCitasMenuLateral_Click(object sender, EventArgs e)
        {
            Cita agenda = new Cita(this);
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

        private void btnEmpleadosMenuLateral_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados(empleado);
            AbrirFormularioHijo(empleados);
        }

        private void btnPresupuestosMenuLateral_Click(object sender, EventArgs e)
        {
            Presupuestos presupuestos = new Presupuestos();
            AbrirFormularioHijo(presupuestos);
        }

        private void btnAlmacenMenuLateral_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen(this);
            AbrirFormularioHijo(almacen);
        }

        private void btnCajaMenuLateral_Click(object sender, EventArgs e)
        {
            Caja caja = new Caja(empleado.Centro);
            AbrirFormularioHijo(caja);
        }

        private void btnFacturasMenuLateral_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas();
            AbrirFormularioHijo(facturas);
        }

        private void btnAgendaMenuLateral_Click(object sender, EventArgs e)
        {
            Agenda ajustes = new Agenda();
            AbrirFormularioHijo(ajustes);
        }

        private void btnEstadisticasMenuLateral_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            AbrirFormularioHijo(estadisticas);
        }
        #endregion
    }
}
