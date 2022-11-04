using DentalSoft.Clases;
using DentalSoft.ControlesPersonalizados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class ReservasPaciente : Form
    {
        // Variables
        private Paciente paciente;
        private DatosGlobales datosGlobales = new DatosGlobales();
        private const int anchoMinimo = 150;

        // Constructores
        #region -> Constructores
        public ReservasPaciente()
        {
            InitializeComponent();
        }

        public ReservasPaciente(Clases.Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void AjustarColumnasDgv()
        {
            dgvReservas.Columns[0].MinimumWidth = anchoMinimo;
            dgvReservas.Columns[1].MinimumWidth = anchoMinimo;
            dgvReservas.Columns[2].MinimumWidth = anchoMinimo;
            dgvReservas.Columns[3].MinimumWidth = anchoMinimo;
            dgvReservas.Columns[4].MinimumWidth = anchoMinimo;
            dgvReservas.Columns[dgvReservas.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            for (int i = 0; i < dgvReservas.ColumnCount; i++) // No permitir editar las columnas
                dgvReservas.Columns[i].ReadOnly = true;
        }

        private void CargarDgv(bool origen)
        {
            Clases.ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string fecha = mcFiltroFecha.Value.ToString("yyyy-MM-dd");
                string sentencia;
                if(origen) // Cargar todas las reservas
                    sentencia = "SELECT r.Fecha, r.Hora, p.Nombre, p.Apellido1, p.Apellido2 FROM Reserva AS r INNER JOIN Paciente AS p ON r.Paciente='" + paciente.Dni + "' AND p.Dni='" + paciente.Dni + "' ORDER BY r.Hora";
                else
                    sentencia = "SELECT r.Fecha, r.Hora, p.Nombre, p.Apellido1, p.Apellido2 FROM Reserva AS r INNER JOIN Paciente AS p ON r.Paciente='" + paciente.Dni + "' AND p.Dni='" + paciente.Dni + "' AND r.Fecha='" + fecha + "' ORDER BY r.Hora";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvReservas.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReservasPaciente_Load(object sender, EventArgs e)
        {
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvReservas);
            CargarDgv(true);
        }

        private void mcFiltroFecha_CloseUp(object sender, EventArgs e)
        {
            CargarDgv(false);
        }
        #endregion


    }
}
