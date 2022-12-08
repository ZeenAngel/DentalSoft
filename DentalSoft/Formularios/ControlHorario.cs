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

namespace DentalSoft.Formularios
{
    public partial class ControlHorario : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();
        private const int anchoMinimo = 125;

        // Constructores
        public ControlHorario()
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
        #region -> Métodos privados
        private void MostrarMensaje(string cadena)
        {
            lblErrorIncidencias.Text = "     " + cadena;
            lblErrorIncidencias.Visible = true;
        }

        private void OcultarMensaje()
        {
            lblErrorIncidencias.Visible = false;
        }

        private void AjustarColumnasDgv()
        {
            for(int i = 0; i < dgvFichajes.ColumnCount - 1; i++)
                dgvFichajes.Columns[i].MinimumWidth = anchoMinimo;
            dgvFichajes.Columns[dgvFichajes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor 
            for (int i = 0; i < dgvFichajes.ColumnCount; i++) // No permitir editar las columnas
                dgvFichajes.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string empleado = txtBuscar.Texto;
                string sentencia = "SELECT Empleado, Fecha, Hora FROM Fichaje_Empleado";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvFichajes.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
        }

        private void FiltrarFichajes(string filtro)
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "";
                string fecha = selectorFecha1.Value.ToString("yyyy-MM-dd");
                switch (filtro)
                {
                    case "dni":
                        sentencia = "SELECT Empleado, Fecha, Hora FROM Fichaje_Empleado WHERE Empleado LIKE '" + txtBuscar.Texto + "%' ORDER BY Fecha ASC";
                        break;
                    case "fecha":
                        sentencia = "SELECT Empleado, Fecha, Hora FROM Fichaje_Empleado WHERE Fecha = '" + fecha + "' ORDER BY Fecha ASC";
                        break;
                    case "todo":
                        sentencia = "SELECT Empleado, Fecha, Hora FROM Fichaje_Empleado WHERE Empleado LIKE '" + txtBuscar.Texto + "%' AND Fecha = '" + fecha + "' ORDER BY Fecha ASC";
                        break;
                }
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvFichajes.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
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

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
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

        private void ControlHorario_Load(object sender, EventArgs e)
        {
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvFichajes);
            CargarDgv();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarFichajes("dni");
        }

        private void selectorFecha1_CloseUp(object sender, EventArgs e)
        {
            if (txtBuscar.Texto.Equals(""))
                FiltrarFichajes("fecha");
            else
                FiltrarFichajes("todo");
        }

        private void btnLimpiarFecha_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarFichajes("dni");
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            if (conexion.EstablecerConexion())
            {
                string empleado = txtBuscar.Texto;
                string sentencia = "SELECT Empleado, Fecha, Hora FROM Fichaje_Empleado WHERE hora LIKE '00:%'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvFichajes.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
        }

        private void dgvFichajes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFichajes.Columns[e.ColumnIndex].Name.Equals("Hora"))
            {
                if (e.Value.ToString().Contains("00:"))
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                    MostrarMensaje("Hay incidencias en los fichajes");
                }
            }
        }

        private void dgvFichajes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarFichaje modificarFichaje = new ModificarFichaje(dgvFichajes.CurrentRow.Cells[0].Value.ToString(),
                dgvFichajes.CurrentRow.Cells[1].Value.ToString(), dgvFichajes.CurrentRow.Cells[2].Value.ToString());
            modificarFichaje.ShowDialog();
            CargarDgv();
            OcultarMensaje();
        }
        #endregion
    }
}
