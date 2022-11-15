using DentalSoft.Clases;
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
    public partial class Pacientes : Form
    {
        // Variables
        #region -> Variables
        public Empleado empleado;
        private MenuPrincipal formPadre;
        const int anchoMinimoDniDgv = 125;
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        #endregion

        // Constructores
        #region -> Constructores
        public Pacientes()
        {
            InitializeComponent();
        }

        public Pacientes(MenuPrincipal formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            empleado = this.formPadre.empleado;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void CargarFiltros()
        {
            for (int i = 0; i < dgvPacientes.Columns.Count; i++)
                cbFiltrosPacientes.Items.Add(dgvPacientes.Columns[i].HeaderText.ToString());
            cbFiltrosPacientes.SelectedIndex = 0;
        }

        private void AjustarColumnasDgv()
        {
            dgvPacientes.Columns[dgvPacientes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            dgvPacientes.Columns[0].MinimumWidth = anchoMinimoDniDgv; // Columna DNI
            dgvPacientes.Columns[4].MinimumWidth = anchoMinimoDniDgv; // Columna Teléfono
            dgvPacientes.Columns[5].MinimumWidth = anchoMinimoDniDgv * 2; // Columna Email
            for (int i = 0; i < dgvPacientes.ColumnCount; i++) // No permitir editar las columnas
                dgvPacientes.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string paciente = txtPacientes.Texto;
                string sentencia = "SELECT Dni, Nombre, Apellido1, Apellido2, Telefono, Email, CP FROM Paciente";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvPacientes.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
        }

        private void FiltrarPacientes()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Dni, Nombre, Apellido1, Apellido2, Telefono, Email, CP FROM Paciente WHERE " + cbFiltrosPacientes.Textos + " LIKE '" + txtPacientes.Texto + "%'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvPacientes.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
        }

        private void AsignarPrivilegios()
        {
            if (empleado.Puesto == 3 || empleado.Puesto == 4)
            {
                btnNuevoPaciente.Enabled = false;
                btnNuevoPaciente.Visible = false;
                btnEditarPacientes.Enabled = false;
                btnEditarPacientes.Enabled = false;
                btnEliminarPacientes.Enabled = false;
                btnEliminarPacientes.Enabled = false;
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void Pacientes_Load(object sender, EventArgs e)
        {
            Clases.Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(this.dgvPacientes);
            CargarDgv();
            CargarFiltros();
            AsignarPrivilegios();
        }

        private void txtPacientes__TextChanged(object sender, EventArgs e)
        {
            if (txtPacientes.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarPacientes();
        }

        private void cbFiltrosPacientes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPacientes.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarPacientes();
        }

        private void btnHistorialPacientes_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                string dni = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString();
                MenuPrincipalPaciente menuPaciente = new MenuPrincipalPaciente(dni);
                menuPaciente.Show();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Debe seleccionar un paciente de la lista", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            NuevoPaciente nuevoPaciente = new NuevoPaciente();
            nuevoPaciente.ShowDialog();
            CargarDgv();
        }

        private void btnEditarPacientes_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                string dni = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString();
                NuevoPaciente nuevoPaciente = new NuevoPaciente(dni);
                nuevoPaciente.ShowDialog();
                CargarDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Debe seleccionar un paciente de la lista", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPacientes_Click(object sender, EventArgs e)
        {
            DialogResult mensaje;
            if (dgvPacientes.SelectedRows.Count > 0) // Comprobar si hay seleccionada alguna fila
            {
                string dni = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString();
                mensaje = MessageBoxPersonalizadoControl.Show("¿Seguro que quiere eliminar este paciente?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mensaje == DialogResult.Yes)
                {
                    if (conexion.EstablecerConexion())
                    {
                        string sentencia = "DELETE FROM Paciente WHERE DNI='" + dni + "'";
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        comando.ExecuteNonQuery();
                        conexion.CerrarConexion();
                        CargarDgv();
                    }
                }
            }
            else
            {
                mensaje = MessageBoxPersonalizadoControl.Show("Debe seleccionar un paciente de la lista", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
