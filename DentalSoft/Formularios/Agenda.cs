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
    public partial class Agenda : Form
    {
        // Variables
        public Empleado empleado;
        private MenuPrincipal formPadre;
        ConexionBD conexion = new Clases.ConexionBD();
        DatosGlobales datosGlobales = new DatosGlobales();

        // Constructores
        #region -> Constructores
        public Agenda()
        {
            InitializeComponent();
        }

        public Agenda(MenuPrincipal formularioPadre)
        {
            InitializeComponent();
            this.formPadre = formularioPadre;
            this.empleado = formPadre.empleado;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void AjustarColumnasDgv()
        {
            dgvReservas.Columns[dgvReservas.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            for (int i = 0; i < dgvReservas.ColumnCount; i++) // No permitir editar las columnas
                dgvReservas.Columns[i].ReadOnly = true;
        }

        private void ConectarBd()
        {
            if (conexion.EstablecerConexion())
            {
                string fecha = selectorFecha1.Value.ToString("yyyy-MM-dd");
                string sentencia;
                if (empleado.Puesto == 3) // Si es Odontologo ve solo sus reservas
                    sentencia = "SELECT r.Id, r.Hora, p.Nombre, p.Apellido1, p.Apellido2 FROM Reserva AS r INNER JOIN Paciente AS p " +
                        "ON p.Dni=r.Paciente AND r.Odontologo='" + empleado.Dni + "' AND r.Fecha='" + fecha + "' ORDER BY r.Hora";
                else // Como los auxiliares no está ligados a un único Odontologo, pueden ver todas las Reservas pero no editarlas ni crear nuevas
                    sentencia = "SELECT r.Id, r.Hora, p.Nombre, p.Apellido1, p.Apellido2 FROM Reserva AS r INNER JOIN Paciente AS p ON p.Dni=r.Paciente AND r.Fecha='" + fecha + "' ORDER BY r.Hora";
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

        private void AsignarPrivilegios()
        {
            if (empleado.Puesto == 3 || empleado.Puesto == 4)
            {
                btnEliminarAgenda.Enabled = false;
                btnEliminarAgenda.BackColor = Color.DarkGray;
                btnEliminarAgenda.ForeColor = Color.White;
                btnNuevaAgenda.Enabled = false;
                btnNuevaAgenda.BackColor = Color.DarkGray;
                btnNuevaAgenda.ForeColor = Color.White;
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            ConectarBd();
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvReservas);
            selectorFecha1.MinDate = DateTime.Now;
            AsignarPrivilegios();
        }

        private void selectorFecha1_CloseUp(object sender, EventArgs e)
        {
            ConectarBd();
        }

        private void btnNuevaAgenda_Click(object sender, EventArgs e)
        {
            NuevaReserva nuevaReserva = new NuevaReserva(formPadre);
            nuevaReserva.MdiParent = this.MdiParent;
            formPadre.AbrirFormularioHijo(nuevaReserva);
            this.Close();
        }

        private void btnEliminarAgenda_Click(object sender, EventArgs e)
        {
            DialogResult mensaje;
            if (dgvReservas.SelectedRows.Count > 0) // Comprobar si hay seleccionada alguna fila
            {
                int reserva = int.Parse(dgvReservas.Rows[dgvReservas.CurrentRow.Index].Cells[0].Value.ToString());
                mensaje = MessageBoxPersonalizadoControl.Show("¿Seguro que quiere eliminar esta reserva?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mensaje == DialogResult.Yes)
                {
                    if (conexion.EstablecerConexion())
                    {
                        string sentencia = "DELETE FROM Reserva WHERE Id=" + reserva;
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        comando.ExecuteNonQuery();
                        conexion.CerrarConexion();
                        ConectarBd();
                    }
                    else
                    {
                        mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido establecer la conexión con la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                mensaje = MessageBoxPersonalizadoControl.Show("Debe seleccionar una reserva de la lista", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarAgenda_Click(object sender, EventArgs e)
        {
            if(dgvReservas.SelectedRows.Count > 0)
            {
                int reserva = int.Parse(dgvReservas.Rows[dgvReservas.CurrentRow.Index].Cells[0].Value.ToString());
                EditarReserva editarR = new EditarReserva(reserva);
                editarR.ShowDialog();
                ConectarBd();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Debe seleccionar una reserva de la lista", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dgvReservas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TratamientoPaciente tratamientoPaciente = new TratamientoPaciente(int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString()));
            tratamientoPaciente.ShowDialog();
        }
    }
}
