using DentalSoft.Clases;
using DentalSoft.ControlesPersonalizados;
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
    public partial class BuscarPaciente : Form
    {
        // Variables
        const int anchoMinimoDniDgv = 125;
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private TextboxPersonalizado txtPaciente;

        // Constructores
        #region -> Constructores
        public BuscarPaciente()
        {
            InitializeComponent();
        }

        public BuscarPaciente(ref TextboxPersonalizado textbox)
        {
            InitializeComponent();
            this.txtPaciente = textbox;
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
        private void CargarFiltros()
        {
            for (int i = 0; i < dgvPacientesBuscarPaciente.Columns.Count; i++)
                cbFiltrosBuscarPaciente.Items.Add(dgvPacientesBuscarPaciente.Columns[i].HeaderText.ToString());
            cbFiltrosBuscarPaciente.SelectedIndex = 0;
        }

        private void AjustarColumnasDgv()
        {
            dgvPacientesBuscarPaciente.Columns[dgvPacientesBuscarPaciente.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            dgvPacientesBuscarPaciente.Columns[0].MinimumWidth = anchoMinimoDniDgv;
            for (int i = 0; i < dgvPacientesBuscarPaciente.ColumnCount; i++) // No permitir editar las columnas
                dgvPacientesBuscarPaciente.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string paciente = txtPacienteBuscarPaciente.Texto;
                string sentencia = "SELECT Dni, Nombre, Apellido1, Apellido2 FROM Paciente";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvPacientesBuscarPaciente.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FiltrarPacientes()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Dni, Nombre, Apellido1, Apellido2 FROM Paciente WHERE " + cbFiltrosBuscarPaciente.Textos + " LIKE '" + txtPacienteBuscarPaciente.Texto + "%'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvPacientesBuscarPaciente.DataSource = tabla;
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
        private void BuscarPaciente_Load(object sender, EventArgs e)
        {
            Clases.Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(this.dgvPacientesBuscarPaciente);
            CargarDgv();
            CargarFiltros();
        }

        private void txtPacienteBuscarPaciente__TextChanged(object sender, EventArgs e)
        {
            if (txtPacienteBuscarPaciente.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarPacientes();
        }

        private void cbFiltrosBuscarPaciente_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPacienteBuscarPaciente.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarPacientes();
        }

        private void dgvPacientesBuscarPaciente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtPaciente.Texto = dgvPacientesBuscarPaciente.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
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
        #endregion
    }
}
