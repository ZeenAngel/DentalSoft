using DentalSoft.Clases;
using DentalSoft.ControlesPersonalizados;
using Flurl.Http;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Formularios
{
    public partial class Empleados : Form
    {
        // Variables
        private Empleado empleado;
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();
        private const int anchoMinimo = 150;

        // Constructores
        #region -> Constructores
        public Empleados()
        {
            InitializeComponent();
        }

        public Empleados(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void AjustarColumnasDgv(string dgv)
        {
            switch (dgv)
            {
                case "empleado":
                    for(int i = 0; i < dgvEmpleados.ColumnCount - 1; i++)
                        dgvEmpleados.Columns[i].MinimumWidth = anchoMinimo;
                    dgvEmpleados.Columns[dgvEmpleados.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
                    for (int i = 0; i < dgvEmpleados.ColumnCount; i++) // No permitir editar las columnas
                        dgvEmpleados.Columns[i].ReadOnly = true;
                    break;
                case "fichaje":
                    for (int i = 0; i < dgvFichajes.ColumnCount - 1; i++)
                        dgvFichajes.Columns[i].MinimumWidth = anchoMinimo;
                    dgvFichajes.Columns[dgvFichajes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
                    for (int i = 0; i < dgvFichajes.ColumnCount; i++) // No permitir editar las columnas
                        dgvFichajes.Columns[i].ReadOnly = true;
                    break;
            }    
        }

        private void OcultarControles()
        {
            mcFecha.Enabled = true;
            mcFecha.Visible = true;
            lblFecha.Visible = true;
            lblFiltros.Visible = false;
            cbActivos.Enabled = false;
            cbActivos.Visible = false;
            cbVacaciones.Enabled = false;
            cbVacaciones.Visible = false;
            cbOdontologos.Enabled = false;
            cbOdontologos.Visible = false;
            lblEmpleados.Visible = false;
            lblFichajes.Visible = true;
            btnNuevoEmpleado.Enabled = false;
            btnNuevoEmpleado.Visible = false;
            btnControlHorario.Enabled = false;
            btnControlHorario.Visible = false;
            pnlContenedorFichajes.Enabled = true;
            pnlContenedorFichajes.Visible = true;
            dgvFichajes.Enabled = true;
            dgvFichajes.Visible = true;
            pnlContenedorEmpleados.Enabled = false;
            pnlContenedorEmpleados.Visible = false;
            dgvEmpleados.Enabled = false;
            dgvEmpleados.Visible = false;
            btnTodasFechas.Enabled = true;
            btnTodasFechas.Visible = true;
        }

        private void MostrarControles()
        {
            mcFecha.Enabled = false;
            mcFecha.Visible = false;
            lblFecha.Visible = false;
            lblFiltros.Visible = true;
            cbActivos.Enabled = true;
            cbActivos.Visible = true;
            cbVacaciones.Enabled = true;
            cbVacaciones.Visible = true;
            cbOdontologos.Enabled = true;
            cbOdontologos.Visible = true;
            lblEmpleados.Visible = true;
            lblFichajes.Visible = false;
            btnNuevoEmpleado.Enabled = true;
            btnNuevoEmpleado.Visible = true;
            btnControlHorario.Enabled = true;
            btnControlHorario.Visible = true;
            pnlContenedorFichajes.Enabled = false;
            pnlContenedorFichajes.Visible = false;
            dgvFichajes.Enabled = false;
            dgvFichajes.Visible = false;
            pnlContenedorEmpleados.Enabled = true;
            pnlContenedorEmpleados.Visible = true;
            dgvEmpleados.Enabled = true;
            dgvEmpleados.Visible = true;
            btnTodasFechas.Enabled = false;
            btnTodasFechas.Visible = false;
        }

        private void CargarDgvFichajes(string tipo)
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Empleado, Fecha, Hora FROM Fichaje_Empleado WHERE Empleado='" + empleado.Dni + "'";
                if (tipo.Equals("fecha"))
                {
                    string fecha = mcFecha.Value.ToString("yyyy-MM-dd");
                    sentencia += " AND Fecha='" + fecha + "'";
                }
                sentencia += " ORDER BY Fecha DESC";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvFichajes.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv("fichaje");
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarDgvEmpleados()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Dni, Nombre, Apellido1, Apellido2, Telefono, Vacaciones, Email, Puesto, Especialidad, Num_Colegiado, Centro FROM Empleado WHERE Dni != 'admin'";
                if (cbActivos.Checked)
                    sentencia += " AND Activo=1";
                if (cbVacaciones.Checked)
                    sentencia += " AND Vacaciones=1";
                if (cbOdontologos.Checked)
                    sentencia += " AND Num_Colegiado IS NOT NULL";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvEmpleados.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv("empleado");
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ComprobarAdministrador()
        {
            if (empleado.Puesto == 1 || empleado.Puesto == 5) // Ni Gerencia ni Administrador
                return true;
            else
                return false;
        }

        private void ComprobarPrivilegios()
        {
            Estilo estilo = new Estilo();
            lblFichajeCorrecto.Visible = false;
            if(! ComprobarAdministrador()) // Ni Gerencia ni Administrador
            {
                estilo.EstiloDataGridView(dgvFichajes);
                OcultarControles();
                CargarDgvFichajes("");
            }
            else
            {
                estilo.EstiloDataGridView(dgvEmpleados);
                MostrarControles();
                CargarDgvEmpleados();
            }
        }

        private string CargarPuesto()
        {
            string puesto = "";
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Descripcion FROM Puesto_Trabajo WHERE Id=" + empleado.Puesto;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                puesto = reader.GetString(0);
                reader.Close();
                conexion.CerrarConexion();
            }
            return puesto;
        }

        private string CargarEspecialidad()
        {
            string especialidad = "";
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Descripcion FROM Especialidad WHERE Id=" + empleado.Especialidad;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                especialidad = reader.GetString(0);
                reader.Close();
                conexion.CerrarConexion();
            }
            return especialidad;
        }

        private void CargarDatosEmpleado()
        {
            lblDni.Text = empleado.Dni;
            lblNombre.Text = empleado.Nombre + " " + empleado.Apellido1 + " ";
            if (!empleado.Apellido2.Equals(""))
                lblNombre.Text += " " + empleado.Apellido2;
            lblTelefono.Text = empleado.Telefono;
            lblEmail.Text = empleado.Email;
            lblPuesto.Text = CargarPuesto();
            if(empleado.Puesto == 3)
            {
                lblEspecialidad.Text = CargarEspecialidad();
                lblColegiado.Text = empleado.NumColegiado;
            }
            else
            {
                lblEspecialidad.Visible = false;
                lblColegiado.Visible = false;
            }
            if (empleado.EstadoFichaje)
                btnFichar.Text = "Fichar salida";
            else
                btnFichar.Text = "Fichar entrada";
        }

        private Task<string> RealizarFichaje()
        {
            try
            {
                return datosGlobales.UrlApiFichar.PostUrlEncodedAsync(new { empleado = empleado.Dni }).ReceiveString();
            }
            catch(Exception e)
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Error en el fichaje: " + e.Message, datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Task.FromResult("Error");
            }
        }

        private void ModificarFichaje(bool estado)
        {
            string sentencia = "UPDATE Empleado SET EstadoFichaje=";
            if (estado)
                sentencia += "1";
            else
                sentencia += "0";
            sentencia += " WHERE Dni='" + empleado.Dni + "'";
            if (conexion.EstablecerConexion())
            {
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            if (empleado.EstadoFichaje)
                btnFichar.BackColor = Color.IndianRed;
            else
                btnFichar.BackColor = Color.ForestGreen;
            ComprobarPrivilegios();
            CargarDatosEmpleado();  
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDgvEmpleados();
        }

        private void cbVacaciones_CheckedChanged(object sender, EventArgs e)
        {
            CargarDgvEmpleados();
        }

        private void cbOdontologos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDgvEmpleados();
        }

        private void mcFecha_CloseUp(object sender, EventArgs e)
        {
            CargarDgvFichajes("fecha");
        }

        private void dgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NuevoEmpleado nuevoEmpleado = new NuevoEmpleado(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
            nuevoEmpleado.ShowDialog();
            CargarDgvEmpleados();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFichajeCorrecto.Visible = false;
            timer1.Stop();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            NuevoEmpleado nuevoEmpleado = new NuevoEmpleado();
            nuevoEmpleado.ShowDialog();
            CargarDgvEmpleados();
        }

        private void btnControlHorario_Click(object sender, EventArgs e)
        {
            ControlHorario controlHorario = new ControlHorario();
            controlHorario.ShowDialog();
        }

        private void btnFichar_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = RealizarFichaje().Result;
                if (empleado.EstadoFichaje) // Salida
                {
                    btnFichar.Text = "Fichar Entrada";
                    btnFichar.BackColor = Color.ForestGreen;
                    empleado.EstadoFichaje = false;
                    ModificarFichaje(false);
                    lblFichajeCorrecto.Text = "Salida realizada correctamente";
                }
                else
                {
                    btnFichar.Text = "Fichar Salida";
                    btnFichar.BackColor = Color.IndianRed;
                    empleado.EstadoFichaje = true;
                    ModificarFichaje(true);
                    lblFichajeCorrecto.Text = "Entrada realizada correctamente";
                    
                }
                lblFichajeCorrecto.Visible = true;
                timer1.Start(); // Iniciar el temporizador para ocultar el mensaje a los 5 segundos
                lblErrorFichar.Visible = false;
                if (! ComprobarAdministrador())
                    CargarDgvFichajes("");
            }
            catch(Exception ex)
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Error en el fichaje: " + ex.Message, datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodasFechas_Click(object sender, EventArgs e)
        {
            CargarDgvFichajes("");
        }
        #endregion


    }
}
