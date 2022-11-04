using DentalSoft.Clases;
using DentalSoft.Formularios;
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
    public partial class MenuPrincipalPaciente : Form
    {
        // Variables
        private Form formularioActivo = null;
        public Empleado empleado = new Empleado();
        private Paciente paciente;
        private string dni;
        private DatosGlobales datosGlobales = new DatosGlobales();

        // Funcionalidades
        #region -> Funcionalidades
        // Funcionalidades arrastrar formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Constructores
        public MenuPrincipalPaciente()
        {
            InitializeComponent();
        }

        public MenuPrincipalPaciente(string dni)
        {
            InitializeComponent();
            this.dni = dni;
            paciente = new Paciente();
        }

        // Métodos privados
        public void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null) // Si hay un formulario activo se cierra
                formularioActivo.Close();
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

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

        private void btnDatos_Click(object sender, EventArgs e)
        {
            DatosPaciente datosPaciente = new DatosPaciente(this.paciente);
            AbrirFormularioHijo(datosPaciente);
        }

        private void MenuPrincipalPaciente_Load(object sender, EventArgs e)
        {
            paciente.CargarPaciente(this.dni);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            ReservasPaciente reservaPaciente = new ReservasPaciente(this.paciente);
            AbrirFormularioHijo(reservaPaciente);
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            ArchivosPaciente archivoPaciente = new ArchivosPaciente(paciente.Dni);
            AbrirFormularioHijo(archivoPaciente);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialPaciente historialPaciente = new HistorialPaciente(paciente.Dni, this);
            AbrirFormularioHijo(historialPaciente);
        }
        #endregion

        private void btnOdontograma_Click(object sender, EventArgs e)
        {
            Odontograma odontograma = new Odontograma(paciente);
            AbrirFormularioHijo(odontograma);
        }
    }
}
